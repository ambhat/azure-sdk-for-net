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

    public partial class MobilityServiceUpdate
    {
        /// <summary>
        /// Initializes a new instance of the MobilityServiceUpdate class.
        /// </summary>
        public MobilityServiceUpdate() { }

        /// <summary>
        /// Initializes a new instance of the MobilityServiceUpdate class.
        /// </summary>
        public MobilityServiceUpdate(string version = default(string), string rebootStatus = default(string), string osType = default(string))
        {
            Version = version;
            RebootStatus = rebootStatus;
            OsType = osType;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rebootStatus")]
        public string RebootStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

    }
}
