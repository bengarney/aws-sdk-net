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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the ListLicenseConfigurations operation.
    /// </summary>
    public partial class ListLicenseConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<LicenseConfiguration> _licenseConfigurations = new List<LicenseConfiguration>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LicenseConfigurations. 
        /// <para>
        /// Information about the license configurations.
        /// </para>
        /// </summary>
        public List<LicenseConfiguration> LicenseConfigurations
        {
            get { return this._licenseConfigurations; }
            set { this._licenseConfigurations = value; }
        }

        // Check to see if LicenseConfigurations property is set
        internal bool IsSetLicenseConfigurations()
        {
            return this._licenseConfigurations != null && this._licenseConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
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

    }
}