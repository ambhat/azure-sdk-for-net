// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.SiteRecovery;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to add a physical machine as a protectable item in a container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiscoverProtectableItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the DiscoverProtectableItemRequest
        /// class.
        /// </summary>
        public DiscoverProtectableItemRequest() { }

        /// <summary>
        /// Initializes a new instance of the DiscoverProtectableItemRequest
        /// class.
        /// </summary>
        /// <param name="friendlyName">Gets or sets the friendly name of the
        /// physical machine.</param>
        /// <param name="ipAddress">Gets or sets the IP address of the physical
        /// machine to be discovered.</param>
        /// <param name="osType">Gets or sets the OS type on the physical
        /// machine.</param>
        public DiscoverProtectableItemRequest(string friendlyName = default(string), string ipAddress = default(string), string osType = default(string))
        {
            FriendlyName = friendlyName;
            IpAddress = ipAddress;
            OsType = osType;
        }

        /// <summary>
        /// Gets or sets the friendly name of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the physical machine to be
        /// discovered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the OS type on the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

    }
}
