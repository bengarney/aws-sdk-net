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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchAssociateApprovalRuleTemplateWithRepositories Request Marshaller
    /// </summary>       
    public class BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller : IMarshaller<IRequest, BatchAssociateApprovalRuleTemplateWithRepositoriesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchAssociateApprovalRuleTemplateWithRepositoriesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchAssociateApprovalRuleTemplateWithRepositoriesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.BatchAssociateApprovalRuleTemplateWithRepositories";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-13";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApprovalRuleTemplateName())
                {
                    context.Writer.WritePropertyName("approvalRuleTemplateName");
                    context.Writer.Write(publicRequest.ApprovalRuleTemplateName);
                }

                if(publicRequest.IsSetRepositoryNames())
                {
                    context.Writer.WritePropertyName("repositoryNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRepositoryNamesListValue in publicRequest.RepositoryNames)
                    {
                            context.Writer.Write(publicRequestRepositoryNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller _instance = new BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller();        

        internal static BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}