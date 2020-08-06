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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SavingsPlansUtilizationAggregates Object
    /// </summary>  
    public class SavingsPlansUtilizationAggregatesUnmarshaller : IUnmarshaller<SavingsPlansUtilizationAggregates, XmlUnmarshallerContext>, IUnmarshaller<SavingsPlansUtilizationAggregates, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SavingsPlansUtilizationAggregates IUnmarshaller<SavingsPlansUtilizationAggregates, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SavingsPlansUtilizationAggregates Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SavingsPlansUtilizationAggregates unmarshalledObject = new SavingsPlansUtilizationAggregates();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmortizedCommitment", targetDepth))
                {
                    var unmarshaller = SavingsPlansAmortizedCommitmentUnmarshaller.Instance;
                    unmarshalledObject.AmortizedCommitment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Savings", targetDepth))
                {
                    var unmarshaller = SavingsPlansSavingsUnmarshaller.Instance;
                    unmarshalledObject.Savings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Utilization", targetDepth))
                {
                    var unmarshaller = SavingsPlansUtilizationUnmarshaller.Instance;
                    unmarshalledObject.Utilization = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SavingsPlansUtilizationAggregatesUnmarshaller _instance = new SavingsPlansUtilizationAggregatesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlansUtilizationAggregatesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}