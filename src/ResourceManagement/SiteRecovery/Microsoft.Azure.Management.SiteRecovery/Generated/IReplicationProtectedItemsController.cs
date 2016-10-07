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
    using Models;

    /// <summary>
    /// ReplicationProtectedItemsController operations.
    /// </summary>
    public partial interface IReplicationProtectedItemsController
    {
        /// <param name='fabricName'>
        /// </param>
        /// <param name='protectionContainerName'>
        /// </param>
        /// <param name='replicatedProtectedItemName'>
        /// </param>
        /// <param name='failoverInput'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PlannedFailoverWithHttpMessagesAsync(string fabricName, string protectionContainerName, string replicatedProtectedItemName, PlannedFailoverInput failoverInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='skipToken'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReplicationProtectedItemCollection>> EnumerateAllReplicationProtectedItemsWithHttpMessagesAsync(string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
