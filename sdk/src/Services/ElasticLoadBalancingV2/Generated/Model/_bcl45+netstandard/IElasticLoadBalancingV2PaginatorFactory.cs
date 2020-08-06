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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Paginators for the ElasticLoadBalancingV2 service
    ///</summary>
    public interface IElasticLoadBalancingV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeListeners operation
        ///</summary>
        IDescribeListenersPaginator DescribeListeners(DescribeListenersRequest request);

        /// <summary>
        /// Paginator for DescribeLoadBalancers operation
        ///</summary>
        IDescribeLoadBalancersPaginator DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Paginator for DescribeTargetGroups operation
        ///</summary>
        IDescribeTargetGroupsPaginator DescribeTargetGroups(DescribeTargetGroupsRequest request);
    }
}
#endif