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
    /// Extension methods for FabricsControllerOperations.
    /// </summary>
    public static partial class FabricsControllerOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            public static Fabric GetFabric(this IFabricsControllerOperations operations, string fabricName)
            {
                return Task.Factory.StartNew(s => ((IFabricsControllerOperations)s).GetFabricAsync(fabricName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fabric> GetFabricAsync(this IFabricsControllerOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFabricWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='input'>
            /// </param>
            public static void CreateFabric(this IFabricsControllerOperations operations, string fabricName, FabricCreationInput input)
            {
                Task.Factory.StartNew(s => ((IFabricsControllerOperations)s).CreateFabricAsync(fabricName, input), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// </param>
            /// <param name='input'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateFabricAsync(this IFabricsControllerOperations operations, string fabricName, FabricCreationInput input, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CreateFabricWithHttpMessagesAsync(fabricName, input, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static FabricCollection EnumerateFabrics(this IFabricsControllerOperations operations)
            {
                return Task.Factory.StartNew(s => ((IFabricsControllerOperations)s).EnumerateFabricsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FabricCollection> EnumerateFabricsAsync(this IFabricsControllerOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnumerateFabricsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
