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
    /// Recovery plan details.
    /// </summary>
    public partial class RecoveryPlan : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlan class.
        /// </summary>
        public RecoveryPlan() { }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlan class.
        /// </summary>
        public RecoveryPlan(string id = default(string), string name = default(string), string type = default(string), string location = default(string), RecoveryPlanProperties properties = default(RecoveryPlanProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the custom details.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RecoveryPlanProperties Properties { get; set; }

    }
}
