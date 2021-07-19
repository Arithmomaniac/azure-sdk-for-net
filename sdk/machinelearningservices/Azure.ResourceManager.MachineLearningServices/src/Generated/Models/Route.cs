// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The Route. </summary>
    public partial class Route
    {
        /// <summary> Initializes a new instance of Route. </summary>
        /// <param name="path"> The path for the route. </param>
        /// <param name="port"> The port for the route. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public Route(string path, int port)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            Path = path;
            Port = port;
        }

        /// <summary> The path for the route. </summary>
        public string Path { get; set; }
        /// <summary> The port for the route. </summary>
        public int Port { get; set; }
    }
}
