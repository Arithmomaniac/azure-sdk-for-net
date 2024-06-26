// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The private link service connection state of the private endpoint connection. </summary>
    public partial class BatchPrivateLinkServiceConnectionState
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

        /// <summary> Initializes a new instance of <see cref="BatchPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of the Batch private endpoint connection. </param>
        public BatchPrivateLinkServiceConnectionState(BatchPrivateLinkServiceConnectionStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of the Batch private endpoint connection. </param>
        /// <param name="description"> Description of the private Connection state. </param>
        /// <param name="actionRequired"> Action required on the private connection state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPrivateLinkServiceConnectionState(BatchPrivateLinkServiceConnectionStatus status, string description, string actionRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionRequired = actionRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPrivateLinkServiceConnectionState"/> for deserialization. </summary>
        internal BatchPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> The status of the Batch private endpoint connection. </summary>
        public BatchPrivateLinkServiceConnectionStatus Status { get; set; }
        /// <summary> Description of the private Connection state. </summary>
        public string Description { get; set; }
        /// <summary> Action required on the private connection state. </summary>
        public string ActionRequired { get; }
    }
}
