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
    /// Replication protected item.
    /// </summary>
    public partial class ReplicationProtectedItem : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationProtectedItem class.
        /// </summary>
        public ReplicationProtectedItem() { }

        /// <summary>
        /// Initializes a new instance of the ReplicationProtectedItem class.
        /// </summary>
        public ReplicationProtectedItem(string id = default(string), string name = default(string), string type = default(string), string location = default(string), ReplicationProtectedItemProperties properties = default(ReplicationProtectedItemProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the custom data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ReplicationProtectedItemProperties Properties { get; set; }

    }
}
