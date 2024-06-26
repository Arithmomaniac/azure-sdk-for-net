// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Replication usages of a vault. </summary>
    public partial class ReplicationUsage
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

        /// <summary> Initializes a new instance of <see cref="ReplicationUsage"/>. </summary>
        internal ReplicationUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationUsage"/>. </summary>
        /// <param name="monitoringSummary"> Summary of the replication monitoring data for this vault. </param>
        /// <param name="jobsSummary"> Summary of the replication jobs data for this vault. </param>
        /// <param name="protectedItemCount"> Number of replication protected items for this vault. </param>
        /// <param name="recoveryPlanCount"> Number of replication recovery plans for this vault. </param>
        /// <param name="registeredServersCount"> Number of servers registered to this vault. </param>
        /// <param name="recoveryServicesProviderAuthType"> The authentication type of recovery service providers in the vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReplicationUsage(VaultMonitoringSummary monitoringSummary, ReplicationJobSummary jobsSummary, int? protectedItemCount, int? recoveryPlanCount, int? registeredServersCount, int? recoveryServicesProviderAuthType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MonitoringSummary = monitoringSummary;
            JobsSummary = jobsSummary;
            ProtectedItemCount = protectedItemCount;
            RecoveryPlanCount = recoveryPlanCount;
            RegisteredServersCount = registeredServersCount;
            RecoveryServicesProviderAuthType = recoveryServicesProviderAuthType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Summary of the replication monitoring data for this vault. </summary>
        public VaultMonitoringSummary MonitoringSummary { get; }
        /// <summary> Summary of the replication jobs data for this vault. </summary>
        public ReplicationJobSummary JobsSummary { get; }
        /// <summary> Number of replication protected items for this vault. </summary>
        public int? ProtectedItemCount { get; }
        /// <summary> Number of replication recovery plans for this vault. </summary>
        public int? RecoveryPlanCount { get; }
        /// <summary> Number of servers registered to this vault. </summary>
        public int? RegisteredServersCount { get; }
        /// <summary> The authentication type of recovery service providers in the vault. </summary>
        public int? RecoveryServicesProviderAuthType { get; }
    }
}
