using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class IntegerEnumDefinition : EnumDefinitionBase<int>
    {
        public IntegerEnumDefinition(
            string name,
            OpenApiSchemaDescription schema
            ) : base(name, schema)
        {}

        protected override int GetValueFromJsonElement(JsonElement jsonElement)
            => jsonElement.GetInt32();
        
    }


}
