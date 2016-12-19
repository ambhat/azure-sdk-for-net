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
using System.Linq;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The Azure reprotect input.
    /// </summary>
    public partial class HyperVReplicaAzureReprotectInput : ReverseReplicationProviderSpecificInput
    {
        private string _hvHostVmId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string HvHostVmId
        {
            get { return this._hvHostVmId; }
            set { this._hvHostVmId = value; }
        }
        
        private string _logStorageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the storage account to be used for logging
        /// duringreplication. This is needed when the target storage account
        /// is of premium type only.
        /// </summary>
        public string LogStorageAccountId
        {
            get { return this._logStorageAccountId; }
            set { this._logStorageAccountId = value; }
        }
        
        private string _oSType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OSType
        {
            get { return this._oSType; }
            set { this._oSType = value; }
        }
        
        private string _storageAccountId;
        
        /// <summary>
        /// Optional. Gets or sets the storage account Id.
        /// </summary>
        public string StorageAccountId
        {
            get { return this._storageAccountId; }
            set { this._storageAccountId = value; }
        }
        
        private string _vHDId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VHDId
        {
            get { return this._vHDId; }
            set { this._vHDId = value; }
        }
        
        private string _vmName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzureReprotectInput
        /// class.
        /// </summary>
        public HyperVReplicaAzureReprotectInput()
        {
        }
    }
}
