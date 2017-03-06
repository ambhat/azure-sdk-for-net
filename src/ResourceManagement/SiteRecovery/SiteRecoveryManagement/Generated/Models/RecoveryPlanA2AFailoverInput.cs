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
    /// Recovery plan A2A failover input.
    /// </summary>
    public partial class RecoveryPlanA2AFailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        private string _cloudServiceCreationOption;
        
        /// <summary>
        /// Required. Indicates whether to use recovery cloud service for TFO
        /// or not. Values from AutoCreateCloudService/UseRecoveryCloudService.
        /// </summary>
        public string CloudServiceCreationOption
        {
            get { return this._cloudServiceCreationOption; }
            set { this._cloudServiceCreationOption = value; }
        }
        
        private string _recoveryPointType;
        
        /// <summary>
        /// Required. The recovery point type. Values from
        /// Latest/LatestProcessed/LatestApplicationConsistent/LatestCrashConsistent.
        /// </summary>
        public string RecoveryPointType
        {
            get { return this._recoveryPointType; }
            set { this._recoveryPointType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput
        /// class.
        /// </summary>
        public RecoveryPlanA2AFailoverInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput
        /// class with required arguments.
        /// </summary>
        public RecoveryPlanA2AFailoverInput(string recoveryPointType, string cloudServiceCreationOption)
            : this()
        {
            if (recoveryPointType == null)
            {
                throw new ArgumentNullException("recoveryPointType");
            }
            if (cloudServiceCreationOption == null)
            {
                throw new ArgumentNullException("cloudServiceCreationOption");
            }
            this.RecoveryPointType = recoveryPointType;
            this.CloudServiceCreationOption = cloudServiceCreationOption;
        }
    }
}
