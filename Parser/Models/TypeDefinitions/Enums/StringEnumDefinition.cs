using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class StringEnumDefinition : EnumDefinitionBase<string>
    {
        public StringEnumDefinition(
            string name,
            OpenApiSchemaDescription schema
            ) : base(name, schema)
        { }

        protected override string GetValueFromJsonElement(JsonElement jsonElement)
            => jsonElement.GetString();
    }
}
