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
    /// <summary> Creates or updates a labeling job (asynchronous). </summary>
    public partial class LabelingJobsCreateOrUpdateOperation : Operation<LabelingJobResource>, IOperationSource<LabelingJobResource>
    {
        private readonly OperationInternals<LabelingJobResource> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of LabelingJobsCreateOrUpdateOperation for mocking. </summary>
        protected LabelingJobsCreateOrUpdateOperation()
        {
        }

        internal LabelingJobsCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<LabelingJobResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "LabelingJobsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LabelingJobResource Value => _operation.Value;

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
        public override ValueTask<Response<LabelingJobResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LabelingJobResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LabelingJobResource IOperationSource<LabelingJobResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new LabelingJobResource(_operationBase, LabelingJobResourceData.DeserializeLabelingJobResourceData(document.RootElement));
        }

        async ValueTask<LabelingJobResource> IOperationSource<LabelingJobResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new LabelingJobResource(_operationBase, LabelingJobResourceData.DeserializeLabelingJobResourceData(document.RootElement));
        }
    }
}
