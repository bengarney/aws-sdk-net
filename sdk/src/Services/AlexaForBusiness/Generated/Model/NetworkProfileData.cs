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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The data associated with a network profile.
    /// </summary>
    public partial class NetworkProfileData
    {
        private string _certificateAuthorityArn;
        private string _description;
        private NetworkEapMethod _eapMethod;
        private string _networkProfileArn;
        private string _networkProfileName;
        private NetworkSecurityType _securityType;
        private string _ssid;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The ARN of the Private Certificate Authority (PCA) created in AWS Certificate Manager
        /// (ACM). This is used to issue certificates to the devices.
        /// </para>
        /// </summary>
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Detailed information about a device's network profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EapMethod. 
        /// <para>
        /// The authentication standard that is used in the EAP framework. Currently, EAP_TLS
        /// is supported.
        /// </para>
        /// </summary>
        public NetworkEapMethod EapMethod
        {
            get { return this._eapMethod; }
            set { this._eapMethod = value; }
        }

        // Check to see if EapMethod property is set
        internal bool IsSetEapMethod()
        {
            return this._eapMethod != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkProfileArn. 
        /// <para>
        /// The ARN of the network profile associated with a device.
        /// </para>
        /// </summary>
        public string NetworkProfileArn
        {
            get { return this._networkProfileArn; }
            set { this._networkProfileArn = value; }
        }

        // Check to see if NetworkProfileArn property is set
        internal bool IsSetNetworkProfileArn()
        {
            return this._networkProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkProfileName. 
        /// <para>
        /// The name of the network profile associated with a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string NetworkProfileName
        {
            get { return this._networkProfileName; }
            set { this._networkProfileName = value; }
        }

        // Check to see if NetworkProfileName property is set
        internal bool IsSetNetworkProfileName()
        {
            return this._networkProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityType. 
        /// <para>
        /// The security type of the Wi-Fi network. This can be WPA2_ENTERPRISE, WPA2_PSK, WPA_PSK,
        /// WEP, or OPEN.
        /// </para>
        /// </summary>
        public NetworkSecurityType SecurityType
        {
            get { return this._securityType; }
            set { this._securityType = value; }
        }

        // Check to see if SecurityType property is set
        internal bool IsSetSecurityType()
        {
            return this._securityType != null;
        }

        /// <summary>
        /// Gets and sets the property Ssid. 
        /// <para>
        /// The SSID of the Wi-Fi network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Ssid
        {
            get { return this._ssid; }
            set { this._ssid = value; }
        }

        // Check to see if Ssid property is set
        internal bool IsSetSsid()
        {
            return this._ssid != null;
        }

    }
}