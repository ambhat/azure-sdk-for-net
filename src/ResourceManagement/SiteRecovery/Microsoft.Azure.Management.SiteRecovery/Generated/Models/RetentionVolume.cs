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
    /// The retention details of the MT.
    /// </summary>
    public partial class RetentionVolume
    {
        /// <summary>
        /// Initializes a new instance of the RetentionVolume class.
        /// </summary>
        public RetentionVolume() { }

        /// <summary>
        /// Initializes a new instance of the RetentionVolume class.
        /// </summary>
        public RetentionVolume(string volumeName = default(string), long? capacityInBytes = default(long?), long? freeSpaceInBytes = default(long?), int? thresholdPercentage = default(int?))
        {
            VolumeName = volumeName;
            CapacityInBytes = capacityInBytes;
            FreeSpaceInBytes = freeSpaceInBytes;
            ThresholdPercentage = thresholdPercentage;
        }

        /// <summary>
        /// Gets or sets the volume name.
        /// </summary>
        [JsonProperty(PropertyName = "volumeName")]
        public string VolumeName { get; set; }

        /// <summary>
        /// Gets or sets the volume capacity.
        /// </summary>
        [JsonProperty(PropertyName = "capacityInBytes")]
        public long? CapacityInBytes { get; set; }

        /// <summary>
        /// Gets or sets the free space available in this volume.
        /// </summary>
        [JsonProperty(PropertyName = "freeSpaceInBytes")]
        public long? FreeSpaceInBytes { get; set; }

        /// <summary>
        /// Gets or sets the threshold percentage.
        /// </summary>
        [JsonProperty(PropertyName = "thresholdPercentage")]
        public int? ThresholdPercentage { get; set; }

    }
}
