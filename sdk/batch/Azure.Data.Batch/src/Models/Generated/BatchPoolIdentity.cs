// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    /// <summary> The identity of the Batch pool, if configured. </summary>
    public partial class BatchPoolIdentity
    {
        /// <summary> Initializes a new instance of BatchPoolIdentity. </summary>
        /// <param name="type"> The list of user identities associated with the Batch pool. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </param>
        internal BatchPoolIdentity(PoolIdentityType type)
        {
            Type = type;
            UserAssignedIdentities = new ChangeTrackingList<UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of BatchPoolIdentity. </summary>
        /// <param name="type"> The list of user identities associated with the Batch pool. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </param>
        /// <param name="userAssignedIdentities"> The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </param>
        internal BatchPoolIdentity(PoolIdentityType type, IReadOnlyList<UserAssignedIdentity> userAssignedIdentities)
        {
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The list of user identities associated with the Batch pool. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </summary>
        public PoolIdentityType Type { get; }
        /// <summary> The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </summary>
        public IReadOnlyList<UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
