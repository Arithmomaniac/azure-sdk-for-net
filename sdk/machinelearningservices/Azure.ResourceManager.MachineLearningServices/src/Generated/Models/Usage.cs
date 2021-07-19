// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Describes AML Resource Usage. </summary>
    public partial class Usage : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Usage. </summary>
        internal Usage()
        {
        }

        /// <summary> Initializes a new instance of Usage. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="amlWorkspaceLocation"> Region of the AML workspace in the id. </param>
        /// <param name="type"> Specifies the resource type. </param>
        /// <param name="unit"> An enum describing the unit of usage measurement. </param>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name of the type of usage. </param>
        internal Usage(string id, string amlWorkspaceLocation, string type, UsageUnit? unit, long? currentValue, long? limit, UsageName name) : base(id)
        {
            AmlWorkspaceLocation = amlWorkspaceLocation;
            Type = type;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Region of the AML workspace in the id. </summary>
        public string AmlWorkspaceLocation { get; }
        /// <summary> Specifies the resource type. </summary>
        public string Type { get; }
        /// <summary> An enum describing the unit of usage measurement. </summary>
        public UsageUnit? Unit { get; }
        /// <summary> The current usage of the resource. </summary>
        public long? CurrentValue { get; }
        /// <summary> The maximum permitted usage of the resource. </summary>
        public long? Limit { get; }
        /// <summary> The name of the type of usage. </summary>
        public UsageName Name { get; }
    }
}
