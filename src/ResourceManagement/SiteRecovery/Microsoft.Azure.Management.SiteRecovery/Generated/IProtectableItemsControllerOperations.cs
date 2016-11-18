// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.SiteRecovery
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ProtectableItemsControllerOperations operations.
    /// </summary>
    public partial interface IProtectableItemsControllerOperations
    {
        /// <summary>
        /// Gets the details of a protection entity.
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container Id.
        /// </param>
        /// <param name='protectableItemName'>
        /// Protection entity Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectableItem>> GetProtectableItemWithHttpMessagesAsync(string fabricName, string protectionContainerName, string protectableItemName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection entities.
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectableItem>>> EnumerateProtectableItemsWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection entities.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectableItem>>> EnumerateProtectableItemsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
