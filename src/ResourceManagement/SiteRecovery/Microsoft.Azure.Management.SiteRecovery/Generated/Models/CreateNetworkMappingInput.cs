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
    /// Create network mappings input.
    /// </summary>
    public partial class CreateNetworkMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the CreateNetworkMappingInput class.
        /// </summary>
        public CreateNetworkMappingInput() { }

        /// <summary>
        /// Initializes a new instance of the CreateNetworkMappingInput class.
        /// </summary>
        public CreateNetworkMappingInput(string recoveryFabricName = default(string), string recoveryNetworkId = default(string))
        {
            RecoveryFabricName = recoveryFabricName;
            RecoveryNetworkId = recoveryNetworkId;
        }

        /// <summary>
        /// Gets or sets recovery server Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricName")]
        public string RecoveryFabricName { get; set; }

        /// <summary>
        /// Gets or sets recovery network Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkId")]
        public string RecoveryNetworkId { get; set; }

    }
}
