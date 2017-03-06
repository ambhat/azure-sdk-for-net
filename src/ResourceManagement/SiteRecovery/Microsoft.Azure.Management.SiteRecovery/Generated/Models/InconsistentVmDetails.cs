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
    /// This class stores the monitoring details for consistency check of
    /// inconsistent Protected Entity.
    /// </summary>
    public partial class InconsistentVmDetails
    {
        /// <summary>
        /// Initializes a new instance of the InconsistentVmDetails class.
        /// </summary>
        public InconsistentVmDetails() { }

        /// <summary>
        /// Initializes a new instance of the InconsistentVmDetails class.
        /// </summary>
        /// <param name="vmName">Gets or sets the Vm name.</param>
        /// <param name="cloudName">Gets or sets the Cloud name.</param>
        /// <param name="details">Gets or sets the list of details regarding
        /// state of the
        /// Protected Entity in SRS and On prem.</param>
        /// <param name="errorIds">Gets or sets the list of error ids.</param>
        public InconsistentVmDetails(string vmName = default(string), string cloudName = default(string), IList<string> details = default(IList<string>), IList<string> errorIds = default(IList<string>))
        {
            VmName = vmName;
            CloudName = cloudName;
            Details = details;
            ErrorIds = errorIds;
        }

        /// <summary>
        /// Gets or sets the Vm name.
        /// </summary>
        [JsonProperty(PropertyName = "vmName")]
        public string VmName { get; set; }

        /// <summary>
        /// Gets or sets the Cloud name.
        /// </summary>
        [JsonProperty(PropertyName = "cloudName")]
        public string CloudName { get; set; }

        /// <summary>
        /// Gets or sets the list of details regarding state of the
        /// Protected Entity in SRS and On prem.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<string> Details { get; set; }

        /// <summary>
        /// Gets or sets the list of error ids.
        /// </summary>
        [JsonProperty(PropertyName = "errorIds")]
        public IList<string> ErrorIds { get; set; }

    }
}
