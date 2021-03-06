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

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// The definition of a PlannedFailoverInput properties object.
    /// </summary>
    public partial class AllocateStampInputProperties
    {
        private string _lowerBoundStampVersion;
        
        /// <summary>
        /// Optional. Gets or sets lower bound stamp version.
        /// </summary>
        public string LowerBoundStampVersion
        {
            get { return this._lowerBoundStampVersion; }
            set { this._lowerBoundStampVersion = value; }
        }
        
        private string _preferredStampId;
        
        /// <summary>
        /// Optional. Gets or sets type of stamp (a GUID).
        /// </summary>
        public string PreferredStampId
        {
            get { return this._preferredStampId; }
            set { this._preferredStampId = value; }
        }
        
        private string _queueDetailsRequired;
        
        /// <summary>
        /// Optional. Gets or sets if queue details of stamp required.
        /// </summary>
        public string QueueDetailsRequired
        {
            get { return this._queueDetailsRequired; }
            set { this._queueDetailsRequired = value; }
        }
        
        private string _queueSuffix;
        
        /// <summary>
        /// Optional. Gets or sets queue suffix for stamp.
        /// </summary>
        public string QueueSuffix
        {
            get { return this._queueSuffix; }
            set { this._queueSuffix = value; }
        }
        
        private string _stampType;
        
        /// <summary>
        /// Optional. Gets or sets type of stamp.
        /// </summary>
        public string StampType
        {
            get { return this._stampType; }
            set { this._stampType = value; }
        }
        
        private string _upperBoundStampVersion;
        
        /// <summary>
        /// Optional. Gets or sets upper bound stamp version.
        /// </summary>
        public string UpperBoundStampVersion
        {
            get { return this._upperBoundStampVersion; }
            set { this._upperBoundStampVersion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AllocateStampInputProperties
        /// class.
        /// </summary>
        public AllocateStampInputProperties()
        {
        }
    }
}
