using Parser.OpenApiData;

namespace Parser.Models.TypeDefinitions.Collections
{
    public class DictionaryDefinition : CollectionDefinitionBase
    {
        public DictionaryDefinition(
            OpenApiSchemaDescription schema,
            TypeDefinitionModelBase elementDefinition)
            : base(schema, elementDefinition)
        { }
    }

    


}
