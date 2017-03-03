// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Azure;
    using Management;
    using Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An alert incident indicates the activation status of an alert rule.
    /// </summary>
    public partial class Incident
    {
        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        public Incident() { }

        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        /// <param name="name">Incident name.</param>
        /// <param name="ruleName">Rule name that is associated with the
        /// incident.</param>
        /// <param name="isActive">A boolean to indicate whether the incident
        /// is active or resolved.</param>
        /// <param name="activatedTime">The time at which the incident was
        /// activated in ISO8601 format.</param>
        /// <param name="resolvedTime">The time at which the incident was
        /// resolved in ISO8601 format. If null, it means the incident is still
        /// active.</param>
        public Incident(string name = default(string), string ruleName = default(string), bool? isActive = default(bool?), System.DateTime? activatedTime = default(System.DateTime?), System.DateTime? resolvedTime = default(System.DateTime?))
        {
            Name = name;
            RuleName = ruleName;
            IsActive = isActive;
            ActivatedTime = activatedTime;
            ResolvedTime = resolvedTime;
        }

        /// <summary>
        /// Gets incident name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets rule name that is associated with the incident.
        /// </summary>
        [JsonProperty(PropertyName = "ruleName")]
        public string RuleName { get; protected set; }

        /// <summary>
        /// Gets a boolean to indicate whether the incident is active or
        /// resolved.
        /// </summary>
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; protected set; }

        /// <summary>
        /// Gets the time at which the incident was activated in ISO8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "activatedTime")]
        public System.DateTime? ActivatedTime { get; protected set; }

        /// <summary>
        /// Gets the time at which the incident was resolved in ISO8601 format.
        /// If null, it means the incident is still active.
        /// </summary>
        [JsonProperty(PropertyName = "resolvedTime")]
        public System.DateTime? ResolvedTime { get; protected set; }

    }
}

