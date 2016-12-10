// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for StorageClassificationsOperations.
    /// </summary>
    public static partial class StorageClassificationsOperationsExtensions
    {
            /// <summary>
            /// Gets the details of a storage classification.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Name of storage classification to be fetched.
            /// </param>
            public static StorageClassification Get(this IStorageClassificationsOperations operations, string fabricName, string storageClassificationName)
            {
                return Task.Factory.StartNew(s => ((IStorageClassificationsOperations)s).GetAsync(fabricName, storageClassificationName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a storage classification.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Name of storage classification to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageClassification> GetAsync(this IStorageClassificationsOperations operations, string fabricName, string storageClassificationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, storageClassificationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            public static IPage<StorageClassification> ListByFabric(this IStorageClassificationsOperations operations, string fabricName)
            {
                return Task.Factory.StartNew(s => ((IStorageClassificationsOperations)s).ListByFabricAsync(fabricName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Site name of interest.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListByFabricAsync(this IStorageClassificationsOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<StorageClassification> List(this IStorageClassificationsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IStorageClassificationsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListAsync(this IStorageClassificationsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassification> ListByFabricNext(this IStorageClassificationsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IStorageClassificationsOperations)s).ListByFabricNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a fabric.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListByFabricNextAsync(this IStorageClassificationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassification> ListNext(this IStorageClassificationsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IStorageClassificationsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification objects under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassification>> ListNextAsync(this IStorageClassificationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
