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

    public partial class InMageAzureV2EnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2EnableProtectionInput class.
        /// </summary>
        public InMageAzureV2EnableProtectionInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2EnableProtectionInput class.
        /// </summary>
        public InMageAzureV2EnableProtectionInput(string masterTargetId = default(string), string processServerId = default(string), string storageAccountId = default(string), string runAsAccountId = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), IList<string> disksToInclude = default(IList<string>), string targetAzureNetworkId = default(string), string targetAzureSubnetId = default(string), string enableRDPOnTargetOption = default(string), string targetAzureVmName = default(string), string logStorageAccountId = default(string))
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            StorageAccountId = storageAccountId;
            RunAsAccountId = runAsAccountId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            DisksToInclude = disksToInclude;
            TargetAzureNetworkId = targetAzureNetworkId;
            TargetAzureSubnetId = targetAzureSubnetId;
            EnableRDPOnTargetOption = enableRDPOnTargetOption;
            TargetAzureVmName = targetAzureVmName;
            LogStorageAccountId = logStorageAccountId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccountId")]
        public string RunAsAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<string> DisksToInclude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureNetworkId")]
        public string TargetAzureNetworkId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureSubnetId")]
        public string TargetAzureSubnetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enableRDPOnTargetOption")]
        public string EnableRDPOnTargetOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetAzureVmName")]
        public string TargetAzureVmName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logStorageAccountId")]
        public string LogStorageAccountId { get; set; }

    }
}
