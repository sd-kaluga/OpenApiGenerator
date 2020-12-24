using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public class DoubleDefinition : NumericTypeDefinitionBase<double>
    {
        public DoubleDefinition(OpenApiSchemaDescription schema) : base(schema)
        { }

        public override NumericMemberFormat FormatExact => NumericMemberFormat.Double;

        protected override double GetValueFromJsonElement(JsonElement jsonElement)
         => jsonElement.GetDouble();
    }


}
