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
    /// Model class for event details of a A2A event.
    /// </summary>
    public partial class A2AEventDetails : EventProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AEventDetails class.
        /// </summary>
        public A2AEventDetails() { }

        /// <summary>
        /// Initializes a new instance of the A2AEventDetails class.
        /// </summary>
        public A2AEventDetails(string protectedItemName = default(string), string fabricObjectId = default(string), string fabricName = default(string), string fabricLocation = default(string), string remoteFabricName = default(string), string remoteFabricLocation = default(string))
        {
            ProtectedItemName = protectedItemName;
            FabricObjectId = fabricObjectId;
            FabricName = fabricName;
            FabricLocation = fabricLocation;
            RemoteFabricName = remoteFabricName;
            RemoteFabricLocation = remoteFabricLocation;
        }

        /// <summary>
        /// Gets or sets the protected item arm name.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemName")]
        public string ProtectedItemName { get; set; }

        /// <summary>
        /// Gets or sets the azure vm arm id.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; set; }

        /// <summary>
        /// Gets or sets fabric arm name.
        /// </summary>
        [JsonProperty(PropertyName = "fabricName")]
        public string FabricName { get; set; }

        /// <summary>
        /// Gets or sets the fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "fabricLocation")]
        public string FabricLocation { get; set; }

        /// <summary>
        /// Gets or sets remote fabric arm name.
        /// </summary>
        [JsonProperty(PropertyName = "remoteFabricName")]
        public string RemoteFabricName { get; set; }

        /// <summary>
        /// Gets or sets remote fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "remoteFabricLocation")]
        public string RemoteFabricLocation { get; set; }

    }
}
