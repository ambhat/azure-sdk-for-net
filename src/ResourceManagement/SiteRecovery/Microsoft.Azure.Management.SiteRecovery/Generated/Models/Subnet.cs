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
    /// Subnets of the network.
    /// </summary>
    public partial class Subnet
    {
        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet() { }

        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet(string name = default(string), string friendlyName = default(string), IList<string> addressList = default(IList<string>))
        {
            Name = name;
            FriendlyName = friendlyName;
            AddressList = addressList;
        }

        /// <summary>
        /// Gets or sets the subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subnet friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the list of addresses for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "addressList")]
        public IList<string> AddressList { get; set; }

    }
}
