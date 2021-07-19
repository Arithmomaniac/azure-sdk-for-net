// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The DeploymentProvisioningState. </summary>
    public readonly partial struct DeploymentProvisioningState : IEquatable<DeploymentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DeploymentProvisioningState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string ScalingValue = "Scaling";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static DeploymentProvisioningState Creating { get; } = new DeploymentProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static DeploymentProvisioningState Deleting { get; } = new DeploymentProvisioningState(DeletingValue);
        /// <summary> Scaling. </summary>
        public static DeploymentProvisioningState Scaling { get; } = new DeploymentProvisioningState(ScalingValue);
        /// <summary> Updating. </summary>
        public static DeploymentProvisioningState Updating { get; } = new DeploymentProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static DeploymentProvisioningState Succeeded { get; } = new DeploymentProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DeploymentProvisioningState Failed { get; } = new DeploymentProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DeploymentProvisioningState Canceled { get; } = new DeploymentProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="DeploymentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DeploymentProvisioningState left, DeploymentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DeploymentProvisioningState left, DeploymentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentProvisioningState"/>. </summary>
        public static implicit operator DeploymentProvisioningState(string value) => new DeploymentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
