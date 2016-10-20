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
    /// Extension methods for NetworksControllerOperations.
    /// </summary>
    public static partial class NetworksControllerOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Network> EnumerateAllNetworks(this INetworksControllerOperations operations)
            {
                return Task.Factory.StartNew(s => ((INetworksControllerOperations)s).EnumerateAllNetworksAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Network>> EnumerateAllNetworksAsync(this INetworksControllerOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateAllNetworksWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            public static IPage<Network> EnumerateNetworks(this INetworksControllerOperations operations, string fabricName)
            {
                return Task.Factory.StartNew(s => ((INetworksControllerOperations)s).EnumerateNetworksAsync(fabricName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Network>> EnumerateNetworksAsync(this INetworksControllerOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateNetworksWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
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
            public static Network GetNetwork(this INetworksControllerOperations operations, string fabricName, string networkName)
            {
                return Task.Factory.StartNew(s => ((INetworksControllerOperations)s).GetNetworkAsync(fabricName, networkName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task<Network> GetNetworkAsync(this INetworksControllerOperations operations, string fabricName, string networkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNetworkWithHttpMessagesAsync(fabricName, networkName, null, cancellationToken).ConfigureAwait(false))
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
            public static IPage<Network> EnumerateAllNetworksNext(this INetworksControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworksControllerOperations)s).EnumerateAllNetworksNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task<IPage<Network>> EnumerateAllNetworksNextAsync(this INetworksControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateAllNetworksNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
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
            public static IPage<Network> EnumerateNetworksNext(this INetworksControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworksControllerOperations)s).EnumerateNetworksNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task<IPage<Network>> EnumerateNetworksNextAsync(this INetworksControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateNetworksNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
