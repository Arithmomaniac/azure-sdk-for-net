// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Labeling MLAssist configuration definition. </summary>
    public partial class MLAssistConfiguration
    {
        /// <summary> Initializes a new instance of MLAssistConfiguration. </summary>
        public MLAssistConfiguration()
        {
        }

        /// <summary> Initializes a new instance of MLAssistConfiguration. </summary>
        /// <param name="inferencingComputeBinding"> AML compute binding used in inferencing. </param>
        /// <param name="mlAssistEnabled"> Indicates whether MLAssist feature is enabled. </param>
        /// <param name="trainingComputeBinding"> AML compute binding used in training. </param>
        internal MLAssistConfiguration(ComputeConfiguration inferencingComputeBinding, bool? mlAssistEnabled, ComputeConfiguration trainingComputeBinding)
        {
            InferencingComputeBinding = inferencingComputeBinding;
            MlAssistEnabled = mlAssistEnabled;
            TrainingComputeBinding = trainingComputeBinding;
        }

        /// <summary> AML compute binding used in inferencing. </summary>
        public ComputeConfiguration InferencingComputeBinding { get; set; }
        /// <summary> Indicates whether MLAssist feature is enabled. </summary>
        public bool? MlAssistEnabled { get; set; }
        /// <summary> AML compute binding used in training. </summary>
        public ComputeConfiguration TrainingComputeBinding { get; set; }
    }
}
