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
    /// Job details based on specific job type.
    /// </summary>
    public partial class JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        public JobDetails() { }

        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        public JobDetails(IDictionary<string, string> affectedObjectDetails = default(IDictionary<string, string>))
        {
            AffectedObjectDetails = affectedObjectDetails;
        }

        /// <summary>
        /// Gets or sets the affected object properties like source server,
        /// source cloud, target
        /// server, target cloud etc. based on the workflow object
        /// details.
        /// </summary>
        [JsonProperty(PropertyName = "affectedObjectDetails")]
        public IDictionary<string, string> AffectedObjectDetails { get; set; }

    }
}
