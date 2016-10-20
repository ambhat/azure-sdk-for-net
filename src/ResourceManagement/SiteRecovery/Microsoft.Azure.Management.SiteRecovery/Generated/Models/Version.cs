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

    public partial class Version
    {
        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() { }

        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version(int? _major = default(int?), int? _minor = default(int?), int? _build = default(int?), int? _revision = default(int?))
        {
            _major = _major;
            _minor = _minor;
            _build = _build;
            _revision = _revision;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_Major")]
        public int? _major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_Minor")]
        public int? _minor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_Build")]
        public int? _build { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_Revision")]
        public int? _revision { get; set; }

    }
}
