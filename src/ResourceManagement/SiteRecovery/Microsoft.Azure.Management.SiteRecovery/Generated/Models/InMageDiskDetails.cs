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
    /// VMware/Physical specific Disk Details
    /// </summary>
    public partial class InMageDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageDiskDetails class.
        /// </summary>
        public InMageDiskDetails() { }

        /// <summary>
        /// Initializes a new instance of the InMageDiskDetails class.
        /// </summary>
        public InMageDiskDetails(string diskId = default(string), string diskName = default(string), string diskSizeInMB = default(string), string diskType = default(string), string diskConfiguration = default(string), IList<DiskVolumeDetails> volumeList = default(IList<DiskVolumeDetails>))
        {
            DiskId = diskId;
            DiskName = diskName;
            DiskSizeInMB = diskSizeInMB;
            DiskType = diskType;
            DiskConfiguration = diskConfiguration;
            VolumeList = volumeList;
        }

        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or sets the disk size in MB.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeInMB")]
        public string DiskSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets whether disk is system disk or data disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// Gets or sets whether disk is dynamic disk or basic disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskConfiguration")]
        public string DiskConfiguration { get; set; }

        /// <summary>
        /// Gets or sets volumes of the disk.
        /// </summary>
        [JsonProperty(PropertyName = "volumeList")]
        public IList<DiskVolumeDetails> VolumeList { get; set; }

    }
}
