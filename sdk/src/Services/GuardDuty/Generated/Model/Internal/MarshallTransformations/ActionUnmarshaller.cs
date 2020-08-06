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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Action Object
    /// </summary>  
    public class ActionUnmarshaller : IUnmarshaller<Action, XmlUnmarshallerContext>, IUnmarshaller<Action, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Action IUnmarshaller<Action, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Action Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Action unmarshalledObject = new Action();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsApiCallAction", targetDepth))
                {
                    var unmarshaller = AwsApiCallActionUnmarshaller.Instance;
                    unmarshalledObject.AwsApiCallAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsRequestAction", targetDepth))
                {
                    var unmarshaller = DnsRequestActionUnmarshaller.Instance;
                    unmarshalledObject.DnsRequestAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkConnectionAction", targetDepth))
                {
                    var unmarshaller = NetworkConnectionActionUnmarshaller.Instance;
                    unmarshalledObject.NetworkConnectionAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portProbeAction", targetDepth))
                {
                    var unmarshaller = PortProbeActionUnmarshaller.Instance;
                    unmarshalledObject.PortProbeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionUnmarshaller _instance = new ActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}