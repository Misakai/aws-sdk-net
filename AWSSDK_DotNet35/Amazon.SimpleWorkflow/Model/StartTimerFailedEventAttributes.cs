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

/*
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details of the <code>StartTimerFailed</code> event.
    /// </summary>
    public partial class StartTimerFailedEventAttributes
    {
        private StartTimerFailedCause _cause;
        private long? _decisionTaskCompletedEventId;
        private string _timerId;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The cause of the failure to process the decision. This information is generated by
        /// the system and can be useful for diagnostic purposes.
        /// </para>
        /// </summary>
        public StartTimerFailedCause Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        ///  The id of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>StartTimer</code> decision for this activity task.
        /// This information can be useful for diagnosing problems by tracing back the cause of
        /// events. 
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimerId. 
        /// <para>
        ///  The timerId provided in the <code>StartTimer</code> decision that failed. 
        /// </para>
        /// </summary>
        public string TimerId
        {
            get { return this._timerId; }
            set { this._timerId = value; }
        }

        // Check to see if TimerId property is set
        internal bool IsSetTimerId()
        {
            return this._timerId != null;
        }

    }
}