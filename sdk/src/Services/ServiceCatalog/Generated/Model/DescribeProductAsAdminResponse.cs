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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeProductAsAdmin operation.
    /// </summary>
    public partial class DescribeProductAsAdminResponse : AmazonWebServiceResponse
    {
        private List<BudgetDetail> _budgets = new List<BudgetDetail>();
        private ProductViewDetail _productViewDetail;
        private List<ProvisioningArtifactSummary> _provisioningArtifactSummaries = new List<ProvisioningArtifactSummary>();
        private List<TagOptionDetail> _tagOptions = new List<TagOptionDetail>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Budgets. 
        /// <para>
        /// Information about the associated budgets.
        /// </para>
        /// </summary>
        public List<BudgetDetail> Budgets
        {
            get { return this._budgets; }
            set { this._budgets = value; }
        }

        // Check to see if Budgets property is set
        internal bool IsSetBudgets()
        {
            return this._budgets != null && this._budgets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductViewDetail. 
        /// <para>
        /// Information about the product view.
        /// </para>
        /// </summary>
        public ProductViewDetail ProductViewDetail
        {
            get { return this._productViewDetail; }
            set { this._productViewDetail = value; }
        }

        // Check to see if ProductViewDetail property is set
        internal bool IsSetProductViewDetail()
        {
            return this._productViewDetail != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactSummaries. 
        /// <para>
        /// Information about the provisioning artifacts (also known as versions) for the specified
        /// product.
        /// </para>
        /// </summary>
        public List<ProvisioningArtifactSummary> ProvisioningArtifactSummaries
        {
            get { return this._provisioningArtifactSummaries; }
            set { this._provisioningArtifactSummaries = value; }
        }

        // Check to see if ProvisioningArtifactSummaries property is set
        internal bool IsSetProvisioningArtifactSummaries()
        {
            return this._provisioningArtifactSummaries != null && this._provisioningArtifactSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagOptions. 
        /// <para>
        /// Information about the TagOptions associated with the product.
        /// </para>
        /// </summary>
        public List<TagOptionDetail> TagOptions
        {
            get { return this._tagOptions; }
            set { this._tagOptions = value; }
        }

        // Check to see if TagOptions property is set
        internal bool IsSetTagOptions()
        {
            return this._tagOptions != null && this._tagOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tags associated with the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}