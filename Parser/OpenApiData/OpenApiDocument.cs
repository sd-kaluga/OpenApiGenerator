using Parser.OpenApiData;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Parser.OpenApiData
{
    public abstract class SchemaElementBase
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> OtherElements { get; set; }
    }

    public class DictionaryElement<TValue> : Dictionary<string, TValue>
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> OtherElements { get; set; }
    }


    public class OpenApiDocument : SchemaElementBase
    {
        [JsonPropertyName("paths")]
        public Dictionary<string, Path> Paths { get; set; }
        [JsonPropertyName("components")]
        public Components Components { get; set; }
    }

    public class Components : SchemaElementBase
    {
        [JsonPropertyName("schemas")]
        public Schemas Schemas { get; set; }
    }

    public class Schemas : DictionaryElement<OpenApiSchemaDescription>
    {
    }

    public class Properties : DictionaryElement<OpenApiSchemaDescription>
    {

    }

    public class Path : Dictionary<HttpAction, Operation>
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> OtherElements { get; set; }
    }

    public class Operation : SchemaElementBase
    {
        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Key - код ответа
        /// </summary>
        /// <remarks>
        /// Key Нельзя парсить "в лоб" по спеке допустимо значение 5XX
        /// </remarks>
        [JsonPropertyName("responses")]
        public Dictionary<string, Response> Responses { get; set; }

        [JsonPropertyName("parameters")]
        public Parameter[] Parameters { get; set; }

        [JsonPropertyName("requestBody")]
        public RequestBody RequestBody { get; set; }

    }

    public class RequestBody
    {
        [JsonPropertyName("content")]
        public Dictionary<string, Content> Contents { get; set; }
    }

    public class Response : SchemaElementBase
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("content")]
        public Dictionary<string, Content> Contents { get; set; }

    }

    public class Content : SchemaElementBase
    {
        [JsonPropertyName("schema")]
        public OpenApiSchemaDescription Schema { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ParameterLocation
    {
        Other,
        [EnumMember(Value = "path")]
        Path,
        [EnumMember(Value = "query")]
        Query,
        [EnumMember(Value = "header")]
        Header,
        [EnumMember(Value = "cookie")]
        Cookie
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SchemaType
    {
        /// <summary>
        /// (this includes dates and files)
        /// </summary>
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "array")]
        Array,
        [EnumMember(Value = "object")]
        Object
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HttpAction
    {
        [EnumMember(Value = "get")]
        Get,
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "put")]
        Put,
        [EnumMember(Value = "patch")]
        Patch,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "head")]
        Head,
        [EnumMember(Value = "options")]
        Options,
        [EnumMember(Value = "trace")]
        Trace
    }




    public class Parameter : SchemaElementBase
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("in")]
        public ParameterLocation In { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("required")]
        public bool? Required { get; set; }

        [JsonPropertyName("deprecated")]
        public bool Deprecated { get; set; }

        [JsonPropertyName("allowEmptyValue")]
        public bool AllowEmptyValue { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("explode")]
        public bool? Explode { get; set; }

        [JsonPropertyName("allowReserved")]
        public bool AllowReserved { get; set; }
        [JsonPropertyName("schema")]
        public OpenApiSchemaDescription Schema { get; set; }

    }
}
