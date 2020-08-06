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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBInstanceAutomatedBackup operation.
    /// Deletes automated backups based on the source instance's <code>DbiResourceId</code>
    /// value or the restorable instance's resource ID.
    /// </summary>
    public partial class DeleteDBInstanceAutomatedBackupRequest : AmazonRDSRequest
    {
        private string _dbiResourceId;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
        /// to an AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

    }
}