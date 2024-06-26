// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricNeighborGroup data model.
    /// Defines the Neighbor Group.
    /// </summary>
    public partial class NetworkFabricNeighborGroupData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetworkFabricNeighborGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricNeighborGroupData(AzureLocation location) : base(location)
        {
            NetworkTapIds = new ChangeTrackingList<ResourceIdentifier>();
            NetworkTapRuleIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricNeighborGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="destination"> An array of destination IPv4 Addresses or IPv6 Addresses. </param>
        /// <param name="networkTapIds"> List of NetworkTap IDs where neighbor group is associated. </param>
        /// <param name="networkTapRuleIds"> List of Network Tap Rule IDs where neighbor group is associated. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricNeighborGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NeighborGroupDestination destination, IReadOnlyList<ResourceIdentifier> networkTapIds, IReadOnlyList<ResourceIdentifier> networkTapRuleIds, NetworkFabricProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            Destination = destination;
            NetworkTapIds = networkTapIds;
            NetworkTapRuleIds = networkTapRuleIds;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricNeighborGroupData"/> for deserialization. </summary>
        internal NetworkFabricNeighborGroupData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> An array of destination IPv4 Addresses or IPv6 Addresses. </summary>
        public NeighborGroupDestination Destination { get; set; }
        /// <summary> List of NetworkTap IDs where neighbor group is associated. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkTapIds { get; }
        /// <summary> List of Network Tap Rule IDs where neighbor group is associated. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkTapRuleIds { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
