// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{

    /// <summary>
    /// Defines values for RestorePointEncryptionType.
    /// </summary>
    public static class RestorePointEncryptionType
    {
        /// <summary>
        /// Disk Restore Point is encrypted at rest with Platform managed key.
        /// </summary>
        public const string EncryptionAtRestWithPlatformKey = "EncryptionAtRestWithPlatformKey";
        /// <summary>
        /// Disk Restore Point is encrypted at rest with Customer managed key
        /// that can be changed and revoked by a customer.
        /// </summary>
        public const string EncryptionAtRestWithCustomerKey = "EncryptionAtRestWithCustomerKey";
        /// <summary>
        /// Disk Restore Point is encrypted at rest with 2 layers of
        /// encryption. One of the keys is Customer managed and the other key
        /// is Platform managed.
        /// </summary>
        public const string EncryptionAtRestWithPlatformAndCustomerKeys = "EncryptionAtRestWithPlatformAndCustomerKeys";
    }
}
