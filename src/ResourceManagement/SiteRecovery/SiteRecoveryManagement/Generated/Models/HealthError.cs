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
    /// The definition of a Protection Container mapping health object.
    /// </summary>
    public partial class HealthError
    {
        private string _creationTimeUtc;
        
        /// <summary>
        /// Optional. Error creation time (UTC)
        /// </summary>
        public string CreationTimeUtc
        {
            get { return this._creationTimeUtc; }
            set { this._creationTimeUtc = value; }
        }
        
        private string _entityId;
        
        /// <summary>
        /// Optional. ID of the entity.
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }
        
        private string _errorCode;
        
        /// <summary>
        /// Optional. Error code.
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorLevel;
        
        /// <summary>
        /// Optional. Level of error.
        /// </summary>
        public string ErrorLevel
        {
            get { return this._errorLevel; }
            set { this._errorLevel = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error message.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _errorSource;
        
        /// <summary>
        /// Optional. Source of error.
        /// </summary>
        public string ErrorSource
        {
            get { return this._errorSource; }
            set { this._errorSource = value; }
        }
        
        private string _errorType;
        
        /// <summary>
        /// Optional. Type of error.
        /// </summary>
        public string ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }
        
        private string _possibleCauses;
        
        /// <summary>
        /// Optional. Possible causes of error.
        /// </summary>
        public string PossibleCauses
        {
            get { return this._possibleCauses; }
            set { this._possibleCauses = value; }
        }
        
        private string _recommendedAction;
        
        /// <summary>
        /// Optional. Recommended action to resolve error.
        /// </summary>
        public string RecommendedAction
        {
            get { return this._recommendedAction; }
            set { this._recommendedAction = value; }
        }
        
        private string _recoveryProviderErrorMessage;
        
        /// <summary>
        /// Optional. Recovery Provider error message.
        /// </summary>
        public string RecoveryProviderErrorMessage
        {
            get { return this._recoveryProviderErrorMessage; }
            set { this._recoveryProviderErrorMessage = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HealthError class.
        /// </summary>
        public HealthError()
        {
        }
    }
}
