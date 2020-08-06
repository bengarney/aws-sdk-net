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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetAccountSettings operation.
    /// </summary>
    public partial class GetAccountSettingsResponse : AmazonWebServiceResponse
    {
        private AccountLimit _accountLimit;
        private AccountUsage _accountUsage;

        /// <summary>
        /// Gets and sets the property AccountLimit. 
        /// <para>
        /// Limits that are related to concurrency and code storage.
        /// </para>
        /// </summary>
        public AccountLimit AccountLimit
        {
            get { return this._accountLimit; }
            set { this._accountLimit = value; }
        }

        // Check to see if AccountLimit property is set
        internal bool IsSetAccountLimit()
        {
            return this._accountLimit != null;
        }

        /// <summary>
        /// Gets and sets the property AccountUsage. 
        /// <para>
        /// The number of functions and amount of storage in use.
        /// </para>
        /// </summary>
        public AccountUsage AccountUsage
        {
            get { return this._accountUsage; }
            set { this._accountUsage = value; }
        }

        // Check to see if AccountUsage property is set
        internal bool IsSetAccountUsage()
        {
            return this._accountUsage != null;
        }

    }
}