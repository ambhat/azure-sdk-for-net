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
    /// Volume details.
    /// </summary>
    public partial class DiskVolumeDetails
    {
        /// <summary>
        /// Initializes a new instance of the DiskVolumeDetails class.
        /// </summary>
        public DiskVolumeDetails() { }

        /// <summary>
        /// Initializes a new instance of the DiskVolumeDetails class.
        /// </summary>
        public DiskVolumeDetails(string label = default(string), string name = default(string))
        {
            Label = label;
            Name = name;
        }

        /// <summary>
        /// Gets or sets the volume label.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the volume name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
