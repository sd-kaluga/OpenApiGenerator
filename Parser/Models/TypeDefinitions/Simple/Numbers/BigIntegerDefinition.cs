using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class BigIntegerDefinition : NumericTypeDefinitionBase<long>
    {
        public BigIntegerDefinition(OpenApiSchemaDescription schema) : base(schema)
        { }

        public override NumericMemberFormat FormatExact => NumericMemberFormat.Int64;

        protected override long GetValueFromJsonElement(JsonElement jsonElement)
        => jsonElement.GetInt64();
    }


}
