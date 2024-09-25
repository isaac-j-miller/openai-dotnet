// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Moderations
{
    internal partial class InternalModerationCategories : IJsonModel<InternalModerationCategories>
    {
        void IJsonModel<InternalModerationCategories>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalModerationCategories>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModerationCategories)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("hate") != true)
            {
                writer.WritePropertyName("hate"u8);
                writer.WriteBooleanValue(Hate);
            }
            if (SerializedAdditionalRawData?.ContainsKey("hate/threatening") != true)
            {
                writer.WritePropertyName("hate/threatening"u8);
                writer.WriteBooleanValue(HateThreatening);
            }
            if (SerializedAdditionalRawData?.ContainsKey("harassment") != true)
            {
                writer.WritePropertyName("harassment"u8);
                writer.WriteBooleanValue(Harassment);
            }
            if (SerializedAdditionalRawData?.ContainsKey("harassment/threatening") != true)
            {
                writer.WritePropertyName("harassment/threatening"u8);
                writer.WriteBooleanValue(HarassmentThreatening);
            }
            if (SerializedAdditionalRawData?.ContainsKey("self-harm") != true)
            {
                writer.WritePropertyName("self-harm"u8);
                writer.WriteBooleanValue(SelfHarm);
            }
            if (SerializedAdditionalRawData?.ContainsKey("self-harm/intent") != true)
            {
                writer.WritePropertyName("self-harm/intent"u8);
                writer.WriteBooleanValue(SelfHarmIntent);
            }
            if (SerializedAdditionalRawData?.ContainsKey("self-harm/instructions") != true)
            {
                writer.WritePropertyName("self-harm/instructions"u8);
                writer.WriteBooleanValue(SelfHarmInstructions);
            }
            if (SerializedAdditionalRawData?.ContainsKey("sexual") != true)
            {
                writer.WritePropertyName("sexual"u8);
                writer.WriteBooleanValue(Sexual);
            }
            if (SerializedAdditionalRawData?.ContainsKey("sexual/minors") != true)
            {
                writer.WritePropertyName("sexual/minors"u8);
                writer.WriteBooleanValue(SexualMinors);
            }
            if (SerializedAdditionalRawData?.ContainsKey("violence") != true)
            {
                writer.WritePropertyName("violence"u8);
                writer.WriteBooleanValue(Violence);
            }
            if (SerializedAdditionalRawData?.ContainsKey("violence/graphic") != true)
            {
                writer.WritePropertyName("violence/graphic"u8);
                writer.WriteBooleanValue(ViolenceGraphic);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalModerationCategories IJsonModel<InternalModerationCategories>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalModerationCategories>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModerationCategories)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalModerationCategories(document.RootElement, options);
        }

        internal static InternalModerationCategories DeserializeInternalModerationCategories(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool hate = default;
            bool hateThreatening = default;
            bool harassment = default;
            bool harassmentThreatening = default;
            bool selfHarm = default;
            bool selfHarmIntent = default;
            bool selfHarmInstructions = default;
            bool sexual = default;
            bool sexualMinors = default;
            bool violence = default;
            bool violenceGraphic = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hate"u8))
                {
                    hate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hate/threatening"u8))
                {
                    hateThreatening = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("harassment"u8))
                {
                    harassment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("harassment/threatening"u8))
                {
                    harassmentThreatening = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("self-harm"u8))
                {
                    selfHarm = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("self-harm/intent"u8))
                {
                    selfHarmIntent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("self-harm/instructions"u8))
                {
                    selfHarmInstructions = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sexual"u8))
                {
                    sexual = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sexual/minors"u8))
                {
                    sexualMinors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("violence"u8))
                {
                    violence = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("violence/graphic"u8))
                {
                    violenceGraphic = property.Value.GetBoolean();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalModerationCategories(
                hate,
                hateThreatening,
                harassment,
                harassmentThreatening,
                selfHarm,
                selfHarmIntent,
                selfHarmInstructions,
                sexual,
                sexualMinors,
                violence,
                violenceGraphic,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalModerationCategories>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalModerationCategories>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalModerationCategories)} does not support writing '{options.Format}' format.");
            }
        }

        InternalModerationCategories IPersistableModel<InternalModerationCategories>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalModerationCategories>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalModerationCategories(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalModerationCategories)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalModerationCategories>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalModerationCategories FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalModerationCategories(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}