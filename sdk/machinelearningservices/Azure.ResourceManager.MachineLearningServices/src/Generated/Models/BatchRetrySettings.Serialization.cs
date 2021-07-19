// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class BatchRetrySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxRetries))
            {
                writer.WritePropertyName("maxRetries");
                writer.WriteNumberValue(MaxRetries.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static BatchRetrySettings DeserializeBatchRetrySettings(JsonElement element)
        {
            Optional<int> maxRetries = default;
            Optional<TimeSpan> timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRetries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxRetries = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new BatchRetrySettings(Optional.ToNullable(maxRetries), Optional.ToNullable(timeout));
        }
    }
}
