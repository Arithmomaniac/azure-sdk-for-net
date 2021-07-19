// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Empty/none datastore secret. </summary>
    public partial class NoneDatastoreSecrets : DatastoreSecrets
    {
        /// <summary> Initializes a new instance of NoneDatastoreSecrets. </summary>
        public NoneDatastoreSecrets()
        {
            SecretsType = SecretsType.None;
        }

        /// <summary> Initializes a new instance of NoneDatastoreSecrets. </summary>
        /// <param name="secretsType"> Credential type used to authentication with storage. </param>
        internal NoneDatastoreSecrets(SecretsType secretsType) : base(secretsType)
        {
            SecretsType = secretsType;
        }
    }
}
