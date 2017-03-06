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
    /// The Mobility Service update details.
    /// </summary>
    public partial class MobilityServiceUpdate
    {
        /// <summary>
        /// Initializes a new instance of the MobilityServiceUpdate class.
        /// </summary>
        public MobilityServiceUpdate() { }

        /// <summary>
        /// Initializes a new instance of the MobilityServiceUpdate class.
        /// </summary>
        /// <param name="version">Gets or sets the version of the latest
        /// update.</param>
        /// <param name="rebootStatus">Gets or sets the reboot status of the
        /// update - whether it is required or not.</param>
        /// <param name="osType">Gets or sets the OS type.</param>
        public MobilityServiceUpdate(string version = default(string), string rebootStatus = default(string), string osType = default(string))
        {
            Version = version;
            RebootStatus = rebootStatus;
            OsType = osType;
        }

        /// <summary>
        /// Gets or sets the version of the latest update.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the reboot status of the update - whether it is
        /// required or not.
        /// </summary>
        [JsonProperty(PropertyName = "rebootStatus")]
        public string RebootStatus { get; set; }

        /// <summary>
        /// Gets or sets the OS type.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

    }
}
