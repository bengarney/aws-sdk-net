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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTEventsData.Model;
using Amazon.IoTEventsData.Model.Internal.MarshallTransformations;
using Amazon.IoTEventsData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTEventsData
{
    /// <summary>
    /// Implementation for accessing IoTEventsData
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur. AWS IoT Events Data API commands
    /// enable you to send inputs to detectors, list detectors, and view or update a detector's
    /// status.
    /// </summary>
    public partial class AmazonIoTEventsDataClient : AmazonServiceClient, IAmazonIoTEventsData
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTEventsDataMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        public AmazonIoTEventsDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsDataConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        public AmazonIoTEventsDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(AmazonIoTEventsDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTEventsDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials and an
        /// AmazonIoTEventsDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials, AmazonIoTEventsDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTEventsDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTEventsDataConfig clientConfig)
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


        #region  BatchPutMessage

        /// <summary>
        /// Sends a set of messages to the AWS IoT Events system. Each message payload is transformed
        /// into the input you specify (<code>"inputName"</code>) and ingested into any detectors
        /// that monitor that input. If multiple messages are sent, the order in which the messages
        /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
        /// at a time and wait for a successful response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual IAsyncResult BeginBatchPutMessage(BatchPutMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutMessage.</param>
        /// 
        /// <returns>Returns a  BatchPutMessageResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual BatchPutMessageResponse EndBatchPutMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateDetector

        /// <summary>
        /// Updates the state, variable values, and timer settings of one or more detectors (instances)
        /// of a specified detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        public virtual BatchUpdateDetectorResponse BatchUpdateDetector(BatchUpdateDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDetectorResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateDetector(BatchUpdateDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateDetector.</param>
        /// 
        /// <returns>Returns a  BatchUpdateDetectorResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        public virtual BatchUpdateDetectorResponse EndBatchUpdateDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDetector

        /// <summary>
        /// Returns information about the specified detector (instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual IAsyncResult BeginDescribeDetector(DescribeDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetector.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse EndDescribeDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDetectors

        /// <summary>
        /// Lists detectors (the instances of a detector model).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual ListDetectorsResponse ListDetectors(ListDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual IAsyncResult BeginListDetectors(ListDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectors.</param>
        /// 
        /// <returns>Returns a  ListDetectorsResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual ListDetectorsResponse EndListDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDetectorsResponse>(asyncResult);
        }

        #endregion
        
    }
}