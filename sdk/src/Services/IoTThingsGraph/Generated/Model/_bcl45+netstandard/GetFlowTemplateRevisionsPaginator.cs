#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Base class for GetFlowTemplateRevisions paginators.
    /// </summary>
    internal sealed partial class GetFlowTemplateRevisionsPaginator : IPaginator<GetFlowTemplateRevisionsResponse>, IGetFlowTemplateRevisionsPaginator
    {
        private readonly IAmazonIoTThingsGraph _client;
        private readonly GetFlowTemplateRevisionsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetFlowTemplateRevisionsResponse> Responses => new PaginatedResponse<GetFlowTemplateRevisionsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Summaries
        /// </summary>
        public IPaginatedEnumerable<FlowTemplateSummary> Summaries => 
            new PaginatedResultKeyResponse<GetFlowTemplateRevisionsResponse, FlowTemplateSummary>(this, (i) => i.Summaries);

        internal GetFlowTemplateRevisionsPaginator(IAmazonIoTThingsGraph client, GetFlowTemplateRevisionsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetFlowTemplateRevisionsResponse> IPaginator<GetFlowTemplateRevisionsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            GetFlowTemplateRevisionsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.GetFlowTemplateRevisions(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetFlowTemplateRevisionsResponse> IPaginator<GetFlowTemplateRevisionsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            GetFlowTemplateRevisionsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.GetFlowTemplateRevisionsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (nextToken != null);
        }
#endif
    }
}
#endif