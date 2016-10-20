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

    public partial class ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionContainer class.
        /// </summary>
        public ProtectionContainer() { }

        /// <summary>
        /// Initializes a new instance of the ProtectionContainer class.
        /// </summary>
        public ProtectionContainer(string id = default(string), string name = default(string), string type = default(string), ProtectionContainerProperties properties = default(ProtectionContainerProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
        }

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
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ProtectionContainerProperties Properties { get; set; }

    }
}
