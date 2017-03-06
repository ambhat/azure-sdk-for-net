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
    /// Extension methods for RecoveryPointsOperations.
    /// </summary>
    public static partial class RecoveryPointsOperationsExtensions
    {
            /// <summary>
            /// Get a recovery point.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The protection container name.
            /// </param>
            /// <param name='replicatedProtectedItemName'>
            /// The replication protectable item's name.
            /// </param>
            /// <param name='recoveryPointName'>
            /// The recovery point name.
            /// </param>
            public static RecoveryPoint Get(this IRecoveryPointsOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, string recoveryPointName)
            {
                return operations.GetAsync(fabricName, protectionContainerName, replicatedProtectedItemName, recoveryPointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a recovery point.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The protection container name.
            /// </param>
            /// <param name='replicatedProtectedItemName'>
            /// The replication protectable item's name.
            /// </param>
            /// <param name='recoveryPointName'>
            /// The recovery point name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoveryPoint> GetAsync(this IRecoveryPointsOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, string recoveryPointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, protectionContainerName, replicatedProtectedItemName, recoveryPointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The protection container name.
            /// </param>
            /// <param name='replicatedProtectedItemName'>
            /// The replication protectable item's name.
            /// </param>
            public static IPage<RecoveryPoint> ListByReplicationProtectedItem(this IRecoveryPointsOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName)
            {
                return operations.ListByReplicationProtectedItemAsync(fabricName, protectionContainerName, replicatedProtectedItemName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
            /// <remarks>
            /// TODO (avrai): Detailed Description.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// The fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// The protection container name.
            /// </param>
            /// <param name='replicatedProtectedItemName'>
            /// The replication protectable item's name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryPoint>> ListByReplicationProtectedItemAsync(this IRecoveryPointsOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectedItemWithHttpMessagesAsync(fabricName, protectionContainerName, replicatedProtectedItemName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recovery points for a protected entity.
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
            public static IPage<RecoveryPoint> ListByReplicationProtectedItemNext(this IRecoveryPointsOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationProtectedItemNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recovery points for a protected entity.
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
            public static async Task<IPage<RecoveryPoint>> ListByReplicationProtectedItemNextAsync(this IRecoveryPointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectedItemNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
