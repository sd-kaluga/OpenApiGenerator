using Parser.OpenApiData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Parser.Models.TypeDefinitions
{
   
    public sealed class ObjectProperty
    {
        public ObjectProperty(
            string name,
            TypeDefinitionModelBase typeDefinition,
            bool isRequired)
        {
            TypeDefinitionFromRefLazy = (typeDefinition ?? throw new ArgumentNullException(nameof(TypeDefinitionModelBase))) switch
            {
                ReferenceLinkedTypeDefinition link => new Lazy<TypeDefinitionModelBase>(link.GetTypeDefinitionByReference),
                _ => null
            };
            AssignedTypeDefinition = typeDefinition switch
            {
                 ReferenceLinkedTypeDefinition _ => null,
                 _ => typeDefinition
            };
            Name = name;
            IsRequired = isRequired;
        }

        /// <summary>
        /// Нужно для отложенного (после того, как все описания типов будут сформированы)
        /// обращения к пропертям, описанным через $Ref
        /// </summary>
        private Lazy<TypeDefinitionModelBase> TypeDefinitionFromRefLazy { get; }

        private TypeDefinitionModelBase AssignedTypeDefinition { get; }

        public TypeDefinitionModelBase TypeDefinition => AssignedTypeDefinition ?? TypeDefinitionFromRefLazy.Value;

        public string Name { get; }

        public bool IsRequired { get; }
    }
}
