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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The data stores in the fabric. This pertains to the data stores in the
    /// vCenter.
    /// </summary>
    public partial class DataStore
    {
        private string _capacity;
        
        /// <summary>
        /// Optional. The capacity of data store in GBs.
        /// </summary>
        public string Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }
        
        private string _freeSpace;
        
        /// <summary>
        /// Optional. The free space of data store in GBs.
        /// </summary>
        public string FreeSpace
        {
            get { return this._freeSpace; }
            set { this._freeSpace = value; }
        }
        
        private string _symbolicName;
        
        /// <summary>
        /// Optional. The symbolic name of data store.
        /// </summary>
        public string SymbolicName
        {
            get { return this._symbolicName; }
            set { this._symbolicName = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. The type of data store.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _uuid;
        
        /// <summary>
        /// Optional. The uuid of data store.
        /// </summary>
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        public DataStore()
        {
        }
    }
}
