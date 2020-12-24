using Parser.OpenApiData;

namespace Parser.Models.TypeDefinitions
{
    public interface IPropertyLengthConditions
    {
        int? MaxLength { get; }
        int? MinLength { get; }
    }

    public class StringDefinition : TypeDefinitionModelBase, IPropertyLengthConditions
    {
        public StringDefinition(OpenApiSchemaDescription schema) : base(schema)
        {
            Pattern = schema.Pattern;
            MaxLength = schema.MaxLength;
            MinLength = schema.MinLength;
        }

        public string Pattern { get; }

        public int? MaxLength { get; }
        public int? MinLength { get; }
    }


}
