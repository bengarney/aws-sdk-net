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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CertificateManager.Model;
using Amazon.CertificateManager.Model.Internal.MarshallTransformations;
using Amazon.CertificateManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CertificateManager
{
    /// <summary>
    /// Implementation for accessing CertificateManager
    ///
    /// AWS Certificate Manager 
    /// <para>
    /// Welcome to the AWS Certificate Manager (ACM) API documentation.
    /// </para>
    ///  
    /// <para>
    /// You can use ACM to manage SSL/TLS certificates for your AWS-based websites and applications.
    /// For general information about using ACM, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">
    /// <i>AWS Certificate Manager User Guide</i> </a>.
    /// </para>
    /// </summary>
    public partial class AmazonCertificateManagerClient : AmazonServiceClient, IAmazonCertificateManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonCertificateManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCertificateManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AmazonCertificateManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials and an
        /// AmazonCertificateManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, AmazonCertificateManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICertificateManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICertificateManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CertificateManagerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddTagsToCertificate

        internal virtual AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return Invoke<AddTagsToCertificateResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a <code>key</code> and an optional
        /// <code>value</code>. You specify the certificate on input by its Amazon Resource Name
        /// (ARN). You specify the tag by using a key-value pair. 
        /// 
        ///  
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM certificates</a>. 
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        public virtual Task<AddTagsToCertificateResponse> AddTagsToCertificateAsync(AddTagsToCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate

        internal virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by AWS services integrated with ACM. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by AWS services integrated with ACM. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificate

        internal virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportCertificate

        internal virtual ExportCertificateResponse ExportCertificate(ExportCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return Invoke<ExportCertificateResponse>(request, options);
        }



        /// <summary>
        /// Exports a private certificate issued by a private certificate authority (CA) for use
        /// anywhere. The exported file contains the certificate, the certificate chain, and the
        /// encrypted private 2048-bit RSA key associated with the public key that is embedded
        /// in the certificate. For security, you must assign a passphrase for the private key
        /// when exporting it. 
        /// 
        ///  
        /// <para>
        /// For information about exporting and formatting a certificate using the ACM console
        /// or CLI, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-export-private.html">Export
        /// a Private Certificate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        public virtual Task<ExportCertificateResponse> ExportCertificateAsync(ExportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ExportCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCertificate

        internal virtual GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an Amazon-issued certificate and its certificate chain. The chain consists
        /// of the certificate of the issuing CA and the intermediate certificates of any other
        /// subordinate CAs. All of the certificates are base64 encoded. You can use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Retrieves an Amazon-issued certificate and its certificate chain. The chain consists
        /// of the certificate of the issuing CA and the intermediate certificates of any other
        /// subordinate CAs. All of the certificates are base64 encoded. You can use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportCertificate

        internal virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }



        /// <summary>
        /// Imports a certificate into AWS Certificate Manager (ACM) to use with services that
        /// are integrated with ACM. Note that <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
        /// services</a> allow only certificate types and keys they support to be associated with
        /// their resources. Further, their support differs depending on whether the certificate
        /// is imported into IAM or into ACM. For more information, see the documentation for
        /// each service. For more information about importing certificates into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// Note the following guidelines when importing third party certificates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must enter the private key that matches the certificate you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be unencrypted. You cannot import a private key that is protected
        /// by a password or a passphrase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the certificate you are importing is not self-signed, you must enter its certificate
        /// chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a certificate chain is included, the issuer must be the subject of one of the certificates
        /// in the chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current time must be between the <code>Not Before</code> and <code>Not After</code>
        /// certificate fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Issuer</code> field must not be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The OCSP authority URL, if present, must not exceed 1000 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To import a new certificate, omit the <code>CertificateArn</code> argument. Include
        /// this argument only when you want to replace a previously imported certifica
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using the CLI, you must specify the certificate,
        /// the certificate chain, and the private key by their file names preceded by <code>file://</code>.
        /// For example, you can specify a certificate saved in the <code>C:\temp</code> folder
        /// as <code>file://C:\temp\certificate_to_import.pem</code>. If you are making an HTTP
        /// or HTTPS Query request, include these arguments as BLOBs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using an SDK, you must specify the certificate, the
        /// certificate chain, and the private key files in the manner required by the programming
        /// language you're using. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cryptographic algorithm of an imported certificate must match the algorithm of
        /// the signing CA. For example, if the signing CA key type is RSA, then the certificate
        /// key type must also be RSA.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificates

        internal virtual ListCertificatesResponse ListCertificates()
        {
            return ListCertificates(new ListCertificatesRequest());
        }
        internal virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <code>RSA_2048</code> certificates.
        /// For more information, see <a>Filters</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of of request parameters specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCertificatesAsync(new ListCertificatesRequest(), cancellationToken);
        }



        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <code>RSA_2048</code> certificates.
        /// For more information, see <a>Filters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of of request parameters specified is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForCertificate

        internal virtual ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return Invoke<ListTagsForCertificateResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags that have been applied to the ACM certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        public virtual Task<ListTagsForCertificateResponse> ListTagsForCertificateAsync(ListTagsForCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromCertificate

        internal virtual RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromCertificateResponse>(request, options);
        }



        /// <summary>
        /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. 
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        public virtual Task<RemoveTagsFromCertificateResponse> RemoveTagsFromCertificateAsync(RemoveTagsFromCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenewCertificate

        internal virtual RenewCertificateResponse RenewCertificate(RenewCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewCertificateResponseUnmarshaller.Instance;

            return Invoke<RenewCertificateResponse>(request, options);
        }



        /// <summary>
        /// Renews an eligable ACM certificate. At this time, only exported private certificates
        /// can be renewed with this operation. In order to renew your ACM PCA certificates with
        /// ACM, you must first <a href="https://docs.aws.amazon.com/acm-pca/latest/userguide/PcaPermissions.html">grant
        /// the ACM service principal permission to do so</a>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/manual-renewal.html">Testing
        /// Managed Renewal</a> in the ACM User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenewCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RenewCertificate">REST API Reference for RenewCertificate Operation</seealso>
        public virtual Task<RenewCertificateResponse> RenewCertificateAsync(RenewCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RenewCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestCertificate

        internal virtual RequestCertificateResponse RequestCertificate(RequestCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return Invoke<RequestCertificateResponse>(request, options);
        }


        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
        /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
        /// after receiving approval from the domain owner. 
        /// </para>
        /// </summary>
        /// <param name="domainName"> Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.   The first domain name you enter cannot exceed 64 octets, including periods. Each subsequent Subject Alternative Name (SAN), however, can be up to 253 octets in length. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
        /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
        /// after receiving approval from the domain owner. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(RequestCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RequestCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResendValidationEmail

        internal virtual ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendValidationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return Invoke<ResendValidationEmailResponse>(request, options);
        }



        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// For more information about setting up your contact email addresses, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/setup-email.html">Configure
        /// Email for your Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        public virtual Task<ResendValidationEmailResponse> ResendValidationEmailAsync(ResendValidationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendValidationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendValidationEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCertificateOptions

        internal virtual UpdateCertificateOptionsResponse UpdateCertificateOptions(UpdateCertificateOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateOptionsResponse>(request, options);
        }



        /// <summary>
        /// Updates a certificate. Currently, you can use this function to specify whether to
        /// opt in to or out of recording your certificate in a certificate transparency log.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">
        /// Opting Out of Certificate Transparency Logging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificateOptions service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        public virtual Task<UpdateCertificateOptionsResponse> UpdateCertificateOptionsAsync(UpdateCertificateOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCertificateOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}