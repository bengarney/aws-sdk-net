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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the GetSigningProfile operation.
    /// </summary>
    public partial class GetSigningProfileResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private SigningPlatformOverrides _overrides;
        private string _platformId;
        private string _profileName;
        private SigningMaterial _signingMaterial;
        private Dictionary<string, string> _signingParameters = new Dictionary<string, string>();
        private SigningProfileStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the signing profile.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of overrides applied by the target signing profile for signing operations.
        /// </para>
        /// </summary>
        public SigningPlatformOverrides Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of the platform that is used by the target signing profile.
        /// </para>
        /// </summary>
        public string PlatformId
        {
            get { return this._platformId; }
            set { this._platformId = value; }
        }

        // Check to see if PlatformId property is set
        internal bool IsSetPlatformId()
        {
            return this._platformId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the target signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property SigningMaterial. 
        /// <para>
        /// The ARN of the certificate that the target profile uses for signing operations.
        /// </para>
        /// </summary>
        public SigningMaterial SigningMaterial
        {
            get { return this._signingMaterial; }
            set { this._signingMaterial = value; }
        }

        // Check to see if SigningMaterial property is set
        internal bool IsSetSigningMaterial()
        {
            return this._signingMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property SigningParameters. 
        /// <para>
        /// A map of key-value pairs for signing operations that is attached to the target signing
        /// profile.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SigningParameters
        {
            get { return this._signingParameters; }
            set { this._signingParameters = value; }
        }

        // Check to see if SigningParameters property is set
        internal bool IsSetSigningParameters()
        {
            return this._signingParameters != null && this._signingParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target signing profile.
        /// </para>
        /// </summary>
        public SigningProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}