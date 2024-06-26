// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> Response that identifies a Job Run. </summary>
    public partial class JobRunResourceId
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

        /// <summary> Initializes a new instance of <see cref="JobRunResourceId"/>. </summary>
        internal JobRunResourceId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobRunResourceId"/>. </summary>
        /// <param name="jobRunResourceIdValue"> Fully qualified resource id of the Job Run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobRunResourceId(ResourceIdentifier jobRunResourceIdValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobRunResourceIdValue = jobRunResourceIdValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully qualified resource id of the Job Run. </summary>
        public ResourceIdentifier JobRunResourceIdValue { get; }
    }
}
