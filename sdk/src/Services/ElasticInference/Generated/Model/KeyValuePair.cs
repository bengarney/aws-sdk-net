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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// A throughput entry for an Elastic Inference Accelerator type.
    /// </summary>
    public partial class KeyValuePair
    {
        private string _key;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The throughput value of the Elastic Inference Accelerator type. It can assume the
        /// following values: TFLOPS16bit: the throughput expressed in 16bit TeraFLOPS. TFLOPS32bit:
        /// the throughput expressed in 32bit TeraFLOPS. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The throughput value of the Elastic Inference Accelerator type. 
        /// </para>
        /// </summary>
        public int Value
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