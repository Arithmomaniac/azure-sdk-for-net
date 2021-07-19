// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Creates or updates compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. If your intent is to create a new compute, do a GET first to verify that it does not exist yet. </summary>
    public partial class ComputeCreateOrUpdateOperation : Operation<ComputeResource>, IOperationSource<ComputeResource>
    {
        private readonly OperationInternals<ComputeResource> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of ComputeCreateOrUpdateOperation for mocking. </summary>
        protected ComputeCreateOrUpdateOperation()
        {
        }

        internal ComputeCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ComputeResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ComputeCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ComputeResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ComputeResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ComputeResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ComputeResource IOperationSource<ComputeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ComputeResource(_operationBase, ComputeResourceData.DeserializeComputeResourceData(document.RootElement));
        }

        async ValueTask<ComputeResource> IOperationSource<ComputeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ComputeResource(_operationBase, ComputeResourceData.DeserializeComputeResourceData(document.RootElement));
        }
    }
}
