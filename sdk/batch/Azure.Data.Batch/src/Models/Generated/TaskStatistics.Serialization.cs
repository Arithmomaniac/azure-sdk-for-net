// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class TaskStatistics
    {
        internal static TaskStatistics DeserializeTaskStatistics(JsonElement element)
        {
            string url = default;
            DateTimeOffset startTime = default;
            DateTimeOffset lastUpdateTime = default;
            TimeSpan userCPUTime = default;
            TimeSpan kernelCPUTime = default;
            TimeSpan wallClockTime = default;
            long readIOps = default;
            long writeIOps = default;
            double readIOGiB = default;
            double writeIOGiB = default;
            TimeSpan waitTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userCPUTime"))
                {
                    userCPUTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("kernelCPUTime"))
                {
                    kernelCPUTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("wallClockTime"))
                {
                    wallClockTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("readIOps"))
                {
                    readIOps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("writeIOps"))
                {
                    writeIOps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("readIOGiB"))
                {
                    readIOGiB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("writeIOGiB"))
                {
                    writeIOGiB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("waitTime"))
                {
                    waitTime = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new TaskStatistics(url, startTime, lastUpdateTime, userCPUTime, kernelCPUTime, wallClockTime, readIOps, writeIOps, readIOGiB, writeIOGiB, waitTime);
        }
    }
}
