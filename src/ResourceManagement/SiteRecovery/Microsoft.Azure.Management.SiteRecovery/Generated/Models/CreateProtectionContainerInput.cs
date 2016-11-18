// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Create protection container input.
    /// </summary>
    public partial class CreateProtectionContainerInput
    {
        /// <summary>
        /// Initializes a new instance of the CreateProtectionContainerInput
        /// class.
        /// </summary>
        public CreateProtectionContainerInput() { }

        /// <summary>
        /// Initializes a new instance of the CreateProtectionContainerInput
        /// class.
        /// </summary>
        public CreateProtectionContainerInput(CreateProtectionContainerInputProperties properties = default(CreateProtectionContainerInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets create protection container input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreateProtectionContainerInputProperties Properties { get; set; }

    }
}
