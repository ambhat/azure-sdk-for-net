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
    /// Network model.
    /// </summary>
    public partial class Network : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Network class.
        /// </summary>
        public Network() { }

        /// <summary>
        /// Initializes a new instance of the Network class.
        /// </summary>
        public Network(string id = default(string), string name = default(string), string type = default(string), string location = default(string), NetworkProperties properties = default(NetworkProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the Network Properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public NetworkProperties Properties { get; set; }

    }
}
