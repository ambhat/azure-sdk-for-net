// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a configure alert request.
    /// </summary>
    public partial class ConfigureAlertRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequestProperties
        /// class.
        /// </summary>
        public ConfigureAlertRequestProperties() { }

        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequestProperties
        /// class.
        /// </summary>
        /// <param name="sendToOwners">Gets or sets a value indicating whether
        /// to send email to subscription administrator.</param>
        /// <param name="customEmailAddresses">Gets or sets the custom email
        /// address for sending emails.</param>
        /// <param name="locale">Gets or sets the locale for the email
        /// notification.</param>
        public ConfigureAlertRequestProperties(string sendToOwners = default(string), IList<string> customEmailAddresses = default(IList<string>), string locale = default(string))
        {
            SendToOwners = sendToOwners;
            CustomEmailAddresses = customEmailAddresses;
            Locale = locale;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription administrator.
        /// </summary>
        [JsonProperty(PropertyName = "sendToOwners")]
        public string SendToOwners { get; set; }

        /// <summary>
        /// Gets or sets the custom email address for sending emails.
        /// </summary>
        [JsonProperty(PropertyName = "customEmailAddresses")]
        public IList<string> CustomEmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the locale for the email notification.
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
