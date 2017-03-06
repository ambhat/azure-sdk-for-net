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
    /// This class represents the manual action task details.
    /// </summary>
    public partial class ManualActionTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the ManualActionTaskDetails class.
        /// </summary>
        public ManualActionTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the ManualActionTaskDetails class.
        /// </summary>
        /// <param name="name">Gets or sets the name.</param>
        /// <param name="instructions">Gets or sets the instructions.</param>
        /// <param name="observation">Gets or sets the observation.</param>
        public ManualActionTaskDetails(string name = default(string), string instructions = default(string), string observation = default(string))
        {
            Name = name;
            Instructions = instructions;
            Observation = observation;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the instructions.
        /// </summary>
        [JsonProperty(PropertyName = "instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets the observation.
        /// </summary>
        [JsonProperty(PropertyName = "observation")]
        public string Observation { get; set; }

    }
}
