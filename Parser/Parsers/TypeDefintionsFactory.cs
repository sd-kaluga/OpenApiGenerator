using Parser.Models.TypeDefinitions;
using Parser.Models.TypeDefinitions.Collections;
using Parser.OpenApiData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parser.Parsers
{
    public class TypeDefintionsFactory
    {
        private ReferencesTable ReferencesTable { get; }
        public TypeDefintionsFactory(ReferencesTable referencesTable)
        {
            ReferencesTable = referencesTable;
        }

        public TypeDefinitionModelBase GetTypeDefinition(OpenApiSchemaDescription schema, string name)
        {
            // ToDo: потенциально возможны повторяющиеся имена типов, если св-ва объектного типа объявлены по месту без $ref и имеют одинаковые имена
            return schema switch
            {
                { Type: null } and { Reference: null } => throw new Exception(), // no type, no ref
                { Enum: not null } => CreateEnumDefinition(schema, name),
                { Type: SchemaType.Object }
                    and { AdditionalProperties: false }
                    and { AdditionalPropertiesSchema: null } // Тип объекта, но не словарь (нет AdditionalProperties)
                    => CreateObjectDefinition(schema, name),
                { Reference: not null } => new ReferenceLinkedTypeDefinition(schema, ReferencesTable),
                { Type: SchemaType.Integer or SchemaType.Number }
                    => CreateNumericPropertyDefinition(schema),
                (SchemaType.String, _) => CreateStringBasedDefinition(schema),
                { Type: SchemaType.Boolean } => new BooleanDefinition(schema),
                { Type: SchemaType.Array } => CreateArrayDefinition(schema),
                { Type: SchemaType.Object }
                    and { AdditionalProperties: null }
                    and { AdditionalPropertiesSchema: not null }
                    => CreateDictionaryDefinition(schema),
                null => throw new ArgumentException(nameof(schema)),
                _ => null // throw new NotImplementedException()
            };
        }

        private EnumDefinitionBase CreateEnumDefinition(OpenApiSchemaDescription schema, string name)
        {
            EnumDefinitionBase typeDefinition = schema.Type switch
            {
                SchemaType.Integer => new IntegerEnumDefinition(name, schema),
                SchemaType.String => new StringEnumDefinition(name, schema),
                _ => throw new NotSupportedException("For enum only integer and string types are available")
            };
            return typeDefinition;
        }

        private ObjectTypeDefinition CreateObjectDefinition(OpenApiSchemaDescription schema, string name)
        {
            var membersDefinitions = schema.Properties?
                .Select(kvp => CreatePropertyDefinition(kvp.Key, kvp.Value, schema))
                .ToList() ?? new List<ObjectProperty>();

            return new ObjectTypeDefinition(name, schema, membersDefinitions);
        }

        private ArrayDefinition CreateArrayDefinition(OpenApiSchemaDescription schema)
        {
            var elementDefinitionScheme = schema.Items ?? throw new InvalidOperationException();
            var elementDefinition = GetTypeDefinition(elementDefinitionScheme, null);
            return new ArrayDefinition(schema, elementDefinition);
        }
        private DictionaryDefinition CreateDictionaryDefinition(OpenApiSchemaDescription schema)
        {
            var elementDefinitionScheme = schema.AdditionalPropertiesSchema ?? throw new InvalidOperationException();
            var elementDefinition = GetTypeDefinition(elementDefinitionScheme, null);
            return new DictionaryDefinition(schema, elementDefinition);
        }
        private ObjectProperty CreatePropertyDefinition(string propertyName,
            OpenApiSchemaDescription propertySchema,
            OpenApiSchemaDescription objectSchema)
        {
            var propertyTypeDefinition = GetTypeDefinition(propertySchema, null);
            var isRequired = objectSchema.Required?.Contains(propertyName) ?? false;
            return new ObjectProperty(propertyName, propertyTypeDefinition, isRequired);
        }

        private StringDefinition CreateStringBasedDefinition(OpenApiSchemaDescription schema)
        {
            StringDefinition definition = schema switch
            {
                null => throw new ArgumentNullException(nameof(schema)),
                { Type: not SchemaType.String } => throw new ArgumentException(nameof(schema)),
                // OpenAPI defines
                { Format: "date" or "date-time" } => new DateTimeDefinition(schema),
                { Format: "byte" } => null,
                { Format: "binary" } => null,
                { Format: "password " } => new StringDefinition(schema), // Формат, оговорен спецификацией
                // Прочие форматы
                _ => new StringDefinition(schema)
            };
            return definition;
        }

        private NumericTypeDefinitionBase CreateNumericPropertyDefinition(OpenApiSchemaDescription propertySchema)
        {
            NumericTypeDefinitionBase definition = propertySchema switch
            {
                null => throw new ArgumentNullException(nameof(propertySchema)),
                { Type: not (SchemaType.Integer or SchemaType.Number) }
                    => throw new ArgumentException(nameof(propertySchema)),
                (SchemaType.Integer, null or "" or "int64") => new BigIntegerDefinition(propertySchema),
                (SchemaType.Integer, "int32") => new IntegerDefinition(propertySchema),
                (SchemaType.Number, null or "" or "double") => new DoubleDefinition(propertySchema),
                (SchemaType.Number, "float") => new FloatDefinition(propertySchema),
                _ => throw new InvalidOperationException()
            };
            return definition;
        }

    }
}


