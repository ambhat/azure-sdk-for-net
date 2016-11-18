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
    /// Properties of site details provided during the time of site creation
    /// </summary>
    public partial class FabricCreationInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the FabricCreationInputProperties
        /// class.
        /// </summary>
        public FabricCreationInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the FabricCreationInputProperties
        /// class.
        /// </summary>
        public FabricCreationInputProperties(FabricSpecificCreationInput customDetails = default(FabricSpecificCreationInput))
        {
            CustomDetails = customDetails;
        }

        /// <summary>
        /// Gets or sets fabric provider specific creation input.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public FabricSpecificCreationInput CustomDetails { get; set; }

    }
}
