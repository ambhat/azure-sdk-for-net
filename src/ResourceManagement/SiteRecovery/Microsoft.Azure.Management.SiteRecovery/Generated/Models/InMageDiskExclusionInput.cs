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
    /// DiskExclusionInput when doing enable protection of virtual machine in
    /// InMage provider.
    /// </summary>
    public partial class InMageDiskExclusionInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageDiskExclusionInput class.
        /// </summary>
        public InMageDiskExclusionInput() { }

        /// <summary>
        /// Initializes a new instance of the InMageDiskExclusionInput class.
        /// </summary>
        /// <param name="volumeOptions">Gets or sets the volume label based
        /// option for disk exclusion.</param>
        /// <param name="diskSignatureOptions">Gets or sets the guest disk
        /// signature based option for disk exclusion.</param>
        public InMageDiskExclusionInput(IList<InMageVolumeExclusionOptions> volumeOptions = default(IList<InMageVolumeExclusionOptions>), IList<InMageDiskSignatureExclusionOptions> diskSignatureOptions = default(IList<InMageDiskSignatureExclusionOptions>))
        {
            VolumeOptions = volumeOptions;
            DiskSignatureOptions = diskSignatureOptions;
        }

        /// <summary>
        /// Gets or sets the volume label based option for disk exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "volumeOptions")]
        public IList<InMageVolumeExclusionOptions> VolumeOptions { get; set; }

        /// <summary>
        /// Gets or sets the guest disk signature based option for disk
        /// exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "diskSignatureOptions")]
        public IList<InMageDiskSignatureExclusionOptions> DiskSignatureOptions { get; set; }

    }
}
