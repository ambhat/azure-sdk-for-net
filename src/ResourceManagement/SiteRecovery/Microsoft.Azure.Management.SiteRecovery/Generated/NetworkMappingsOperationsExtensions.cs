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
    /// Extension methods for NetworkMappingsOperations.
    /// </summary>
    public static partial class NetworkMappingsOperationsExtensions
    {
            /// <summary>
            /// Tracks the provider async operation.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            /// <param name='jobName'>
            /// job id to track.
            /// </param>
            public static NetworkMapping TrackAsyncOperation(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, string jobName)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).TrackAsyncOperationAsync(fabricName, networkName, networkMappingName, jobName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tracks the provider async operation.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            /// <param name='jobName'>
            /// job id to track.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkMapping> TrackAsyncOperationAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TrackAsyncOperationWithHttpMessagesAsync(fabricName, networkName, networkMappingName, jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the network mappings under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkMapping> List(this INetworkMappingsOperations operations)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the network mappings under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> ListAsync(this INetworkMappingsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the network mappings under a network.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            public static IPage<NetworkMapping> ListByFabric(this INetworkMappingsOperations operations, string fabricName, string networkName)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).ListByFabricAsync(fabricName, networkName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the network mappings under a network.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkMapping>> ListByFabricAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricWithHttpMessagesAsync(fabricName, networkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets network mapping by name.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            public static NetworkMapping Get(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).GetAsync(fabricName, networkName, networkMappingName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets network mapping by name.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkMapping> GetAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, networkName, networkMappingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            /// <param name='input'>
            /// Create network mapping input.
            /// </param>
            public static NetworkMapping Create(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).CreateAsync(fabricName, networkName, networkMappingName, input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            /// <param name='input'>
            /// Create network mapping input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkMapping> CreateAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, networkName, networkMappingName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            /// <param name='input'>
            /// Create network mapping input.
            /// </param>
            public static NetworkMapping BeginCreate(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).BeginCreateAsync(fabricName, networkName, networkMappingName, input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// Network mapping name.
            /// </param>
            /// <param name='input'>
            /// Create network mapping input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkMapping> BeginCreateAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, networkName, networkMappingName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            public static void Delete(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName)
            {
                Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).DeleteAsync(fabricName, networkName, networkMappingName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(fabricName, networkName, networkMappingName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            public static void BeginDelete(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName)
            {
                Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).BeginDeleteAsync(fabricName, networkName, networkMappingName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete network mapping.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Primary fabric name.
            /// </param>
            /// <param name='networkName'>
            /// Primary network name.
            /// </param>
            /// <param name='networkMappingName'>
            /// ARM Resource Name for network mapping.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INetworkMappingsOperations operations, string fabricName, string networkName, string networkMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(fabricName, networkName, networkMappingName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the network mappings under a vault.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkMapping> ListNext(this INetworkMappingsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the network mappings under a vault.
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
            public static async Task<IPage<NetworkMapping>> ListNextAsync(this INetworkMappingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the network mappings under a network.
            /// </summary>
            /// Deletes the site.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkMapping> ListByFabricNext(this INetworkMappingsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INetworkMappingsOperations)s).ListByFabricNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the network mappings under a network.
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
            public static async Task<IPage<NetworkMapping>> ListByFabricNextAsync(this INetworkMappingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
