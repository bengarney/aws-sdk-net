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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Base class for ListDomainConfigurations paginators.
    /// </summary>
    internal sealed partial class ListDomainConfigurationsPaginator : IPaginator<ListDomainConfigurationsResponse>, IListDomainConfigurationsPaginator
    {
        private readonly IAmazonIoT _client;
        private readonly ListDomainConfigurationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListDomainConfigurationsResponse> Responses => new PaginatedResponse<ListDomainConfigurationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the DomainConfigurations
        /// </summary>
        public IPaginatedEnumerable<DomainConfigurationSummary> DomainConfigurations => 
            new PaginatedResultKeyResponse<ListDomainConfigurationsResponse, DomainConfigurationSummary>(this, (i) => i.DomainConfigurations);

        internal ListDomainConfigurationsPaginator(IAmazonIoT client, ListDomainConfigurationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListDomainConfigurationsResponse> IPaginator<ListDomainConfigurationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListDomainConfigurationsResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListDomainConfigurations(_request);
                marker = response.NextMarker;
                yield return response;
            }
            while (marker != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListDomainConfigurationsResponse> IPaginator<ListDomainConfigurationsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListDomainConfigurationsResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListDomainConfigurationsAsync(_request, cancellationToken).ConfigureAwait(false);
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