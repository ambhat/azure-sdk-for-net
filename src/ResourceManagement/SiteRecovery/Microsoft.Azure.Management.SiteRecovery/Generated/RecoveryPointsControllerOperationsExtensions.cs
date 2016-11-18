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
    /// Extension methods for RecoveryPointsControllerOperations.
    /// </summary>
    public static partial class RecoveryPointsControllerOperationsExtensions
    {
            /// <summary>
            /// Get a recovery point.
            /// </summary>
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
            public static RecoveryPoint GetRecoveryPoint(this IRecoveryPointsControllerOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, string recoveryPointName)
            {
                return Task.Factory.StartNew(s => ((IRecoveryPointsControllerOperations)s).GetRecoveryPointAsync(fabricName, protectionContainerName, replicatedProtectedItemName, recoveryPointName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a recovery point.
            /// </summary>
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
            public static async Task<RecoveryPoint> GetRecoveryPointAsync(this IRecoveryPointsControllerOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, string recoveryPointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRecoveryPointWithHttpMessagesAsync(fabricName, protectionContainerName, replicatedProtectedItemName, recoveryPointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
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
            public static IPage<RecoveryPoint> EnumerateRecoveryPoints(this IRecoveryPointsControllerOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName)
            {
                return Task.Factory.StartNew(s => ((IRecoveryPointsControllerOperations)s).EnumerateRecoveryPointsAsync(fabricName, protectionContainerName, replicatedProtectedItemName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
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
            public static async Task<IPage<RecoveryPoint>> EnumerateRecoveryPointsAsync(this IRecoveryPointsControllerOperations operations, string fabricName, string protectionContainerName, string replicatedProtectedItemName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateRecoveryPointsWithHttpMessagesAsync(fabricName, protectionContainerName, replicatedProtectedItemName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecoveryPoint> EnumerateRecoveryPointsNext(this IRecoveryPointsControllerOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IRecoveryPointsControllerOperations)s).EnumerateRecoveryPointsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recovery points for a protected entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryPoint>> EnumerateRecoveryPointsNextAsync(this IRecoveryPointsControllerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateRecoveryPointsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
