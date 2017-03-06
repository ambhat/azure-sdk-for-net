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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ProtectionContainersOperations operations.
    /// </summary>
    public partial interface IProtectionContainersOperations
    {
        /// <summary>
        /// Switches protection from one container to another or one
        /// replication provider to
        /// another.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='switchInput'>
        /// Switch protection input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> SwitchProtectionWithHttpMessagesAsync(string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Tracks the provider async operation.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Site name to work on.
        /// </param>
        /// <param name='jobId'>
        /// job id to track.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> GetTrackAsyncOperationWithHttpMessagesAsync(string fabricName, string protectionContainerName, string jobId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a protectable item inside the replication protection
        /// container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> DiscoverProtectableItemWithHttpMessagesAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the protection container details.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> GetWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='creationInput'>
        /// Creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> CreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListByFabricWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection containers in a vault.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Switches protection from one container to another or one
        /// replication provider to
        /// another.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='switchInput'>
        /// Switch protection input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> BeginSwitchProtectionWithHttpMessagesAsync(string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a protectable item inside the replication protection
        /// container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> BeginDiscoverProtectableItemWithHttpMessagesAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='creationInput'>
        /// Creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProtectionContainer>> BeginCreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListByFabricNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection containers in a vault.
        /// </summary>
        /// <remarks>
        /// TODO (avrai): Detailed Description.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
