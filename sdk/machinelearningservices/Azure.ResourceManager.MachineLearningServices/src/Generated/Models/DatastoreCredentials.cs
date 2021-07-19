// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Base definition for datastore credentials. </summary>
    public partial class DatastoreCredentials
    {
        /// <summary> Initializes a new instance of DatastoreCredentials. </summary>
        public DatastoreCredentials()
        {
        }

        /// <summary> Initializes a new instance of DatastoreCredentials. </summary>
        /// <param name="credentialsType"> Credential type used to authentication with storage. </param>
        internal DatastoreCredentials(CredentialsType credentialsType)
        {
            CredentialsType = credentialsType;
        }

        /// <summary> Credential type used to authentication with storage. </summary>
        internal CredentialsType CredentialsType { get; set; }
    }
}
