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

    public partial class A2AProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AProtectedDiskDetails class.
        /// </summary>
        public A2AProtectedDiskDetails() { }

        /// <summary>
        /// Initializes a new instance of the A2AProtectedDiskDetails class.
        /// </summary>
        public A2AProtectedDiskDetails(string diskUri = default(string), string recoveryAzureStorageAccountId = default(string), string primaryStagingAzureStorageAccountId = default(string), string primaryDiskAzureStorageAccountId = default(string), string recoveryDiskUri = default(string))
        {
            DiskUri = diskUri;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            PrimaryDiskAzureStorageAccountId = primaryDiskAzureStorageAccountId;
            RecoveryDiskUri = recoveryDiskUri;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccountId")]
        public string RecoveryAzureStorageAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryDiskAzureStorageAccountId")]
        public string PrimaryDiskAzureStorageAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryDiskUri")]
        public string RecoveryDiskUri { get; set; }

    }
}
