using Parser.Models.Stores;
using Parser.Models.TypeDefinitions;
using Parser.OpenApiData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Parser.Parsers
{

    public class OpenApiParser
    {
        private ReferencesTable ReferencesTable { get; } = new ReferencesTable();

        private OpenApiDocument OpenApi { get; }

        private TypeDefintionsFactory DefintionsFactory { get; }

        public OpenApiParser(OpenApiDocument openApi)
        {
            OpenApi = openApi;
            DefintionsFactory = new TypeDefintionsFactory(ReferencesTable);
        }

        public DocumentModel BuildModel()
        {
            var documentModel = new DocumentModel();

            const string schemasReferenceTemplate = "#/components/schemas/";

            foreach (var (name, schema) in OpenApi.Components.Schemas)
            {
                var reference = $"{schemasReferenceTemplate}{name}";
                var definition = DefintionsFactory.GetTypeDefinition(schema, name);
                if (definition == null)
                {
#if !DEBUG
                        throw new NotImplementedException();
#endif
                    continue;
                }
                ReferencesTable[reference] = definition;
                documentModel.TypesDefinitions.Add(definition);
            }
            documentModel.Endpoints.AddRange(BuildEndpoints());
            return documentModel;
        }

        private IEnumerable<EndpointModel> BuildEndpoints()
        {
            foreach ((string fullPath, Path pathInfo) in OpenApi.Paths)
            {
                var segments = fullPath
                    .Split("/")
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(s => new PathSegmentModel(s));

                var pathModel = new PathModel(segments);

                yield return new EndpointModel(pathModel, BuildEndpointOperations(pathInfo));
            }
        }
        private IEnumerable<EndpointOperationModel> BuildEndpointOperations(Path pathInfo)
        {
            foreach ((HttpAction httpAction, Operation operationInfo) in pathInfo)
            {
                yield return new EndpointOperationModel(httpAction,
                                                        BuildOperationsParametes(operationInfo),
                                                        BuildResponses(operationInfo),
                                                        BuildBody(operationInfo));
            }

        }

        private BodyModel BuildBody(Operation operationInfo)
        {
            var data = operationInfo.RequestBody?.Contents.FirstOrDefault();
            if (data == null)
            {
                return null;
            }
            (string contentType, Content content) = data.Value;
            var typeDefinition = DefintionsFactory.GetTypeDefinition(content.Schema, null) switch
            {
                ReferenceLinkedTypeDefinition referenceToType => referenceToType.GetTypeDefinitionByReference(),
                TypeDefinitionModelBase def => def
            };
            return new BodyModel(typeDefinition, contentType);
        }

        private IEnumerable<ResponseCodeModel> BuildResponses(Operation operationInfo)
        {
            foreach ((string code, Response response) in operationInfo.Responses)
            {
                var descripton = response.Description;
                foreach ((string contentType, Content content) in response.Contents) 
                {
                    var typeDefinition = DefintionsFactory.GetTypeDefinition(content.Schema, null) switch
                    { 
                        ReferenceLinkedTypeDefinition referenceToType => referenceToType.GetTypeDefinitionByReference(),
                        TypeDefinitionModelBase def => def
                    };
                    var model = new ResponseCodeModel(responseCode: code, contentType: contentType, typeDefinition);
                    yield return model;
                }
            }
        }

        private IEnumerable<OperationParameterModel> BuildOperationsParametes(Operation operationInfo)
        {
            foreach (var param in operationInfo.Parameters ?? Enumerable.Empty<Parameter>())
            {
                var paramModel = new OperationParameterModel
                {
                    Name = param.Name,
                    Definition = DefintionsFactory.GetTypeDefinition(param.Schema, null),
                    Location = param.In
                };
                yield return paramModel;
            }

        }
    }

    public class EndpointModel
    {
        public EndpointModel(PathModel path, IEnumerable<EndpointOperationModel> operations)
        {
            Path = path;
            Operations = operations.ToList() ?? new List<EndpointOperationModel>();
        }
        public PathModel Path { get; }
        public IEnumerable<EndpointOperationModel> Operations { get; }
    }

    public class EndpointOperationModel
    {
        public EndpointOperationModel(HttpAction httpAction,
                                      IEnumerable<OperationParameterModel> operationParameters,
                                      IEnumerable<ResponseCodeModel> responses,
                                      BodyModel body)
        {
            HttpAction = httpAction;
            OperationParameters = operationParameters.ToList();
            Responses = responses.ToList();
            Body = body;
        }
        public HttpAction HttpAction { get; }

        public IReadOnlyList<OperationParameterModel> OperationParameters { get; }

        public IReadOnlyList<ResponseCodeModel> Responses { get; }
        public BodyModel Body { get; }
    }

    public class BodyModel
    {
        public TypeDefinitionModelBase TypeDefinition { get; }
        public string ContentType { get; }

        public BodyModel(TypeDefinitionModelBase typeDefinition, string contentType)
        {
            TypeDefinition = typeDefinition;
            ContentType = contentType;
        }


    }

    public class ResponseCodeModel
    {
        private static Regex CheckRangeRegex = new Regex(@"^\d*[Xx]*\d*$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public ResponseCodeModel(string responseCode, string contentType, TypeDefinitionModelBase typeDefinition)
        {
            if (int.TryParse(responseCode, out var code))
            {
                IsRange = false;
                Code = code;
            }
            else if (!CheckRangeRegex.IsMatch(responseCode))
            {
                throw new ArgumentException(nameof(responseCode));
            }
            FromCode = int.Parse(responseCode.Replace('X', '0').Replace('x', '0'));
            ToCode = int.Parse(responseCode.Replace('X', '9').Replace('x', '9'));
            ContentType = contentType;
            TypeDefinition = typeDefinition;
        }
        /// <summary>
        /// Представляет диапазон статус кодов
        /// </summary>
        /// <remarks>
        /// Согласно спецификации в responses ключем может быть значение вида 5XX,
        /// то есть диапазон 501-599 и общее описание типа для него
        /// </remarks>
        public bool IsRange { get; private set; }

        private int code;

        public int Code { get => Get(false, code); private set => code = value; }

        private int fromCode;
        public int FromCode { get => Get(true, fromCode); private set => fromCode = value; }

        private int toCode;
        public int ToCode { get => Get(true, toCode); set => toCode = value; }
        public string ContentType { get; }
        public TypeDefinitionModelBase TypeDefinition { get; }

        private int Get(bool expectedIsRange, int value)
        {
            if (IsRange == expectedIsRange)
            {
                return value;
            }
            var message = $"Неприменимо, если Response описывает {(IsRange ? "диапазон кодов" : "отдельный код")}";
            throw new InvalidOperationException(message);
        }
    }


    public class PathModel : IEnumerable<PathSegmentModel>
    {
        private PathSegmentModel[] Segments { get; }

        public PathModel(IEnumerable<PathSegmentModel> segments)
        {
            Segments = segments.ToArray();
        }

        public IEnumerator<PathSegmentModel> GetEnumerator()
        {
            foreach (var s in Segments) yield return s;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}


