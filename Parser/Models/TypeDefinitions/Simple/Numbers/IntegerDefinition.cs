using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class IntegerDefinition : NumericTypeDefinitionBase<int>
    {
        public IntegerDefinition(OpenApiSchemaDescription schema) : base(schema)
        { }

        public override NumericMemberFormat FormatExact => NumericMemberFormat.Int32;

        protected override int GetValueFromJsonElement(JsonElement jsonElement)
            => jsonElement.GetInt32();
    }


}
