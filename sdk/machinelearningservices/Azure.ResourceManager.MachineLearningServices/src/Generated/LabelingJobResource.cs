// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a LabelingJobResource along with the instance operations that can be performed on it. </summary>
    public class LabelingJobResource : LabelingJobResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "LabelingJobResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal LabelingJobResource(OperationsBase options, LabelingJobResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the LabelingJobResourceData. </summary>
        public LabelingJobResourceData Data { get; private set; }
    }
}
