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
    /// A2A Policy creation input.
    /// </summary>
    public partial class A2APolicyCreationInput : PolicyProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the A2APolicyCreationInput class.
        /// </summary>
        public A2APolicyCreationInput() { }

        /// <summary>
        /// Initializes a new instance of the A2APolicyCreationInput class.
        /// </summary>
        public A2APolicyCreationInput(SetMultiVmSyncStatus multiVmSyncStatus, int? recoveryPointThresholdInMinutes = default(int?), int? recoveryPointHistory = default(int?), int? crashConsistentFrequencyInMinutes = default(int?), int? appConsistentFrequencyInMinutes = default(int?))
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
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
        /// Gets or sets the crash consistent snapshot frequency (in minutes).
        /// </summary>
        [JsonProperty(PropertyName = "crashConsistentFrequencyInMinutes")]
        public int? CrashConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency (in minutes).
        /// </summary>
        [JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi-VM sync has to be
        /// enabled.
        /// Value should be 'Enabled' or 'Disabled'. Possible
        /// values include: 'Enable', 'Disable'
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public SetMultiVmSyncStatus MultiVmSyncStatus { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
