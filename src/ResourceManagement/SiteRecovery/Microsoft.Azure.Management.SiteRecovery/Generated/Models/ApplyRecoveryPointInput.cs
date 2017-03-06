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
    /// Input to apply recovery point.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplyRecoveryPointInput
    {
        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>
        public ApplyRecoveryPointInput() { }

        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>
        /// <param name="recoveryPointId">Gets or sets the recovery point
        /// Id.</param>
        /// <param name="providerSpecificDetails">Gets or sets Provider
        /// specific input for applying recovery point.</param>
        public ApplyRecoveryPointInput(string recoveryPointId = default(string), ApplyRecoveryPointProviderSpecificInput providerSpecificDetails = default(ApplyRecoveryPointProviderSpecificInput))
        {
            RecoveryPointId = recoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Gets or sets the recovery point Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets Provider specific input for applying recovery point.
        /// </summary>
        [JsonProperty(PropertyName = "properties.providerSpecificDetails")]
        public ApplyRecoveryPointProviderSpecificInput ProviderSpecificDetails { get; set; }

    }
}
