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
    /// The details of the InMage agent.
    /// </summary>
    public partial class InMageAgentDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageAgentDetails class.
        /// </summary>
        public InMageAgentDetails() { }

        /// <summary>
        /// Initializes a new instance of the InMageAgentDetails class.
        /// </summary>
        /// <param name="agentVersion">Gets or sets the agent version.</param>
        /// <param name="agentUpdateStatus">Gets or sets a value indicating
        /// whether installed agent needs to be updated.</param>
        /// <param name="postUpdateRebootStatus">Gets or sets a value
        /// indicating whether reboot is required after update is
        /// applied.</param>
        public InMageAgentDetails(string agentVersion = default(string), string agentUpdateStatus = default(string), string postUpdateRebootStatus = default(string))
        {
            AgentVersion = agentVersion;
            AgentUpdateStatus = agentUpdateStatus;
            PostUpdateRebootStatus = postUpdateRebootStatus;
        }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether installed agent needs to be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "agentUpdateStatus")]
        public string AgentUpdateStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reboot is required after
        /// update is applied.
        /// </summary>
        [JsonProperty(PropertyName = "postUpdateRebootStatus")]
        public string PostUpdateRebootStatus { get; set; }

    }
}
