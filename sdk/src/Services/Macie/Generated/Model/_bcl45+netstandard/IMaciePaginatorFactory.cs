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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */

namespace Amazon.Macie.Model
{
    /// <summary>
    /// Paginators for the Macie service
    ///</summary>
    public interface IMaciePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        ///</summary>
        IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request);

        /// <summary>
        /// Paginator for ListS3Resources operation
        ///</summary>
        IListS3ResourcesPaginator ListS3Resources(ListS3ResourcesRequest request);
    }
}
#endif