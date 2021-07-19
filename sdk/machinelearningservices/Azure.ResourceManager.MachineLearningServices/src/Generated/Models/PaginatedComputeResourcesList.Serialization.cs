// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class PaginatedComputeResourcesList
    {
        internal static PaginatedComputeResourcesList DeserializePaginatedComputeResourcesList(JsonElement element)
        {
            Optional<IReadOnlyList<ComputeResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComputeResourceData> array = new List<ComputeResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeResourceData.DeserializeComputeResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PaginatedComputeResourcesList(Optional.ToList(value), nextLink.Value);
        }
    }
}
