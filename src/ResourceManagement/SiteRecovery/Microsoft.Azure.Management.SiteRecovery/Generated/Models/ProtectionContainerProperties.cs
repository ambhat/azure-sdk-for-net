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
    /// Protection profile custom data details.
    /// </summary>
    public partial class ProtectionContainerProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionContainerProperties
        /// class.
        /// </summary>
        public ProtectionContainerProperties() { }

        /// <summary>
        /// Initializes a new instance of the ProtectionContainerProperties
        /// class.
        /// </summary>
        public ProtectionContainerProperties(string fabricFriendlyName = default(string), string friendlyName = default(string), string fabricType = default(string), int? protectedItemCount = default(int?), string pairingStatus = default(string), string role = default(string), ProtectionContainerFabricSpecificDetails fabricSpecificDetails = default(ProtectionContainerFabricSpecificDetails))
        {
            FabricFriendlyName = fabricFriendlyName;
            FriendlyName = friendlyName;
            FabricType = fabricType;
            ProtectedItemCount = protectedItemCount;
            PairingStatus = pairingStatus;
            Role = role;
            FabricSpecificDetails = fabricSpecificDetails;
        }

        /// <summary>
        /// Gets or sets Fabric friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "fabricFriendlyName")]
        public string FabricFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the fabric type.
        /// </summary>
        [JsonProperty(PropertyName = "fabricType")]
        public string FabricType { get; set; }

        /// <summary>
        /// Gets or sets Number of protected PEs
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemCount")]
        public int? ProtectedItemCount { get; set; }

        /// <summary>
        /// Gets or sets the pairing status of this cloud.
        /// </summary>
        [JsonProperty(PropertyName = "pairingStatus")]
        public string PairingStatus { get; set; }

        /// <summary>
        /// Gets or sets the role of this cloud.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets fabric specific details.
        /// </summary>
        [JsonProperty(PropertyName = "fabricSpecificDetails")]
        public ProtectionContainerFabricSpecificDetails FabricSpecificDetails { get; set; }

    }
}
