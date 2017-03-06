// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProtectionContainersOperations.
    /// </summary>
    public static partial class ProtectionContainersOperationsExtensions
    {
            /// <summary>
            /// Switches protection from one container to another or one replication
            /// provider to
            /// another.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='switchInput'>
            /// Switch protection input.
            /// </param>
            public static ProtectionContainer SwitchProtection(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, SwitchProtectionInput switchInput)
            {
                return operations.SwitchProtectionAsync(fabricName, protectionContainerName, switchInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Switches protection from one container to another or one replication
            /// provider to
            /// another.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='switchInput'>
            /// Switch protection input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> SwitchProtectionAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SwitchProtectionWithHttpMessagesAsync(fabricName, protectionContainerName, switchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            public static void Delete(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName)
            {
                operations.DeleteAsync(fabricName, protectionContainerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Tracks the provider async operation.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Site name to work on.
            /// </param>
            /// <param name='jobId'>
            /// job id to track.
            /// </param>
            public static ProtectionContainer GetTrackAsyncOperation(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, string jobId)
            {
                return operations.GetTrackAsyncOperationAsync(fabricName, protectionContainerName, jobId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tracks the provider async operation.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Site name to work on.
            /// </param>
            /// <param name='jobId'>
            /// job id to track.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> GetTrackAsyncOperationAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, string jobId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrackAsyncOperationWithHttpMessagesAsync(fabricName, protectionContainerName, jobId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a protectable item inside the replication protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The name of the container.
            /// </param>
            /// <param name='discoverProtectableItemRequest'>
            /// The request object to add a protectable
            /// item.
            /// </param>
            public static ProtectionContainer DiscoverProtectableItem(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest)
            {
                return operations.DiscoverProtectableItemAsync(fabricName, protectionContainerName, discoverProtectableItemRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a protectable item inside the replication protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The name of the container.
            /// </param>
            /// <param name='discoverProtectableItemRequest'>
            /// The request object to add a protectable
            /// item.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> DiscoverProtectableItemAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DiscoverProtectableItemWithHttpMessagesAsync(fabricName, protectionContainerName, discoverProtectableItemRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the protection container details.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container id.
            /// </param>
            public static ProtectionContainer Get(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName)
            {
                return operations.GetAsync(fabricName, protectionContainerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the protection container details.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> GetAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='creationInput'>
            /// Creation input.
            /// </param>
            public static ProtectionContainer Create(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput)
            {
                return operations.CreateAsync(fabricName, protectionContainerName, creationInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='creationInput'>
            /// Creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> CreateAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, protectionContainerName, creationInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            public static IPage<ProtectionContainer> ListByFabric(this IProtectionContainersOperations operations, string fabricName)
            {
                return operations.ListByFabricAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectionContainer>> ListByFabricAsync(this IProtectionContainersOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all protection containers in a vault.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ProtectionContainer> List(this IProtectionContainersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all protection containers in a vault.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectionContainer>> ListAsync(this IProtectionContainersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Switches protection from one container to another or one replication
            /// provider to
            /// another.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='switchInput'>
            /// Switch protection input.
            /// </param>
            public static ProtectionContainer BeginSwitchProtection(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, SwitchProtectionInput switchInput)
            {
                return operations.BeginSwitchProtectionAsync(fabricName, protectionContainerName, switchInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Switches protection from one container to another or one replication
            /// provider to
            /// another.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='switchInput'>
            /// Switch protection input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> BeginSwitchProtectionAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginSwitchProtectionWithHttpMessagesAsync(fabricName, protectionContainerName, switchInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            public static void BeginDelete(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName)
            {
                operations.BeginDeleteAsync(fabricName, protectionContainerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Adds a protectable item inside the replication protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The name of the container.
            /// </param>
            /// <param name='discoverProtectableItemRequest'>
            /// The request object to add a protectable
            /// item.
            /// </param>
            public static ProtectionContainer BeginDiscoverProtectableItem(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest)
            {
                return operations.BeginDiscoverProtectableItemAsync(fabricName, protectionContainerName, discoverProtectableItemRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a protectable item inside the replication protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The name of the fabric.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The name of the container.
            /// </param>
            /// <param name='discoverProtectableItemRequest'>
            /// The request object to add a protectable
            /// item.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> BeginDiscoverProtectableItemAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDiscoverProtectableItemWithHttpMessagesAsync(fabricName, protectionContainerName, discoverProtectableItemRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='creationInput'>
            /// Creation input.
            /// </param>
            public static ProtectionContainer BeginCreate(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput)
            {
                return operations.BeginCreateAsync(fabricName, protectionContainerName, creationInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Unique fabric ARM name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Unique protection container ARM name.
            /// </param>
            /// <param name='creationInput'>
            /// Creation input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainer> BeginCreateAsync(this IProtectionContainersOperations operations, string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, protectionContainerName, creationInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProtectionContainer> ListByFabricNext(this IProtectionContainersOperations operations, string nextPageLink)
            {
                return operations.ListByFabricNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protection container.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectionContainer>> ListByFabricNextAsync(this IProtectionContainersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFabricNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all protection containers in a vault.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProtectionContainer> ListNext(this IProtectionContainersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all protection containers in a vault.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectionContainer>> ListNextAsync(this IProtectionContainersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
