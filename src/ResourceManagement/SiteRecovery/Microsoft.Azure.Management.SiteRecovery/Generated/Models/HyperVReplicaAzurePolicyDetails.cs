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

    public partial class HyperVReplicaAzurePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyDetails
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyDetails() { }

        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyDetails
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyDetails(int? recoveryPointHistoryDurationInHours = default(int?), int? applicationConsistentSnapshotFrequencyInHours = default(int?), int? replicationInterval = default(int?), string onlineReplicationStartTime = default(string), string encryption = default(string), string activeStorageAccountId = default(string))
        {
            RecoveryPointHistoryDurationInHours = recoveryPointHistoryDurationInHours;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            ReplicationInterval = replicationInterval;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            Encryption = encryption;
            ActiveStorageAccountId = activeStorageAccountId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistoryDurationInHours")]
        public int? RecoveryPointHistoryDurationInHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationConsistentSnapshotFrequencyInHours")]
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicationInterval")]
        public int? ReplicationInterval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onlineReplicationStartTime")]
        public string OnlineReplicationStartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public string Encryption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeStorageAccountId")]
        public string ActiveStorageAccountId { get; set; }

    }
}
