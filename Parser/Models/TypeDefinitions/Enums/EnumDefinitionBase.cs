using Parser.OpenApiData;

namespace Parser.Models.TypeDefinitions
{
    public abstract class EnumDefinitionBase : TypeDefinitionModelBase
    {
        protected EnumDefinitionBase(string name, OpenApiSchemaDescription schema) : base(schema)
        {
            Name = name;
        }

        public string Name { get; }
    }


}
