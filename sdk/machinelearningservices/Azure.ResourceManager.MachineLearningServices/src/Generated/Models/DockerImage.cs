// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Class to represent configuration settings for Docker Build. </summary>
    public partial class DockerImage : DockerSpecification
    {
        /// <summary> Initializes a new instance of DockerImage. </summary>
        /// <param name="dockerImageUri">
        /// Image name of a custom base image.
        /// 
        /// &lt;seealso href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-custom-docker-image#use-a-custom-base-image&quot; /&gt;.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dockerImageUri"/> is null. </exception>
        public DockerImage(string dockerImageUri)
        {
            if (dockerImageUri == null)
            {
                throw new ArgumentNullException(nameof(dockerImageUri));
            }

            DockerImageUri = dockerImageUri;
            DockerSpecificationType = DockerSpecificationType.Image;
        }

        /// <summary> Initializes a new instance of DockerImage. </summary>
        /// <param name="dockerSpecificationType"> Docker specification must be either Build or Image. </param>
        /// <param name="platform"> The platform information of the docker image. </param>
        /// <param name="dockerImageUri">
        /// Image name of a custom base image.
        /// 
        /// &lt;seealso href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-custom-docker-image#use-a-custom-base-image&quot; /&gt;.
        /// </param>
        internal DockerImage(DockerSpecificationType dockerSpecificationType, DockerImagePlatform platform, string dockerImageUri) : base(dockerSpecificationType, platform)
        {
            DockerImageUri = dockerImageUri;
            DockerSpecificationType = dockerSpecificationType;
        }

        /// <summary>
        /// Image name of a custom base image.
        /// 
        /// &lt;seealso href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-custom-docker-image#use-a-custom-base-image&quot; /&gt;.
        /// </summary>
        public string DockerImageUri { get; set; }
    }
}
