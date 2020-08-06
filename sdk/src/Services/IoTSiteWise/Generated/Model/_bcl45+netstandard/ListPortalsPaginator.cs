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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Base class for ListPortals paginators.
    /// </summary>
    internal sealed partial class ListPortalsPaginator : IPaginator<ListPortalsResponse>, IListPortalsPaginator
    {
        private readonly IAmazonIoTSiteWise _client;
        private readonly ListPortalsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListPortalsResponse> Responses => new PaginatedResponse<ListPortalsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the PortalSummaries
        /// </summary>
        public IPaginatedEnumerable<PortalSummary> PortalSummaries => 
            new PaginatedResultKeyResponse<ListPortalsResponse, PortalSummary>(this, (i) => i.PortalSummaries);

        internal ListPortalsPaginator(IAmazonIoTSiteWise client, ListPortalsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListPortalsResponse> IPaginator<ListPortalsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListPortalsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListPortals(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListPortalsResponse> IPaginator<ListPortalsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListPortalsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListPortalsAsync(_request, cancellationToken).ConfigureAwait(false);
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