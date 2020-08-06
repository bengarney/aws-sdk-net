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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Kinesis.Model;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Kinesis.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Implementation for accessing Kinesis
    ///
    /// Amazon Kinesis Data Streams Service API Reference 
    /// <para>
    /// Amazon Kinesis Data Streams is a managed service that scales elastically for real-time
    /// processing of streaming big data.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AmazonKinesisConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials and an
        /// AmazonKinesisClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

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


        #region  AddTagsToStream

        /// <summary>
        /// Adds or updates tags for the specified Kinesis data stream. Each time you invoke this
        /// operation, you can specify up to 10 tags. If you want to add more than 10 tags to
        /// your stream, you can invoke this operation multiple times. In total, each stream can
        /// have up to 50 tags.
        /// 
        ///  
        /// <para>
        /// If tags have already been assigned to the stream, <code>AddTagsToStream</code> overwrites
        /// any existing tags that correspond to the specified tag keys.
        /// </para>
        ///  
        /// <para>
        ///  <a>AddTagsToStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream service method.</param>
        /// 
        /// <returns>The response from the AddTagsToStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return Invoke<AddTagsToStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToStream(AddTagsToStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToStream.</param>
        /// 
        /// <returns>Returns a  AddTagsToStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        public virtual AddTagsToStreamResponse EndAddTagsToStream(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStream

        /// <summary>
        /// Creates a Kinesis data stream. A stream captures and transports data records that
        /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
        /// within a stream is explicitly supported by means of shards, which are uniquely identified
        /// groups of data records in a stream.
        /// 
        ///  
        /// <para>
        /// You specify and control the number of shards that a stream is composed of. Each shard
        /// can support reads up to five transactions per second, up to a maximum data read total
        /// of 2 MiB per second. Each shard can support writes up to 1,000 records per second,
        /// up to a maximum data write total of 1 MiB per second. If the amount of data input
        /// increases or decreases, you can add or remove shards.
        /// </para>
        ///  
        /// <para>
        /// The stream name identifies the stream. The name is scoped to the AWS account used
        /// by the application. It is also scoped by AWS Region. That is, two streams in two different
        /// accounts can have the same name, and two streams in the same account, but in two different
        /// Regions, can have the same name.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateStream</code> is an asynchronous operation. Upon receiving a <code>CreateStream</code>
        /// request, Kinesis Data Streams immediately returns and sets the stream status to <code>CREATING</code>.
        /// After the stream is created, Kinesis Data Streams sets the stream status to <code>ACTIVE</code>.
        /// You should perform read and write operations only on an <code>ACTIVE</code> stream.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You receive a <code>LimitExceededException</code> when making a <code>CreateStream</code>
        /// request when you try to do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Have more than five streams in the <code>CREATING</code> state at any point in time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create more shards than are authorized for your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default shard limit for an AWS account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// AWS Support</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use <code>DescribeStream</code> to check the stream status, which is returned
        /// in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual IAsyncResult BeginCreateStream(CreateStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStream.</param>
        /// 
        /// <returns>Returns a  CreateStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse EndCreateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DecreaseStreamRetentionPeriod

        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be less than the current retention period.</param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(string streamName, int retentionPeriodHours)
        {
            var request = new DecreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return DecreaseStreamRetentionPeriod(request);
        }


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<DecreaseStreamRetentionPeriodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecreaseStreamRetentionPeriod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual IAsyncResult BeginDecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DecreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecreaseStreamRetentionPeriod.</param>
        /// 
        /// <returns>Returns a  DecreaseStreamRetentionPeriodResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        public virtual DecreaseStreamRetentionPeriodResponse EndDecreaseStreamRetentionPeriod(IAsyncResult asyncResult)
        {
            return EndInvoke<DecreaseStreamRetentionPeriodResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStream

        /// <summary>
        /// Deletes a Kinesis data stream and all its shards and data. You must shut down any
        /// applications that are operating on the stream before you delete the stream. If an
        /// application attempts to operate on a deleted stream, it receives the exception <code>ResourceNotFoundException</code>.
        /// 
        ///  
        /// <para>
        /// If the stream is in the <code>ACTIVE</code> state, you can delete it. After a <code>DeleteStream</code>
        /// request, the specified stream is in the <code>DELETING</code> state until Kinesis
        /// Data Streams completes the deletion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Kinesis Data Streams might continue to accept data read and write operations,
        /// such as <a>PutRecord</a>, <a>PutRecords</a>, and <a>GetRecords</a>, on a stream in
        /// the <code>DELETING</code> state until the stream deletion is complete.
        /// </para>
        ///  
        /// <para>
        /// When you delete a stream, any shards in that stream are also deleted, and any tags
        /// are dissociated from the stream.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>DescribeStream</a> operation to check the state of the stream,
        /// which is returned in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        ///  <a>DeleteStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteStream(DeleteStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStream.</param>
        /// 
        /// <returns>Returns a  DeleteStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual DeleteStreamResponse EndDeleteStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterStreamConsumer

        /// <summary>
        /// To deregister a consumer, provide its ARN. Alternatively, you can provide the ARN
        /// of the data stream and the name you gave the consumer when you registered it. You
        /// may also provide all three parameters, as long as they don't conflict with each other.
        /// If you don't know the name or ARN of the consumer that you want to deregister, you
        /// can use the <a>ListStreamConsumers</a> operation to get a list of the descriptions
        /// of all the consumers that are currently registered with a given data stream. The description
        /// of a consumer contains its name and ARN.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the DeregisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual DeregisterStreamConsumerResponse DeregisterStreamConsumer(DeregisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DeregisterStreamConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterStreamConsumer operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterStreamConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual IAsyncResult BeginDeregisterStreamConsumer(DeregisterStreamConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterStreamConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterStreamConsumer.</param>
        /// 
        /// <returns>Returns a  DeregisterStreamConsumerResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeregisterStreamConsumer">REST API Reference for DeregisterStreamConsumer Operation</seealso>
        public virtual DeregisterStreamConsumerResponse EndDeregisterStreamConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterStreamConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLimits

        /// <summary>
        /// Describes the shard limits and usage for the account.
        /// 
        ///  
        /// <para>
        /// If you update your account limits, the old limits might be returned for a few minutes.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of one transaction per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeLimits service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeLimits(DescribeLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLimits.</param>
        /// 
        /// <returns>Returns a  DescribeLimitsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual DescribeLimitsResponse EndDescribeLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStream

        /// <summary>
        /// Describes the specified Kinesis data stream.
        /// 
        ///  
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), creation
        /// time, enhanced metric configuration, and shard map. The shard map is an array of shard
        /// objects. For each shard object, there is the hash key and sequence number ranges that
        /// the shard spans, and the IDs of any earlier shards that played in a role in creating
        /// the shard. Every record ingested in the stream is identified by a sequence number,
        /// which is assigned when the record is put into the stream.
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of shards returned by each call. For more information, see
        /// <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-retrieve-shards.html">Retrieving
        /// Shards from a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// There are no guarantees about the chronological order shards returned. To process
        /// shards in chronological order, use the ID of the parent shard to track the lineage
        /// to the oldest shard.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of 10 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual IAsyncResult BeginDescribeStream(DescribeStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStream.</param>
        /// 
        /// <returns>Returns a  DescribeStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual DescribeStreamResponse EndDescribeStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStreamConsumer

        /// <summary>
        /// To get the description of a registered consumer, provide the ARN of the consumer.
        /// Alternatively, you can provide the ARN of the data stream and the name you gave the
        /// consumer when you registered it. You may also provide all three parameters, as long
        /// as they don't conflict with each other. If you don't know the name or ARN of the consumer
        /// that you want to describe, you can use the <a>ListStreamConsumers</a> operation to
        /// get a list of the descriptions of all the consumers that are currently registered
        /// with a given data stream.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 20 transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual DescribeStreamConsumerResponse DescribeStreamConsumer(DescribeStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamConsumer operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStreamConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual IAsyncResult BeginDescribeStreamConsumer(DescribeStreamConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStreamConsumer.</param>
        /// 
        /// <returns>Returns a  DescribeStreamConsumerResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamConsumer">REST API Reference for DescribeStreamConsumer Operation</seealso>
        public virtual DescribeStreamConsumerResponse EndDescribeStreamConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStreamSummary

        /// <summary>
        /// Provides a summarized description of the specified Kinesis data stream without the
        /// shard list.
        /// 
        ///  
        /// <para>
        /// The information returned includes the stream name, Amazon Resource Name (ARN), status,
        /// record retention period, approximate creation time, monitoring, encryption details,
        /// and open shard count. 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeStreamSummary</a> has a limit of 20 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamSummary service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual DescribeStreamSummaryResponse DescribeStreamSummary(DescribeStreamSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStreamSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual IAsyncResult BeginDescribeStreamSummary(DescribeStreamSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStreamSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStreamSummary.</param>
        /// 
        /// <returns>Returns a  DescribeStreamSummaryResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        public virtual DescribeStreamSummaryResponse EndDescribeStreamSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableEnhancedMonitoring

        /// <summary>
        /// Disables enhanced monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring service method.</param>
        /// 
        /// <returns>The response from the DisableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual DisableEnhancedMonitoringResponse DisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<DisableEnhancedMonitoringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableEnhancedMonitoring
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual IAsyncResult BeginDisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableEnhancedMonitoringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableEnhancedMonitoring.</param>
        /// 
        /// <returns>Returns a  DisableEnhancedMonitoringResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        public virtual DisableEnhancedMonitoringResponse EndDisableEnhancedMonitoring(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableEnhancedMonitoringResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableEnhancedMonitoring

        /// <summary>
        /// Enables enhanced Kinesis data stream monitoring for shard-level metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring service method.</param>
        /// 
        /// <returns>The response from the EnableEnhancedMonitoring service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual EnableEnhancedMonitoringResponse EnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;

            return Invoke<EnableEnhancedMonitoringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableEnhancedMonitoring
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual IAsyncResult BeginEnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableEnhancedMonitoringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableEnhancedMonitoringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableEnhancedMonitoring.</param>
        /// 
        /// <returns>Returns a  EnableEnhancedMonitoringResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        public virtual EnableEnhancedMonitoringResponse EndEnableEnhancedMonitoring(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableEnhancedMonitoringResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecords

        /// <summary>
        /// Gets data records from a Kinesis data stream's shard.
        /// 
        ///  
        /// <para>
        /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
        /// iterator specifies the position in the shard from which you want to start reading
        /// data records sequentially. If there are no records available in the portion of the
        /// shard that the iterator points to, <a>GetRecords</a> returns an empty list. It might
        /// take multiple calls to get to a portion of the shard that contains records.
        /// </para>
        ///  
        /// <para>
        /// You can scale by provisioning multiple shards per stream while considering service
        /// limits (for more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
        /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// Your application should have one thread per shard, each reading continuously from
        /// its stream. To read from a stream continually, call <a>GetRecords</a> in a loop. Use
        /// <a>GetShardIterator</a> to get the shard iterator to specify in the first <a>GetRecords</a>
        /// call. <a>GetRecords</a> returns a new shard iterator in <code>NextShardIterator</code>.
        /// Specify the shard iterator returned in <code>NextShardIterator</code> in subsequent
        /// calls to <a>GetRecords</a>. If the shard has been closed, the shard iterator can't
        /// return more data and <a>GetRecords</a> returns <code>null</code> in <code>NextShardIterator</code>.
        /// You can terminate the loop when the shard is closed, or when the shard iterator reaches
        /// the record with the sequence number or other attribute that marks it as the last record
        /// to process.
        /// </para>
        ///  
        /// <para>
        /// Each data record can be up to 1 MiB in size, and each shard can read up to 2 MiB per
        /// second. You can ensure that your calls don't exceed the maximum supported size or
        /// throughput by using the <code>Limit</code> parameter to specify the maximum number
        /// of records that <a>GetRecords</a> can return. Consider your average record size when
        /// determining this limit. The maximum number of records that can be returned per call
        /// is 10,000.
        /// </para>
        ///  
        /// <para>
        /// The size of the data returned by <a>GetRecords</a> varies depending on the utilization
        /// of the shard. The maximum size of data that <a>GetRecords</a> can return is 10 MiB.
        /// If a call returns this amount of data, subsequent calls made within the next 5 seconds
        /// throw <code>ProvisionedThroughputExceededException</code>. If there is insufficient
        /// provisioned throughput on the stream, subsequent calls made within the next 1 second
        /// throw <code>ProvisionedThroughputExceededException</code>. <a>GetRecords</a> doesn't
        /// return any data when it throws an exception. For this reason, we recommend that you
        /// wait 1 second between calls to <a>GetRecords</a>. However, it's possible that the
        /// application will get exceptions for longer than 1 second.
        /// </para>
        ///  
        /// <para>
        /// To detect whether the application is falling behind in processing, you can use the
        /// <code>MillisBehindLatest</code> response attribute. You can also monitor the stream
        /// using CloudWatch metrics and other mechanisms (see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring.html">Monitoring</a>
        /// in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Kinesis record includes a value, <code>ApproximateArrivalTimestamp</code>,
        /// that is set when a stream successfully receives and stores a record. This is commonly
        /// referred to as a server-side time stamp, whereas a client-side time stamp is set when
        /// a data producer creates or sends the record to a stream (a data producer is any data
        /// source putting data records into a stream, for example with <a>PutRecords</a>). The
        /// time stamp has millisecond precision. There are no guarantees about the time stamp
        /// accuracy, or that the time stamp is always increasing. For example, records in a shard
        /// or across a stream might have time stamps that are out of order.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredIteratorException">
        /// The provided iterator exceeds the maximum age allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The AWS access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return Invoke<GetRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual IAsyncResult BeginGetRecords(GetRecordsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecords.</param>
        /// 
        /// <returns>Returns a  GetRecordsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        public virtual GetRecordsResponse EndGetRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetShardIterator

        /// <summary>
        /// Gets an Amazon Kinesis shard iterator. A shard iterator expires 5 minutes after it
        /// is returned to the requester.
        /// 
        ///  
        /// <para>
        /// A shard iterator specifies the shard position from which to start reading data records
        /// sequentially. The position is specified using the sequence number of a data record
        /// in a shard. A sequence number is the identifier associated with every record ingested
        /// in the stream, and is assigned when a record is put into the stream. Each stream has
        /// one or more shards.
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard iterator type. For example, you can set the <code>ShardIteratorType</code>
        /// parameter to read exactly from the position denoted by a specific sequence number
        /// by using the <code>AT_SEQUENCE_NUMBER</code> shard iterator type. Alternatively, the
        /// parameter can read right after the sequence number by using the <code>AFTER_SEQUENCE_NUMBER</code>
        /// shard iterator type, using sequence numbers returned by earlier calls to <a>PutRecord</a>,
        /// <a>PutRecords</a>, <a>GetRecords</a>, or <a>DescribeStream</a>. In the request, you
        /// can specify the shard iterator type <code>AT_TIMESTAMP</code> to read records from
        /// an arbitrary point in time, <code>TRIM_HORIZON</code> to cause <code>ShardIterator</code>
        /// to point to the last untrimmed record in the shard in the system (the oldest data
        /// record in the shard), or <code>LATEST</code> so that you always read the most recent
        /// data in the shard. 
        /// </para>
        ///  
        /// <para>
        /// When you read repeatedly from a stream, use a <a>GetShardIterator</a> request to get
        /// the first shard iterator for use in your first <a>GetRecords</a> request and for subsequent
        /// reads use the shard iterator returned by the <a>GetRecords</a> request in <code>NextShardIterator</code>.
        /// A new shard iterator is returned by every <a>GetRecords</a> request in <code>NextShardIterator</code>,
        /// which you use in the <code>ShardIterator</code> parameter of the next <a>GetRecords</a>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// If a <a>GetShardIterator</a> request is made too often, you receive a <code>ProvisionedThroughputExceededException</code>.
        /// For more information about throughput limits, see <a>GetRecords</a>, and <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the shard is closed, <a>GetShardIterator</a> returns a valid iterator for the last
        /// sequence number of the shard. A shard can be closed as a result of using <a>SplitShard</a>
        /// or <a>MergeShards</a>.
        /// </para>
        ///  
        /// <para>
        ///  <a>GetShardIterator</a> has a limit of five transactions per second per account per
        /// open shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return Invoke<GetShardIteratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetShardIterator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual IAsyncResult BeginGetShardIterator(GetShardIteratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetShardIterator.</param>
        /// 
        /// <returns>Returns a  GetShardIteratorResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        public virtual GetShardIteratorResponse EndGetShardIterator(IAsyncResult asyncResult)
        {
            return EndInvoke<GetShardIteratorResponse>(asyncResult);
        }

        #endregion
        
        #region  IncreaseStreamRetentionPeriod

        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 168 hours (7 days).
        /// 
        ///  
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(string streamName, int retentionPeriodHours)
        {
            var request = new IncreaseStreamRetentionPeriodRequest();
            request.StreamName = streamName;
            request.RetentionPeriodHours = retentionPeriodHours;
            return IncreaseStreamRetentionPeriod(request);
        }


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 168 hours (7 days).
        /// 
        ///  
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<IncreaseStreamRetentionPeriodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIncreaseStreamRetentionPeriod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IAsyncResult BeginIncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseStreamRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseStreamRetentionPeriodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IncreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIncreaseStreamRetentionPeriod.</param>
        /// 
        /// <returns>Returns a  IncreaseStreamRetentionPeriodResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        public virtual IncreaseStreamRetentionPeriodResponse EndIncreaseStreamRetentionPeriod(IAsyncResult asyncResult)
        {
            return EndInvoke<IncreaseStreamRetentionPeriodResponse>(asyncResult);
        }

        #endregion
        
        #region  ListShards

        /// <summary>
        /// Lists the shards in a stream and provides information about each shard. This operation
        /// has a limit of 100 transactions per second per data stream.
        /// 
        ///  <important> 
        /// <para>
        /// This API is a new operation that is used by the Amazon Kinesis Client Library (KCL).
        /// If you have a fine-grained IAM policy that only allows specific operations, you must
        /// update your policy to allow calls to this API. For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
        /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShards service method.</param>
        /// 
        /// <returns>The response from the ListShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual ListShardsResponse ListShards(ListShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;

            return Invoke<ListShardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListShards operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListShards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual IAsyncResult BeginListShards(ListShardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListShards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListShards.</param>
        /// 
        /// <returns>Returns a  ListShardsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        public virtual ListShardsResponse EndListShards(IAsyncResult asyncResult)
        {
            return EndInvoke<ListShardsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreamConsumers

        /// <summary>
        /// Lists the consumers registered to receive data from a stream using enhanced fan-out,
        /// and provides information about each consumer.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of 5 transactions per second per stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamConsumers service method.</param>
        /// 
        /// <returns>The response from the ListStreamConsumers service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredNextTokenException">
        /// The pagination token passed to the operation is expired.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual ListStreamConsumersResponse ListStreamConsumers(ListStreamConsumersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;

            return Invoke<ListStreamConsumersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamConsumers operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamConsumers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual IAsyncResult BeginListStreamConsumers(ListStreamConsumersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamConsumersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamConsumers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamConsumers.</param>
        /// 
        /// <returns>Returns a  ListStreamConsumersResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreamConsumers">REST API Reference for ListStreamConsumers Operation</seealso>
        public virtual ListStreamConsumersResponse EndListStreamConsumers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamConsumersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreams

        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Kinesis Data Streams
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams()
        {
            return ListStreams(new ListStreamsRequest());
        }

        /// <summary>
        /// Lists your Kinesis data streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Kinesis Data Streams
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListStreams</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse EndListStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForStream

        /// <summary>
        /// Lists the tags for the specified Kinesis data stream. This operation has a limit of
        /// five transactions per second per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual IAsyncResult BeginListTagsForStream(ListTagsForStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForStream.</param>
        /// 
        /// <returns>Returns a  ListTagsForStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual ListTagsForStreamResponse EndListTagsForStream(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  MergeShards

        /// <summary>
        /// Merges two adjacent shards in a Kinesis data stream and combines them into a single
        /// shard to reduce the stream's capacity to ingest and transport data. Two shards are
        /// considered adjacent if the union of the hash key ranges for the two shards form a
        /// contiguous set with no gaps. For example, if you have two shards, one with a hash
        /// key range of 276...381 and the other with a hash key range of 382...454, then you
        /// could merge these two shards into a single shard that would have a hash key range
        /// of 276...454. After the merge, the single child shard receives data for all hash key
        /// values covered by the two parent shards.
        /// 
        ///  
        /// <para>
        ///  <code>MergeShards</code> is called when there is a need to reduce the overall capacity
        /// of a stream because of excess capacity that is not being used. You must specify the
        /// shard to be merged and the adjacent shard for a stream. For more information about
        /// merging shards, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-merge.html">Merge
        /// Two Shards</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the stream is in the <code>ACTIVE</code> state, you can call <code>MergeShards</code>.
        /// If a stream is in the <code>CREATING</code>, <code>UPDATING</code>, or <code>DELETING</code>
        /// state, <code>MergeShards</code> returns a <code>ResourceInUseException</code>. If
        /// the specified stream does not exist, <code>MergeShards</code> returns a <code>ResourceNotFoundException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStream</a> to check the state of the stream, which is returned
        /// in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>MergeShards</code> is an asynchronous operation. Upon receiving a <code>MergeShards</code>
        /// request, Amazon Kinesis Data Streams immediately returns a response and sets the <code>StreamStatus</code>
        /// to <code>UPDATING</code>. After the operation is completed, Kinesis Data Streams sets
        /// the <code>StreamStatus</code> to <code>ACTIVE</code>. Read and write operations continue
        /// to work while the stream is in the <code>UPDATING</code> state. 
        /// </para>
        ///  
        /// <para>
        /// You use <a>DescribeStream</a> to determine the shard IDs that are specified in the
        /// <code>MergeShards</code> request. 
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
        /// <code>MergeShards</code>, or <a>SplitShard</a>, you receive a <code>LimitExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>MergeShards</code> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeShards service method.</param>
        /// 
        /// <returns>The response from the MergeShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual MergeShardsResponse MergeShards(MergeShardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return Invoke<MergeShardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MergeShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeShards operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeShards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual IAsyncResult BeginMergeShards(MergeShardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeShardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MergeShards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeShards.</param>
        /// 
        /// <returns>Returns a  MergeShardsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        public virtual MergeShardsResponse EndMergeShards(IAsyncResult asyncResult)
        {
            return EndInvoke<MergeShardsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecord

        /// <summary>
        /// Writes a single data record into an Amazon Kinesis data stream. Call <code>PutRecord</code>
        /// to send data into the stream for real-time ingestion and subsequent processing, one
        /// record at a time. Each shard can support writes up to 1,000 records per second, up
        /// to a maximum data write total of 1 MiB per second.
        /// 
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; a partition key; and the data blob itself.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams to distribute data across shards.
        /// Kinesis Data Streams segregates the data records that belong to a stream into multiple
        /// shards, using the partition key associated with each data record to determine the
        /// shard to which a given data record belongs.
        /// </para>
        ///  
        /// <para>
        /// Partition keys are Unicode strings, with a maximum length limit of 256 characters
        /// for each key. An MD5 hash function is used to map partition keys to 128-bit integer
        /// values and to map associated data records to shards using the hash key ranges of the
        /// shards. You can override hashing the partition key to determine the shard by explicitly
        /// specifying a hash value using the <code>ExplicitHashKey</code> parameter. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutRecord</code> returns the shard ID of where the data record was placed and
        /// the sequence number that was assigned to the data record.
        /// </para>
        ///  
        /// <para>
        /// Sequence numbers increase over time and are specific to a shard within a stream, not
        /// across all shards within a stream. To guarantee strictly increasing ordering, write
        /// serially to a shard and use the <code>SequenceNumberForOrdering</code> parameter.
        /// For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// If a <code>PutRecord</code> request cannot be processed because of insufficient provisioned
        /// throughput on the shard involved in the request, <code>PutRecord</code> throws <code>ProvisionedThroughputExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The AWS access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual IAsyncResult BeginPutRecord(PutRecordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecord.</param>
        /// 
        /// <returns>Returns a  PutRecordResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse EndPutRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecords

        /// <summary>
        /// Writes multiple data records into a Kinesis data stream in a single call (also referred
        /// to as a <code>PutRecords</code> request). Use this operation to send data into the
        /// stream for data ingestion and processing. 
        /// 
        ///  
        /// <para>
        /// Each <code>PutRecords</code> request can support up to 500 records. Each record in
        /// the request can be as large as 1 MiB, up to a limit of 5 MiB for the entire request,
        /// including partition keys. Each shard can support writes up to 1,000 records per second,
        /// up to a maximum data write total of 1 MiB per second.
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; and an array of request <code>Records</code>, with each record in the array
        /// requiring a partition key and data blob. The record size limit applies to the total
        /// size of the partition key and data blob.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Kinesis Data Streams as input to a hash function that
        /// maps the partition key and associated data to a specific shard. An MD5 hash function
        /// is used to map partition keys to 128-bit integer values and to map associated data
        /// records to shards. As a result of this hashing mechanism, all data records with the
        /// same partition key map to the same shard within the stream. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-add-data-to-stream">Adding
        /// Data to a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each record in the <code>Records</code> array may include an optional parameter, <code>ExplicitHashKey</code>,
        /// which overrides the partition key to shard mapping. This parameter allows a data producer
        /// to determine explicitly the shard where the record is stored. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/developing-producers-with-sdk.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <code>PutRecords</code> response includes an array of response <code>Records</code>.
        /// Each record in the response array directly correlates with a record in the request
        /// array using natural ordering, from the top to the bottom of the request and response.
        /// The response <code>Records</code> array always includes the same number of records
        /// as the request array.
        /// </para>
        ///  
        /// <para>
        /// The response <code>Records</code> array includes both successfully and unsuccessfully
        /// processed records. Kinesis Data Streams attempts to process all records in each <code>PutRecords</code>
        /// request. A single record failure does not stop the processing of subsequent records.
        /// As a result, PutRecords doesn't guarantee the ordering of records. If you need to
        /// read records in the same order they are written to the stream, use <a>PutRecord</a>
        /// instead of <code>PutRecords</code>, and write to the same shard.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes <code>ShardId</code> and <code>SequenceNumber</code>
        /// values. The <code>ShardId</code> parameter identifies the shard in the stream where
        /// the record is stored. The <code>SequenceNumber</code> parameter is an identifier assigned
        /// to the put record, unique to all records in the stream.
        /// </para>
        ///  
        /// <para>
        /// An unsuccessfully processed record includes <code>ErrorCode</code> and <code>ErrorMessage</code>
        /// values. <code>ErrorCode</code> reflects the type of error and can be one of the following
        /// values: <code>ProvisionedThroughputExceededException</code> or <code>InternalFailure</code>.
        /// <code>ErrorMessage</code> provides more detailed information about the <code>ProvisionedThroughputExceededException</code>
        /// exception including the account ID, stream name, and shard ID of the record that was
        /// throttled. For more information about partially successful responses, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-add-data-to-stream.html#kinesis-using-sdk-java-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Data Streams Developer
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you write a record to a stream, you cannot modify that record or its order within
        /// the stream.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, data records are accessible for 24 hours from the time that they are added
        /// to a stream. You can use <a>IncreaseStreamRetentionPeriod</a> or <a>DecreaseStreamRetentionPeriod</a>
        /// to modify this retention period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecords service method.</param>
        /// 
        /// <returns>The response from the PutRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The AWS access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate for the stream is too high, or the requested data is too large for
        /// the available throughput. Reduce the frequency or size of your requests. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>, and <a href="https://docs.aws.amazon.com/general/latest/gr/api-retries.html">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual PutRecordsResponse PutRecords(PutRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return Invoke<PutRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual IAsyncResult BeginPutRecords(PutRecordsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecords.</param>
        /// 
        /// <returns>Returns a  PutRecordsResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        public virtual PutRecordsResponse EndPutRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterStreamConsumer

        /// <summary>
        /// Registers a consumer with a Kinesis data stream. When you use this operation, the
        /// consumer you register can then call <a>SubscribeToShard</a> to receive data from the
        /// stream using enhanced fan-out, at a rate of up to 2 MiB per second for every shard
        /// you subscribe to. This rate is unaffected by the total number of consumers that read
        /// from the same stream.
        /// 
        ///  
        /// <para>
        /// You can register up to 20 consumers per stream. A given consumer can only be registered
        /// with one stream at a time.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to use this operations, see <a href="/streams/latest/dev/building-enhanced-consumers-api.html">Enhanced
        /// Fan-Out Using the Kinesis Data Streams API</a>.
        /// </para>
        ///  
        /// <para>
        /// The use of this operation has a limit of five transactions per second per account.
        /// Also, only 5 consumers can be created simultaneously. In other words, you cannot have
        /// more than 5 consumers in a <code>CREATING</code> status at the same time. Registering
        /// a 6th consumer while there are 5 in a <code>CREATING</code> status results in a <code>LimitExceededException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterStreamConsumer service method.</param>
        /// 
        /// <returns>The response from the RegisterStreamConsumer service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual RegisterStreamConsumerResponse RegisterStreamConsumer(RegisterStreamConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;

            return Invoke<RegisterStreamConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterStreamConsumer operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterStreamConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual IAsyncResult BeginRegisterStreamConsumer(RegisterStreamConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterStreamConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterStreamConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterStreamConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterStreamConsumer.</param>
        /// 
        /// <returns>Returns a  RegisterStreamConsumerResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RegisterStreamConsumer">REST API Reference for RegisterStreamConsumer Operation</seealso>
        public virtual RegisterStreamConsumerResponse EndRegisterStreamConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterStreamConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromStream

        /// <summary>
        /// Removes tags from the specified Kinesis data stream. Removed tags are deleted and
        /// cannot be recovered after this operation successfully completes.
        /// 
        ///  
        /// <para>
        /// If you specify a tag that does not exist, it is ignored.
        /// </para>
        ///  
        /// <para>
        ///  <a>RemoveTagsFromStream</a> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromStream(RemoveTagsFromStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromStream.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromStreamResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        public virtual RemoveTagsFromStreamResponse EndRemoveTagsFromStream(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  SplitShard

        /// <summary>
        /// Splits a shard into two new shards in the Kinesis data stream, to increase the stream's
        /// capacity to ingest and transport data. <code>SplitShard</code> is called when there
        /// is a need to increase the overall capacity of a stream because of an expected increase
        /// in the volume of data records being ingested. 
        /// 
        ///  
        /// <para>
        /// You can also use <code>SplitShard</code> when a shard appears to be approaching its
        /// maximum utilization; for example, the producers sending data into the specific shard
        /// are suddenly sending more than previously anticipated. You can also call <code>SplitShard</code>
        /// to increase stream capacity, so that more Kinesis Data Streams applications can simultaneously
        /// read data from the stream for real-time processing. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard to be split and the new hash key, which is the position
        /// in the shard where the shard gets split in two. In many cases, the new hash key might
        /// be the average of the beginning and ending hash key, but it can be any hash key value
        /// in the range being mapped into the shard. For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-split.html">Split
        /// a Shard</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStream</a> to determine the shard ID and hash key values for
        /// the <code>ShardToSplit</code> and <code>NewStartingHashKey</code> parameters that
        /// are specified in the <code>SplitShard</code> request.
        /// </para>
        ///  
        /// <para>
        ///  <code>SplitShard</code> is an asynchronous operation. Upon receiving a <code>SplitShard</code>
        /// request, Kinesis Data Streams immediately returns a response and sets the stream status
        /// to <code>UPDATING</code>. After the operation is completed, Kinesis Data Streams sets
        /// the stream status to <code>ACTIVE</code>. Read and write operations continue to work
        /// while the stream is in the <code>UPDATING</code> state. 
        /// </para>
        ///  
        /// <para>
        /// You can use <code>DescribeStream</code> to check the status of the stream, which is
        /// returned in <code>StreamStatus</code>. If the stream is in the <code>ACTIVE</code>
        /// state, you can call <code>SplitShard</code>. If a stream is in <code>CREATING</code>
        /// or <code>UPDATING</code> or <code>DELETING</code> states, <code>DescribeStream</code>
        /// returns a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// If the specified stream does not exist, <code>DescribeStream</code> returns a <code>ResourceNotFoundException</code>.
        /// If you try to create more shards than are authorized for your account, you receive
        /// a <code>LimitExceededException</code>. 
        /// </para>
        ///  
        /// <para>
        /// For the default shard limit for an AWS account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Kinesis
        /// Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// AWS Support</a>.
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams simultaneously using <a>CreateStream</a>,
        /// <a>DeleteStream</a>, <a>MergeShards</a>, and/or <a>SplitShard</a>, you receive a <code>LimitExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>SplitShard</code> has a limit of five transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SplitShard service method.</param>
        /// 
        /// <returns>The response from the SplitShard service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual SplitShardResponse SplitShard(SplitShardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;

            return Invoke<SplitShardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SplitShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SplitShard operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSplitShard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual IAsyncResult BeginSplitShard(SplitShardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SplitShardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SplitShardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SplitShard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSplitShard.</param>
        /// 
        /// <returns>Returns a  SplitShardResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        public virtual SplitShardResponse EndSplitShard(IAsyncResult asyncResult)
        {
            return EndInvoke<SplitShardResponse>(asyncResult);
        }

        #endregion
        
        #region  StartStreamEncryption

        /// <summary>
        /// Enables or updates server-side encryption using an AWS KMS key for a specified stream.
        /// 
        /// 
        ///  
        /// <para>
        /// Starting encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <code>UPDATING</code>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <code>ACTIVE</code>. Updating or applying encryption normally takes a few seconds
        /// to complete, but it can take minutes. You can continue to read and write data to your
        /// stream while its status is <code>UPDATING</code>. Once the status of the stream is
        /// <code>ACTIVE</code>, encryption begins for records written to the stream. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully apply a new AWS KMS key for server-side encryption
        /// 25 times in a rolling 24-hour period.
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <code>ACTIVE</code> status
        /// before all records written to the stream are encrypted. After you enable encryption,
        /// you can verify that encryption is applied by inspecting the API response from <code>PutRecord</code>
        /// or <code>PutRecords</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption service method.</param>
        /// 
        /// <returns>The response from the StartStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSOptInRequiredException">
        /// The AWS access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual StartStreamEncryptionResponse StartStreamEncryption(StartStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StartStreamEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStreamEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual IAsyncResult BeginStartStreamEncryption(StartStreamEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStreamEncryption.</param>
        /// 
        /// <returns>Returns a  StartStreamEncryptionResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        public virtual StartStreamEncryptionResponse EndStartStreamEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<StartStreamEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopStreamEncryption

        /// <summary>
        /// Disables server-side encryption for a specified stream. 
        /// 
        ///  
        /// <para>
        /// Stopping encryption is an asynchronous operation. Upon receiving the request, Kinesis
        /// Data Streams returns immediately and sets the status of the stream to <code>UPDATING</code>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <code>ACTIVE</code>. Stopping encryption normally takes a few seconds to complete,
        /// but it can take minutes. You can continue to read and write data to your stream while
        /// its status is <code>UPDATING</code>. Once the status of the stream is <code>ACTIVE</code>,
        /// records written to the stream are no longer encrypted by Kinesis Data Streams. 
        /// </para>
        ///  
        /// <para>
        /// API Limits: You can successfully disable server-side encryption 25 times in a rolling
        /// 24-hour period. 
        /// </para>
        ///  
        /// <para>
        /// Note: It can take up to 5 seconds after the stream is in an <code>ACTIVE</code> status
        /// before all records written to the stream are no longer subject to encryption. After
        /// you disabled encryption, you can verify that encryption is not applied by inspecting
        /// the API response from <code>PutRecord</code> or <code>PutRecords</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption service method.</param>
        /// 
        /// <returns>The response from the StopStreamEncryption service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual StopStreamEncryptionResponse StopStreamEncryption(StopStreamEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;

            return Invoke<StopStreamEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStreamEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual IAsyncResult BeginStopStreamEncryption(StopStreamEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStreamEncryption.</param>
        /// 
        /// <returns>Returns a  StopStreamEncryptionResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        public virtual StopStreamEncryptionResponse EndStopStreamEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<StopStreamEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateShardCount

        /// <summary>
        /// Updates the shard count of the specified stream to the specified number of shards.
        /// 
        ///  
        /// <para>
        /// Updating the shard count is an asynchronous operation. Upon receiving the request,
        /// Kinesis Data Streams returns immediately and sets the status of the stream to <code>UPDATING</code>.
        /// After the update is complete, Kinesis Data Streams sets the status of the stream back
        /// to <code>ACTIVE</code>. Depending on the size of the stream, the scaling action could
        /// take a few minutes to complete. You can continue to read and write data to your stream
        /// while its status is <code>UPDATING</code>.
        /// </para>
        ///  
        /// <para>
        /// To update the shard count, Kinesis Data Streams performs splits or merges on individual
        /// shards. This can cause short-lived shards to be created, in addition to the final
        /// shards. These short-lived shards count towards your total shard limit for your account
        /// in the Region.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, we recommend that you specify a target shard count that
        /// is a multiple of 25% (25%, 50%, 75%, 100%). You can specify any target value within
        /// your shard limit. However, if you specify a target that isn't a multiple of 25%, the
        /// scaling action might take longer to complete. 
        /// </para>
        ///  
        /// <para>
        /// This operation has the following default limits. By default, you cannot do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scale more than ten times per rolling 24-hour period per stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than double your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale down below half your current shard count for a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than 500 shards in a stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale a stream with more than 500 shards down unless the result is less than 500 shards
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scale up to more than the shard limit for your account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the default limits for an AWS account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Streams
        /// Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>. To request an
        /// increase in the call rate limit, the shard limit for this API, or your overall shard
        /// limit, use the <a href="https://console.aws.amazon.com/support/v1#/case/create?issueType=service-limit-increase&amp;limitType=service-code-kinesis">limits
        /// form</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount service method.</param>
        /// 
        /// <returns>The response from the UpdateShardCount service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual UpdateShardCountResponse UpdateShardCount(UpdateShardCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;

            return Invoke<UpdateShardCountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateShardCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateShardCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual IAsyncResult BeginUpdateShardCount(UpdateShardCountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShardCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShardCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateShardCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateShardCount.</param>
        /// 
        /// <returns>Returns a  UpdateShardCountResult from Kinesis.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        public virtual UpdateShardCountResponse EndUpdateShardCount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateShardCountResponse>(asyncResult);
        }

        #endregion
        
    }
}