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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEntityRecognizer operation.
    /// Provides details about an entity recognizer including status, S3 buckets containing
    /// training data, recognizer metadata, metrics, and so on.
    /// </summary>
    public partial class DescribeEntityRecognizerRequest : AmazonComprehendRequest
    {
        private string _entityRecognizerArn;

        /// <summary>
        /// Gets and sets the property EntityRecognizerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EntityRecognizerArn
        {
            get { return this._entityRecognizerArn; }
            set { this._entityRecognizerArn = value; }
        }

        // Check to see if EntityRecognizerArn property is set
        internal bool IsSetEntityRecognizerArn()
        {
            return this._entityRecognizerArn != null;
        }

    }
}