// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of an artifact parameter.
    /// </summary>
    public partial class ArtifactParameterProperties
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactParameterProperties
        /// class.
        /// </summary>
        public ArtifactParameterProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactParameterProperties
        /// class.
        /// </summary>
        /// <param name="name">The name of the artifact parameter.</param>
        /// <param name="value">The value of the artifact parameter.</param>
        public ArtifactParameterProperties(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the artifact parameter.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the artifact parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
