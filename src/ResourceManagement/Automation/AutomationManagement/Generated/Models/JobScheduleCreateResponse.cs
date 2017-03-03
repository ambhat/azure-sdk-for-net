// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the create job schedule operation.
    /// </summary>
    public partial class JobScheduleCreateResponse : AzureOperationResponse
    {
        private JobSchedule _jobSchedule;
        
        /// <summary>
        /// Optional. Gets or sets a job schedule.
        /// </summary>
        public JobSchedule JobSchedule
        {
            get { return this._jobSchedule; }
            set { this._jobSchedule = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobScheduleCreateResponse class.
        /// </summary>
        public JobScheduleCreateResponse()
        {
        }
    }
}
