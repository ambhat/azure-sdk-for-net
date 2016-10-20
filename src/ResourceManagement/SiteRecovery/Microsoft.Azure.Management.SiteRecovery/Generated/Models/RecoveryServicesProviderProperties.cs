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

    public partial class RecoveryServicesProviderProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesProviderProperties class.
        /// </summary>
        public RecoveryServicesProviderProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesProviderProperties class.
        /// </summary>
        public RecoveryServicesProviderProperties(string fabricType = default(string), string friendlyName = default(string), string providerVersion = default(string), string serverVersion = default(string), string providerVersionState = default(string), DateTime? providerVersionExpiryDate = default(DateTime?), string fabricFriendlyName = default(string), DateTime? lastHeartBeat = default(DateTime?), string connectionStatus = default(string), int? protectedItemCount = default(int?), IList<string> allowedScenarios = default(IList<string>))
        {
            FabricType = fabricType;
            FriendlyName = friendlyName;
            ProviderVersion = providerVersion;
            ServerVersion = serverVersion;
            ProviderVersionState = providerVersionState;
            ProviderVersionExpiryDate = providerVersionExpiryDate;
            FabricFriendlyName = fabricFriendlyName;
            LastHeartBeat = lastHeartBeat;
            ConnectionStatus = connectionStatus;
            ProtectedItemCount = protectedItemCount;
            AllowedScenarios = allowedScenarios;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fabricType")]
        public string FabricType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serverVersion")]
        public string ServerVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerVersionState")]
        public string ProviderVersionState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerVersionExpiryDate")]
        public DateTime? ProviderVersionExpiryDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fabricFriendlyName")]
        public string FabricFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartBeat")]
        public DateTime? LastHeartBeat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemCount")]
        public int? ProtectedItemCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedScenarios")]
        public IList<string> AllowedScenarios { get; set; }

    }
}
