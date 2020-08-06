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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRemediationExceptions Request Marshaller
    /// </summary>       
    public class PutRemediationExceptionsRequestMarshaller : IMarshaller<IRequest, PutRemediationExceptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRemediationExceptionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRemediationExceptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.PutRemediationExceptions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigRuleName())
                {
                    context.Writer.WritePropertyName("ConfigRuleName");
                    context.Writer.Write(publicRequest.ConfigRuleName);
                }

                if(publicRequest.IsSetExpirationTime())
                {
                    context.Writer.WritePropertyName("ExpirationTime");
                    context.Writer.Write(publicRequest.ExpirationTime);
                }

                if(publicRequest.IsSetMessage())
                {
                    context.Writer.WritePropertyName("Message");
                    context.Writer.Write(publicRequest.Message);
                }

                if(publicRequest.IsSetResourceKeys())
                {
                    context.Writer.WritePropertyName("ResourceKeys");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceKeysListValue in publicRequest.ResourceKeys)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RemediationExceptionResourceKeyMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourceKeysListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutRemediationExceptionsRequestMarshaller _instance = new PutRemediationExceptionsRequestMarshaller();        

        internal static PutRemediationExceptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRemediationExceptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}