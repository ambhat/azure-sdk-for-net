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
    /// Store the fabric details specific to the VMware fabric.
    /// </summary>
    public partial class VMwareDetails : FabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMwareDetails class.
        /// </summary>
        public VMwareDetails() { }

        /// <summary>
        /// Initializes a new instance of the VMwareDetails class.
        /// </summary>
        /// <param name="processServers">Gets or sets the list of Process
        /// Servers associated with the fabric.</param>
        /// <param name="masterTargetServers">Gets or sets the list of Master
        /// Target servers associated with
        /// the fabric.</param>
        /// <param name="runAsAccounts">Gets or sets the list of run as
        /// accounts created on the server.</param>
        /// <param name="replicationPairCount">Gets or sets the number of
        /// replication pairs configured in this CS.</param>
        /// <param name="processServerCount">Gets or sets the number of process
        /// servers.</param>
        /// <param name="agentCount">Gets or sets the number of source and
        /// target servers configured to talk to this CS.</param>
        /// <param name="protectedServers">Gets or sets the number of protected
        /// servers.</param>
        /// <param name="systemLoad">Gets or sets the percentage of the system
        /// load.</param>
        /// <param name="systemLoadStatus">Gets or sets the system load
        /// status.</param>
        /// <param name="cpuLoad">Gets or sets the percentage of the CPU
        /// load.</param>
        /// <param name="cpuLoadStatus">Gets or sets the CPU load
        /// status.</param>
        /// <param name="totalMemoryInBytes">Gets or sets the total
        /// memory.</param>
        /// <param name="availableMemoryInBytes">Gets or sets the available
        /// memory.</param>
        /// <param name="memoryUsageStatus">Gets or sets the memory usage
        /// status.</param>
        /// <param name="totalSpaceInBytes">Gets or sets the total
        /// space.</param>
        /// <param name="availableSpaceInBytes">Gets or sets the available
        /// space.</param>
        /// <param name="spaceUsageStatus">Gets or sets the space usage
        /// status.</param>
        /// <param name="webLoad">Gets or sets the web load.</param>
        /// <param name="webLoadStatus">Gets or sets the web load
        /// status.</param>
        /// <param name="databaseServerLoad">Gets or sets the database server
        /// load.</param>
        /// <param name="databaseServerLoadStatus">Gets or sets the database
        /// server load status.</param>
        /// <param name="csServiceStatus">Gets or sets the CS service
        /// status.</param>
        /// <param name="ipAddress">Gets or sets the IP address.</param>
        /// <param name="agentVersion">Gets or sets the agent Version.</param>
        /// <param name="hostName">Gets or sets the host name.</param>
        /// <param name="lastHeartbeat">Gets or sets the last heartbeat
        /// received from CS server.</param>
        /// <param name="versionStatus">Gets or sets version status</param>
        /// <param name="sslCertExpiryDate">Gets or sets CS SSL cert expiry
        /// date.</param>
        /// <param name="sslCertExpiryRemainingDays">Gets or sets CS SSL cert
        /// expiry date.</param>
        /// <param name="psTemplateVersion">Gets or sets PS template
        /// version.</param>
        public VMwareDetails(IList<ProcessServer> processServers = default(IList<ProcessServer>), IList<MasterTargetServer> masterTargetServers = default(IList<MasterTargetServer>), IList<RunAsAccount> runAsAccounts = default(IList<RunAsAccount>), string replicationPairCount = default(string), string processServerCount = default(string), string agentCount = default(string), string protectedServers = default(string), string systemLoad = default(string), string systemLoadStatus = default(string), string cpuLoad = default(string), string cpuLoadStatus = default(string), long? totalMemoryInBytes = default(long?), long? availableMemoryInBytes = default(long?), string memoryUsageStatus = default(string), long? totalSpaceInBytes = default(long?), long? availableSpaceInBytes = default(long?), string spaceUsageStatus = default(string), string webLoad = default(string), string webLoadStatus = default(string), string databaseServerLoad = default(string), string databaseServerLoadStatus = default(string), string csServiceStatus = default(string), string ipAddress = default(string), string agentVersion = default(string), string hostName = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string versionStatus = default(string), System.DateTime? sslCertExpiryDate = default(System.DateTime?), int? sslCertExpiryRemainingDays = default(int?), string psTemplateVersion = default(string))
        {
            ProcessServers = processServers;
            MasterTargetServers = masterTargetServers;
            RunAsAccounts = runAsAccounts;
            ReplicationPairCount = replicationPairCount;
            ProcessServerCount = processServerCount;
            AgentCount = agentCount;
            ProtectedServers = protectedServers;
            SystemLoad = systemLoad;
            SystemLoadStatus = systemLoadStatus;
            CpuLoad = cpuLoad;
            CpuLoadStatus = cpuLoadStatus;
            TotalMemoryInBytes = totalMemoryInBytes;
            AvailableMemoryInBytes = availableMemoryInBytes;
            MemoryUsageStatus = memoryUsageStatus;
            TotalSpaceInBytes = totalSpaceInBytes;
            AvailableSpaceInBytes = availableSpaceInBytes;
            SpaceUsageStatus = spaceUsageStatus;
            WebLoad = webLoad;
            WebLoadStatus = webLoadStatus;
            DatabaseServerLoad = databaseServerLoad;
            DatabaseServerLoadStatus = databaseServerLoadStatus;
            CsServiceStatus = csServiceStatus;
            IpAddress = ipAddress;
            AgentVersion = agentVersion;
            HostName = hostName;
            LastHeartbeat = lastHeartbeat;
            VersionStatus = versionStatus;
            SslCertExpiryDate = sslCertExpiryDate;
            SslCertExpiryRemainingDays = sslCertExpiryRemainingDays;
            PsTemplateVersion = psTemplateVersion;
        }

        /// <summary>
        /// Gets or sets the list of Process Servers associated with the
        /// fabric.
        /// </summary>
        [JsonProperty(PropertyName = "processServers")]
        public IList<ProcessServer> ProcessServers { get; set; }

        /// <summary>
        /// Gets or sets the list of Master Target servers associated with
        /// the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetServers")]
        public IList<MasterTargetServer> MasterTargetServers { get; set; }

        /// <summary>
        /// Gets or sets the list of run as accounts created on the server.
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccounts")]
        public IList<RunAsAccount> RunAsAccounts { get; set; }

        /// <summary>
        /// Gets or sets the number of replication pairs configured in this CS.
        /// </summary>
        [JsonProperty(PropertyName = "replicationPairCount")]
        public string ReplicationPairCount { get; set; }

        /// <summary>
        /// Gets or sets the number of process servers.
        /// </summary>
        [JsonProperty(PropertyName = "processServerCount")]
        public string ProcessServerCount { get; set; }

        /// <summary>
        /// Gets or sets the number of source and target servers configured to
        /// talk to this CS.
        /// </summary>
        [JsonProperty(PropertyName = "agentCount")]
        public string AgentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of protected servers.
        /// </summary>
        [JsonProperty(PropertyName = "protectedServers")]
        public string ProtectedServers { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the system load.
        /// </summary>
        [JsonProperty(PropertyName = "systemLoad")]
        public string SystemLoad { get; set; }

        /// <summary>
        /// Gets or sets the system load status.
        /// </summary>
        [JsonProperty(PropertyName = "systemLoadStatus")]
        public string SystemLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the CPU load.
        /// </summary>
        [JsonProperty(PropertyName = "cpuLoad")]
        public string CpuLoad { get; set; }

        /// <summary>
        /// Gets or sets the CPU load status.
        /// </summary>
        [JsonProperty(PropertyName = "cpuLoadStatus")]
        public string CpuLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the total memory.
        /// </summary>
        [JsonProperty(PropertyName = "totalMemoryInBytes")]
        public long? TotalMemoryInBytes { get; set; }

        /// <summary>
        /// Gets or sets the available memory.
        /// </summary>
        [JsonProperty(PropertyName = "availableMemoryInBytes")]
        public long? AvailableMemoryInBytes { get; set; }

        /// <summary>
        /// Gets or sets the memory usage status.
        /// </summary>
        [JsonProperty(PropertyName = "memoryUsageStatus")]
        public string MemoryUsageStatus { get; set; }

        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        [JsonProperty(PropertyName = "totalSpaceInBytes")]
        public long? TotalSpaceInBytes { get; set; }

        /// <summary>
        /// Gets or sets the available space.
        /// </summary>
        [JsonProperty(PropertyName = "availableSpaceInBytes")]
        public long? AvailableSpaceInBytes { get; set; }

        /// <summary>
        /// Gets or sets the space usage status.
        /// </summary>
        [JsonProperty(PropertyName = "spaceUsageStatus")]
        public string SpaceUsageStatus { get; set; }

        /// <summary>
        /// Gets or sets the web load.
        /// </summary>
        [JsonProperty(PropertyName = "webLoad")]
        public string WebLoad { get; set; }

        /// <summary>
        /// Gets or sets the web load status.
        /// </summary>
        [JsonProperty(PropertyName = "webLoadStatus")]
        public string WebLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the database server load.
        /// </summary>
        [JsonProperty(PropertyName = "databaseServerLoad")]
        public string DatabaseServerLoad { get; set; }

        /// <summary>
        /// Gets or sets the database server load status.
        /// </summary>
        [JsonProperty(PropertyName = "databaseServerLoadStatus")]
        public string DatabaseServerLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the CS service status.
        /// </summary>
        [JsonProperty(PropertyName = "csServiceStatus")]
        public string CsServiceStatus { get; set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the agent Version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the host name.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from CS server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets version status
        /// </summary>
        [JsonProperty(PropertyName = "versionStatus")]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Gets or sets CS SSL cert expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "sslCertExpiryDate")]
        public System.DateTime? SslCertExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets CS SSL cert expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "sslCertExpiryRemainingDays")]
        public int? SslCertExpiryRemainingDays { get; set; }

        /// <summary>
        /// Gets or sets PS template version.
        /// </summary>
        [JsonProperty(PropertyName = "psTemplateVersion")]
        public string PsTemplateVersion { get; set; }

    }
}
