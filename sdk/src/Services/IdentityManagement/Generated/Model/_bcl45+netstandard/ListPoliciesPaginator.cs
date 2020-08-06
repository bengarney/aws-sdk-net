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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Base class for ListPolicies paginators.
    /// </summary>
    internal sealed partial class ListPoliciesPaginator : IPaginator<ListPoliciesResponse>, IListPoliciesPaginator
    {
        private readonly IAmazonIdentityManagementService _client;
        private readonly ListPoliciesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListPoliciesResponse> Responses => new PaginatedResponse<ListPoliciesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Policies
        /// </summary>
        public IPaginatedEnumerable<ManagedPolicy> Policies => 
            new PaginatedResultKeyResponse<ListPoliciesResponse, ManagedPolicy>(this, (i) => i.Policies);

        internal ListPoliciesPaginator(IAmazonIdentityManagementService client, ListPoliciesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListPoliciesResponse> IPaginator<ListPoliciesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListPoliciesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListPolicies(_request);
                marker = response.Marker;
                yield return response;
            }
            while (response.IsTruncated);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListPoliciesResponse> IPaginator<ListPoliciesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListPoliciesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListPoliciesAsync(_request, cancellationToken).ConfigureAwait(false);
                marker = response.Marker;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (response.IsTruncated);
        }
#endif
    }
}
#endif