using Parser.OpenApiData;
using System.Text.Json;

namespace Parser.Models.TypeDefinitions
{
    public abstract class NumericTypeDefinitionBase<TValue> : NumericTypeDefinitionBase where TValue : struct
    {
        protected NumericTypeDefinitionBase(OpenApiSchemaDescription schema) : base(schema)
        {
            ExclusiveMinimum = schema.ExclusiveMinimum;
            ExclusiveMaximum = schema.ExclusiveMaximum;
            Minimum = schema.Minimum.HasValue
                ? GetValueFromJsonElement(schema.Minimum.Value)
                : default(TValue?);
            Maximum = schema.Maximum.HasValue
                ? GetValueFromJsonElement(schema.Maximum.Value)
                : default(TValue?);
        }

        public TValue? Minimum { get; }
        public bool? ExclusiveMinimum { get; }
        public TValue? Maximum { get; }
        public bool? ExclusiveMaximum { get; }

        // ToDo: Добавить свойство multipleOf

        protected abstract TValue GetValueFromJsonElement(JsonElement jsonElement);
    }


}
