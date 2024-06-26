// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> Metadata of the Resource Type. </summary>
    public partial class CustomLocationEnabledResourceTypeMetadata
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

        /// <summary> Initializes a new instance of <see cref="CustomLocationEnabledResourceTypeMetadata"/>. </summary>
        public CustomLocationEnabledResourceTypeMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomLocationEnabledResourceTypeMetadata"/>. </summary>
        /// <param name="apiVersion"> Api Version of Resource Type. </param>
        /// <param name="resourceProviderNamespace"> Resource Provider Namespace of Resource Type. </param>
        /// <param name="resourceType"> Resource Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomLocationEnabledResourceTypeMetadata(string apiVersion, string resourceProviderNamespace, string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiVersion = apiVersion;
            ResourceProviderNamespace = resourceProviderNamespace;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Api Version of Resource Type. </summary>
        public string ApiVersion { get; set; }
        /// <summary> Resource Provider Namespace of Resource Type. </summary>
        public string ResourceProviderNamespace { get; set; }
        /// <summary> Resource Type. </summary>
        public string ResourceType { get; set; }
    }
}
