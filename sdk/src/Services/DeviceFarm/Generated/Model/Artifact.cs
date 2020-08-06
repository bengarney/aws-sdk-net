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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the output of a test. Examples of artifacts include logs and screenshots.
    /// </summary>
    public partial class Artifact
    {
        private string _arn;
        private string _extension;
        private string _name;
        private ArtifactType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The artifact's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
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
        /// Gets and sets the property Extension. 
        /// <para>
        /// The artifact's file extension.
        /// </para>
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        // Check to see if Extension property is set
        internal bool IsSetExtension()
        {
            return this._extension != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The artifact's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The artifact's type.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// UNKNOWN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCREENSHOT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEVICE_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MESSAGE_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VIDEO_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RESULT_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WEBKIT_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXERCISER_MONKEY_OUTPUT: the artifact (log) generated by an Android fuzz test.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH_JSON_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH_PRETTY_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH_STANDARD_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH_JAVA_XML_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AUTOMATION_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_SERVER_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_XML_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON_XML_OUTPUT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXPLORER_EVENT_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXPLORER_SUMMARY_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPLICATION_CRASH_REPORT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VIDEO
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUSTOMER_ARTIFACT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUSTOMER_ARTIFACT_LOG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TESTSPEC_OUTPUT
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ArtifactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned Amazon S3 URL that can be used with a GET request to download the artifact's
        /// file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}