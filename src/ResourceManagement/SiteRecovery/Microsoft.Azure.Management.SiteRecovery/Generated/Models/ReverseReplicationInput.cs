// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.SiteRecovery;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reverse replication input.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ReverseReplicationInput
    {
        /// <summary>
        /// Initializes a new instance of the ReverseReplicationInput class.
        /// </summary>
        public ReverseReplicationInput() { }

        /// <summary>
        /// Initializes a new instance of the ReverseReplicationInput class.
        /// </summary>
        /// <param name="failoverDirection">Gets or sets Failover
        /// direction.</param>
        /// <param name="providerSpecificDetails">Gets or sets Provider
        /// specific reverse replication input.</param>
        public ReverseReplicationInput(string failoverDirection = default(string), ReverseReplicationProviderSpecificInput providerSpecificDetails = default(ReverseReplicationProviderSpecificInput))
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Gets or sets Failover direction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Gets or sets Provider specific reverse replication input.
        /// </summary>
        [JsonProperty(PropertyName = "properties.providerSpecificDetails")]
        public ReverseReplicationProviderSpecificInput ProviderSpecificDetails { get; set; }

    }
}
