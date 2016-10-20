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

    public partial class JobEntity
    {
        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        public JobEntity() { }

        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        public JobEntity(string jobId = default(string), string jobFriendlyName = default(string), string targetObjectId = default(string), string targetObjectName = default(string), string targetInstanceType = default(string), string jobScenarioName = default(string))
        {
            JobId = jobId;
            JobFriendlyName = jobFriendlyName;
            TargetObjectId = targetObjectId;
            TargetObjectName = targetObjectName;
            TargetInstanceType = targetInstanceType;
            JobScenarioName = jobScenarioName;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobFriendlyName")]
        public string JobFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectId")]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectName")]
        public string TargetObjectName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetInstanceType")]
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobScenarioName")]
        public string JobScenarioName { get; set; }

    }
}
