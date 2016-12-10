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
    /// Storage object properties.
    /// </summary>
    public partial class StorageClassificationProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageClassificationProperties
        /// class.
        /// </summary>
        public StorageClassificationProperties() { }

        /// <summary>
        /// Initializes a new instance of the StorageClassificationProperties
        /// class.
        /// </summary>
        public StorageClassificationProperties(string friendlyName = default(string))
        {
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Gets or sets friendly name of the Storage classification.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

    }
}
