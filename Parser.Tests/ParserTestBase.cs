using Parser.Models.Stores;
using Parser.OpenApiData;
using Parser.Parsers;
using System;
using System.IO;
using System.Text.Json;

namespace Parser.Tests
{
    public abstract class ParserTestBase
    {
        private string OpenApiFile { get; }

        protected ParserTestBase(string openApiFile)
        {
            OpenApiFile = openApiFile;
            DocumentModelLazy = new Lazy<DocumentModel>(LoadAndParseSchema);
        }

        private DocumentModel LoadAndParseSchema()
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Schemas", OpenApiFile);
            var content = File.ReadAllText(path);
            OpenApiDocument document = JsonSerializer.Deserialize<OpenApiDocument>(content);
            DocumentModel model = new OpenApiParser(document).BuildModel();
            return model;
        }

        private Lazy<DocumentModel> DocumentModelLazy { get; }

        protected DocumentModel DocumentModel => DocumentModelLazy.Value;
    }
}
