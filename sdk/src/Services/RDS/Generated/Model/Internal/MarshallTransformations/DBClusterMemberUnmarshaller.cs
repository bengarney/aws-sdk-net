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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBClusterMember Object
    /// </summary>  
    public class DBClusterMemberUnmarshaller : IUnmarshaller<DBClusterMember, XmlUnmarshallerContext>, IUnmarshaller<DBClusterMember, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBClusterMember Unmarshall(XmlUnmarshallerContext context)
        {
            DBClusterMember unmarshalledObject = new DBClusterMember();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBClusterParameterGroupStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBClusterParameterGroupStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsClusterWriter", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.IsClusterWriter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PromotionTier", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.PromotionTier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBClusterMember Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static DBClusterMemberUnmarshaller _instance = new DBClusterMemberUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBClusterMemberUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}