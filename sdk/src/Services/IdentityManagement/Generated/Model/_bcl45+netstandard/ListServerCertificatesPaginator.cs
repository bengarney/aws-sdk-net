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
    /// Base class for ListServerCertificates paginators.
    /// </summary>
    internal sealed partial class ListServerCertificatesPaginator : IPaginator<ListServerCertificatesResponse>, IListServerCertificatesPaginator
    {
        private readonly IAmazonIdentityManagementService _client;
        private readonly ListServerCertificatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListServerCertificatesResponse> Responses => new PaginatedResponse<ListServerCertificatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ServerCertificateMetadataList
        /// </summary>
        public IPaginatedEnumerable<ServerCertificateMetadata> ServerCertificateMetadataList => 
            new PaginatedResultKeyResponse<ListServerCertificatesResponse, ServerCertificateMetadata>(this, (i) => i.ServerCertificateMetadataList);

        internal ListServerCertificatesPaginator(IAmazonIdentityManagementService client, ListServerCertificatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListServerCertificatesResponse> IPaginator<ListServerCertificatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListServerCertificatesResponse response;
            do
            {
                _request.Marker = marker;
                response = _client.ListServerCertificates(_request);
                marker = response.Marker;
                yield return response;
            }
            while (response.IsTruncated);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListServerCertificatesResponse> IPaginator<ListServerCertificatesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var marker = _request.Marker;
            ListServerCertificatesResponse response;
            do
            {
                _request.Marker = marker;
                response = await _client.ListServerCertificatesAsync(_request, cancellationToken).ConfigureAwait(false);
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