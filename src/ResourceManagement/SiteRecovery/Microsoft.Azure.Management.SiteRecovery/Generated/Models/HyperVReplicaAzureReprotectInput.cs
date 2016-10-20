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
        public HyperVReplicaAzureReprotectInput(string hvHostVmId = default(string), string vmName = default(string), string osType = default(string), string vHDId = default(string), string storageAccountId = default(string))
        {
            HvHostVmId = hvHostVmId;
            VmName = vmName;
            OsType = osType;
            VHDId = vHDId;
            StorageAccountId = storageAccountId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hvHostVmId")]
        public string HvHostVmId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vmName")]
        public string VmName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vHDId")]
        public string VHDId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

    }
}
