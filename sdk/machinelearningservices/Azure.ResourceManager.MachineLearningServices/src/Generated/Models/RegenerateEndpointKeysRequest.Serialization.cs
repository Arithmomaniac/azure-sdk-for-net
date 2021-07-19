// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class RegenerateEndpointKeysRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyType");
            writer.WriteStringValue(KeyType.ToString());
            if (Optional.IsDefined(KeyValue))
            {
                writer.WritePropertyName("keyValue");
                writer.WriteStringValue(KeyValue);
            }
            writer.WriteEndObject();
        }
    }
}
