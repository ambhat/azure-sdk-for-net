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
    /// Extension methods for ProtectableItemsControllerOperations.
    /// </summary>
    public static partial class ProtectableItemsControllerOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='protectionContainerName'>
            /// </param>
            /// <param name='protectableItemName'>
            /// </param>
            public static ProtectableItem GetProtectableItem(this IProtectableItemsControllerOperations operations, string fabricName, string protectionContainerName, string protectableItemName)
            {
                return Task.Factory.StartNew(s => ((IProtectableItemsControllerOperations)s).GetProtectableItemAsync(fabricName, protectionContainerName, protectableItemName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='protectionContainerName'>
            /// </param>
            /// <param name='protectableItemName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectableItem> GetProtectableItemAsync(this IProtectableItemsControllerOperations operations, string fabricName, string protectionContainerName, string protectableItemName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProtectableItemWithHttpMessagesAsync(fabricName, protectionContainerName, protectableItemName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='protectionContainerName'>
            /// </param>
            public static IPage<ProtectableItem> EnumerateProtectableItems(this IProtectableItemsControllerOperations operations, string fabricName, string protectionContainerName)
            {
                return Task.Factory.StartNew(s => ((IProtectableItemsControllerOperations)s).EnumerateProtectableItemsAsync(fabricName, protectionContainerName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='protectionContainerName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectableItem>> EnumerateProtectableItemsAsync(this IProtectableItemsControllerOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateProtectableItemsWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false))
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
            public static IPage<ProtectableItem> EnumerateProtectableItemsNext(this IProtectableItemsControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IProtectableItemsControllerOperations)s).EnumerateProtectableItemsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task<IPage<ProtectableItem>> EnumerateProtectableItemsNextAsync(this IProtectableItemsControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateProtectableItemsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
