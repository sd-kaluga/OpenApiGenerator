using Parser.OpenApiData;
using System;
using System.Linq;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public abstract class EnumDefinitionBase<TValue> : EnumDefinitionBase
    {
        protected EnumDefinitionBase(string name,
             OpenApiSchemaDescription schema) : base(name, schema)
        {
            Values = (schema.Enum ?? throw new ArgumentException(nameof(schema)))
                .Select(GetValueFromJsonElement)
                .ToArray();
        }

        public TValue[] Values { get; }

        protected abstract TValue GetValueFromJsonElement(JsonElement jsonElement);
    }


}
