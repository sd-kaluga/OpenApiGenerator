//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Parser.openapi
//{
//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Reference : System.Collections.Generic.Dictionary<string, object>
//    {

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Info
//    {
//        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Title { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("termsOfService", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string TermsOfService { get; set; }

//        [Newtonsoft.Json.JsonProperty("contact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Contact Contact { get; set; }

//        [Newtonsoft.Json.JsonProperty("license", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public License License { get; set; }

//        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Version { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Contact
//    {
//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Url { get; set; }

//        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Email { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class License
//    {
//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Url { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Server
//    {
//        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Url { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("variables", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, ServerVariable> Variables { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ServerVariable
//    {
//        [Newtonsoft.Json.JsonProperty("enum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<string> Enum { get; set; }

//        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Default { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Components
//    {
//        [Newtonsoft.Json.JsonProperty("schemas", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Schemas { get; set; }

//        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Responses { get; set; }

//        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

//        [Newtonsoft.Json.JsonProperty("examples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Examples { get; set; }

//        [Newtonsoft.Json.JsonProperty("requestBodies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> RequestBodies { get; set; }

//        [Newtonsoft.Json.JsonProperty("headers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Headers { get; set; }

//        [Newtonsoft.Json.JsonProperty("securitySchemes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> SecuritySchemes { get; set; }

//        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Links { get; set; }

//        [Newtonsoft.Json.JsonProperty("callbacks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Callbacks { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Schema
//    {
//        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Title { get; set; }

//        [Newtonsoft.Json.JsonProperty("multipleOf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
//        public double MultipleOf { get; set; }

//        [Newtonsoft.Json.JsonProperty("maximum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public double Maximum { get; set; }

//        [Newtonsoft.Json.JsonProperty("exclusiveMaximum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool ExclusiveMaximum { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("minimum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public double Minimum { get; set; }

//        [Newtonsoft.Json.JsonProperty("exclusiveMinimum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool ExclusiveMinimum { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("maxLength", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MaxLength { get; set; }

//        [Newtonsoft.Json.JsonProperty("minLength", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MinLength { get; set; } = 0;

//        [Newtonsoft.Json.JsonProperty("pattern", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Pattern { get; set; }

//        [Newtonsoft.Json.JsonProperty("maxItems", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MaxItems { get; set; }

//        [Newtonsoft.Json.JsonProperty("minItems", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MinItems { get; set; } = 0;

//        [Newtonsoft.Json.JsonProperty("uniqueItems", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool UniqueItems { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("maxProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MaxProperties { get; set; }

//        [Newtonsoft.Json.JsonProperty("minProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
//        public int MinProperties { get; set; } = 0;

//        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.MinLength(1)]
//        public System.Collections.Generic.ICollection<string> Required { get; set; }

//        [Newtonsoft.Json.JsonProperty("enum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [System.ComponentModel.DataAnnotations.MinLength(1)]
//        public System.Collections.Generic.ICollection<object> Enum { get; set; }

//        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public SchemaType Type { get; set; }

//        [Newtonsoft.Json.JsonProperty("not", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema Not { get; set; }

//        [Newtonsoft.Json.JsonProperty("allOf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Schema> AllOf { get; set; }

//        [Newtonsoft.Json.JsonProperty("oneOf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Schema> OneOf { get; set; }

//        [Newtonsoft.Json.JsonProperty("anyOf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Schema> AnyOf { get; set; }

//        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema Items { get; set; }

//        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Schema> Properties { get; set; }

//        [Newtonsoft.Json.JsonProperty("additionalProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema AdditionalProperties { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Format { get; set; }

//        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Default { get; set; }

//        [Newtonsoft.Json.JsonProperty("nullable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Nullable { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("discriminator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Discriminator Discriminator { get; set; }

//        [Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool ReadOnly { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("writeOnly", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool WriteOnly { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Example { get; set; }

//        [Newtonsoft.Json.JsonProperty("externalDocs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ExternalDocumentation ExternalDocs { get; set; }

//        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Deprecated { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("xml", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public XML Xml { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Discriminator
//    {
//        [Newtonsoft.Json.JsonProperty("propertyName", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string PropertyName { get; set; }

//        [Newtonsoft.Json.JsonProperty("mapping", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, string> Mapping { get; set; }

//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [Newtonsoft.Json.JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class XML
//    {
//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Uri Namespace { get; set; }

//        [Newtonsoft.Json.JsonProperty("prefix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Prefix { get; set; }

//        [Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Attribute { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("wrapped", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Wrapped { get; set; } = false;


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Response
//    {
//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("headers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Header> Headers { get; set; }

//        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, MediaType> Content { get; set; }

//        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Link> Links { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class MediaType : ExampleXORExamples
//    {
//        [Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema Schema { get; set; }

//        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Example { get; set; }

//        [Newtonsoft.Json.JsonProperty("examples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Example> Examples { get; set; }

//        [Newtonsoft.Json.JsonProperty("encoding", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Encoding> Encoding { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Example
//    {
//        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Summary { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Value { get; set; }

//        [Newtonsoft.Json.JsonProperty("externalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string ExternalValue { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Header : ExampleXORExamples
//    {
//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Required { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Deprecated { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("allowEmptyValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool AllowEmptyValue { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("style", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public HeaderStyle Style { get; set; } = HeaderStyle.Simple;

//        [Newtonsoft.Json.JsonProperty("explode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Explode { get; set; }

//        [Newtonsoft.Json.JsonProperty("allowReserved", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool AllowReserved { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema Schema { get; set; }

//        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, MediaType> Content { get; set; }

//        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Example { get; set; }

//        [Newtonsoft.Json.JsonProperty("examples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Example> Examples { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Paths : System.Collections.Generic.Dictionary<string, PathItem>
//    {

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class PathItem
//    {
//        [Newtonsoft.Json.JsonProperty("$ref", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Ref { get; set; }

//        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Summary { get; set; }
            
//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("servers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Server> Servers { get; set; }

//        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Parameter> Parameters { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Operation
//    {
//        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<string> Tags { get; set; }

//        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Summary { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("externalDocs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ExternalDocumentation ExternalDocs { get; set; }

//        [Newtonsoft.Json.JsonProperty("operationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string OperationId { get; set; }

//        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Parameter> Parameters { get; set; }

//        [Newtonsoft.Json.JsonProperty("requestBody", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public RequestBody RequestBody { get; set; }

//        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public Responses Responses { get; set; } = new Responses();

//        [Newtonsoft.Json.JsonProperty("callbacks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Callback> Callbacks { get; set; }

//        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Deprecated { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("security", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<SecurityRequirement> Security { get; set; }

//        [Newtonsoft.Json.JsonProperty("servers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Server> Servers { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Responses
//    {
//        [Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Response Default { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class SecurityRequirement : System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.Collection<string>>
//    {

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Tag
//    {
//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("externalDocs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ExternalDocumentation ExternalDocs { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ExternalDocumentation
//    {
//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Url { get; set; }


//    }

//    /// <summary>Example and examples are mutually exclusive</summary>
//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ExampleXORExamples
//    {
//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [Newtonsoft.Json.JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class SchemaXORContent
//    {
//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [Newtonsoft.Json.JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Parameter : ExampleXORExamples
//    {
//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("in", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string In { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Required { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Deprecated { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("allowEmptyValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool AllowEmptyValue { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("style", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Style { get; set; }

//        [Newtonsoft.Json.JsonProperty("explode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Explode { get; set; }

//        [Newtonsoft.Json.JsonProperty("allowReserved", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool AllowReserved { get; set; } = false;

//        [Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Schema Schema { get; set; }

//        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, MediaType> Content { get; set; }

//        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object Example { get; set; }

//        [Newtonsoft.Json.JsonProperty("examples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Example> Examples { get; set; }


//    }

//    /// <summary>Parameter in path</summary>
//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ParameterLocation
//    {
//        [Newtonsoft.Json.JsonProperty("in", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ParameterLocationIn In { get; set; }

//        [Newtonsoft.Json.JsonProperty("style", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ParameterLocationStyle Style { get; set; }

//        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Always)]
//        public ParameterLocationRequired Required { get; set; }

//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [Newtonsoft.Json.JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class RequestBody
//    {
//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public System.Collections.Generic.IDictionary<string, MediaType> Content { get; set; } = new System.Collections.Generic.Dictionary<string, MediaType>();

//        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Required { get; set; } = false;


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class SecurityScheme
//    {
//        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public SecuritySchemeType Type { get; set; }

//        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string Name { get; set; }

//        [Newtonsoft.Json.JsonProperty("in", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public SecuritySchemeIn In { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }


//    }

//    /// <summary>Bearer</summary>
//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class HTTPSecurityScheme
//    {
//        [Newtonsoft.Json.JsonProperty("scheme", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public HTTPSecuritySchemeScheme Scheme { get; set; }

//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [Newtonsoft.Json.JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class OAuth2SecurityScheme
//    {
//        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public OAuth2SecuritySchemeType Type { get; set; }

//        [Newtonsoft.Json.JsonProperty("flows", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public OAuthFlows Flows { get; set; } = new OAuthFlows();

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class OpenIdConnectSecurityScheme
//    {
//        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public OpenIdConnectSecuritySchemeType Type { get; set; }

//        [Newtonsoft.Json.JsonProperty("openIdConnectUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string OpenIdConnectUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class OAuthFlows
//    {
//        [Newtonsoft.Json.JsonProperty("implicit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ImplicitOAuthFlow Implicit { get; set; }

//        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public PasswordOAuthFlow Password { get; set; }

//        [Newtonsoft.Json.JsonProperty("clientCredentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ClientCredentialsFlow ClientCredentials { get; set; }

//        [Newtonsoft.Json.JsonProperty("authorizationCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public AuthorizationCodeOAuthFlow AuthorizationCode { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ImplicitOAuthFlow
//    {
//        [Newtonsoft.Json.JsonProperty("authorizationUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string AuthorizationUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("refreshUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string RefreshUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public System.Collections.Generic.IDictionary<string, string> Scopes { get; set; } = new System.Collections.Generic.Dictionary<string, string>();


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class PasswordOAuthFlow
//    {
//        [Newtonsoft.Json.JsonProperty("tokenUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string TokenUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("refreshUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string RefreshUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, string> Scopes { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class ClientCredentialsFlow
//    {
//        [Newtonsoft.Json.JsonProperty("tokenUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string TokenUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("refreshUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string RefreshUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, string> Scopes { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class AuthorizationCodeOAuthFlow
//    {
//        [Newtonsoft.Json.JsonProperty("authorizationUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string AuthorizationUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("tokenUrl", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        public string TokenUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("refreshUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string RefreshUrl { get; set; }

//        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, string> Scopes { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Link
//    {
//        [Newtonsoft.Json.JsonProperty("operationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string OperationId { get; set; }

//        [Newtonsoft.Json.JsonProperty("operationRef", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string OperationRef { get; set; }

//        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

//        [Newtonsoft.Json.JsonProperty("requestBody", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public object RequestBody { get; set; }

//        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string Description { get; set; }

//        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Server Server { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Callback : System.Collections.Generic.Dictionary<string, PathItem>
//    {

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class Encoding
//    {
//        [Newtonsoft.Json.JsonProperty("contentType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public string ContentType { get; set; }

//        [Newtonsoft.Json.JsonProperty("headers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.IDictionary<string, Header> Headers { get; set; }

//        [Newtonsoft.Json.JsonProperty("style", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
//        public EncodingStyle Style { get; set; }

//        [Newtonsoft.Json.JsonProperty("explode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool Explode { get; set; }

//        [Newtonsoft.Json.JsonProperty("allowReserved", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public bool AllowReserved { get; set; } = false;


//    }

//    /// <summary>Validation schema for OpenAPI Specification 3.0.X.</summary>
//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public partial class OpenApi
//    {
//        [Newtonsoft.Json.JsonProperty("openapi", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
//        [System.ComponentModel.DataAnnotations.RegularExpression(@"^3\.0\.\d(-.+)?$")]
//        public string Openapi { get; set; }

//        [Newtonsoft.Json.JsonProperty("info", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public Info Info { get; set; } = new Info();

//        [Newtonsoft.Json.JsonProperty("externalDocs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public ExternalDocumentation ExternalDocs { get; set; }

//        [Newtonsoft.Json.JsonProperty("servers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Server> Servers { get; set; }

//        [Newtonsoft.Json.JsonProperty("security", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<SecurityRequirement> Security { get; set; }

//        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public System.Collections.Generic.ICollection<Tag> Tags { get; set; }

//        [Newtonsoft.Json.JsonProperty("paths", Required = Newtonsoft.Json.Required.Always)]
//        [System.ComponentModel.DataAnnotations.Required]
//        public Paths Paths { get; set; } = new Paths();

//        [Newtonsoft.Json.JsonProperty("components", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public Components Components { get; set; }


//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum SchemaType
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"array")]
//        Array = 0,

//        [System.Runtime.Serialization.EnumMember(Value = @"boolean")]
//        Boolean = 1,

//        [System.Runtime.Serialization.EnumMember(Value = @"integer")]
//        Integer = 2,

//        [System.Runtime.Serialization.EnumMember(Value = @"number")]
//        Number = 3,

//        [System.Runtime.Serialization.EnumMember(Value = @"object")]
//        Object = 4,

//        [System.Runtime.Serialization.EnumMember(Value = @"string")]
//        String = 5,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum HeaderStyle
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"simple")]
//        Simple = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum ParameterLocationIn
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"path")]
//        Path = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum ParameterLocationStyle
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"matrix")]
//        Matrix = 0,

//        [System.Runtime.Serialization.EnumMember(Value = @"label")]
//        Label = 1,

//        [System.Runtime.Serialization.EnumMember(Value = @"simple")]
//        Simple = 2,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum ParameterLocationRequired
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"True")]
//        True = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum SecuritySchemeType
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"apiKey")]
//        ApiKey = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum SecuritySchemeIn
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"header")]
//        Header = 0,

//        [System.Runtime.Serialization.EnumMember(Value = @"query")]
//        Query = 1,

//        [System.Runtime.Serialization.EnumMember(Value = @"cookie")]
//        Cookie = 2,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum HTTPSecuritySchemeScheme
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"bearer")]
//        Bearer = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum OAuth2SecuritySchemeType
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"oauth2")]
//        Oauth2 = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum OpenIdConnectSecuritySchemeType
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"openIdConnect")]
//        OpenIdConnect = 0,

//    }

//    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
//    public enum EncodingStyle
//    {
//        [System.Runtime.Serialization.EnumMember(Value = @"form")]
//        Form = 0,

//        [System.Runtime.Serialization.EnumMember(Value = @"spaceDelimited")]
//        SpaceDelimited = 1,

//        [System.Runtime.Serialization.EnumMember(Value = @"pipeDelimited")]
//        PipeDelimited = 2,

//        [System.Runtime.Serialization.EnumMember(Value = @"deepObject")]
//        DeepObject = 3,

//    }

//}
