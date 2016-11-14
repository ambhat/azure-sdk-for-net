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
    /// A2A protected entity fabric configuration details.
    /// </summary>
    public partial class AzureToAzureVmSyncedConfigDetails
    {
        private IList<InputEndpoint> _inputEndpoints;
        
        /// <summary>
        /// Optional. Azure VM input endpoints.
        /// </summary>
        public IList<InputEndpoint> InputEndpoints
        {
            get { return this._inputEndpoints; }
            set { this._inputEndpoints = value; }
        }
        
        private IList<RoleAssignment> _roleAssignments;
        
        /// <summary>
        /// Optional. Azure VM role assignments.
        /// </summary>
        public IList<RoleAssignment> RoleAssignments
        {
            get { return this._roleAssignments; }
            set { this._roleAssignments = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Azure VM tags.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureToAzureVmSyncedConfigDetails
        /// class.
        /// </summary>
        public AzureToAzureVmSyncedConfigDetails()
        {
            this.InputEndpoints = new LazyList<InputEndpoint>();
            this.RoleAssignments = new LazyList<RoleAssignment>();
            this.Tags = new LazyDictionary<string, string>();
        }
    }
}