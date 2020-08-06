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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for ListOfferingsResponse
    /// </summary>
    public partial class ListOfferingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Offering> _offerings = new List<Offering>();

        /// <summary>
        /// Gets and sets the property NextToken. Token to retrieve the next page of results
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
        /// Gets and sets the property Offerings. List of offerings
        /// </summary>
        public List<Offering> Offerings
        {
            get { return this._offerings; }
            set { this._offerings = value; }
        }

        // Check to see if Offerings property is set
        internal bool IsSetOfferings()
        {
            return this._offerings != null && this._offerings.Count > 0; 
        }

    }
}