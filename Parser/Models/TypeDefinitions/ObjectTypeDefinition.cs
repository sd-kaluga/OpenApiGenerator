using Parser.OpenApiData;
using System.Collections.Generic;
using System.Linq;

namespace Parser.Models.TypeDefinitions
{
    public class ObjectTypeDefinition : TypeDefinitionModelBase
    {
        private readonly ObjectProperty[] _properties;
        public ObjectTypeDefinition(
            string name, 
            OpenApiSchemaDescription schema, 
            IEnumerable<ObjectProperty> properties) 
            : base(schema)
        {
            _properties = properties?.ToArray() ?? new ObjectProperty[0];
            Name = name;
        }

        public virtual string Name { get; }

        public IEnumerable<ObjectProperty> Properties => _properties;
    }

  


}
