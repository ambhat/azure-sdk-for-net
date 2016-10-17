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

    public partial class ProviderError
    {
        /// <summary>
        /// Initializes a new instance of the ProviderError class.
        /// </summary>
        public ProviderError() { }

        /// <summary>
        /// Initializes a new instance of the ProviderError class.
        /// </summary>
        public ProviderError(int? errorCode = default(int?), string errorMessage = default(string), string errorId = default(string), string possibleCauses = default(string), string recommendedAction = default(string))
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorId = errorId;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "possibleCauses")]
        public string PossibleCauses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; set; }

    }
}
