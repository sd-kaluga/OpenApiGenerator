using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Parser.OpenApiData
{
    public class OpenApiSchemaDescription : SchemaElementBase
    {

        [JsonPropertyName("type")]
        public SchemaType? Type { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("nullable")]
        public bool? Nullable { get; set; }

        [JsonPropertyName("$ref")]
        public string Reference { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }

        #region AdditionalProperties

        [JsonPropertyName("additionalProperties")]
        public JsonElement? AdditionalPropertiesFromJson { get; set; }

        public OpenApiSchemaDescription AdditionalPropertiesSchema
        {
            get
            {
                if (TryGetAdditionalPropertiesAsBool(out var _) || !AdditionalPropertiesFromJson.HasValue)
                {
                    return null;
                }

                var rawJson = AdditionalPropertiesFromJson.Value.GetRawText();
                return JsonSerializer.Deserialize<OpenApiSchemaDescription>(rawJson);
            }
        }

        private bool TryGetAdditionalPropertiesAsBool(out bool value)
        {
            if (!AdditionalPropertiesFromJson.HasValue)
            {
                value = false;
                return false;
            }
            try
            {
                value = AdditionalPropertiesFromJson.Value.GetBoolean();
                return true;
            }
            catch (InvalidOperationException)
            {
                value = false;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool? AdditionalProperties
        {
            get => TryGetAdditionalPropertiesAsBool(out var res) 
                ? res
                : default(bool?);
        }

        #endregion

        [JsonPropertyName("required")]
        public string[] Required { get; set; }

        [JsonPropertyName("enum")]
        public JsonElement[] Enum { get; set; }

        [JsonPropertyName("minimum")]
        public JsonElement? Minimum { get; set; }

        [JsonPropertyName("maximum")]
        public JsonElement? Maximum { get; set; }

        [JsonPropertyName("exclusiveMinimum")]
        public bool? ExclusiveMinimum { get; set; }

        [JsonPropertyName("exclusiveMaximum")]
        public bool? ExclusiveMaximum { get; set; }

        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        [JsonPropertyName("maxLength")]
        public int? MaxLength { get; set; }

        [JsonPropertyName("minLength")]
        public int? MinLength { get; set; }

        [JsonPropertyName("items")]
        public OpenApiSchemaDescription Items { get; set; }

        public void Deconstruct(out SchemaType? type, out string format)
        {
            type = Type;
            format = Format;
        }
    }
}
