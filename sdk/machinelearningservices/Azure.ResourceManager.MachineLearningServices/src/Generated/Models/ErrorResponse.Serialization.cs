// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ErrorResponse
    {
        internal static ErrorResponse DeserializeErrorResponse(JsonElement element)
        {
            Optional<ErrorDetail> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
            }
            return new ErrorResponse(error.Value);
        }
    }
}
