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

    public partial class HyperVReplicaPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaPolicyDetails class.
        /// </summary>
        public HyperVReplicaPolicyDetails() { }

        /// <summary>
        /// Initializes a new instance of the HyperVReplicaPolicyDetails class.
        /// </summary>
        public HyperVReplicaPolicyDetails(int? recoveryPoints = default(int?), int? applicationConsistentSnapshotFrequencyInHours = default(int?), string compression = default(string), string initialReplicationMethod = default(string), string onlineReplicationStartTime = default(string), string offlineReplicationImportPath = default(string), string offlineReplicationExportPath = default(string), int? replicationPort = default(int?), int? allowedAuthenticationType = default(int?), string replicaDeletionOption = default(string))
        {
            RecoveryPoints = recoveryPoints;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            Compression = compression;
            InitialReplicationMethod = initialReplicationMethod;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            OfflineReplicationImportPath = offlineReplicationImportPath;
            OfflineReplicationExportPath = offlineReplicationExportPath;
            ReplicationPort = replicationPort;
            AllowedAuthenticationType = allowedAuthenticationType;
            ReplicaDeletionOption = replicaDeletionOption;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPoints")]
        public int? RecoveryPoints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationConsistentSnapshotFrequencyInHours")]
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compression")]
        public string Compression { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationMethod")]
        public string InitialReplicationMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onlineReplicationStartTime")]
        public string OnlineReplicationStartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offlineReplicationImportPath")]
        public string OfflineReplicationImportPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offlineReplicationExportPath")]
        public string OfflineReplicationExportPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicationPort")]
        public int? ReplicationPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedAuthenticationType")]
        public int? AllowedAuthenticationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicaDeletionOption")]
        public string ReplicaDeletionOption { get; set; }

    }
}
