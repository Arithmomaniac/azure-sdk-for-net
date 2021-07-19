// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> SAS datastore credentials configuration. </summary>
    public partial class SasDatastoreCredentials : DatastoreCredentials
    {
        /// <summary> Initializes a new instance of SasDatastoreCredentials. </summary>
        public SasDatastoreCredentials()
        {
            CredentialsType = CredentialsType.Sas;
        }

        /// <summary> Initializes a new instance of SasDatastoreCredentials. </summary>
        /// <param name="credentialsType"> Credential type used to authentication with storage. </param>
        /// <param name="secrets"> Storage container secrets. </param>
        internal SasDatastoreCredentials(CredentialsType credentialsType, SasDatastoreSecrets secrets) : base(credentialsType)
        {
            Secrets = secrets;
            CredentialsType = credentialsType;
        }

        /// <summary> Storage container secrets. </summary>
        public SasDatastoreSecrets Secrets { get; set; }
    }
}
