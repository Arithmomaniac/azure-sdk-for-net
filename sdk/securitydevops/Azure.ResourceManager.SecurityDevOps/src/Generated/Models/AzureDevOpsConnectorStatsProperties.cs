// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AzureDevOpsConnectorStatsProperties. </summary>
    public partial class AzureDevOpsConnectorStatsProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsConnectorStatsProperties"/>. </summary>
        public AzureDevOpsConnectorStatsProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsConnectorStatsProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="orgsCount"> Gets or sets orgs count. </param>
        /// <param name="projectsCount"> Gets or sets projects count. </param>
        /// <param name="reposCount"> Gets or sets repos count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsConnectorStatsProperties(ProvisioningState? provisioningState, long? orgsCount, long? projectsCount, long? reposCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            OrgsCount = orgsCount;
            ProjectsCount = projectsCount;
            ReposCount = reposCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets orgs count. </summary>
        public long? OrgsCount { get; set; }
        /// <summary> Gets or sets projects count. </summary>
        public long? ProjectsCount { get; set; }
        /// <summary> Gets or sets repos count. </summary>
        public long? ReposCount { get; set; }
    }
}
