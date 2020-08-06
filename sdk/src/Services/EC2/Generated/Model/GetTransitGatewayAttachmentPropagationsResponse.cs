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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetTransitGatewayAttachmentPropagations operation.
    /// </summary>
    public partial class GetTransitGatewayAttachmentPropagationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TransitGatewayAttachmentPropagation> _transitGatewayAttachmentPropagations = new List<TransitGatewayAttachmentPropagation>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentPropagations. 
        /// <para>
        /// Information about the propagation route tables.
        /// </para>
        /// </summary>
        public List<TransitGatewayAttachmentPropagation> TransitGatewayAttachmentPropagations
        {
            get { return this._transitGatewayAttachmentPropagations; }
            set { this._transitGatewayAttachmentPropagations = value; }
        }

        // Check to see if TransitGatewayAttachmentPropagations property is set
        internal bool IsSetTransitGatewayAttachmentPropagations()
        {
            return this._transitGatewayAttachmentPropagations != null && this._transitGatewayAttachmentPropagations.Count > 0; 
        }

    }
}