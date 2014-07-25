/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The list of severity levels returned by the <a>DescribeSeverityLevels</a> operation.
    /// </summary>
    public partial class DescribeSeverityLevelsResult : AmazonWebServiceResponse
    {
        private List<SeverityLevel> _severityLevels = new List<SeverityLevel>();


        /// <summary>
        /// Gets and sets the property SeverityLevels. 
        /// <para>
        /// The available severity levels for the support case. Available severity levels are
        /// defined by your service level agreement with AWS.
        /// </para>
        /// </summary>
        public List<SeverityLevel> SeverityLevels
        {
            get { return this._severityLevels; }
            set { this._severityLevels = value; }
        }

        // Check to see if SeverityLevels property is set
        internal bool IsSetSeverityLevels()
        {
            return this._severityLevels != null && this._severityLevels.Count > 0; 
        }

    }
}