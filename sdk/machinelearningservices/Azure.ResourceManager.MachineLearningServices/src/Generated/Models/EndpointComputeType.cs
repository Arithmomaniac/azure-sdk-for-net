// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum to determine endpoint compute type. </summary>
    public readonly partial struct EndpointComputeType : IEquatable<EndpointComputeType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EndpointComputeType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointComputeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManagedValue = "Managed";
        private const string K8SValue = "K8S";
        private const string AzureMLComputeValue = "AzureMLCompute";

        /// <summary> Managed. </summary>
        public static EndpointComputeType Managed { get; } = new EndpointComputeType(ManagedValue);
        /// <summary> K8S. </summary>
        public static EndpointComputeType K8S { get; } = new EndpointComputeType(K8SValue);
        /// <summary> AzureMLCompute. </summary>
        public static EndpointComputeType AzureMLCompute { get; } = new EndpointComputeType(AzureMLComputeValue);
        /// <summary> Determines if two <see cref="EndpointComputeType"/> values are the same. </summary>
        public static bool operator ==(EndpointComputeType left, EndpointComputeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointComputeType"/> values are not the same. </summary>
        public static bool operator !=(EndpointComputeType left, EndpointComputeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointComputeType"/>. </summary>
        public static implicit operator EndpointComputeType(string value) => new EndpointComputeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointComputeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointComputeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
