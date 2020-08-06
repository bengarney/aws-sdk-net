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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChannelStorageSummary Object
    /// </summary>  
    public class ChannelStorageSummaryUnmarshaller : IUnmarshaller<ChannelStorageSummary, XmlUnmarshallerContext>, IUnmarshaller<ChannelStorageSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ChannelStorageSummary IUnmarshaller<ChannelStorageSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ChannelStorageSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ChannelStorageSummary unmarshalledObject = new ChannelStorageSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("customerManagedS3", targetDepth))
                {
                    var unmarshaller = CustomerManagedChannelS3StorageSummaryUnmarshaller.Instance;
                    unmarshalledObject.CustomerManagedS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceManagedS3", targetDepth))
                {
                    var unmarshaller = ServiceManagedChannelS3StorageSummaryUnmarshaller.Instance;
                    unmarshalledObject.ServiceManagedS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ChannelStorageSummaryUnmarshaller _instance = new ChannelStorageSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChannelStorageSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}