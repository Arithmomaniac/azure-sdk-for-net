// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ManagedOnlineDeployment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceType))
            {
                writer.WritePropertyName("instanceType");
                writer.WriteStringValue(InstanceType);
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                writer.WritePropertyName("readinessProbe");
                writer.WriteObjectValue(ReadinessProbe);
            }
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled");
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                writer.WritePropertyName("codeConfiguration");
                writer.WriteObjectValue(CodeConfiguration);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("endpointComputeType");
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId");
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                writer.WritePropertyName("livenessProbe");
                writer.WriteObjectValue(LivenessProbe);
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model");
                writer.WriteObjectValue(Model);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RequestSettings))
            {
                writer.WritePropertyName("requestSettings");
                writer.WriteObjectValue(RequestSettings);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings");
                writer.WriteObjectValue(ScaleSettings);
            }
            writer.WriteEndObject();
        }

        internal static ManagedOnlineDeployment DeserializeManagedOnlineDeployment(JsonElement element)
        {
            Optional<string> instanceType = default;
            Optional<ProbeSettings> readinessProbe = default;
            Optional<bool> appInsightsEnabled = default;
            Optional<CodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            EndpointComputeType endpointComputeType = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<ProbeSettings> livenessProbe = default;
            Optional<AssetReferenceBase> model = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<DeploymentProvisioningState> provisioningState = default;
            Optional<OnlineRequestSettings> requestSettings = default;
            Optional<OnlineScaleSettings> scaleSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readinessProbe"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readinessProbe = ProbeSettings.DeserializeProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("appInsightsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("codeConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    codeConfiguration = CodeConfiguration.DeserializeCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointComputeType"))
                {
                    endpointComputeType = new EndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environmentId"))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("livenessProbe"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    livenessProbe = ProbeSettings.DeserializeProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("model"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    model = AssetReferenceBase.DeserializeAssetReferenceBase(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new DeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestSettings = OnlineRequestSettings.DeserializeOnlineRequestSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSettings = OnlineScaleSettings.DeserializeOnlineScaleSettings(property.Value);
                    continue;
                }
            }
            return new ManagedOnlineDeployment(Optional.ToNullable(appInsightsEnabled), codeConfiguration.Value, description.Value, endpointComputeType, environmentId.Value, Optional.ToDictionary(environmentVariables), livenessProbe.Value, model.Value, Optional.ToDictionary(properties), Optional.ToNullable(provisioningState), requestSettings.Value, scaleSettings.Value, instanceType.Value, readinessProbe.Value);
        }
    }
}
