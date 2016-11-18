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
    /// RecoveryServicesProviderControllerOperations operations.
    /// </summary>
    public partial interface IRecoveryServicesProviderControllerOperations
    {
        /// <summary>
        /// Refresh the data on the provider.
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='providerName'>
        /// Unique provider name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RefreshProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes provider from fabric.
        /// Note: Deleting provider for any fabric other than
        /// SingleHost is unsupported. To
        /// maintain backward compatibility for released clients
        /// the object "deleteRspInput" is
        /// used (if the object is empty we assume that it is old
        /// client and continue the old
        /// behavior).
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric Id.
        /// </param>
        /// <param name='providerName'>
        /// Unique provider id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of a server.
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric Id.
        /// </param>
        /// <param name='providerName'>
        /// Server id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<RecoveryServicesProvider>> GetProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges provider from fabric
        /// </summary>
        /// <param name='fabricName'>
        /// Unique fabric Id.
        /// </param>
        /// <param name='providerName'>
        /// Unique provider id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PurgeProviderWithHttpMessagesAsync(string fabricName, string providerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of servers registered.
        /// </summary>
        /// <param name='fabricName'>
        /// Id of the fabric to be retrieved
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> EnumerateProvidersWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of servers registered across fabrics.
        /// This is view only api.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> EnumerateAllProvidersWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of servers registered.
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> EnumerateProvidersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of servers registered across fabrics.
        /// This is view only api.
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
        Task<AzureOperationResponse<IPage<RecoveryServicesProvider>>> EnumerateAllProvidersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
