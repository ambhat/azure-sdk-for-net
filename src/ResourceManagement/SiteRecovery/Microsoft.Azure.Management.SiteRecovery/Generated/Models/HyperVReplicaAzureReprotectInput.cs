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
    /// Azure specific reprotect input.
    /// </summary>
    public partial class HyperVReplicaAzureReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzureReprotectInput
        /// class.
        /// </summary>
        public HyperVReplicaAzureReprotectInput() { }

        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzureReprotectInput
        /// class.
        /// </summary>
        /// <param name="hvHostVmId">Gets or sets the Hyper-V host Vm
        /// Id.</param>
        /// <param name="vmName">Gets or sets the Vm Name.</param>
        /// <param name="osType">Gets or sets the OS type associated with
        /// vm.</param>
        /// <param name="vHDId">Gets or sets the OS disk VHD id associated with
        /// vm.</param>
        /// <param name="storageAccountId">Gets or sets the storage account
        /// name.</param>
        /// <param name="logStorageAccountId">Gets or sets the storage account
        /// to be used for logging during replication.</param>
        public HyperVReplicaAzureReprotectInput(string hvHostVmId = default(string), string vmName = default(string), string osType = default(string), string vHDId = default(string), string storageAccountId = default(string), string logStorageAccountId = default(string))
        {
            HvHostVmId = hvHostVmId;
            VmName = vmName;
            OsType = osType;
            VHDId = vHDId;
            StorageAccountId = storageAccountId;
            LogStorageAccountId = logStorageAccountId;
        }

        /// <summary>
        /// Gets or sets the Hyper-V host Vm Id.
        /// </summary>
        [JsonProperty(PropertyName = "hvHostVmId")]
        public string HvHostVmId { get; set; }

        /// <summary>
        /// Gets or sets the Vm Name.
        /// </summary>
        [JsonProperty(PropertyName = "vmName")]
        public string VmName { get; set; }

        /// <summary>
        /// Gets or sets the OS type associated with vm.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the OS disk VHD id associated with vm.
        /// </summary>
        [JsonProperty(PropertyName = "vHDId")]
        public string VHDId { get; set; }

        /// <summary>
        /// Gets or sets the storage account name.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the storage account to be used for logging during
        /// replication.
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

    }
}
