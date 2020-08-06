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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties for logging events associated with a peer node owned by a
    /// member in a Managed Blockchain network.
    /// </summary>
    public partial class NodeLogPublishingConfiguration
    {
        private NodeFabricLogPublishingConfiguration _fabric;

        /// <summary>
        /// Gets and sets the property Fabric. 
        /// <para>
        /// Configuration properties for logging events associated with a node that is owned by
        /// a member of a Managed Blockchain network using the Hyperledger Fabric framework.
        /// </para>
        /// </summary>
        public NodeFabricLogPublishingConfiguration Fabric
        {
            get { return this._fabric; }
            set { this._fabric = value; }
        }

        // Check to see if Fabric property is set
        internal bool IsSetFabric()
        {
            return this._fabric != null;
        }

    }
}