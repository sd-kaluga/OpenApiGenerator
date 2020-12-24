using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class FloatDefinition : NumericTypeDefinitionBase<float>
    {
        public FloatDefinition(OpenApiSchemaDescription schema) : base(schema)
        { }

        public override NumericMemberFormat FormatExact => NumericMemberFormat.Float;

        protected override float GetValueFromJsonElement(JsonElement jsonElement)
            => jsonElement.GetSingle();
    }


}
