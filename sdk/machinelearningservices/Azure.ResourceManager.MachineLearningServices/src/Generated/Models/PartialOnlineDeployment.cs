// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Mutable online deployment configuration. </summary>
    public partial class PartialOnlineDeployment
    {
        /// <summary> Initializes a new instance of PartialOnlineDeployment. </summary>
        public PartialOnlineDeployment()
        {
        }

        public bool? AppInsightsEnabled { get; set; }
        /// <summary> Enum to determine endpoint compute type. </summary>
        internal EndpointComputeType EndpointComputeType { get; set; }
        public ProbeSettings LivenessProbe { get; set; }
        public OnlineRequestSettings RequestSettings { get; set; }
        public OnlineScaleSettings ScaleSettings { get; set; }
    }
}
