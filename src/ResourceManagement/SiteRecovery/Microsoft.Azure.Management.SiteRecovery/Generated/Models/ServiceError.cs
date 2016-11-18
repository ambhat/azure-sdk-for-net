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
    /// ASR error model
    /// </summary>
    public partial class ServiceError
    {
        /// <summary>
        /// Initializes a new instance of the ServiceError class.
        /// </summary>
        public ServiceError() { }

        /// <summary>
        /// Initializes a new instance of the ServiceError class.
        /// </summary>
        public ServiceError(string code = default(string), string message = default(string), string possibleCauses = default(string), string recommendedAction = default(string), string activityId = default(string))
        {
            Code = code;
            Message = message;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            ActivityId = activityId;
        }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets possible causes of error.
        /// </summary>
        [JsonProperty(PropertyName = "possibleCauses")]
        public string PossibleCauses { get; set; }

        /// <summary>
        /// Gets or sets recommended action to resolve error.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Gets or sets activity Id.
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

    }
}
