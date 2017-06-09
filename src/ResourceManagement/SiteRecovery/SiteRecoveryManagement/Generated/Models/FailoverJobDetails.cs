// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Custom details for failover job.
    /// </summary>
    public partial class FailoverJobDetails : JobDetails
    {
        private IList<FailoverReplicationProtectedItemDetails> _protectedItemDetails;
        
        /// <summary>
        /// Optional. Protected item details for the test failover job.
        /// </summary>
        public IList<FailoverReplicationProtectedItemDetails> ProtectedItemDetails
        {
            get { return this._protectedItemDetails; }
            set { this._protectedItemDetails = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FailoverJobDetails class.
        /// </summary>
        public FailoverJobDetails()
        {
            this.ProtectedItemDetails = new LazyList<FailoverReplicationProtectedItemDetails>();
        }
        
        /// <summary>
        /// Initializes a new instance of the FailoverJobDetails class with
        /// required arguments.
        /// </summary>
        public FailoverJobDetails(string instanceType, IDictionary<string, string> affectedObjectDetails)
            : this()
        {
            if (instanceType == null)
            {
                throw new ArgumentNullException("instanceType");
            }
            if (affectedObjectDetails == null)
            {
                throw new ArgumentNullException("affectedObjectDetails");
            }
            this.InstanceType = instanceType;
            this.AffectedObjectDetails = affectedObjectDetails;
        }
    }
}