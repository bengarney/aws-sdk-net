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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Stack Object
    /// </summary>  
    public class StackUnmarshaller : IUnmarshaller<Stack, XmlUnmarshallerContext>, IUnmarshaller<Stack, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Stack IUnmarshaller<Stack, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Stack Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Stack unmarshalledObject = new Stack();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AgentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChefConfiguration", targetDepth))
                {
                    var unmarshaller = ChefConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ChefConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationManager", targetDepth))
                {
                    var unmarshaller = StackConfigurationManagerUnmarshaller.Instance;
                    unmarshalledObject.ConfigurationManager = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomCookbooksSource", targetDepth))
                {
                    var unmarshaller = SourceUnmarshaller.Instance;
                    unmarshalledObject.CustomCookbooksSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomJson", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomJson = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultInstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultInstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultOs", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultOs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRootDeviceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultRootDeviceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSshKeyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultSshKeyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HostnameTheme", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HostnameTheme = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseCustomCookbooks", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseCustomCookbooks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseOpsworksSecurityGroups", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseOpsworksSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StackUnmarshaller _instance = new StackUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StackUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}