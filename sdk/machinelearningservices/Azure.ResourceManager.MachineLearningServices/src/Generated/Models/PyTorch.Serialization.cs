// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PyTorch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessCount))
            {
                writer.WritePropertyName("processCount");
                writer.WriteNumberValue(ProcessCount.Value);
            }
            writer.WritePropertyName("distributionType");
            writer.WriteStringValue(DistributionType.ToString());
            writer.WriteEndObject();
        }

        internal static PyTorch DeserializePyTorch(JsonElement element)
        {
            Optional<int> processCount = default;
            DistributionType distributionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    processCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
            }
            return new PyTorch(distributionType, Optional.ToNullable(processCount));
        }
    }
}
