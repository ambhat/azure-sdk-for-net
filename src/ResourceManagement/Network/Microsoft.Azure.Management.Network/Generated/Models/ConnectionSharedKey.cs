// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for GetConnectionSharedKey API service call
    /// </summary>
    public partial class ConnectionSharedKey
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKey class.
        /// </summary>
        public ConnectionSharedKey() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKey class.
        /// </summary>
        /// <param name="value">The virtual network connection shared key
        /// value.</param>
        public ConnectionSharedKey(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the virtual network connection shared key value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}

