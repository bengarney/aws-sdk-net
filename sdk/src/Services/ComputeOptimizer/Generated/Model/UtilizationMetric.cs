/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a utilization metric of a resource, such as an Amazon EC2 instance.
    /// </summary>
    public partial class UtilizationMetric
    {
        private MetricName _name;
        private MetricStatistic _statistic;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the utilization metric.
        /// </para>
        ///  <note> 
        /// <para>
        /// Memory metrics are only returned for resources that have the unified CloudWatch agent
        /// installed on them. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Install-CloudWatch-Agent.html">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public MetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic of the utilization metric.
        /// </para>
        /// </summary>
        public MetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the utilization metric.
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}