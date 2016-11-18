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
    /// Recovery plan test failover input.
    /// </summary>
    public partial class RecoveryPlanTestFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanTestFailoverInput
        /// class.
        /// </summary>
        public RecoveryPlanTestFailoverInput() { }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanTestFailoverInput
        /// class.
        /// </summary>
        public RecoveryPlanTestFailoverInput(RecoveryPlanTestFailoverInputProperties properties)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the recovery plan test failover input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RecoveryPlanTestFailoverInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
