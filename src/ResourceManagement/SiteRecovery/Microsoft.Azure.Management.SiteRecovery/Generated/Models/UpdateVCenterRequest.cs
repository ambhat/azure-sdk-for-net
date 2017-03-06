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
    /// Input required to update vCenter.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdateVCenterRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateVCenterRequest class.
        /// </summary>
        public UpdateVCenterRequest() { }

        /// <summary>
        /// Initializes a new instance of the UpdateVCenterRequest class.
        /// </summary>
        /// <param name="friendlyName">Gets or sets the friendly name of the
        /// vCenter.</param>
        /// <param name="ipAddress">Gets or sets the IP address of the vCenter
        /// to be discovered.</param>
        /// <param name="processServerId">Gets or sets the process server Id
        /// from where the update can be orchestrated.</param>
        /// <param name="port">Gets or sets the port number for
        /// discovery.</param>
        /// <param name="runAsAccountId">Gets or sets the CS account Id which
        /// has priviliges to update the vCenter.</param>
        public UpdateVCenterRequest(string friendlyName = default(string), string ipAddress = default(string), string processServerId = default(string), string port = default(string), string runAsAccountId = default(string))
        {
            FriendlyName = friendlyName;
            IpAddress = ipAddress;
            ProcessServerId = processServerId;
            Port = port;
            RunAsAccountId = runAsAccountId;
        }

        /// <summary>
        /// Gets or sets the friendly name of the vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the vCenter to be discovered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the process server Id from where the update can be
        /// orchestrated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the port number for discovery.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets the CS account Id which has priviliges to update the
        /// vCenter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runAsAccountId")]
        public string RunAsAccountId { get; set; }

    }
}
