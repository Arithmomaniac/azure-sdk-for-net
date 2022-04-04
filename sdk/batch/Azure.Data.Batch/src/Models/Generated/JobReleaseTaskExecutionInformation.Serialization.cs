// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class JobReleaseTaskExecutionInformation
    {
        internal static JobReleaseTaskExecutionInformation DeserializeJobReleaseTaskExecutionInformation(JsonElement element)
        {
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset> endTime = default;
            JobReleaseTaskState state = default;
            Optional<string> taskRootDirectory = default;
            Optional<string> taskRootDirectoryUrl = default;
            Optional<int> exitCode = default;
            Optional<TaskContainerExecutionInformation> containerInfo = default;
            Optional<TaskFailureInformation> failureInfo = default;
            Optional<TaskExecutionResult> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString().ToJobReleaseTaskState();
                    continue;
                }
                if (property.NameEquals("taskRootDirectory"))
                {
                    taskRootDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskRootDirectoryUrl"))
                {
                    taskRootDirectoryUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exitCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exitCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerInfo = TaskContainerExecutionInformation.DeserializeTaskContainerExecutionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("failureInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failureInfo = TaskFailureInformation.DeserializeTaskFailureInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    result = property.Value.GetString().ToTaskExecutionResult();
                    continue;
                }
            }
            return new JobReleaseTaskExecutionInformation(startTime, Optional.ToNullable(endTime), state, taskRootDirectory.Value, taskRootDirectoryUrl.Value, Optional.ToNullable(exitCode), containerInfo.Value, failureInfo.Value, Optional.ToNullable(result));
        }
    }
}
