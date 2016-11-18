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
    /// InMage specific protection profile details.
    /// </summary>
    public partial class InMagePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMagePolicyDetails class.
        /// </summary>
        public InMagePolicyDetails() { }

        /// <summary>
        /// Initializes a new instance of the InMagePolicyDetails class.
        /// </summary>
        public InMagePolicyDetails(int? recoveryPointThresholdInMinutes = default(int?), int? recoveryPointHistory = default(int?), int? appConsistentFrequencyInMinutes = default(int?), string multiVmSyncStatus = default(string))
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            MultiVmSyncStatus = multiVmSyncStatus;
        }

        /// <summary>
        /// Gets or sets the recovery point threshold in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointThresholdInMinutes")]
        public int? RecoveryPointThresholdInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes until which the recovery
        /// points need to be
        /// stored.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistory")]
        public int? RecoveryPointHistory { get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi-VM sync has to be
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVmSyncStatus { get; set; }

    }
}
