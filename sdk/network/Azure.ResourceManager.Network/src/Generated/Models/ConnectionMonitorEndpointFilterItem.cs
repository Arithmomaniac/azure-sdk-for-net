// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the connection monitor endpoint filter item. </summary>
    public partial class ConnectionMonitorEndpointFilterItem
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

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointFilterItem"/>. </summary>
        public ConnectionMonitorEndpointFilterItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointFilterItem"/>. </summary>
        /// <param name="itemType"> The type of item included in the filter. Currently only 'AgentAddress' is supported. </param>
        /// <param name="address"> The address of the filter item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorEndpointFilterItem(ConnectionMonitorEndpointFilterItemType? itemType, string address, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ItemType = itemType;
            Address = address;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of item included in the filter. Currently only 'AgentAddress' is supported. </summary>
        public ConnectionMonitorEndpointFilterItemType? ItemType { get; set; }
        /// <summary> The address of the filter item. </summary>
        public string Address { get; set; }
    }
}
