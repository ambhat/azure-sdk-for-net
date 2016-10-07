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

    public partial class PlannedFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        public PlannedFailoverInput() { }

        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        public PlannedFailoverInput(PlannedFailoverInputProperties properties = default(PlannedFailoverInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PlannedFailoverInputProperties Properties { get; set; }

    }
}
