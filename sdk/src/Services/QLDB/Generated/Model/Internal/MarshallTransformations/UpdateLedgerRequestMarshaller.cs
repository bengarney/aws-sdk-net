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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QLDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLedger Request Marshaller
    /// </summary>       
    public class UpdateLedgerRequestMarshaller : IMarshaller<IRequest, UpdateLedgerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLedgerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLedgerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QLDB");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-02";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetName())
                throw new AmazonQLDBException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/ledgers/{name}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeletionProtection())
                {
                    context.Writer.WritePropertyName("DeletionProtection");
                    context.Writer.Write(publicRequest.DeletionProtection);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLedgerRequestMarshaller _instance = new UpdateLedgerRequestMarshaller();        

        internal static UpdateLedgerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLedgerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}