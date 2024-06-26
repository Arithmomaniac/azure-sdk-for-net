// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlServerAdministratorOperationSource : IOperationSource<PostgreSqlServerAdministratorResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlServerAdministratorOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlServerAdministratorResource IOperationSource<PostgreSqlServerAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlServerAdministratorData.DeserializePostgreSqlServerAdministratorData(document.RootElement);
            return new PostgreSqlServerAdministratorResource(_client, data);
        }

        async ValueTask<PostgreSqlServerAdministratorResource> IOperationSource<PostgreSqlServerAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlServerAdministratorData.DeserializePostgreSqlServerAdministratorData(document.RootElement);
            return new PostgreSqlServerAdministratorResource(_client, data);
        }
    }
}
