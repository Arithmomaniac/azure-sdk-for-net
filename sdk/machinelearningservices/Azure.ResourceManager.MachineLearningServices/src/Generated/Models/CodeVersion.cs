// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Code asset version details. </summary>
    public partial class CodeVersion
    {
        /// <summary> Initializes a new instance of CodeVersion. </summary>
        /// <param name="path"> The path of the file/directory in the datastore. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public CodeVersion(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            Path = path;
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of CodeVersion. </summary>
        /// <param name="datastoreId"> ARM resource ID of the datastore where the asset is located. </param>
        /// <param name="description"> The asset description text. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="path"> The path of the file/directory in the datastore. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        internal CodeVersion(string datastoreId, string description, bool? isAnonymous, string path, IDictionary<string, string> properties, IDictionary<string, string> tags)
        {
            DatastoreId = datastoreId;
            Description = description;
            IsAnonymous = isAnonymous;
            Path = path;
            Properties = properties;
            Tags = tags;
        }

        /// <summary> ARM resource ID of the datastore where the asset is located. </summary>
        public string DatastoreId { get; set; }
        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> If the name version are system generated (anonymous registration). </summary>
        public bool? IsAnonymous { get; set; }
        /// <summary> The path of the file/directory in the datastore. </summary>
        public string Path { get; set; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
