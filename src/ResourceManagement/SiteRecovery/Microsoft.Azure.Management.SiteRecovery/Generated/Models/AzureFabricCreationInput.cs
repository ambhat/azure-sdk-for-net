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
    public partial class AzureFabricCreationInput : FabricSpecificCreationInput
    {
        /// <summary>
        /// Initializes a new instance of the AzureFabricCreationInput class.
        /// </summary>
        public AzureFabricCreationInput() { }

        /// <summary>
        /// Initializes a new instance of the AzureFabricCreationInput class.
        /// </summary>
        public AzureFabricCreationInput(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
