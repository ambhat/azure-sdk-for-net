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

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Represents the parameters supplied to the Create Database operation.
    /// </summary>
    public partial class DatabaseUpdateParameters
    {
        private string _edition;
        
        /// <summary>
        /// Required. Gets or sets the new edition for the database.
        /// </summary>
        public string Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }
        
        private long? _maximumDatabaseSizeInBytes;
        
        /// <summary>
        /// Optional. Gets or sets the maximum size of this database expressed
        /// in bytes.  If this is used with MaximumDatabaseSizeInGB they must
        /// agree.
        /// </summary>
        public long? MaximumDatabaseSizeInBytes
        {
            get { return this._maximumDatabaseSizeInBytes; }
            set { this._maximumDatabaseSizeInBytes = value; }
        }
        
        private int? _maximumDatabaseSizeInGB;
        
        /// <summary>
        /// Optional. Gets or sets the maximum size of this database expressed
        /// in gigabytes.  If this is used with MaximumDatabaseSizeInBytes
        /// they must agree.
        /// </summary>
        public int? MaximumDatabaseSizeInGB
        {
            get { return this._maximumDatabaseSizeInGB; }
            set { this._maximumDatabaseSizeInGB = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the new name of the database.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serviceObjectiveId;
        
        /// <summary>
        /// Optional. Gets or sets the unique identifier for the service
        /// objective to apply to the database.
        /// </summary>
        public string ServiceObjectiveId
        {
            get { return this._serviceObjectiveId; }
            set { this._serviceObjectiveId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseUpdateParameters class.
        /// </summary>
        public DatabaseUpdateParameters()
        {
        }
    }
}