// Copyright 2023 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Storage.V2
{
    /// <summary>Settings for <see cref="StorageClient"/> instances.</summary>
    public sealed partial class StorageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageSettings"/>.</returns>
        public static StorageSettings GetDefault() => new StorageSettings();

        /// <summary>Constructs a new <see cref="StorageSettings"/> object with default settings.</summary>
        public StorageSettings()
        {
        }

        private StorageSettings(StorageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteBucketSettings = existing.DeleteBucketSettings;
            GetBucketSettings = existing.GetBucketSettings;
            CreateBucketSettings = existing.CreateBucketSettings;
            ListBucketsSettings = existing.ListBucketsSettings;
            LockBucketRetentionPolicySettings = existing.LockBucketRetentionPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateBucketSettings = existing.UpdateBucketSettings;
            DeleteNotificationConfigSettings = existing.DeleteNotificationConfigSettings;
            GetNotificationConfigSettings = existing.GetNotificationConfigSettings;
            CreateNotificationConfigSettings = existing.CreateNotificationConfigSettings;
            ListNotificationConfigsSettings = existing.ListNotificationConfigsSettings;
            ComposeObjectSettings = existing.ComposeObjectSettings;
            DeleteObjectSettings = existing.DeleteObjectSettings;
            CancelResumableWriteSettings = existing.CancelResumableWriteSettings;
            GetObjectSettings = existing.GetObjectSettings;
            ReadObjectSettings = existing.ReadObjectSettings;
            UpdateObjectSettings = existing.UpdateObjectSettings;
            WriteObjectSettings = existing.WriteObjectSettings;
            WriteObjectStreamingSettings = existing.WriteObjectStreamingSettings;
            ListObjectsSettings = existing.ListObjectsSettings;
            RewriteObjectSettings = existing.RewriteObjectSettings;
            StartResumableWriteSettings = existing.StartResumableWriteSettings;
            QueryWriteStatusSettings = existing.QueryWriteStatusSettings;
            GetServiceAccountSettings = existing.GetServiceAccountSettings;
            CreateHmacKeySettings = existing.CreateHmacKeySettings;
            DeleteHmacKeySettings = existing.DeleteHmacKeySettings;
            GetHmacKeySettings = existing.GetHmacKeySettings;
            ListHmacKeysSettings = existing.ListHmacKeysSettings;
            UpdateHmacKeySettings = existing.UpdateHmacKeySettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.DeleteBucket</c>
        ///  and <c>StorageClient.DeleteBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetBucket</c>
        /// and <c>StorageClient.GetBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.CreateBucket</c>
        ///  and <c>StorageClient.CreateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ListBuckets</c>
        ///  and <c>StorageClient.ListBucketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBucketsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.LockBucketRetentionPolicy</c> and <c>StorageClient.LockBucketRetentionPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LockBucketRetentionPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetIamPolicy</c>
        ///  and <c>StorageClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.SetIamPolicy</c>
        ///  and <c>StorageClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.TestIamPermissions</c> and <c>StorageClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.UpdateBucket</c>
        ///  and <c>StorageClient.UpdateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.DeleteNotificationConfig</c> and <c>StorageClient.DeleteNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotificationConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.GetNotificationConfig</c> and <c>StorageClient.GetNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.CreateNotificationConfig</c> and <c>StorageClient.CreateNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNotificationConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.ListNotificationConfigs</c> and <c>StorageClient.ListNotificationConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ComposeObject</c>
        ///  and <c>StorageClient.ComposeObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComposeObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.DeleteObject</c>
        ///  and <c>StorageClient.DeleteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.CancelResumableWrite</c> and <c>StorageClient.CancelResumableWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelResumableWriteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetObject</c>
        /// and <c>StorageClient.GetObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ReadObject</c>
        ///  and <c>StorageClient.ReadObjectAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 60 seconds.</remarks>
        public gaxgrpc::CallSettings ReadObjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.UpdateObject</c>
        ///  and <c>StorageClient.UpdateObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.WriteObject</c>
        ///  and <c>StorageClient.WriteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::ClientStreamingSettings"/> for calls to <c>StorageClient.WriteObject</c> and
        /// <c>StorageClient.WriteObjectAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::ClientStreamingSettings WriteObjectStreamingSettings { get; set; } = new gaxgrpc::ClientStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ListObjects</c>
        ///  and <c>StorageClient.ListObjectsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.RewriteObject</c>
        ///  and <c>StorageClient.RewriteObjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RewriteObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.StartResumableWrite</c> and <c>StorageClient.StartResumableWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartResumableWriteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.QueryWriteStatus</c> and <c>StorageClient.QueryWriteStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryWriteStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageClient.GetServiceAccount</c> and <c>StorageClient.GetServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.CreateHmacKey</c>
        ///  and <c>StorageClient.CreateHmacKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHmacKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.DeleteHmacKey</c>
        ///  and <c>StorageClient.DeleteHmacKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHmacKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.GetHmacKey</c>
        ///  and <c>StorageClient.GetHmacKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHmacKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.ListHmacKeys</c>
        ///  and <c>StorageClient.ListHmacKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHmacKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StorageClient.UpdateHmacKey</c>
        ///  and <c>StorageClient.UpdateHmacKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHmacKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageSettings"/> object.</returns>
        public StorageSettings Clone() => new StorageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class StorageClientBuilder : gaxgrpc::ClientBuilderBase<StorageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageClientBuilder() : base(StorageClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageClient Build()
        {
            StorageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<StorageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageClient.ChannelPool;
    }

    /// <summary>Storage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview and Naming Syntax
    /// 
    /// The Cloud Storage gRPC API allows applications to read and write data through
    /// the abstractions of buckets and objects. For a description of these
    /// abstractions please see https://cloud.google.com/storage/docs.
    /// 
    /// Resources are named as follows:
    /// - Projects are referred to as they are defined by the Resource Manager API,
    /// using strings like `projects/123456` or `projects/my-string-id`.
    /// - Buckets are named using string names of the form:
    /// `projects/{project}/buckets/{bucket}`
    /// For globally unique buckets, `_` may be substituted for the project.
    /// - Objects are uniquely identified by their name along with the name of the
    /// bucket they belong to, as separate strings in this API. For example:
    /// 
    /// ReadObjectRequest {
    /// bucket: 'projects/_/buckets/my-bucket'
    /// object: 'my-object'
    /// }
    /// Note that object names can contain `/` characters, which are treated as
    /// any other character (no special directory semantics).
    /// </remarks>
    public abstract partial class StorageClient
    {
        /// <summary>
        /// The default endpoint for the Storage service, which is a host of "storage.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storage.googleapis.com:443";

        /// <summary>The default Storage scopes.</summary>
        /// <remarks>
        /// The default Storage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/devstorage.full_control",
            "https://www.googleapis.com/auth/devstorage.read_only",
            "https://www.googleapis.com/auth/devstorage.read_write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Storage.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="StorageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageClient"/>.</returns>
        public static stt::Task<StorageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="StorageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        public static StorageClient Create() => new StorageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageClient"/>.</returns>
        internal static StorageClient Create(grpccore::CallInvoker callInvoker, StorageSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Storage.StorageClient grpcClient = new Storage.StorageClient(callInvoker);
            return new StorageClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Storage client</summary>
        public virtual Storage.StorageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucket(new DeleteBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucketAsync(new DeleteBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucket(new DeleteBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBucketAsync(new DeleteBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(BucketName name, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, st::CancellationToken cancellationToken) =>
            GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(string parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket CreateBucket(gagr::ProjectName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(gagr::ProjectName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Bucket = bucket,
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
            }, callSettings);

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to which this bucket will belong.
        /// </param>
        /// <param name="bucket">
        /// Properties of the new bucket being inserted.
        /// The name of the bucket is specified in the `bucket_id` field. Populating
        /// `bucket.name` field will be ignored.
        /// The project of the bucket must be specified in the `bucket.project` field.
        /// This field must be in `projects/{projectIdentifier}` format,
        /// {projectIdentifier} can be the project ID or project number. The `parent`
        /// field must be either empty or `projects/_`.
        /// </param>
        /// <param name="bucketId">
        /// Required. The ID to use for this bucket, which will become the final
        /// component of the bucket's resource name. For example, the value `foo` might
        /// result in a bucket with the name `projects/123456/buckets/foo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> CreateBucketAsync(gagr::ProjectName parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project whose buckets we are listing.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(string bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicy(new LockBucketRetentionPolicyRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(string bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicyAsync(new LockBucketRetentionPolicyRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(string bucket, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(bucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket LockBucketRetentionPolicy(BucketName bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicy(new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(BucketName bucket, gaxgrpc::CallSettings callSettings = null) =>
            LockBucketRetentionPolicyAsync(new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of a bucket.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> LockBucketRetentionPolicyAsync(BucketName bucket, st::CancellationToken cancellationToken) =>
            LockBucketRetentionPolicyAsync(bucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket UpdateBucket(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucket(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucketAsync(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="bucket">
        /// Required. The bucket to update.
        /// The bucket's `name` field will be used to identify the bucket.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(bucket, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfig(new DeleteNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfigAsync(new DeleteNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfig(new DeleteNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfigAsync(new DeleteNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(NotificationConfigName name, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfig(new GetNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfigAsync(new GetNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfig(new GetNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfigAsync(new GetNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The parent bucket of the NotificationConfig.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/notificationConfigs/{notificationConfig}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(NotificationConfigName name, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(string parent, NotificationConfig notificationConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(string parent, NotificationConfig notificationConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(string parent, NotificationConfig notificationConfig, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(BucketName parent, NotificationConfig notificationConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(BucketName parent, NotificationConfig notificationConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket to which this NotificationConfig belongs.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. Properties of the NotificationConfig to be inserted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(BucketName parent, NotificationConfig notificationConfig, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a Google Cloud Storage bucket.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotificationConfigs(new ListNotificationConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a Google Cloud Storage bucket.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotificationConfigsAsync(new ListNotificationConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a Google Cloud Storage bucket.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotificationConfigs(new ListNotificationConfigsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a Google Cloud Storage bucket.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotificationConfigsAsync(new ListNotificationConfigsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object ComposeObject(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, st::CancellationToken cancellationToken) =>
            ComposeObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(DeleteObjectRequest request, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(string bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObject(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. The name of the finalized object to delete.
        /// Note: If you want to delete an unfinalized resumable upload please use
        /// `CancelResumableWrite`.
        /// </param>
        /// <param name="generation">
        /// If present, permanently deletes a specific revision of this object (as
        /// opposed to the latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteObjectAsync(BucketName bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            DeleteObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelResumableWriteResponse CancelResumableWrite(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, st::CancellationToken cancellationToken) =>
            CancelResumableWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelResumableWriteResponse CancelResumableWrite(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            CancelResumableWrite(new CancelResumableWriteRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            CancelResumableWriteAsync(new CancelResumableWriteRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The upload_id of the resumable upload to cancel. This should be
        /// copied from the `upload_id` field of `StartResumableWriteResponse`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(string uploadId, st::CancellationToken cancellationToken) =>
            CancelResumableWriteAsync(uploadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(GetObjectRequest request, st::CancellationToken cancellationToken) =>
            GetObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(string bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object GetObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObject(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            GetObjectAsync(new GetObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="bucket">
        /// Required. Name of the bucket in which the object resides.
        /// </param>
        /// <param name="object">
        /// Required. Name of the object.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed to the
        /// latest version, the default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> GetObjectAsync(BucketName bucket, string @object, long generation, st::CancellationToken cancellationToken) =>
            GetObjectAsync(bucket, @object, generation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ReadObject(ReadObjectRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadObjectStream : gaxgrpc::ServerStreamingBase<ReadObjectResponse>
        {
        }

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(ReadObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(string bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(BucketName bucket, string @object, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed
        /// to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(string bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNullOrEmpty(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="bucket">
        /// Required. The name of the bucket containing the object to read.
        /// </param>
        /// <param name="object">
        /// Required. The name of the object to read.
        /// </param>
        /// <param name="generation">
        /// If present, selects a specific revision of this object (as opposed
        /// to the latest version, the default).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadObjectStream ReadObject(BucketName bucket, string @object, long generation, gaxgrpc::CallSettings callSettings = null) =>
            ReadObject(new ReadObjectRequest
            {
                BucketAsBucketName = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
                Generation = generation,
            }, callSettings);

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object UpdateObject(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, st::CancellationToken cancellationToken) =>
            UpdateObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Object UpdateObject(Object @object, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateObject(new UpdateObjectRequest
            {
                Object = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(Object @object, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateObjectAsync(new UpdateObjectRequest
            {
                Object = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="object">
        /// Required. The object to update.
        /// The object's bucket and name fields are used to identify the object to
        /// update. If present, the object's generation field selects a specific
        /// revision of this object whose metadata should be updated. Otherwise,
        /// assumes the live version of the object.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated.
        /// 
        /// To specify ALL fields, equivalent to the JSON API's "update" function,
        /// specify a single field with the value `*`. Note: not recommended. If a new
        /// field is introduced at a later time, an older client updating with the `*`
        /// may accidentally reset the new field's value.
        /// 
        /// Not specifying any fields is an error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Object> UpdateObjectAsync(Object @object, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateObjectAsync(@object, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Client streaming methods for
        /// <see cref="WriteObject(gaxgrpc::CallSettings,gaxgrpc::ClientStreamingSettings)"/>.
        /// </summary>
        public abstract partial class WriteObjectStream : gaxgrpc::ClientStreamingBase<WriteObjectRequest, WriteObjectResponse>
        {
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// An object can be written either in a single message stream or in a
        /// resumable sequence of message streams. To write using a single stream,
        /// the client should include in the first message of the stream an
        /// `WriteObjectSpec` describing the destination bucket, object, and any
        /// preconditions. Additionally, the final message must set 'finish_write' to
        /// true, or else it is an error.
        /// 
        /// For a resumable write, the client should instead call
        /// `StartResumableWrite()`, populating a `WriteObjectSpec` into that request.
        /// They should then attach the returned `upload_id` to the first message of
        /// each following call to `WriteObject`. If the stream is closed before
        /// finishing the upload (either explicitly by the client or due to a network
        /// error or an error response from the server), the client should do as
        /// follows:
        /// - Check the result Status of the stream, to determine if writing can be
        /// resumed on this stream or must be restarted from scratch (by calling
        /// `StartResumableWrite()`). The resumable errors are DEADLINE_EXCEEDED,
        /// INTERNAL, and UNAVAILABLE. For each case, the client should use binary
        /// exponential backoff before retrying.  Additionally, writes can be
        /// resumed after RESOURCE_EXHAUSTED errors, but only after taking
        /// appropriate measures, which may include reducing aggregate send rate
        /// across clients and/or requesting a quota increase for your project.
        /// - If the call to `WriteObject` returns `ABORTED`, that indicates
        /// concurrent attempts to update the resumable write, caused either by
        /// multiple racing clients or by a single client where the previous
        /// request was timed out on the client side but nonetheless reached the
        /// server. In this case the client should take steps to prevent further
        /// concurrent writes (e.g., increase the timeouts, stop using more than
        /// one process to perform the upload, etc.), and then should follow the
        /// steps below for resuming the upload.
        /// - For resumable errors, the client should call `QueryWriteStatus()` and
        /// then continue writing from the returned `persisted_size`. This may be
        /// less than the amount of data the client previously sent. Note also that
        /// it is acceptable to send data starting at an offset earlier than the
        /// returned `persisted_size`; in this case, the service will skip data at
        /// offsets that were already persisted (without checking that it matches
        /// the previously written data), and write only the data starting from the
        /// persisted offset. Even though the data isn't written, it may still
        /// incur a performance cost over resuming at the correct write offset.
        /// This behavior can make client-side handling simpler in some cases.
        /// - Clients must only send data that is a multiple of 256 KiB per message,
        /// unless the object is being finished with `finish_write` set to `true`.
        /// 
        /// The service will not view the object as complete until the client has
        /// sent a `WriteObjectRequest` with `finish_write` set to `true`. Sending any
        /// requests on a stream after sending a request with `finish_write` set to
        /// `true` will cause an error. The client **should** check the response it
        /// receives to determine how much data the service was able to commit and
        /// whether the service views the object as complete.
        /// 
        /// Attempting to resume an already finalized object will result in an OK
        /// status, with a WriteObjectResponse containing the finalized object's
        /// metadata.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client stream.</returns>
        public virtual WriteObjectStream WriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::ClientStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListObjects(new ListObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListObjectsAsync(new ListObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListObjects(new ListObjectsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for objects.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListObjectsAsync(new ListObjectsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RewriteResponse RewriteObject(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, st::CancellationToken cancellationToken) =>
            RewriteObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a resumable write. How long the write operation remains valid, and
        /// what happens when the write operation becomes invalid, are
        /// service-dependent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartResumableWriteResponse StartResumableWrite(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a resumable write. How long the write operation remains valid, and
        /// what happens when the write operation becomes invalid, are
        /// service-dependent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a resumable write. How long the write operation remains valid, and
        /// what happens when the write operation becomes invalid, are
        /// service-dependent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, st::CancellationToken cancellationToken) =>
            StartResumableWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryWriteStatusResponse QueryWriteStatus(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, st::CancellationToken cancellationToken) =>
            QueryWriteStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryWriteStatusResponse QueryWriteStatus(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            QueryWriteStatus(new QueryWriteStatusRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(string uploadId, gaxgrpc::CallSettings callSettings = null) =>
            QueryWriteStatusAsync(new QueryWriteStatusRequest
            {
                UploadId = gax::GaxPreconditions.CheckNotNullOrEmpty(uploadId, nameof(uploadId)),
            }, callSettings);

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="uploadId">
        /// Required. The name of the resume token for the object whose write status is
        /// being requested.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(string uploadId, st::CancellationToken cancellationToken) =>
            QueryWriteStatusAsync(uploadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string project, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID, in the format of "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(gagr::ProjectName project, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateHmacKeyResponse CreateHmacKey(CreateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(CreateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(CreateHmacKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateHmacKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateHmacKeyResponse CreateHmacKey(string project, string serviceAccountEmail, gaxgrpc::CallSettings callSettings = null) =>
            CreateHmacKey(new CreateHmacKeyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ServiceAccountEmail = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountEmail, nameof(serviceAccountEmail)),
            }, callSettings);

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(string project, string serviceAccountEmail, gaxgrpc::CallSettings callSettings = null) =>
            CreateHmacKeyAsync(new CreateHmacKeyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ServiceAccountEmail = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountEmail, nameof(serviceAccountEmail)),
            }, callSettings);

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(string project, string serviceAccountEmail, st::CancellationToken cancellationToken) =>
            CreateHmacKeyAsync(project, serviceAccountEmail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateHmacKeyResponse CreateHmacKey(gagr::ProjectName project, string serviceAccountEmail, gaxgrpc::CallSettings callSettings = null) =>
            CreateHmacKey(new CreateHmacKeyRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                ServiceAccountEmail = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountEmail, nameof(serviceAccountEmail)),
            }, callSettings);

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(gagr::ProjectName project, string serviceAccountEmail, gaxgrpc::CallSettings callSettings = null) =>
            CreateHmacKeyAsync(new CreateHmacKeyRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                ServiceAccountEmail = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountEmail, nameof(serviceAccountEmail)),
            }, callSettings);

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="project">
        /// Required. The project that the HMAC-owning service account lives in, in the
        /// format of "projects/{projectIdentifier}". {projectIdentifier} can be the
        /// project ID or project number.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// Required. The service account to create the HMAC for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(gagr::ProjectName project, string serviceAccountEmail, st::CancellationToken cancellationToken) =>
            CreateHmacKeyAsync(project, serviceAccountEmail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteHmacKey(DeleteHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(DeleteHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(DeleteHmacKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteHmacKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteHmacKey(string accessId, string project, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHmacKey(new DeleteHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(string accessId, string project, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHmacKeyAsync(new DeleteHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(string accessId, string project, st::CancellationToken cancellationToken) =>
            DeleteHmacKeyAsync(accessId, project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteHmacKey(string accessId, gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHmacKey(new DeleteHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(string accessId, gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHmacKeyAsync(new DeleteHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project that owns the HMAC key, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteHmacKeyAsync(string accessId, gagr::ProjectName project, st::CancellationToken cancellationToken) =>
            DeleteHmacKeyAsync(accessId, project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HmacKeyMetadata GetHmacKey(GetHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(GetHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(GetHmacKeyRequest request, st::CancellationToken cancellationToken) =>
            GetHmacKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HmacKeyMetadata GetHmacKey(string accessId, string project, gaxgrpc::CallSettings callSettings = null) =>
            GetHmacKey(new GetHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(string accessId, string project, gaxgrpc::CallSettings callSettings = null) =>
            GetHmacKeyAsync(new GetHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(string accessId, string project, st::CancellationToken cancellationToken) =>
            GetHmacKeyAsync(accessId, project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HmacKeyMetadata GetHmacKey(string accessId, gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            GetHmacKey(new GetHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(string accessId, gagr::ProjectName project, gaxgrpc::CallSettings callSettings = null) =>
            GetHmacKeyAsync(new GetHmacKeyRequest
            {
                AccessId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessId, nameof(accessId)),
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="accessId">
        /// Required. The identifying key for the HMAC to delete.
        /// </param>
        /// <param name="project">
        /// Required. The project the HMAC key lies in, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> GetHmacKeyAsync(string accessId, gagr::ProjectName project, st::CancellationToken cancellationToken) =>
            GetHmacKeyAsync(accessId, project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeys(ListHmacKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeysAsync(ListHmacKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="project">
        /// Required. The project to list HMAC keys for, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeys(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHmacKeys(new ListHmacKeysRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="project">
        /// Required. The project to list HMAC keys for, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeysAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHmacKeysAsync(new ListHmacKeysRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="project">
        /// Required. The project to list HMAC keys for, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeys(gagr::ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHmacKeys(new ListHmacKeysRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="project">
        /// Required. The project to list HMAC keys for, in the format of
        /// "projects/{projectIdentifier}".
        /// {projectIdentifier} can be the project ID or project number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeysAsync(gagr::ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListHmacKeysAsync(new ListHmacKeysRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HmacKeyMetadata UpdateHmacKey(UpdateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> UpdateHmacKeyAsync(UpdateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> UpdateHmacKeyAsync(UpdateHmacKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateHmacKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="hmacKey">
        /// Required. The HMAC key to update.
        /// If present, the hmac_key's `id` field will be used to identify the key.
        /// Otherwise, the hmac_key's access_id and project fields will be used to
        /// identify the key.
        /// </param>
        /// <param name="updateMask">
        /// Update mask for hmac_key.
        /// Not specifying any fields will mean only the `state` field is updated to
        /// the value specified in `hmac_key`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HmacKeyMetadata UpdateHmacKey(HmacKeyMetadata hmacKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHmacKey(new UpdateHmacKeyRequest
            {
                HmacKey = gax::GaxPreconditions.CheckNotNull(hmacKey, nameof(hmacKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="hmacKey">
        /// Required. The HMAC key to update.
        /// If present, the hmac_key's `id` field will be used to identify the key.
        /// Otherwise, the hmac_key's access_id and project fields will be used to
        /// identify the key.
        /// </param>
        /// <param name="updateMask">
        /// Update mask for hmac_key.
        /// Not specifying any fields will mean only the `state` field is updated to
        /// the value specified in `hmac_key`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> UpdateHmacKeyAsync(HmacKeyMetadata hmacKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHmacKeyAsync(new UpdateHmacKeyRequest
            {
                HmacKey = gax::GaxPreconditions.CheckNotNull(hmacKey, nameof(hmacKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="hmacKey">
        /// Required. The HMAC key to update.
        /// If present, the hmac_key's `id` field will be used to identify the key.
        /// Otherwise, the hmac_key's access_id and project fields will be used to
        /// identify the key.
        /// </param>
        /// <param name="updateMask">
        /// Update mask for hmac_key.
        /// Not specifying any fields will mean only the `state` field is updated to
        /// the value specified in `hmac_key`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HmacKeyMetadata> UpdateHmacKeyAsync(HmacKeyMetadata hmacKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHmacKeyAsync(hmacKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Storage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview and Naming Syntax
    /// 
    /// The Cloud Storage gRPC API allows applications to read and write data through
    /// the abstractions of buckets and objects. For a description of these
    /// abstractions please see https://cloud.google.com/storage/docs.
    /// 
    /// Resources are named as follows:
    /// - Projects are referred to as they are defined by the Resource Manager API,
    /// using strings like `projects/123456` or `projects/my-string-id`.
    /// - Buckets are named using string names of the form:
    /// `projects/{project}/buckets/{bucket}`
    /// For globally unique buckets, `_` may be substituted for the project.
    /// - Objects are uniquely identified by their name along with the name of the
    /// bucket they belong to, as separate strings in this API. For example:
    /// 
    /// ReadObjectRequest {
    /// bucket: 'projects/_/buckets/my-bucket'
    /// object: 'my-object'
    /// }
    /// Note that object names can contain `/` characters, which are treated as
    /// any other character (no special directory semantics).
    /// </remarks>
    public sealed partial class StorageClientImpl : StorageClient
    {
        private readonly gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> _callDeleteBucket;

        private readonly gaxgrpc::ApiCall<GetBucketRequest, Bucket> _callGetBucket;

        private readonly gaxgrpc::ApiCall<CreateBucketRequest, Bucket> _callCreateBucket;

        private readonly gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> _callListBuckets;

        private readonly gaxgrpc::ApiCall<LockBucketRetentionPolicyRequest, Bucket> _callLockBucketRetentionPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, Bucket> _callUpdateBucket;

        private readonly gaxgrpc::ApiCall<DeleteNotificationConfigRequest, wkt::Empty> _callDeleteNotificationConfig;

        private readonly gaxgrpc::ApiCall<GetNotificationConfigRequest, NotificationConfig> _callGetNotificationConfig;

        private readonly gaxgrpc::ApiCall<CreateNotificationConfigRequest, NotificationConfig> _callCreateNotificationConfig;

        private readonly gaxgrpc::ApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse> _callListNotificationConfigs;

        private readonly gaxgrpc::ApiCall<ComposeObjectRequest, Object> _callComposeObject;

        private readonly gaxgrpc::ApiCall<DeleteObjectRequest, wkt::Empty> _callDeleteObject;

        private readonly gaxgrpc::ApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse> _callCancelResumableWrite;

        private readonly gaxgrpc::ApiCall<GetObjectRequest, Object> _callGetObject;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadObjectRequest, ReadObjectResponse> _callReadObject;

        private readonly gaxgrpc::ApiCall<UpdateObjectRequest, Object> _callUpdateObject;

        private readonly gaxgrpc::ApiClientStreamingCall<WriteObjectRequest, WriteObjectResponse> _callWriteObject;

        private readonly gaxgrpc::ApiCall<ListObjectsRequest, ListObjectsResponse> _callListObjects;

        private readonly gaxgrpc::ApiCall<RewriteObjectRequest, RewriteResponse> _callRewriteObject;

        private readonly gaxgrpc::ApiCall<StartResumableWriteRequest, StartResumableWriteResponse> _callStartResumableWrite;

        private readonly gaxgrpc::ApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse> _callQueryWriteStatus;

        private readonly gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> _callGetServiceAccount;

        private readonly gaxgrpc::ApiCall<CreateHmacKeyRequest, CreateHmacKeyResponse> _callCreateHmacKey;

        private readonly gaxgrpc::ApiCall<DeleteHmacKeyRequest, wkt::Empty> _callDeleteHmacKey;

        private readonly gaxgrpc::ApiCall<GetHmacKeyRequest, HmacKeyMetadata> _callGetHmacKey;

        private readonly gaxgrpc::ApiCall<ListHmacKeysRequest, ListHmacKeysResponse> _callListHmacKeys;

        private readonly gaxgrpc::ApiCall<UpdateHmacKeyRequest, HmacKeyMetadata> _callUpdateHmacKey;

        /// <summary>
        /// Constructs a client wrapper for the Storage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageClientImpl(Storage.StorageClient grpcClient, StorageSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageSettings effectiveSettings = settings ?? StorageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callDeleteBucket = clientHelper.BuildApiCall<DeleteBucketRequest, wkt::Empty>("DeleteBucket", grpcClient.DeleteBucketAsync, grpcClient.DeleteBucket, effectiveSettings.DeleteBucketSettings).WithGoogleRequestParam("bucket", request => request.Name);
            Modify_ApiCall(ref _callDeleteBucket);
            Modify_DeleteBucketApiCall(ref _callDeleteBucket);
            _callGetBucket = clientHelper.BuildApiCall<GetBucketRequest, Bucket>("GetBucket", grpcClient.GetBucketAsync, grpcClient.GetBucket, effectiveSettings.GetBucketSettings).WithGoogleRequestParam("bucket", request => request.Name);
            Modify_ApiCall(ref _callGetBucket);
            Modify_GetBucketApiCall(ref _callGetBucket);
            _callCreateBucket = clientHelper.BuildApiCall<CreateBucketRequest, Bucket>("CreateBucket", grpcClient.CreateBucketAsync, grpcClient.CreateBucket, effectiveSettings.CreateBucketSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateBucketRequest>().WithExtractedParameter("project", "^(.+)$", request => request.Parent).WithExtractedParameter("project", "^(.+)$", request => request.Bucket?.Project));
            Modify_ApiCall(ref _callCreateBucket);
            Modify_CreateBucketApiCall(ref _callCreateBucket);
            _callListBuckets = clientHelper.BuildApiCall<ListBucketsRequest, ListBucketsResponse>("ListBuckets", grpcClient.ListBucketsAsync, grpcClient.ListBuckets, effectiveSettings.ListBucketsSettings).WithGoogleRequestParam("project", request => request.Parent);
            Modify_ApiCall(ref _callListBuckets);
            Modify_ListBucketsApiCall(ref _callListBuckets);
            _callLockBucketRetentionPolicy = clientHelper.BuildApiCall<LockBucketRetentionPolicyRequest, Bucket>("LockBucketRetentionPolicy", grpcClient.LockBucketRetentionPolicyAsync, grpcClient.LockBucketRetentionPolicy, effectiveSettings.LockBucketRetentionPolicySettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callLockBucketRetentionPolicy);
            Modify_LockBucketRetentionPolicyApiCall(ref _callLockBucketRetentionPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::GetIamPolicyRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)/objects(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::SetIamPolicyRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)/objects(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<gciv::TestIamPermissionsRequest>().WithExtractedParameter("bucket", "^(.+)$", request => request.Resource).WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)/objects(?:/.*)?$", request => request.Resource));
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdateBucket = clientHelper.BuildApiCall<UpdateBucketRequest, Bucket>("UpdateBucket", grpcClient.UpdateBucketAsync, grpcClient.UpdateBucket, effectiveSettings.UpdateBucketSettings).WithGoogleRequestParam("bucket", request => request.Bucket?.Name);
            Modify_ApiCall(ref _callUpdateBucket);
            Modify_UpdateBucketApiCall(ref _callUpdateBucket);
            _callDeleteNotificationConfig = clientHelper.BuildApiCall<DeleteNotificationConfigRequest, wkt::Empty>("DeleteNotificationConfig", grpcClient.DeleteNotificationConfigAsync, grpcClient.DeleteNotificationConfig, effectiveSettings.DeleteNotificationConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteNotificationConfigRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteNotificationConfig);
            Modify_DeleteNotificationConfigApiCall(ref _callDeleteNotificationConfig);
            _callGetNotificationConfig = clientHelper.BuildApiCall<GetNotificationConfigRequest, NotificationConfig>("GetNotificationConfig", grpcClient.GetNotificationConfigAsync, grpcClient.GetNotificationConfig, effectiveSettings.GetNotificationConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetNotificationConfigRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetNotificationConfig);
            Modify_GetNotificationConfigApiCall(ref _callGetNotificationConfig);
            _callCreateNotificationConfig = clientHelper.BuildApiCall<CreateNotificationConfigRequest, NotificationConfig>("CreateNotificationConfig", grpcClient.CreateNotificationConfigAsync, grpcClient.CreateNotificationConfig, effectiveSettings.CreateNotificationConfigSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateNotificationConfig);
            Modify_CreateNotificationConfigApiCall(ref _callCreateNotificationConfig);
            _callListNotificationConfigs = clientHelper.BuildApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse>("ListNotificationConfigs", grpcClient.ListNotificationConfigsAsync, grpcClient.ListNotificationConfigs, effectiveSettings.ListNotificationConfigsSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListNotificationConfigs);
            Modify_ListNotificationConfigsApiCall(ref _callListNotificationConfigs);
            _callComposeObject = clientHelper.BuildApiCall<ComposeObjectRequest, Object>("ComposeObject", grpcClient.ComposeObjectAsync, grpcClient.ComposeObject, effectiveSettings.ComposeObjectSettings).WithGoogleRequestParam("bucket", request => request.Destination?.Bucket);
            Modify_ApiCall(ref _callComposeObject);
            Modify_ComposeObjectApiCall(ref _callComposeObject);
            _callDeleteObject = clientHelper.BuildApiCall<DeleteObjectRequest, wkt::Empty>("DeleteObject", grpcClient.DeleteObjectAsync, grpcClient.DeleteObject, effectiveSettings.DeleteObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callDeleteObject);
            Modify_DeleteObjectApiCall(ref _callDeleteObject);
            _callCancelResumableWrite = clientHelper.BuildApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse>("CancelResumableWrite", grpcClient.CancelResumableWriteAsync, grpcClient.CancelResumableWrite, effectiveSettings.CancelResumableWriteSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CancelResumableWriteRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.UploadId));
            Modify_ApiCall(ref _callCancelResumableWrite);
            Modify_CancelResumableWriteApiCall(ref _callCancelResumableWrite);
            _callGetObject = clientHelper.BuildApiCall<GetObjectRequest, Object>("GetObject", grpcClient.GetObjectAsync, grpcClient.GetObject, effectiveSettings.GetObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callGetObject);
            Modify_GetObjectApiCall(ref _callGetObject);
            _callReadObject = clientHelper.BuildApiCall<ReadObjectRequest, ReadObjectResponse>("ReadObject", grpcClient.ReadObject, effectiveSettings.ReadObjectSettings).WithGoogleRequestParam("bucket", request => request.Bucket);
            Modify_ApiCall(ref _callReadObject);
            Modify_ReadObjectApiCall(ref _callReadObject);
            _callUpdateObject = clientHelper.BuildApiCall<UpdateObjectRequest, Object>("UpdateObject", grpcClient.UpdateObjectAsync, grpcClient.UpdateObject, effectiveSettings.UpdateObjectSettings).WithGoogleRequestParam("bucket", request => request.Object?.Bucket);
            Modify_ApiCall(ref _callUpdateObject);
            Modify_UpdateObjectApiCall(ref _callUpdateObject);
            _callWriteObject = clientHelper.BuildApiCall<WriteObjectRequest, WriteObjectResponse>("WriteObject", grpcClient.WriteObject, effectiveSettings.WriteObjectSettings, effectiveSettings.WriteObjectStreamingSettings);
            Modify_ApiCall(ref _callWriteObject);
            Modify_WriteObjectApiCall(ref _callWriteObject);
            _callListObjects = clientHelper.BuildApiCall<ListObjectsRequest, ListObjectsResponse>("ListObjects", grpcClient.ListObjectsAsync, grpcClient.ListObjects, effectiveSettings.ListObjectsSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListObjects);
            Modify_ListObjectsApiCall(ref _callListObjects);
            _callRewriteObject = clientHelper.BuildApiCall<RewriteObjectRequest, RewriteResponse>("RewriteObject", grpcClient.RewriteObjectAsync, grpcClient.RewriteObject, effectiveSettings.RewriteObjectSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RewriteObjectRequest>().WithExtractedParameter("source_bucket", "^(.+)$", request => request.SourceBucket).WithExtractedParameter("bucket", "^(.+)$", request => request.DestinationBucket));
            Modify_ApiCall(ref _callRewriteObject);
            Modify_RewriteObjectApiCall(ref _callRewriteObject);
            _callStartResumableWrite = clientHelper.BuildApiCall<StartResumableWriteRequest, StartResumableWriteResponse>("StartResumableWrite", grpcClient.StartResumableWriteAsync, grpcClient.StartResumableWrite, effectiveSettings.StartResumableWriteSettings).WithGoogleRequestParam("bucket", request => request.WriteObjectSpec?.Resource?.Bucket);
            Modify_ApiCall(ref _callStartResumableWrite);
            Modify_StartResumableWriteApiCall(ref _callStartResumableWrite);
            _callQueryWriteStatus = clientHelper.BuildApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse>("QueryWriteStatus", grpcClient.QueryWriteStatusAsync, grpcClient.QueryWriteStatus, effectiveSettings.QueryWriteStatusSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<QueryWriteStatusRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.UploadId));
            Modify_ApiCall(ref _callQueryWriteStatus);
            Modify_QueryWriteStatusApiCall(ref _callQueryWriteStatus);
            _callGetServiceAccount = clientHelper.BuildApiCall<GetServiceAccountRequest, ServiceAccount>("GetServiceAccount", grpcClient.GetServiceAccountAsync, grpcClient.GetServiceAccount, effectiveSettings.GetServiceAccountSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGetServiceAccount);
            Modify_GetServiceAccountApiCall(ref _callGetServiceAccount);
            _callCreateHmacKey = clientHelper.BuildApiCall<CreateHmacKeyRequest, CreateHmacKeyResponse>("CreateHmacKey", grpcClient.CreateHmacKeyAsync, grpcClient.CreateHmacKey, effectiveSettings.CreateHmacKeySettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callCreateHmacKey);
            Modify_CreateHmacKeyApiCall(ref _callCreateHmacKey);
            _callDeleteHmacKey = clientHelper.BuildApiCall<DeleteHmacKeyRequest, wkt::Empty>("DeleteHmacKey", grpcClient.DeleteHmacKeyAsync, grpcClient.DeleteHmacKey, effectiveSettings.DeleteHmacKeySettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callDeleteHmacKey);
            Modify_DeleteHmacKeyApiCall(ref _callDeleteHmacKey);
            _callGetHmacKey = clientHelper.BuildApiCall<GetHmacKeyRequest, HmacKeyMetadata>("GetHmacKey", grpcClient.GetHmacKeyAsync, grpcClient.GetHmacKey, effectiveSettings.GetHmacKeySettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGetHmacKey);
            Modify_GetHmacKeyApiCall(ref _callGetHmacKey);
            _callListHmacKeys = clientHelper.BuildApiCall<ListHmacKeysRequest, ListHmacKeysResponse>("ListHmacKeys", grpcClient.ListHmacKeysAsync, grpcClient.ListHmacKeys, effectiveSettings.ListHmacKeysSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callListHmacKeys);
            Modify_ListHmacKeysApiCall(ref _callListHmacKeys);
            _callUpdateHmacKey = clientHelper.BuildApiCall<UpdateHmacKeyRequest, HmacKeyMetadata>("UpdateHmacKey", grpcClient.UpdateHmacKeyAsync, grpcClient.UpdateHmacKey, effectiveSettings.UpdateHmacKeySettings).WithGoogleRequestParam("project", request => request.HmacKey?.Project);
            Modify_ApiCall(ref _callUpdateHmacKey);
            Modify_UpdateHmacKeyApiCall(ref _callUpdateHmacKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiClientStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteBucketApiCall(ref gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> call);

        partial void Modify_GetBucketApiCall(ref gaxgrpc::ApiCall<GetBucketRequest, Bucket> call);

        partial void Modify_CreateBucketApiCall(ref gaxgrpc::ApiCall<CreateBucketRequest, Bucket> call);

        partial void Modify_ListBucketsApiCall(ref gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> call);

        partial void Modify_LockBucketRetentionPolicyApiCall(ref gaxgrpc::ApiCall<LockBucketRetentionPolicyRequest, Bucket> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_UpdateBucketApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, Bucket> call);

        partial void Modify_DeleteNotificationConfigApiCall(ref gaxgrpc::ApiCall<DeleteNotificationConfigRequest, wkt::Empty> call);

        partial void Modify_GetNotificationConfigApiCall(ref gaxgrpc::ApiCall<GetNotificationConfigRequest, NotificationConfig> call);

        partial void Modify_CreateNotificationConfigApiCall(ref gaxgrpc::ApiCall<CreateNotificationConfigRequest, NotificationConfig> call);

        partial void Modify_ListNotificationConfigsApiCall(ref gaxgrpc::ApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse> call);

        partial void Modify_ComposeObjectApiCall(ref gaxgrpc::ApiCall<ComposeObjectRequest, Object> call);

        partial void Modify_DeleteObjectApiCall(ref gaxgrpc::ApiCall<DeleteObjectRequest, wkt::Empty> call);

        partial void Modify_CancelResumableWriteApiCall(ref gaxgrpc::ApiCall<CancelResumableWriteRequest, CancelResumableWriteResponse> call);

        partial void Modify_GetObjectApiCall(ref gaxgrpc::ApiCall<GetObjectRequest, Object> call);

        partial void Modify_ReadObjectApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadObjectRequest, ReadObjectResponse> call);

        partial void Modify_UpdateObjectApiCall(ref gaxgrpc::ApiCall<UpdateObjectRequest, Object> call);

        partial void Modify_WriteObjectApiCall(ref gaxgrpc::ApiClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call);

        partial void Modify_ListObjectsApiCall(ref gaxgrpc::ApiCall<ListObjectsRequest, ListObjectsResponse> call);

        partial void Modify_RewriteObjectApiCall(ref gaxgrpc::ApiCall<RewriteObjectRequest, RewriteResponse> call);

        partial void Modify_StartResumableWriteApiCall(ref gaxgrpc::ApiCall<StartResumableWriteRequest, StartResumableWriteResponse> call);

        partial void Modify_QueryWriteStatusApiCall(ref gaxgrpc::ApiCall<QueryWriteStatusRequest, QueryWriteStatusResponse> call);

        partial void Modify_GetServiceAccountApiCall(ref gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> call);

        partial void Modify_CreateHmacKeyApiCall(ref gaxgrpc::ApiCall<CreateHmacKeyRequest, CreateHmacKeyResponse> call);

        partial void Modify_DeleteHmacKeyApiCall(ref gaxgrpc::ApiCall<DeleteHmacKeyRequest, wkt::Empty> call);

        partial void Modify_GetHmacKeyApiCall(ref gaxgrpc::ApiCall<GetHmacKeyRequest, HmacKeyMetadata> call);

        partial void Modify_ListHmacKeysApiCall(ref gaxgrpc::ApiCall<ListHmacKeysRequest, ListHmacKeysResponse> call);

        partial void Modify_UpdateHmacKeyApiCall(ref gaxgrpc::ApiCall<UpdateHmacKeyRequest, HmacKeyMetadata> call);

        partial void OnConstruction(Storage.StorageClient grpcClient, StorageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Storage client</summary>
        public override Storage.StorageClient GrpcClient { get; }

        partial void Modify_DeleteBucketRequest(ref DeleteBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBucketRequest(ref GetBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBucketRequest(ref CreateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBucketsRequest(ref ListBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LockBucketRetentionPolicyRequest(ref LockBucketRetentionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBucketRequest(ref UpdateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotificationConfigRequest(ref DeleteNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationConfigRequest(ref GetNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNotificationConfigRequest(ref CreateNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotificationConfigsRequest(ref ListNotificationConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComposeObjectRequest(ref ComposeObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteObjectRequest(ref DeleteObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelResumableWriteRequest(ref CancelResumableWriteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetObjectRequest(ref GetObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadObjectRequest(ref ReadObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateObjectRequest(ref UpdateObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteObjectRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteObjectRequestRequest(ref WriteObjectRequest request);

        partial void Modify_ListObjectsRequest(ref ListObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RewriteObjectRequest(ref RewriteObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartResumableWriteRequest(ref StartResumableWriteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryWriteStatusRequest(ref QueryWriteStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceAccountRequest(ref GetServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHmacKeyRequest(ref CreateHmacKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHmacKeyRequest(ref DeleteHmacKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHmacKeyRequest(ref GetHmacKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHmacKeysRequest(ref ListHmacKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHmacKeyRequest(ref UpdateHmacKeyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            _callDeleteBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            return _callDeleteBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of buckets for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockBucketRetentionPolicyRequest(ref request, ref callSettings);
            return _callLockBucketRetentionPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Locks retention policy on a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockBucketRetentionPolicyRequest(ref request, ref callSettings);
            return _callLockBucketRetentionPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an IAM policy for the specified bucket or object.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket or object to see which, if
        /// any, are held by the caller.
        /// The `resource` field in the request should be
        /// projects/_/buckets/&lt;bucket_name&gt; for a bucket or
        /// projects/_/buckets/&lt;bucket_name&gt;/objects/&lt;object_name&gt; for an object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. Equivalent to JSON API's storage.buckets.patch method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNotificationConfig(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationConfigRequest(ref request, ref callSettings);
            _callDeleteNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationConfigRequest(ref request, ref callSettings);
            return _callDeleteNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationConfig GetNotificationConfig(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationConfigRequest(ref request, ref callSettings);
            return _callGetNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// View a NotificationConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationConfigRequest(ref request, ref callSettings);
            return _callGetNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationConfig CreateNotificationConfig(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationConfigRequest(ref request, ref callSettings);
            return _callCreateNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a NotificationConfig for a given bucket.
        /// These NotificationConfigs, when triggered, publish messages to the
        /// specified Pub/Sub topics. See
        /// https://cloud.google.com/storage/docs/pubsub-notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationConfigRequest(ref request, ref callSettings);
            return _callCreateNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationConfigsRequest, ListNotificationConfigsResponse, NotificationConfig>(_callListNotificationConfigs, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of NotificationConfigs for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationConfigsRequest, ListNotificationConfigsResponse, NotificationConfig>(_callListNotificationConfigs, request, callSettings);
        }

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object ComposeObject(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComposeObjectRequest(ref request, ref callSettings);
            return _callComposeObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same
        /// bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> ComposeObjectAsync(ComposeObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComposeObjectRequest(ref request, ref callSettings);
            return _callComposeObject.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteObject(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteObjectRequest(ref request, ref callSettings);
            _callDeleteObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an object and its metadata.
        /// 
        /// Deletions are normally permanent when versioning is disabled or whenever
        /// the generation parameter is used. However, if soft delete is enabled for
        /// the bucket, deleted objects can be restored using RestoreObject until the
        /// soft delete retention period has passed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteObjectAsync(DeleteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteObjectRequest(ref request, ref callSettings);
            return _callDeleteObject.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CancelResumableWriteResponse CancelResumableWrite(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelResumableWriteRequest(ref request, ref callSettings);
            return _callCancelResumableWrite.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels an in-progress resumable upload.
        /// 
        /// Any attempts to write to the resumable upload after cancelling the upload
        /// will fail.
        /// 
        /// The behavior for currently in progress write operations is not guaranteed -
        /// they could either complete before the cancellation or fail if the
        /// cancellation completes first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CancelResumableWriteResponse> CancelResumableWriteAsync(CancelResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelResumableWriteRequest(ref request, ref callSettings);
            return _callCancelResumableWrite.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object GetObject(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetObjectRequest(ref request, ref callSettings);
            return _callGetObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an object's metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> GetObjectAsync(GetObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetObjectRequest(ref request, ref callSettings);
            return _callGetObject.Async(request, callSettings);
        }

        internal sealed partial class ReadObjectStreamImpl : ReadObjectStream
        {
            /// <summary>Construct the server streaming method for <c>ReadObject</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadObjectStreamImpl(grpccore::AsyncServerStreamingCall<ReadObjectResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadObjectResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Reads an object's data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override StorageClient.ReadObjectStream ReadObject(ReadObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadObjectRequest(ref request, ref callSettings);
            return new ReadObjectStreamImpl(_callReadObject.Call(request, callSettings));
        }

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Object UpdateObject(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateObjectRequest(ref request, ref callSettings);
            return _callUpdateObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an object's metadata.
        /// Equivalent to JSON API's storage.objects.patch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Object> UpdateObjectAsync(UpdateObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateObjectRequest(ref request, ref callSettings);
            return _callUpdateObject.Async(request, callSettings);
        }

        internal sealed partial class WriteObjectStreamImpl : WriteObjectStream
        {
            /// <summary>Construct the client streaming method for <c>WriteObject</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC client streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{WriteObjectRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public WriteObjectStreamImpl(StorageClientImpl service, grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call, gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StorageClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> _writeBuffer;

            public override grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> GrpcCall { get; }

            private WriteObjectRequest ModifyRequest(WriteObjectRequest request)
            {
                _service.Modify_WriteObjectRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(WriteObjectRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(WriteObjectRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(WriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(WriteObjectRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Stores a new object and metadata.
        /// 
        /// An object can be written either in a single message stream or in a
        /// resumable sequence of message streams. To write using a single stream,
        /// the client should include in the first message of the stream an
        /// `WriteObjectSpec` describing the destination bucket, object, and any
        /// preconditions. Additionally, the final message must set 'finish_write' to
        /// true, or else it is an error.
        /// 
        /// For a resumable write, the client should instead call
        /// `StartResumableWrite()`, populating a `WriteObjectSpec` into that request.
        /// They should then attach the returned `upload_id` to the first message of
        /// each following call to `WriteObject`. If the stream is closed before
        /// finishing the upload (either explicitly by the client or due to a network
        /// error or an error response from the server), the client should do as
        /// follows:
        /// - Check the result Status of the stream, to determine if writing can be
        /// resumed on this stream or must be restarted from scratch (by calling
        /// `StartResumableWrite()`). The resumable errors are DEADLINE_EXCEEDED,
        /// INTERNAL, and UNAVAILABLE. For each case, the client should use binary
        /// exponential backoff before retrying.  Additionally, writes can be
        /// resumed after RESOURCE_EXHAUSTED errors, but only after taking
        /// appropriate measures, which may include reducing aggregate send rate
        /// across clients and/or requesting a quota increase for your project.
        /// - If the call to `WriteObject` returns `ABORTED`, that indicates
        /// concurrent attempts to update the resumable write, caused either by
        /// multiple racing clients or by a single client where the previous
        /// request was timed out on the client side but nonetheless reached the
        /// server. In this case the client should take steps to prevent further
        /// concurrent writes (e.g., increase the timeouts, stop using more than
        /// one process to perform the upload, etc.), and then should follow the
        /// steps below for resuming the upload.
        /// - For resumable errors, the client should call `QueryWriteStatus()` and
        /// then continue writing from the returned `persisted_size`. This may be
        /// less than the amount of data the client previously sent. Note also that
        /// it is acceptable to send data starting at an offset earlier than the
        /// returned `persisted_size`; in this case, the service will skip data at
        /// offsets that were already persisted (without checking that it matches
        /// the previously written data), and write only the data starting from the
        /// persisted offset. Even though the data isn't written, it may still
        /// incur a performance cost over resuming at the correct write offset.
        /// This behavior can make client-side handling simpler in some cases.
        /// - Clients must only send data that is a multiple of 256 KiB per message,
        /// unless the object is being finished with `finish_write` set to `true`.
        /// 
        /// The service will not view the object as complete until the client has
        /// sent a `WriteObjectRequest` with `finish_write` set to `true`. Sending any
        /// requests on a stream after sending a request with `finish_write` set to
        /// `true` will cause an error. The client **should** check the response it
        /// receives to determine how much data the service was able to commit and
        /// whether the service views the object as complete.
        /// 
        /// Attempting to resume an already finalized object will result in an OK
        /// status, with a WriteObjectResponse containing the finalized object's
        /// metadata.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client stream.</returns>
        public override StorageClient.WriteObjectStream WriteObject(gaxgrpc::CallSettings callSettings = null, gaxgrpc::ClientStreamingSettings streamingSettings = null)
        {
            Modify_WriteObjectRequestCallSettings(ref callSettings);
            gaxgrpc::ClientStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callWriteObject.StreamingSettings;
            grpccore::AsyncClientStreamingCall<WriteObjectRequest, WriteObjectResponse> call = _callWriteObject.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<WriteObjectRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new WriteObjectStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Object"/> resources.</returns>
        public override gax::PagedEnumerable<ListObjectsResponse, Object> ListObjects(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListObjectsRequest, ListObjectsResponse, Object>(_callListObjects, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of objects matching the criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Object"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListObjectsResponse, Object> ListObjectsAsync(ListObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListObjectsRequest, ListObjectsResponse, Object>(_callListObjects, request, callSettings);
        }

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RewriteResponse RewriteObject(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RewriteObjectRequest(ref request, ref callSettings);
            return _callRewriteObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Rewrites a source object to a destination object. Optionally overrides
        /// metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RewriteResponse> RewriteObjectAsync(RewriteObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RewriteObjectRequest(ref request, ref callSettings);
            return _callRewriteObject.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a resumable write. How long the write operation remains valid, and
        /// what happens when the write operation becomes invalid, are
        /// service-dependent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartResumableWriteResponse StartResumableWrite(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartResumableWriteRequest(ref request, ref callSettings);
            return _callStartResumableWrite.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a resumable write. How long the write operation remains valid, and
        /// what happens when the write operation becomes invalid, are
        /// service-dependent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartResumableWriteResponse> StartResumableWriteAsync(StartResumableWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartResumableWriteRequest(ref request, ref callSettings);
            return _callStartResumableWrite.Async(request, callSettings);
        }

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryWriteStatusResponse QueryWriteStatus(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWriteStatusRequest(ref request, ref callSettings);
            return _callQueryWriteStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Determines the `persisted_size` for an object that is being written, which
        /// can then be used as the `write_offset` for the next `Write()` call.
        /// 
        /// If the object does not exist (i.e., the object has been deleted, or the
        /// first `Write()` has not yet reached the service), this method returns the
        /// error `NOT_FOUND`.
        /// 
        /// The client **may** call `QueryWriteStatus()` at any time to determine how
        /// much data has been processed for this object. This is useful if the
        /// client is buffering data and needs to know which data can be safely
        /// evicted. For any sequence of `QueryWriteStatus()` calls for a given
        /// object name, the sequence of returned `persisted_size` values will be
        /// non-decreasing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryWriteStatusResponse> QueryWriteStatusAsync(QueryWriteStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWriteStatusRequest(ref request, ref callSettings);
            return _callQueryWriteStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the name of a project's Google Cloud Storage service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateHmacKeyResponse CreateHmacKey(CreateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHmacKeyRequest(ref request, ref callSettings);
            return _callCreateHmacKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new HMAC key for the given service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateHmacKeyResponse> CreateHmacKeyAsync(CreateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHmacKeyRequest(ref request, ref callSettings);
            return _callCreateHmacKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteHmacKey(DeleteHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHmacKeyRequest(ref request, ref callSettings);
            _callDeleteHmacKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a given HMAC key.  Key must be in an INACTIVE state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteHmacKeyAsync(DeleteHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHmacKeyRequest(ref request, ref callSettings);
            return _callDeleteHmacKey.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HmacKeyMetadata GetHmacKey(GetHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHmacKeyRequest(ref request, ref callSettings);
            return _callGetHmacKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an existing HMAC key metadata for the given id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HmacKeyMetadata> GetHmacKeyAsync(GetHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHmacKeyRequest(ref request, ref callSettings);
            return _callGetHmacKey.Async(request, callSettings);
        }

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public override gax::PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeys(ListHmacKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHmacKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHmacKeysRequest, ListHmacKeysResponse, HmacKeyMetadata>(_callListHmacKeys, request, callSettings);
        }

        /// <summary>
        /// Lists HMAC keys under a given project with the additional filters provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HmacKeyMetadata"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> ListHmacKeysAsync(ListHmacKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHmacKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHmacKeysRequest, ListHmacKeysResponse, HmacKeyMetadata>(_callListHmacKeys, request, callSettings);
        }

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HmacKeyMetadata UpdateHmacKey(UpdateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHmacKeyRequest(ref request, ref callSettings);
            return _callUpdateHmacKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a given HMAC key state between ACTIVE and INACTIVE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HmacKeyMetadata> UpdateHmacKeyAsync(UpdateHmacKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHmacKeyRequest(ref request, ref callSettings);
            return _callUpdateHmacKey.Async(request, callSettings);
        }
    }

    public partial class ListBucketsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListObjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHmacKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBucketsResponse : gaxgrpc::IPageResponse<Bucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Bucket> GetEnumerator() => Buckets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotificationConfigsResponse : gaxgrpc::IPageResponse<NotificationConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationConfig> GetEnumerator() => NotificationConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListObjectsResponse : gaxgrpc::IPageResponse<Object>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Object> GetEnumerator() => Objects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHmacKeysResponse : gaxgrpc::IPageResponse<HmacKeyMetadata>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HmacKeyMetadata> GetEnumerator() => HmacKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
