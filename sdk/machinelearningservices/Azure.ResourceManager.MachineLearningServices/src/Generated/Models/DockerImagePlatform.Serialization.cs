// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class DockerImagePlatform : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OperatingSystemType))
            {
                writer.WritePropertyName("operatingSystemType");
                writer.WriteStringValue(OperatingSystemType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DockerImagePlatform DeserializeDockerImagePlatform(JsonElement element)
        {
            Optional<OperatingSystemType> operatingSystemType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatingSystemType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operatingSystemType = new OperatingSystemType(property.Value.GetString());
                    continue;
                }
            }
            return new DockerImagePlatform(Optional.ToNullable(operatingSystemType));
        }
    }
}
