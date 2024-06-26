// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices
{
    internal class CognitiveServicesCommitmentPlanOperationSource : IOperationSource<CognitiveServicesCommitmentPlanResource>
    {
        private readonly ArmClient _client;

        internal CognitiveServicesCommitmentPlanOperationSource(ArmClient client)
        {
            _client = client;
        }

        CognitiveServicesCommitmentPlanResource IOperationSource<CognitiveServicesCommitmentPlanResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CommitmentPlanData.DeserializeCommitmentPlanData(document.RootElement);
            return new CognitiveServicesCommitmentPlanResource(_client, data);
        }

        async ValueTask<CognitiveServicesCommitmentPlanResource> IOperationSource<CognitiveServicesCommitmentPlanResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CommitmentPlanData.DeserializeCommitmentPlanData(document.RootElement);
            return new CognitiveServicesCommitmentPlanResource(_client, data);
        }
    }
}
