using Parser.OpenApiData;

namespace Parser.Models.TypeDefinitions.Collections
{
    public class ArrayDefinition : CollectionDefinitionBase
    {
        public ArrayDefinition(
            OpenApiSchemaDescription schema,
            TypeDefinitionModelBase elementDefinition)
            : base(schema, elementDefinition)
        {}
    }

    


}
