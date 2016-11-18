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
    /// Request to failover a process server.
    /// </summary>
    public partial class FailoverProcessServerRequest
    {
        /// <summary>
        /// Initializes a new instance of the FailoverProcessServerRequest
        /// class.
        /// </summary>
        public FailoverProcessServerRequest() { }

        /// <summary>
        /// Initializes a new instance of the FailoverProcessServerRequest
        /// class.
        /// </summary>
        public FailoverProcessServerRequest(FailoverProcessServerRequestProperties properties = default(FailoverProcessServerRequestProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the properties of the PS Failover request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public FailoverProcessServerRequestProperties Properties { get; set; }

    }
}
