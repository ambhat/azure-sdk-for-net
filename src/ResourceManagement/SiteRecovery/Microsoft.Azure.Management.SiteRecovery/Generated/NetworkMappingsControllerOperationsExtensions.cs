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
    /// Extension methods for NetworkMappingsControllerOperations.
    /// </summary>
    public static partial class NetworkMappingsControllerOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='jobName'>
            /// </param>
            public static void TrackAsyncNetworkMappingOperation(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, string jobName)
            {
                Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).TrackAsyncNetworkMappingOperationAsync(fabricName, networkName, networkMappingName, jobName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='jobName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TrackAsyncNetworkMappingOperationAsync(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.TrackAsyncNetworkMappingOperationWithHttpMessagesAsync(fabricName, networkName, networkMappingName, jobName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkMapping> EnumerateAllNetworkMappings(this INetworkMappingsControllerOperations operations)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).EnumerateAllNetworkMappingsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> EnumerateAllNetworkMappingsAsync(this INetworkMappingsControllerOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateAllNetworkMappingsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            public static IPage<NetworkMapping> EnumerateNetworkMappings(this INetworkMappingsControllerOperations operations, string fabricName, string networkName)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).EnumerateNetworkMappingsAsync(fabricName, networkName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> EnumerateNetworkMappingsAsync(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateNetworkMappingsWithHttpMessagesAsync(fabricName, networkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            public static NetworkMapping GetNetworkMapping(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).GetNetworkMappingAsync(fabricName, networkName, networkMappingName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkMapping> GetNetworkMappingAsync(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNetworkMappingWithHttpMessagesAsync(fabricName, networkName, networkMappingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='input'>
            /// </param>
            public static void CreateNetworkMapping(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input)
            {
                Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).CreateNetworkMappingAsync(fabricName, networkName, networkMappingName, input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='input'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateNetworkMappingAsync(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CreateNetworkMappingWithHttpMessagesAsync(fabricName, networkName, networkMappingName, input, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            public static void DeleteNetworkMapping(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName)
            {
                Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).DeleteNetworkMappingAsync(fabricName, networkName, networkMappingName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='networkName'>
            /// </param>
            /// <param name='networkMappingName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteNetworkMappingAsync(this INetworkMappingsControllerOperations operations, string fabricName, string networkName, string networkMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteNetworkMappingWithHttpMessagesAsync(fabricName, networkName, networkMappingName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkMapping> EnumerateAllNetworkMappingsNext(this INetworkMappingsControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).EnumerateAllNetworkMappingsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> EnumerateAllNetworkMappingsNextAsync(this INetworkMappingsControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateAllNetworkMappingsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkMapping> EnumerateNetworkMappingsNext(this INetworkMappingsControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsControllerOperations)s).EnumerateNetworkMappingsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> EnumerateNetworkMappingsNextAsync(this INetworkMappingsControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateNetworkMappingsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
