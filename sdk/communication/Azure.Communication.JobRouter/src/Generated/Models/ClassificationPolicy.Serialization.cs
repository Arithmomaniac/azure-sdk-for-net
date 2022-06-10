// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ClassificationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FallbackQueueId))
            {
                writer.WritePropertyName("fallbackQueueId");
                writer.WriteStringValue(FallbackQueueId);
            }
            if (Optional.IsCollectionDefined(QueueSelectors))
            {
                writer.WritePropertyName("queueSelectors");
                writer.WriteStartArray();
                foreach (var item in QueueSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrioritizationRule))
            {
                writer.WritePropertyName("prioritizationRule");
                writer.WriteObjectValue(PrioritizationRule);
            }
            if (Optional.IsCollectionDefined(WorkerSelectors))
            {
                writer.WritePropertyName("workerSelectors");
                writer.WriteStartArray();
                foreach (var item in WorkerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ClassificationPolicy DeserializeClassificationPolicy(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> fallbackQueueId = default;
            Optional<IList<QueueSelectorAttachment>> queueSelectors = default;
            Optional<RouterRule> prioritizationRule = default;
            Optional<IList<WorkerSelectorAttachment>> workerSelectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fallbackQueueId"))
                {
                    fallbackQueueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QueueSelectorAttachment> array = new List<QueueSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueSelectorAttachment.DeserializeQueueSelectorAttachment(item));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (property.NameEquals("prioritizationRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prioritizationRule = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("workerSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkerSelectorAttachment> array = new List<WorkerSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerSelectorAttachment.DeserializeWorkerSelectorAttachment(item));
                    }
                    workerSelectors = array;
                    continue;
                }
            }
            return new ClassificationPolicy(id.Value, name.Value, fallbackQueueId.Value, Optional.ToList(queueSelectors), prioritizationRule.Value, Optional.ToList(workerSelectors));
        }
    }
}
