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

    public partial class A2AFailoverProviderInput : ProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AFailoverProviderInput class.
        /// </summary>
        public A2AFailoverProviderInput() { }

        /// <summary>
        /// Initializes a new instance of the A2AFailoverProviderInput class.
        /// </summary>
        public A2AFailoverProviderInput(string recoveryPointId = default(string))
        {
            RecoveryPointId = recoveryPointId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

    }
}
