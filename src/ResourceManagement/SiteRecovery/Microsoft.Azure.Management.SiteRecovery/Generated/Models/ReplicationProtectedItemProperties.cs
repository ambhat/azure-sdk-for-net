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

    public partial class ReplicationProtectedItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties(string friendlyName = default(string), string protectedItemType = default(string), string protectableItemId = default(string), string recoveryServicesProviderId = default(string), string primaryFabricFriendlyName = default(string), string recoveryFabricFriendlyName = default(string), string recoveryFabricId = default(string), string primaryProtectionContainerFriendlyName = default(string), string recoveryProtectionContainerFriendlyName = default(string), string protectionState = default(string), string protectionStateDescription = default(string), string activeLocation = default(string), string testFailoverState = default(string), string testFailoverStateDescription = default(string), IList<string> allowedOperations = default(IList<string>), string replicationHealth = default(string), IList<HealthError> replicationHealthErrors = default(IList<HealthError>), string policyId = default(string), string policyFriendlyName = default(string), DateTime? lastSuccessfulFailoverTime = default(DateTime?), DateTime? lastSuccessfulTestFailoverTime = default(DateTime?), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), string failoverRecoveryPointId = default(string), ReplicationProviderSpecificSettings providerSpecificDetails = default(ReplicationProviderSpecificSettings))
        {
            FriendlyName = friendlyName;
            ProtectedItemType = protectedItemType;
            ProtectableItemId = protectableItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            RecoveryFabricId = recoveryFabricId;
            PrimaryProtectionContainerFriendlyName = primaryProtectionContainerFriendlyName;
            RecoveryProtectionContainerFriendlyName = recoveryProtectionContainerFriendlyName;
            ProtectionState = protectionState;
            ProtectionStateDescription = protectionStateDescription;
            ActiveLocation = activeLocation;
            TestFailoverState = testFailoverState;
            TestFailoverStateDescription = testFailoverStateDescription;
            AllowedOperations = allowedOperations;
            ReplicationHealth = replicationHealth;
            ReplicationHealthErrors = replicationHealthErrors;
            PolicyId = policyId;
            PolicyFriendlyName = policyFriendlyName;
            LastSuccessfulFailoverTime = lastSuccessfulFailoverTime;
            LastSuccessfulTestFailoverTime = lastSuccessfulTestFailoverTime;
            CurrentScenario = currentScenario;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemType")]
        public string ProtectedItemType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableItemId")]
        public string ProtectableItemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryProtectionContainerFriendlyName")]
        public string PrimaryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProtectionContainerFriendlyName")]
        public string RecoveryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectionStateDescription")]
        public string ProtectionStateDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeLocation")]
        public string ActiveLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverState")]
        public string TestFailoverState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverStateDescription")]
        public string TestFailoverStateDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedOperations")]
        public IList<string> AllowedOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicationHealth")]
        public string ReplicationHealth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicationHealthErrors")]
        public IList<HealthError> ReplicationHealthErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policyFriendlyName")]
        public string PolicyFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulFailoverTime")]
        public DateTime? LastSuccessfulFailoverTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulTestFailoverTime")]
        public DateTime? LastSuccessfulTestFailoverTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failoverRecoveryPointId")]
        public string FailoverRecoveryPointId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ReplicationProviderSpecificSettings ProviderSpecificDetails { get; set; }

    }
}
