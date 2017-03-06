// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of a Master Target Server.
    /// </summary>
    public partial class MasterTargetServer
    {
        /// <summary>
        /// Initializes a new instance of the MasterTargetServer class.
        /// </summary>
        public MasterTargetServer() { }

        /// <summary>
        /// Initializes a new instance of the MasterTargetServer class.
        /// </summary>
        /// <param name="id">Gets or sets the server Id.</param>
        /// <param name="ipAddress">Gets or sets the IP address of the
        /// server.</param>
        /// <param name="name">Gets or sets the server name.</param>
        /// <param name="osType">Gets or sets the OS type of the
        /// server.</param>
        /// <param name="agentVersion">Gets or sets the version of the scout
        /// component on the server.</param>
        /// <param name="lastHeartbeat">Gets or sets the last heartbeat
        /// received from the server.</param>
        /// <param name="versionStatus">Gets or sets version status</param>
        /// <param name="retentionVolumes">Gets or sets the retention volumes
        /// of Master target Server.</param>
        /// <param name="dataStores">Gets or sets the list of data stores in
        /// the fabric.</param>
        public MasterTargetServer(string id = default(string), string ipAddress = default(string), string name = default(string), string osType = default(string), string agentVersion = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string versionStatus = default(string), IList<RetentionVolume> retentionVolumes = default(IList<RetentionVolume>), IList<DataStore> dataStores = default(IList<DataStore>))
        {
            Id = id;
            IpAddress = ipAddress;
            Name = name;
            OsType = osType;
            AgentVersion = agentVersion;
            LastHeartbeat = lastHeartbeat;
            VersionStatus = versionStatus;
            RetentionVolumes = retentionVolumes;
            DataStores = dataStores;
        }

        /// <summary>
        /// Gets or sets the server Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the server.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the server name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the OS type of the server.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the version of the scout component on the server.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets version status
        /// </summary>
        [JsonProperty(PropertyName = "versionStatus")]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Gets or sets the retention volumes of Master target Server.
        /// </summary>
        [JsonProperty(PropertyName = "retentionVolumes")]
        public IList<RetentionVolume> RetentionVolumes { get; set; }

        /// <summary>
        /// Gets or sets the list of data stores in the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "dataStores")]
        public IList<DataStore> DataStores { get; set; }

    }
}
