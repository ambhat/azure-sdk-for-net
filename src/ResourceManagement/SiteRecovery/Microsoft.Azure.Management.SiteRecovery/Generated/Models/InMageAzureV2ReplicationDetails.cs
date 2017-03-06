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
    /// InMageAzureV2 provider specific settings
    /// </summary>
    public partial class InMageAzureV2ReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ReplicationDetails
        /// class.
        /// </summary>
        public InMageAzureV2ReplicationDetails() { }

        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ReplicationDetails
        /// class.
        /// </summary>
        /// <param name="infrastructureVmId">Gets or sets the infrastructure VM
        /// Id.</param>
        /// <param name="vCenterInfrastructureId">Gets or sets the vCenter
        /// infrastructure Id.</param>
        /// <param name="protectionStage">Gets or sets the protection
        /// stage.</param>
        /// <param name="vmId">Gets or sets the virtual machine Id.</param>
        /// <param name="vmProtectionState">Gets or sets the protection state
        /// for the vm.</param>
        /// <param name="vmProtectionStateDescription">Gets or sets the
        /// protection state description for the vm.</param>
        /// <param name="resyncProgressPercentage">Gets or sets the resync
        /// progress percentage.</param>
        /// <param name="rpoInSeconds">Gets or sets the RPO in seconds.</param>
        /// <param name="compressedDataRateInMB">Gets or sets the compressed
        /// data change rate in MB.</param>
        /// <param name="uncompressedDataRateInMB">Gets or sets the
        /// uncompressed data change rate in MB.</param>
        /// <param name="ipAddress">Gets or sets the source IP address.</param>
        /// <param name="agentVersion">Gets or sets the agent version.</param>
        /// <param name="isAgentUpdateRequired">Gets or sets a value indicating
        /// whether installed agent needs to be updated.</param>
        /// <param name="isRebootAfterUpdateRequired">Gets or sets a value
        /// indicating whether the source server requires a restart after
        /// update.</param>
        /// <param name="lastHeartbeat">Gets or sets the last heartbeat
        /// received from the source server.</param>
        /// <param name="processServerId">Gets or sets the process server
        /// Id.</param>
        /// <param name="multiVmGroupId">Gets or sets the multi vm group
        /// Id.</param>
        /// <param name="multiVmGroupName">Gets or sets the multi vm group
        /// name.</param>
        /// <param name="protectedDisks">Gets or sets the list of protected
        /// disks.</param>
        /// <param name="diskResized">Gets or sets a value indicating whether
        /// any disk is resized for this VM.</param>
        /// <param name="masterTargetId">Gets or sets the master target
        /// Id.</param>
        /// <param name="sourceVmCPUCount">Gets or sets the CPU count of the VM
        /// on the primary side.</param>
        /// <param name="sourceVmRAMSizeInMB">Gets or sets the RAM size of the
        /// VM on the primary side.</param>
        /// <param name="osType">Gets or sets the type of the OS on the
        /// VM.</param>
        /// <param name="vhdName">Gets or sets the OS disk VHD name.</param>
        /// <param name="osDiskId">Gets or sets the id of the disk containing
        /// the OS.</param>
        /// <param name="azureVMDiskDetails">Gets or sets Azure VM Disk
        /// details.</param>
        /// <param name="recoveryAzureVMName">Gets or sets Recovery Azure given
        /// name.</param>
        /// <param name="recoveryAzureVMSize">Gets or sets the Recovery Azure
        /// VM size.</param>
        /// <param name="recoveryAzureStorageAccount">Gets or sets the recovery
        /// Azure storage account.</param>
        /// <param name="recoveryAzureLogStorageAccountId">Gets or sets the ARM
        /// id of the log storage acount used for replication.
        /// This will be set to null if no log storage account was provided
        /// during enable
        /// protection.</param>
        /// <param name="vmNics">Gets or sets the PE Network details.</param>
        /// <param name="selectedRecoveryAzureNetworkId">Gets or sets the
        /// selected recovery azure network Id.</param>
        /// <param name="discoveryType">Gets or sets a value inidicating the
        /// discovery type of the machine.
        /// Value can be vCenter or physical.</param>
        /// <param name="enableRDPOnTargetOption">Gets or sets the selected
        /// option to enable RDP\SSH on target vm after failover.
        /// String value of {SrsDataContract.EnableRDPOnTargetOption}
        /// enum.</param>
        /// <param name="datastores">Gets or sets the datastores of the
        /// on-premise machine.
        /// Value can be list of strings that contain datastore names.</param>
        /// <param name="targetVmId">Gets or sets the ARM Id of the target
        /// Azure VM.
        /// This value will be null until the VM is failed over.
        /// Only after failure it will be populated with the ARM Id of the
        /// Azure VM.</param>
        public InMageAzureV2ReplicationDetails(string infrastructureVmId = default(string), string vCenterInfrastructureId = default(string), string protectionStage = default(string), string vmId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), int? resyncProgressPercentage = default(int?), long? rpoInSeconds = default(long?), double? compressedDataRateInMB = default(double?), double? uncompressedDataRateInMB = default(double?), string ipAddress = default(string), string agentVersion = default(string), string isAgentUpdateRequired = default(string), string isRebootAfterUpdateRequired = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string processServerId = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), IList<InMageAzureV2ProtectedDiskDetails> protectedDisks = default(IList<InMageAzureV2ProtectedDiskDetails>), string diskResized = default(string), string masterTargetId = default(string), int? sourceVmCPUCount = default(int?), int? sourceVmRAMSizeInMB = default(int?), string osType = default(string), string vhdName = default(string), string osDiskId = default(string), IList<AzureVmDiskDetails> azureVMDiskDetails = default(IList<AzureVmDiskDetails>), string recoveryAzureVMName = default(string), string recoveryAzureVMSize = default(string), string recoveryAzureStorageAccount = default(string), string recoveryAzureLogStorageAccountId = default(string), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), string selectedRecoveryAzureNetworkId = default(string), string discoveryType = default(string), string enableRDPOnTargetOption = default(string), IList<string> datastores = default(IList<string>), string targetVmId = default(string))
        {
            InfrastructureVmId = infrastructureVmId;
            VCenterInfrastructureId = vCenterInfrastructureId;
            ProtectionStage = protectionStage;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            ResyncProgressPercentage = resyncProgressPercentage;
            RpoInSeconds = rpoInSeconds;
            CompressedDataRateInMB = compressedDataRateInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            IpAddress = ipAddress;
            AgentVersion = agentVersion;
            IsAgentUpdateRequired = isAgentUpdateRequired;
            IsRebootAfterUpdateRequired = isRebootAfterUpdateRequired;
            LastHeartbeat = lastHeartbeat;
            ProcessServerId = processServerId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            ProtectedDisks = protectedDisks;
            DiskResized = diskResized;
            MasterTargetId = masterTargetId;
            SourceVmCPUCount = sourceVmCPUCount;
            SourceVmRAMSizeInMB = sourceVmRAMSizeInMB;
            OsType = osType;
            VhdName = vhdName;
            OsDiskId = osDiskId;
            AzureVMDiskDetails = azureVMDiskDetails;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            VmNics = vmNics;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            DiscoveryType = discoveryType;
            EnableRDPOnTargetOption = enableRDPOnTargetOption;
            Datastores = datastores;
            TargetVmId = targetVmId;
        }

        /// <summary>
        /// Gets or sets the infrastructure VM Id.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureVmId")]
        public string InfrastructureVmId { get; set; }

        /// <summary>
        /// Gets or sets the vCenter infrastructure Id.
        /// </summary>
        [JsonProperty(PropertyName = "vCenterInfrastructureId")]
        public string VCenterInfrastructureId { get; set; }

        /// <summary>
        /// Gets or sets the protection stage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStage")]
        public string ProtectionStage { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets or sets the protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the RPO in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the compressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "compressedDataRateInMB")]
        public double? CompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the uncompressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "uncompressedDataRateInMB")]
        public double? UncompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the source IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "isAgentUpdateRequired")]
        public string IsAgentUpdateRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source server requires
        /// a restart after
        /// update.
        /// </summary>
        [JsonProperty(PropertyName = "isRebootAfterUpdateRequired")]
        public string IsRebootAfterUpdateRequired { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the source server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets the process server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group Id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<InMageAzureV2ProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether any disk is resized for
        /// this VM.
        /// </summary>
        [JsonProperty(PropertyName = "diskResized")]
        public string DiskResized { get; set; }

        /// <summary>
        /// Gets or sets the master target Id.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmCPUCount")]
        public int? SourceVmCPUCount { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmRAMSizeInMB")]
        public int? SourceVmRAMSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the OS disk VHD name.
        /// </summary>
        [JsonProperty(PropertyName = "vhdName")]
        public string VhdName { get; set; }

        /// <summary>
        /// Gets or sets the id of the disk containing the OS.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskId")]
        public string OsDiskId { get; set; }

        /// <summary>
        /// Gets or sets Azure VM Disk details.
        /// </summary>
        [JsonProperty(PropertyName = "azureVMDiskDetails")]
        public IList<AzureVmDiskDetails> AzureVMDiskDetails { get; set; }

        /// <summary>
        /// Gets or sets Recovery Azure given name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMName")]
        public string RecoveryAzureVMName { get; set; }

        /// <summary>
        /// Gets or sets the Recovery Azure VM size.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccount")]
        public string RecoveryAzureStorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the ARM id of the log storage acount used for
        /// replication.
        /// This will be set to null if no log storage account was provided
        /// during enable
        /// protection.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureLogStorageAccountId")]
        public string RecoveryAzureLogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the PE Network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the selected recovery azure network Id.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets a value inidicating the discovery type of the machine.
        /// Value can be vCenter or physical.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; set; }

        /// <summary>
        /// Gets or sets the selected option to enable RDP\SSH on target vm
        /// after failover.
        /// String value of {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRDPOnTargetOption")]
        public string EnableRDPOnTargetOption { get; set; }

        /// <summary>
        /// Gets or sets the datastores of the on-premise machine.
        /// Value can be list of strings that contain datastore names.
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public IList<string> Datastores { get; set; }

        /// <summary>
        /// Gets or sets the ARM Id of the target Azure VM.
        /// This value will be null until the VM is failed over.
        /// Only after failure it will be populated with the ARM Id of the
        /// Azure VM.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmId")]
        public string TargetVmId { get; set; }

    }
}
