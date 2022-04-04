// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Batch.Models
{
    /// <summary> The default value is requeue. </summary>
    public enum ComputeNodeReimageOption
    {
        /// <summary> Terminate running Task processes and requeue the Tasks. The Tasks will run again when a Compute Node is available. Reimage the Compute Node as soon as Tasks have been terminated. </summary>
        Requeue,
        /// <summary> Terminate running Tasks. The Tasks will be completed with failureInfo indicating that they were terminated, and will not run again. Reimage the Compute Node as soon as Tasks have been terminated. </summary>
        Terminate,
        /// <summary> Allow currently running Tasks to complete. Schedule no new Tasks while waiting. Reimage the Compute Node when all Tasks have completed. </summary>
        TaskCompletion,
        /// <summary> Allow currently running Tasks to complete, then wait for all Task data retention periods to expire. Schedule no new Tasks while waiting. Reimage the Compute Node when all Task retention periods have expired. </summary>
        RetainedData
    }
}
