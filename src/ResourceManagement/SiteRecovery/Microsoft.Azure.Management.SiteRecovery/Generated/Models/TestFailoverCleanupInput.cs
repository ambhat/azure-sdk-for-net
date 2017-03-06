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
    /// Input definition for test failover cleanup.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TestFailoverCleanupInput
    {
        /// <summary>
        /// Initializes a new instance of the TestFailoverCleanupInput class.
        /// </summary>
        public TestFailoverCleanupInput() { }

        /// <summary>
        /// Initializes a new instance of the TestFailoverCleanupInput class.
        /// </summary>
        /// <param name="comments">Gets or sets test failover cleanup
        /// comments.</param>
        public TestFailoverCleanupInput(string comments = default(string))
        {
            Comments = comments;
        }

        /// <summary>
        /// Gets or sets test failover cleanup comments.
        /// </summary>
        [JsonProperty(PropertyName = "properties.comments")]
        public string Comments { get; set; }

    }
}
