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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteOutboundCrossClusterSearchConnection Request Marshaller
    /// </summary>       
    public class DeleteOutboundCrossClusterSearchConnectionRequestMarshaller : IMarshaller<IRequest, DeleteOutboundCrossClusterSearchConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteOutboundCrossClusterSearchConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteOutboundCrossClusterSearchConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Elasticsearch");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-01-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetCrossClusterSearchConnectionId())
                throw new AmazonElasticsearchException("Request object does not have required field CrossClusterSearchConnectionId set");
            request.AddPathResource("{ConnectionId}", StringUtils.FromString(publicRequest.CrossClusterSearchConnectionId));
            request.ResourcePath = "/2015-01-01/es/ccs/outboundConnection/{ConnectionId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteOutboundCrossClusterSearchConnectionRequestMarshaller _instance = new DeleteOutboundCrossClusterSearchConnectionRequestMarshaller();        

        internal static DeleteOutboundCrossClusterSearchConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteOutboundCrossClusterSearchConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}