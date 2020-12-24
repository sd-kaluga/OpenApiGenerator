using Parser.OpenApiData;
using Parser.Parsers;
using System;

namespace Parser.Models.TypeDefinitions.Collections
{
    public abstract class CollectionDefinitionBase : TypeDefinitionModelBase
    {
        protected CollectionDefinitionBase(
            OpenApiSchemaDescription schema,
            TypeDefinitionModelBase elementDefinition)
            : base(schema)
        {
            ElementDefinitionFromRefLazy = (elementDefinition ?? throw new ArgumentNullException(nameof(TypeDefinitionModelBase))) switch
            {
                ReferenceLinkedTypeDefinition link => new Lazy<TypeDefinitionModelBase>(link.GetTypeDefinitionByReference),
                _ => null
            };
            AssignedElementDefinition = elementDefinition switch
            {
                ReferenceLinkedTypeDefinition _ => null,
                _ => elementDefinition
            };

           
        }

        /// <summary>
        /// Нужно для отложенного (после того, как все описания типов будут сформированы)
        /// обращения к пропертям, описанным через $Ref
        /// </summary>
        private Lazy<TypeDefinitionModelBase> ElementDefinitionFromRefLazy { get; }

        private TypeDefinitionModelBase AssignedElementDefinition { get; }

        public TypeDefinitionModelBase ElementDefinition => AssignedElementDefinition ?? ElementDefinitionFromRefLazy.Value;


    }
}
