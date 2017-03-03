// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubnetsOperations.
    /// </summary>
    public static partial class SubnetsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            public static void Delete(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkName, subnetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the specified subnet by virtual network and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static Subnet Get(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkName, subnetName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified subnet by virtual network and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subnet> GetAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a subnet in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create or update subnet operation.
            /// </param>
            public static Subnet CreateOrUpdate(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a subnet in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create or update subnet operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subnet> CreateOrUpdateAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static IPage<Subnet> List(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                return operations.ListAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Subnet>> ListAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            public static void BeginDelete(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkName, subnetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified subnet.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates or updates a subnet in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create or update subnet operation.
            /// </param>
            public static Subnet BeginCreateOrUpdate(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a subnet in the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='subnetName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='subnetParameters'>
            /// Parameters supplied to the create or update subnet operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subnet> BeginCreateOrUpdateAsync(this ISubnetsOperations operations, string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all subnets in a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Subnet> ListNext(this ISubnetsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subnets in a virtual network.
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
            public static async Task<IPage<Subnet>> ListNextAsync(this ISubnetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

