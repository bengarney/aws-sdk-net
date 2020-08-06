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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OneDriveConfiguration Object
    /// </summary>  
    public class OneDriveConfigurationUnmarshaller : IUnmarshaller<OneDriveConfiguration, XmlUnmarshallerContext>, IUnmarshaller<OneDriveConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OneDriveConfiguration IUnmarshaller<OneDriveConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OneDriveConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OneDriveConfiguration unmarshalledObject = new OneDriveConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.FieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OneDriveUsers", targetDepth))
                {
                    var unmarshaller = OneDriveUsersUnmarshaller.Instance;
                    unmarshalledObject.OneDriveUsers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TenantDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TenantDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OneDriveConfigurationUnmarshaller _instance = new OneDriveConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OneDriveConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}