// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class OnlineDeploymentTrackedResourceArmPaginatedResult
    {
        internal static OnlineDeploymentTrackedResourceArmPaginatedResult DeserializeOnlineDeploymentTrackedResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<OnlineDeploymentTrackedResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OnlineDeploymentTrackedResourceData> array = new List<OnlineDeploymentTrackedResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OnlineDeploymentTrackedResourceData.DeserializeOnlineDeploymentTrackedResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new OnlineDeploymentTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
