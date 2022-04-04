// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    /// <summary> The result of listing the Compute Node counts in the Account. </summary>
    internal partial class PoolNodeCountsListResult
    {
        /// <summary> Initializes a new instance of PoolNodeCountsListResult. </summary>
        internal PoolNodeCountsListResult()
        {
            Value = new ChangeTrackingList<PoolNodeCounts>();
        }

        /// <summary> Initializes a new instance of PoolNodeCountsListResult. </summary>
        /// <param name="value"> A list of Compute Node counts by Pool. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal PoolNodeCountsListResult(IReadOnlyList<PoolNodeCounts> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A list of Compute Node counts by Pool. </summary>
        public IReadOnlyList<PoolNodeCounts> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
