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
using Microsoft.Azure.Management.DataFactories.Common.Models;

namespace Microsoft.Azure.Management.DataFactories.Common.Models
{
    /// <summary>
    /// Policy of a table.
    /// </summary>
    public partial class Policy
    {
        private ExternalDataPolicy _externalData;
        
        /// <summary>
        /// Optional. External data validation and retry policy.
        /// </summary>
        public ExternalDataPolicy ExternalData
        {
            get { return this._externalData; }
            set { this._externalData = value; }
        }
        
        private LatencyPolicy _latency;
        
        /// <summary>
        /// Optional. Latency policy.
        /// </summary>
        public LatencyPolicy Latency
        {
            get { return this._latency; }
            set { this._latency = value; }
        }
        
        private ValidationPolicy _validation;
        
        /// <summary>
        /// Optional. Validation policy.
        /// </summary>
        public ValidationPolicy Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        public Policy()
        {
        }
    }
}
