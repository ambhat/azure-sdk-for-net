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
    /// Request to configure alerts for the system.
    /// </summary>
    public partial class ConfigureAlertRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequest class.
        /// </summary>
        public ConfigureAlertRequest() { }

        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequest class.
        /// </summary>
        public ConfigureAlertRequest(ConfigureAlertRequestProperties properties = default(ConfigureAlertRequestProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the properties of a configure alert request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ConfigureAlertRequestProperties Properties { get; set; }

    }
}
