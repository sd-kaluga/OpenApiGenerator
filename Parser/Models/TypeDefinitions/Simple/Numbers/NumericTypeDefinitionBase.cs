using Parser.OpenApiData;

namespace Parser.Models.TypeDefinitions
{
    public abstract class NumericTypeDefinitionBase : TypeDefinitionModelBase
    {
        protected NumericTypeDefinitionBase(OpenApiSchemaDescription schema) 
            : base(schema)
        {

        }

        public abstract NumericMemberFormat FormatExact { get; }
    }


}
