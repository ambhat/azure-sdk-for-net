// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of allocated stamp operations for the Recovery Services
    /// extension.
    /// </summary>
    internal partial class StampOperations : IServiceOperations<RecoveryServicesManagementClient>, IStampOperations
    {
        /// <summary>
        /// Initializes a new instance of the StampOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal StampOperations(RecoveryServicesManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.RecoveryServicesManagementClient.
        /// </summary>
        public RecoveryServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Retrieve a list of allocated stamps.
        /// </summary>
        /// <param name='region'>
        /// Required. Region of the stamp.
        /// </param>
        /// <param name='provisioningApiVersion'>
        /// Required. Provisioning api version.
        /// </param>
        /// <param name='input'>
        /// Required. Allocate stamp input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for Stamp allocation.
        /// </returns>
        public async Task<StampAllocateResponse> AllocateAsync(string region, string provisioningApiVersion, AllocateStampInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (region == null)
            {
                throw new ArgumentNullException("region");
            }
            if (provisioningApiVersion == null)
            {
                throw new ArgumentNullException("provisioningApiVersion");
            }
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("region", region);
                tracingParameters.Add("provisioningApiVersion", provisioningApiVersion);
                tracingParameters.Add("input", input);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "AllocateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/locations/";
            url = url + Uri.EscapeDataString(region);
            url = url + "/allocateStamp";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(provisioningApiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject allocateStampInputValue = new JObject();
                requestDoc = allocateStampInputValue;
                
                if (input.Properties != null)
                {
                    JObject propertiesValue = new JObject();
                    allocateStampInputValue["properties"] = propertiesValue;
                    
                    if (input.Properties.StampType != null)
                    {
                        propertiesValue["stampType"] = input.Properties.StampType;
                    }
                    
                    if (input.Properties.QueueSuffix != null)
                    {
                        propertiesValue["queueSuffix"] = input.Properties.QueueSuffix;
                    }
                    
                    if (input.Properties.PreferredStampId != null)
                    {
                        propertiesValue["preferredStampId"] = input.Properties.PreferredStampId;
                    }
                    
                    if (input.Properties.LowerBoundStampVersion != null)
                    {
                        propertiesValue["lowerBoundStampVersion"] = input.Properties.LowerBoundStampVersion;
                    }
                    
                    if (input.Properties.UpperBoundStampVersion != null)
                    {
                        propertiesValue["upperBoundStampVersion"] = input.Properties.UpperBoundStampVersion;
                    }
                    
                    if (input.Properties.QueueDetailsRequired != null)
                    {
                        propertiesValue["queueDetailsRequired"] = input.Properties.QueueDetailsRequired;
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    StampAllocateResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new StampAllocateResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    StampExtendedInfo stampExtendedInfoInstance = new StampExtendedInfo();
                                    result.StampInfo.Add(stampExtendedInfoInstance);
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        stampExtendedInfoInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        stampExtendedInfoInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        stampExtendedInfoInstance.Type = typeInstance;
                                    }
                                    
                                    JToken contractVersionValue = valueValue["ContractVersion"];
                                    if (contractVersionValue != null && contractVersionValue.Type != JTokenType.Null)
                                    {
                                        string contractVersionInstance = ((string)contractVersionValue);
                                        stampExtendedInfoInstance.ContractVersion = contractVersionInstance;
                                    }
                                    
                                    JToken propertiesValue2 = valueValue["properties"];
                                    if (propertiesValue2 != null && propertiesValue2.Type != JTokenType.Null)
                                    {
                                        StampExtendedInfoProperties propertiesInstance = new StampExtendedInfoProperties();
                                        stampExtendedInfoInstance.Properties = propertiesInstance;
                                        
                                        JToken uriValue = propertiesValue2["uri"];
                                        if (uriValue != null && uriValue.Type != JTokenType.Null)
                                        {
                                            string uriInstance = ((string)uriValue);
                                            propertiesInstance.Uri = uriInstance;
                                        }
                                        
                                        JToken stampTypeValue = propertiesValue2["stampType"];
                                        if (stampTypeValue != null && stampTypeValue.Type != JTokenType.Null)
                                        {
                                            string stampTypeInstance = ((string)stampTypeValue);
                                            propertiesInstance.StampType = stampTypeInstance;
                                        }
                                        
                                        JToken queueDetailsArray = propertiesValue2["queueDetails"];
                                        if (queueDetailsArray != null && queueDetailsArray.Type != JTokenType.Null)
                                        {
                                            foreach (JToken queueDetailsValue in ((JArray)queueDetailsArray))
                                            {
                                                StampQueueDetails stampQueueDetailsInstance = new StampQueueDetails();
                                                propertiesInstance.QueueDetails.Add(stampQueueDetailsInstance);
                                                
                                                JToken queueSASUriValue = queueDetailsValue["queueSASUri"];
                                                if (queueSASUriValue != null && queueSASUriValue.Type != JTokenType.Null)
                                                {
                                                    string queueSASUriInstance = ((string)queueSASUriValue);
                                                    stampQueueDetailsInstance.QueueSASUri = queueSASUriInstance;
                                                }
                                                
                                                JToken queueSASTokenValue = queueDetailsValue["queueSASToken"];
                                                if (queueSASTokenValue != null && queueSASTokenValue.Type != JTokenType.Null)
                                                {
                                                    string queueSASTokenInstance = ((string)queueSASTokenValue);
                                                    stampQueueDetailsInstance.QueueSASToken = queueSASTokenInstance;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Retrieve a list of allocated stamps.
        /// </summary>
        /// <param name='region'>
        /// Required. Region of the stamp.
        /// </param>
        /// <param name='provisioningApiVersion'>
        /// Required. Provisioning api version.
        /// </param>
        /// <param name='parameters'>
        /// Required. Stamp query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for Stamp list.
        /// </returns>
        public async Task<StampListResponse> ListAsync(string region, string provisioningApiVersion, StampQueryParameter parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (region == null)
            {
                throw new ArgumentNullException("region");
            }
            if (provisioningApiVersion == null)
            {
                throw new ArgumentNullException("provisioningApiVersion");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.StampType == null)
            {
                throw new ArgumentNullException("parameters.StampType");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("region", region);
                tracingParameters.Add("provisioningApiVersion", provisioningApiVersion);
                tracingParameters.Add("parameters", parameters);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/locations/";
            url = url + Uri.EscapeDataString(region);
            url = url + "/allocatedStamp";
            List<string> queryParameters = new List<string>();
            List<string> odataFilter = new List<string>();
            if (parameters.ToQueryString() != null)
            {
                odataFilter.Add(Uri.EscapeDataString(parameters.ToQueryString().ToString()));
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(null, odataFilter));
            }
            queryParameters.Add("api-version=" + Uri.EscapeDataString(provisioningApiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    StampListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new StampListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    Stamp stampInstance = new Stamp();
                                    result.Stamps.Add(stampInstance);
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        stampInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        stampInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        stampInstance.Type = typeInstance;
                                    }
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        StampProperties propertiesInstance = new StampProperties();
                                        stampInstance.Properties = propertiesInstance;
                                        
                                        JToken versionValue = propertiesValue["version"];
                                        if (versionValue != null && versionValue.Type != JTokenType.Null)
                                        {
                                            string versionInstance = ((string)versionValue);
                                            propertiesInstance.Version = versionInstance;
                                        }
                                        
                                        JToken uriValue = propertiesValue["uri"];
                                        if (uriValue != null && uriValue.Type != JTokenType.Null)
                                        {
                                            string uriInstance = ((string)uriValue);
                                            propertiesInstance.Uri = uriInstance;
                                        }
                                        
                                        JToken stampTypeValue = propertiesValue["stampType"];
                                        if (stampTypeValue != null && stampTypeValue.Type != JTokenType.Null)
                                        {
                                            string stampTypeInstance = ((string)stampTypeValue);
                                            propertiesInstance.StampType = stampTypeInstance;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
