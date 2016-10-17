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

    [JsonObject("Azure")]
    public partial class AzureFabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureFabricSpecificDetails class.
        /// </summary>
        public AzureFabricSpecificDetails() { }

        /// <summary>
        /// Initializes a new instance of the AzureFabricSpecificDetails class.
        /// </summary>
        public AzureFabricSpecificDetails(string location = default(string), IList<string> containerIds = default(IList<string>))
        {
            Location = location;
            ContainerIds = containerIds;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerIds")]
        public IList<string> ContainerIds { get; set; }

    }
}
