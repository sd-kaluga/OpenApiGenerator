using Parser.Models.TypeDefinitions;
using System;
using System.Collections.Generic;

namespace Parser.Parsers
{
    public class ReferencesTable
    {
        private Dictionary<string, TypeDefinitionModelBase> DefinitionsMap { get; } = new Dictionary<string, TypeDefinitionModelBase>();

        public TypeDefinitionModelBase this[string reference]
        {
            get => reference switch
            {
                null => throw new ArgumentNullException(nameof(reference)),
                string s when s.StartsWith("#") => DefinitionsMap.TryGetValue(reference, out var r)
                    ? r
                    : throw new KeyNotFoundException($"Описание типа {reference} не найдено"),
                _ => throw new NotSupportedException("Только ref внутри документа")
            };
            set
            {
                DefinitionsMap[reference] = value;
            }
        }
    }
}


