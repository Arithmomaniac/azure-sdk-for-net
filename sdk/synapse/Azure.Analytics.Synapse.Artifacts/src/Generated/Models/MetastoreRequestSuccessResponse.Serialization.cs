// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(MetastoreRequestSuccessResponseConverter))]
    public partial class MetastoreRequestSuccessResponse
    {
        internal static MetastoreRequestSuccessResponse DeserializeMetastoreRequestSuccessResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceStatus? status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ResourceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new MetastoreRequestSuccessResponse(status);
        }

        internal partial class MetastoreRequestSuccessResponseConverter : JsonConverter<MetastoreRequestSuccessResponse>
        {
            public override void Write(Utf8JsonWriter writer, MetastoreRequestSuccessResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MetastoreRequestSuccessResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMetastoreRequestSuccessResponse(document.RootElement);
            }
        }
    }
}
