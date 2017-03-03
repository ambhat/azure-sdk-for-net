// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    public partial class ParametersWithSkipToken
    {
        private string _skipToken;
        
        /// <summary>
        /// Optional. Gets or sets the skip token.
        /// </summary>
        public string SkipToken
        {
            get { return this._skipToken; }
            set { this._skipToken = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ParametersWithSkipToken class.
        /// </summary>
        public ParametersWithSkipToken()
        {
        }
    }
}
