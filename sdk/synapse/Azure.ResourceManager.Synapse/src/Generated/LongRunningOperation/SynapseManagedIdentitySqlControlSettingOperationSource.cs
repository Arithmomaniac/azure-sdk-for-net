// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseManagedIdentitySqlControlSettingOperationSource : IOperationSource<SynapseManagedIdentitySqlControlSettingResource>
    {
        private readonly ArmClient _client;

        internal SynapseManagedIdentitySqlControlSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseManagedIdentitySqlControlSettingResource IOperationSource<SynapseManagedIdentitySqlControlSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseManagedIdentitySqlControlSettingData.DeserializeSynapseManagedIdentitySqlControlSettingData(document.RootElement);
            return new SynapseManagedIdentitySqlControlSettingResource(_client, data);
        }

        async ValueTask<SynapseManagedIdentitySqlControlSettingResource> IOperationSource<SynapseManagedIdentitySqlControlSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseManagedIdentitySqlControlSettingData.DeserializeSynapseManagedIdentitySqlControlSettingData(document.RootElement);
            return new SynapseManagedIdentitySqlControlSettingResource(_client, data);
        }
    }
}
