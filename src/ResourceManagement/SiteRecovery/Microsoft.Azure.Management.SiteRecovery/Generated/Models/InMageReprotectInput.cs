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

    public partial class InMageReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageReprotectInput class.
        /// </summary>
        public InMageReprotectInput() { }

        /// <summary>
        /// Initializes a new instance of the InMageReprotectInput class.
        /// </summary>
        public InMageReprotectInput(string masterTargetId = default(string), string processServerId = default(string), string retentionDrive = default(string), string runAsAccountId = default(string), string datastoreName = default(string), InMageDiskExclusionInput diskExclusionInput = default(InMageDiskExclusionInput), string profileId = default(string), IList<string> disksToInclude = default(IList<string>))
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            RunAsAccountId = runAsAccountId;
            DatastoreName = datastoreName;
            DiskExclusionInput = diskExclusionInput;
            ProfileId = profileId;
            DisksToInclude = disksToInclude;
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
        [JsonProperty(PropertyName = "retentionDrive")]
        public string RetentionDrive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccountId")]
        public string RunAsAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastoreName")]
        public string DatastoreName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "diskExclusionInput")]
        public InMageDiskExclusionInput DiskExclusionInput { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<string> DisksToInclude { get; set; }

    }
}
