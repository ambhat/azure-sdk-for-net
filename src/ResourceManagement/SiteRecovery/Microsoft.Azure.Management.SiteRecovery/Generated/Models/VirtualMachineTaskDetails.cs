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

    /// <summary>
    /// This class represents the virtual machine task details.
    /// </summary>
    public partial class VirtualMachineTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineTaskDetails class.
        /// </summary>
        public VirtualMachineTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineTaskDetails class.
        /// </summary>
        public VirtualMachineTaskDetails(string skippedReason = default(string), string skippedReasonString = default(string), JobEntity jobTask = default(JobEntity))
        {
            SkippedReason = skippedReason;
            SkippedReasonString = skippedReasonString;
            JobTask = jobTask;
        }

        /// <summary>
        /// Gets or sets the skipped reason.
        /// </summary>
        [JsonProperty(PropertyName = "skippedReason")]
        public string SkippedReason { get; set; }

        /// <summary>
        /// Gets or sets the skipped reason string.
        /// </summary>
        [JsonProperty(PropertyName = "skippedReasonString")]
        public string SkippedReasonString { get; set; }

        /// <summary>
        /// Gets or sets the job entity.
        /// </summary>
        [JsonProperty(PropertyName = "jobTask")]
        public JobEntity JobTask { get; set; }

    }
}
