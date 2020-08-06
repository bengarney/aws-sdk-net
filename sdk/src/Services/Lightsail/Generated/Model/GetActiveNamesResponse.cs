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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetActiveNames operation.
    /// </summary>
    public partial class GetActiveNamesResponse : AmazonWebServiceResponse
    {
        private List<string> _activeNames = new List<string>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property ActiveNames. 
        /// <para>
        /// The list of active names returned by the get active names request.
        /// </para>
        /// </summary>
        public List<string> ActiveNames
        {
            get { return this._activeNames; }
            set { this._activeNames = value; }
        }

        // Check to see if ActiveNames property is set
        internal bool IsSetActiveNames()
        {
            return this._activeNames != null && this._activeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of resutls from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <code>GetActiveNames</code> request
        /// and specify the next page token using the <code>pageToken</code> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}