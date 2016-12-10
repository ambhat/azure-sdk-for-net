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
    /// FabricsOperations operations.
    /// </summary>
    public partial interface IFabricsOperations
    {
        /// <summary>
        /// Tracks the Site async operation.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site name to work on.
        /// </param>
        /// <param name='jobName'>
        /// job id to track.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> TrackAsyncOperationWithHttpMessagesAsync(string fabricName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Perform failover of the process server.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// The name of the fabric containing the process server.
        /// </param>
        /// <param name='failoverProcessServerRequest'>
        /// The input to the failover process
        /// server operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> ReassociateGatewayWithHttpMessagesAsync(string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Perform failover of the process server.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// The name of the fabric containing the process server.
        /// </param>
        /// <param name='failoverProcessServerRequest'>
        /// The input to the failover process
        /// server operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginReassociateGatewayWithHttpMessagesAsync(string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys a Process Server.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Id of the fabric under which the process server is to be
        /// deployed.
        /// </param>
        /// <param name='request'>
        /// The input to deploy a Process Server from Azure Image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> DeployProcessServerImageWithHttpMessagesAsync(string fabricName, DeployProcessServerRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys a Process Server.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Id of the fabric under which the process server is to be
        /// deployed.
        /// </param>
        /// <param name='request'>
        /// The input to deploy a Process Server from Azure Image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginDeployProcessServerImageWithHttpMessagesAsync(string fabricName, DeployProcessServerRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renews certificate for the site.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site it to renew certs for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> RenewCertificateWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renews certificate for the site.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site it to renew certs for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginRenewCertificateWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks the consistency of the site.
        /// </summary>
        /// Creates the site.
        /// <param name='fabricName'>
        /// Site name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> CheckConsistencyWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks the consistency of the site.
        /// </summary>
        /// Creates the site.
        /// <param name='fabricName'>
        /// Site name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginCheckConsistencyWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the site.
        /// TODO: put a code based DebugAssert to ensure all
        /// HttpPosts have Operation entry made.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site it to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the site.
        /// TODO: put a code based DebugAssert to ensure all
        /// HttpPosts have Operation entry made.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site it to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of a Site.
        /// </summary>
        /// bksdfj kjdfs ajkgdhkg asjhg.
        /// <param name='fabricName'>
        /// Site name of interest.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> GetWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates the site.
        /// </summary>
        /// klklfd the site.
        /// <param name='fabricName'>
        /// Name of the site.
        /// </param>
        /// <param name='input'>
        /// Site creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> CreateWithHttpMessagesAsync(string fabricName, FabricCreationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates the site.
        /// </summary>
        /// klklfd the site.
        /// <param name='fabricName'>
        /// Name of the site.
        /// </param>
        /// <param name='input'>
        /// Site creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginCreateWithHttpMessagesAsync(string fabricName, FabricCreationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges the site.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site to purge.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PurgeWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges the site.
        /// </summary>
        /// Deletes the site.
        /// <param name='fabricName'>
        /// Site to purge.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPurgeWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of Site registered.
        /// </summary>
        /// registered sites hjg.
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Fabric>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of Site registered.
        /// </summary>
        /// registered sites hjg.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Fabric>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
