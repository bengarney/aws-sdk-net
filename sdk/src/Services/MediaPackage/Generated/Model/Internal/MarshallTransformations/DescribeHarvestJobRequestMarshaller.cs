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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeHarvestJob Request Marshaller
    /// </summary>       
    public class DescribeHarvestJobRequestMarshaller : IMarshaller<IRequest, DescribeHarvestJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeHarvestJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeHarvestJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackage");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-12";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetId())
                throw new AmazonMediaPackageException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/harvest_jobs/{id}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeHarvestJobRequestMarshaller _instance = new DescribeHarvestJobRequestMarshaller();        

        internal static DescribeHarvestJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeHarvestJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}