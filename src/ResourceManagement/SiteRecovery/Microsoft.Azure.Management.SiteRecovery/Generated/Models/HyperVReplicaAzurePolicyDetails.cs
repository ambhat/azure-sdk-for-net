// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hyper-V Replica Azure specific protection profile details.
    /// </summary>
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
        /// <param name="recoveryPointHistoryDurationInHours">Gets or sets the
        /// duration (in hours) to which point the recovery history needs to be
        /// maintained.</param>
        /// <param name="applicationConsistentSnapshotFrequencyInHours">Gets or
        /// sets the interval (in hours) at which Hyper-V Replica should create
        /// an
        /// application consistent snapshot within the VM.</param>
        /// <param name="replicationInterval">Gets or sets the replication
        /// interval.</param>
        /// <param name="onlineReplicationStartTime">Gets or sets the scheduled
        /// start time for the initial replication. If this parameter
        /// is Null, the initial replication starts immediately.</param>
        /// <param name="encryption">Gets or sets a value indicating whether
        /// encryption is enabled for virtual machines
        /// in this cloud.</param>
        /// <param name="activeStorageAccountId">Gets or sets the active
        /// storage account Id.</param>
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
        /// Gets or sets the duration (in hours) to which point the recovery
        /// history needs to be
        /// maintained.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistoryDurationInHours")]
        public int? RecoveryPointHistoryDurationInHours { get; set; }

        /// <summary>
        /// Gets or sets the interval (in hours) at which Hyper-V Replica
        /// should create an
        /// application consistent snapshot within the VM.
        /// </summary>
        [JsonProperty(PropertyName = "applicationConsistentSnapshotFrequencyInHours")]
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// Gets or sets the replication interval.
        /// </summary>
        [JsonProperty(PropertyName = "replicationInterval")]
        public int? ReplicationInterval { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time for the initial replication.
        /// If this parameter
        /// is Null, the initial replication starts immediately.
        /// </summary>
        [JsonProperty(PropertyName = "onlineReplicationStartTime")]
        public string OnlineReplicationStartTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether encryption is enabled for
        /// virtual machines
        /// in this cloud.
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public string Encryption { get; set; }

        /// <summary>
        /// Gets or sets the active storage account Id.
        /// </summary>
        [JsonProperty(PropertyName = "activeStorageAccountId")]
        public string ActiveStorageAccountId { get; set; }

    }
}
