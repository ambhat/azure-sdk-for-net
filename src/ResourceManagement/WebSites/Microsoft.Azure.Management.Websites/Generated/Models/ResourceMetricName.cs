// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Name of a metric for any resource .
    /// </summary>
    public partial class ResourceMetricName
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricName class.
        /// </summary>
        public ResourceMetricName() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricName class.
        /// </summary>
        /// <param name="value">metric name value.</param>
        /// <param name="localizedValue">Localized metric name value.</param>
        public ResourceMetricName(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary>
        /// Gets metric name value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; protected set; }

        /// <summary>
        /// Gets localized metric name value.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; protected set; }

    }
}

