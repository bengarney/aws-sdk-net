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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Base class for DescribeLoadBalancers paginators.
    /// </summary>
    internal sealed partial class DescribeLoadBalancersPaginator : IPaginator<DescribeLoadBalancersResponse>, IDescribeLoadBalancersPaginator
    {
        private readonly IAmazonElasticLoadBalancing _client;
        private readonly DescribeLoadBalancersRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeLoadBalancersResponse> Responses => new PaginatedResponse<DescribeLoadBalancersResponse>(this);

        /// <summary>
        /// Enumerable containing all of the LoadBalancerDescriptions
        /// </summary>
        public IPaginatedEnumerable<LoadBalancerDescription> LoadBalancerDescriptions => 
            new PaginatedResultKeyResponse<DescribeLoadBalancersResponse, LoadBalancerDescription>(this, (i) => i.LoadBalancerDescriptions);

        internal DescribeLoadBalancersPaginator(IAmazonElasticLoadBalancing client, DescribeLoadBalancersRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeLoadBalancersResponse> IPaginator<DescribeLoadBalancersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            DescribeLoadBalancersResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.DescribeLoadBalancers(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (marker != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeLoadBalancersResponse> IPaginator<DescribeLoadBalancersResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            DescribeLoadBalancersResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.DescribeLoadBalancersAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.NextMarker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (marker != null);
        }
#endif
    }
}
#endif