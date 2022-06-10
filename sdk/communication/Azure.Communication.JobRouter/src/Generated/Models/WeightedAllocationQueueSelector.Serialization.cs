// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WeightedAllocationQueueSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allocations");
            writer.WriteStartArray();
            foreach (var item in Allocations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static WeightedAllocationQueueSelector DeserializeWeightedAllocationQueueSelector(JsonElement element)
        {
            IList<QueueWeightedAllocation> allocations = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocations"))
                {
                    List<QueueWeightedAllocation> array = new List<QueueWeightedAllocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueWeightedAllocation.DeserializeQueueWeightedAllocation(item));
                    }
                    allocations = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new WeightedAllocationQueueSelector(kind, allocations);
        }
    }
}
