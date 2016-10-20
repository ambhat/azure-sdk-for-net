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

    public partial class LogicalNetwork
    {
        /// <summary>
        /// Initializes a new instance of the LogicalNetwork class.
        /// </summary>
        public LogicalNetwork() { }

        /// <summary>
        /// Initializes a new instance of the LogicalNetwork class.
        /// </summary>
        public LogicalNetwork(string type = default(string), string id = default(string), string name = default(string), LogicalNetworkProperties properties = default(LogicalNetworkProperties))
        {
            Type = type;
            Id = id;
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public LogicalNetworkProperties Properties { get; set; }

    }
}
