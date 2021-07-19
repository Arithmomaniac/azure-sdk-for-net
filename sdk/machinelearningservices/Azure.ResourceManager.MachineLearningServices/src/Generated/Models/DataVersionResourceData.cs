// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A class representing the DataVersionResource data model. </summary>
    public partial class DataVersionResourceData : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of DataVersionResourceData. </summary>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataVersionResourceData(DataVersion properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataVersionResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal DataVersionResourceData(ResourceGroupResourceIdentifier id, string name, ResourceType type, DataVersion properties, SystemData systemData) : base(id, name, type)
        {
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Additional attributes of the entity. </summary>
        public DataVersion Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}
