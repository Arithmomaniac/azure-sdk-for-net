// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class AzureDataLakeGen1Contents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("storeName");
            writer.WriteStringValue(StoreName);
            writer.WritePropertyName("contentsType");
            writer.WriteStringValue(ContentsType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureDataLakeGen1Contents DeserializeAzureDataLakeGen1Contents(JsonElement element)
        {
            DatastoreCredentials credentials = default;
            string storeName = default;
            ContentsType contentsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"))
                {
                    credentials = DatastoreCredentials.DeserializeDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("storeName"))
                {
                    storeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentsType"))
                {
                    contentsType = new ContentsType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureDataLakeGen1Contents(contentsType, credentials, storeName);
        }
    }
}
