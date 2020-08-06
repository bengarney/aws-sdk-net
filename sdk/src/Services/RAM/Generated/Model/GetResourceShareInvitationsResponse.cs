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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// This is the response object from the GetResourceShareInvitations operation.
    /// </summary>
    public partial class GetResourceShareInvitationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceShareInvitation> _resourceShareInvitations = new List<ResourceShareInvitation>();

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
        /// Gets and sets the property ResourceShareInvitations. 
        /// <para>
        /// Information about the invitations.
        /// </para>
        /// </summary>
        public List<ResourceShareInvitation> ResourceShareInvitations
        {
            get { return this._resourceShareInvitations; }
            set { this._resourceShareInvitations = value; }
        }

        // Check to see if ResourceShareInvitations property is set
        internal bool IsSetResourceShareInvitations()
        {
            return this._resourceShareInvitations != null && this._resourceShareInvitations.Count > 0; 
        }

    }
}