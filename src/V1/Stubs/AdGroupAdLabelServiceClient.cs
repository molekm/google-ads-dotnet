// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>
    /// Settings for a <see cref="AdGroupAdLabelServiceClient"/>.
    /// </summary>
    public sealed partial class AdGroupAdLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AdGroupAdLabelServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AdGroupAdLabelServiceSettings"/>.
        /// </returns>
        public static AdGroupAdLabelServiceSettings GetDefault() => new AdGroupAdLabelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupAdLabelServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupAdLabelServiceSettings() { }

        private AdGroupAdLabelServiceSettings(AdGroupAdLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAdLabelSettings = existing.GetAdGroupAdLabelSettings;
            MutateAdGroupAdLabelsSettings = existing.MutateAdGroupAdLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAdLabelServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AdGroupAdLabelServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabel</c> and <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabel</c> and
        /// <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabelAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupAdLabelSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabels</c> and <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabels</c> and
        /// <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabelsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupAdLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AdGroupAdLabelServiceSettings"/> object.</returns>
        public AdGroupAdLabelServiceSettings Clone() => new AdGroupAdLabelServiceSettings(this);
    }

    /// <summary>
    /// AdGroupAdLabelService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AdGroupAdLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAdLabelService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default AdGroupAdLabelService scopes.
        /// </summary>
        /// <remarks>
        /// The default AdGroupAdLabelService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAdLabelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AdGroupAdLabelServiceClient client = await AdGroupAdLabelServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AdGroupAdLabelServiceClient.DefaultEndpoint.Host, AdGroupAdLabelServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AdGroupAdLabelServiceClient client = AdGroupAdLabelServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AdGroupAdLabelServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static async stt::Task<AdGroupAdLabelServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupAdLabelServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAdLabelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AdGroupAdLabelServiceClient client = AdGroupAdLabelServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AdGroupAdLabelServiceClient.DefaultEndpoint.Host, AdGroupAdLabelServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AdGroupAdLabelServiceClient client = AdGroupAdLabelServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AdGroupAdLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static AdGroupAdLabelServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupAdLabelServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AdGroupAdLabelServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AdGroupAdLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static AdGroupAdLabelServiceClient Create(grpccore::Channel channel, AdGroupAdLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AdGroupAdLabelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AdGroupAdLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static AdGroupAdLabelServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAdLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient = new AdGroupAdLabelService.AdGroupAdLabelServiceClient(callInvoker);
            return new AdGroupAdLabelServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupAdLabelServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupAdLabelServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupAdLabelServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupAdLabelServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AdGroupAdLabelService client.
        /// </summary>
        public virtual AdGroupAdLabelService.AdGroupAdLabelServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAdGroupAdLabelAsync(
                new GetAdGroupAdLabelRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetAdGroupAdLabelAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::AdGroupAdLabel GetAdGroupAdLabel(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAdGroupAdLabel(
                new GetAdGroupAdLabelRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(
            GetAdGroupAdLabelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(
            GetAdGroupAdLabelRequest request,
            st::CancellationToken cancellationToken) => GetAdGroupAdLabelAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::AdGroupAdLabel GetAdGroupAdLabel(
            GetAdGroupAdLabelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAdLabelsAsync(
                new MutateAdGroupAdLabelsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateAdGroupAdLabelsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAdLabels(
                new MutateAdGroupAdLabelsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAdLabelsAsync(
                new MutateAdGroupAdLabelsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupAdLabelsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(
            string customerId,
            scg::IEnumerable<AdGroupAdLabelOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAdLabels(
                new MutateAdGroupAdLabelsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            MutateAdGroupAdLabelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            MutateAdGroupAdLabelsRequest request,
            st::CancellationToken cancellationToken) => MutateAdGroupAdLabelsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(
            MutateAdGroupAdLabelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// AdGroupAdLabelService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AdGroupAdLabelServiceClientImpl : AdGroupAdLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel> _callGetAdGroupAdLabel;
        private readonly gaxgrpc::ApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse> _callMutateAdGroupAdLabels;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAdLabelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupAdLabelServiceSettings"/> used within this client </param>
        public AdGroupAdLabelServiceClientImpl(AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient, AdGroupAdLabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAdLabelServiceSettings effectiveSettings = settings ?? AdGroupAdLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAdLabel = clientHelper.BuildApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel>(
                GrpcClient.GetAdGroupAdLabelAsync, GrpcClient.GetAdGroupAdLabel, effectiveSettings.GetAdGroupAdLabelSettings);
            _callMutateAdGroupAdLabels = clientHelper.BuildApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse>(
                GrpcClient.MutateAdGroupAdLabelsAsync, GrpcClient.MutateAdGroupAdLabels, effectiveSettings.MutateAdGroupAdLabelsSettings);
            Modify_ApiCall(ref _callGetAdGroupAdLabel);
            Modify_GetAdGroupAdLabelApiCall(ref _callGetAdGroupAdLabel);
            Modify_ApiCall(ref _callMutateAdGroupAdLabels);
            Modify_MutateAdGroupAdLabelsApiCall(ref _callMutateAdGroupAdLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetAdGroupAdLabelApiCall(ref gaxgrpc::ApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel> call);
        partial void Modify_MutateAdGroupAdLabelsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse> call);
        partial void OnConstruction(AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient, AdGroupAdLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AdGroupAdLabelService client.
        /// </summary>
        public override AdGroupAdLabelService.AdGroupAdLabelServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetAdGroupAdLabelRequest(ref GetAdGroupAdLabelRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateAdGroupAdLabelsRequest(ref MutateAdGroupAdLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(
            GetAdGroupAdLabelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupAdLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::AdGroupAdLabel GetAdGroupAdLabel(
            GetAdGroupAdLabelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupAdLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(
            MutateAdGroupAdLabelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAdLabels.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(
            MutateAdGroupAdLabelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAdLabels.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
