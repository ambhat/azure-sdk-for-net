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

    public partial class DeployProcessServerRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DeployProcessServerRequestProperties class.
        /// </summary>
        public DeployProcessServerRequestProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DeployProcessServerRequestProperties class.
        /// </summary>
        public DeployProcessServerRequestProperties(string subscriptionId = default(string), string vaultLocation = default(string), string friendlyName = default(string), string userName = default(string), string password = default(string), string ipAddress = default(string), string azureNetworkName = default(string), string azureNetworkSubnet = default(string))
        {
            SubscriptionId = subscriptionId;
            VaultLocation = vaultLocation;
            FriendlyName = friendlyName;
            UserName = userName;
            Password = password;
            IpAddress = ipAddress;
            AzureNetworkName = azureNetworkName;
            AzureNetworkSubnet = azureNetworkSubnet;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vaultLocation")]
        public string VaultLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "azureNetworkName")]
        public string AzureNetworkName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "azureNetworkSubnet")]
        public string AzureNetworkSubnet { get; set; }

    }
}
