using Parser.OpenApiData;
using Parser.Parsers;
using System;

namespace Parser.Models.TypeDefinitions
{
    /// <summary>
    /// Тип описание которого указано с использованием $ref
    /// </summary>
    /// <remarks>
    /// На этапе построения моделей не все типы могут быть обработаны (построены наследники TypeDefinitionBase)
    /// когда ссылка на них уже возникла. Используется данная заглушка для того, чтобы потом быть 
    /// заменной на реальное описание типа
    /// </remarks>
    public class ReferenceLinkedTypeDefinition : TypeDefinitionModelBase
    {
        private ReferencesTable ReferencesTable { get; }
        public ReferenceLinkedTypeDefinition(OpenApiSchemaDescription schema, ReferencesTable referencesTable) 
            : base(schema)
        {
            Reference = schema.Reference;
            ReferencesTable = referencesTable ?? throw new ArgumentNullException(nameof(referencesTable));
        }

        public string Reference { get; }

        internal TypeDefinitionModelBase GetTypeDefinitionByReference()
            => ReferencesTable[Reference];
    }
}
