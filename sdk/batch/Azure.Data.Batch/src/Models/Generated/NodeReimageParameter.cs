// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Batch.Models
{
    /// <summary> Options for reimaging a Compute Node. </summary>
    public partial class NodeReimageParameter
    {
        /// <summary> Initializes a new instance of NodeReimageParameter. </summary>
        public NodeReimageParameter()
        {
        }

        /// <summary> The default value is requeue. </summary>
        public ComputeNodeReimageOption? NodeReimageOption { get; set; }
    }
}
