// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for GetPropertiesFromComputeNode operation.
    /// </summary>
    public partial class FileGetPropertiesFromComputeNodeHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FileGetPropertiesFromComputeNodeHeaders class.
        /// </summary>
        public FileGetPropertiesFromComputeNodeHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FileGetPropertiesFromComputeNodeHeaders class.
        /// </summary>
        /// <param name="clientRequestId">The client-request-id provided by the
        /// client during the request. This will be returned only if the
        /// return-client-request-id parameter was set to true.</param>
        /// <param name="requestId">A unique identifier for the request that
        /// was made to the Batch service. If a request is consistently failing
        /// and you have verified that the request is properly formulated, you
        /// may use this value to report the error to Microsoft. In your
        /// report, include the value of this request ID, the approximate time
        /// that the request was made, the Batch account against which the
        /// request was made, and the region that account resides in.</param>
        /// <param name="eTag">The ETag HTTP response header. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. In particular, you can pass the ETag to one of
        /// the If-Modified-Since, If-Unmodified-Since, If-Match or
        /// If-None-Match headers.</param>
        /// <param name="lastModified">The time at which the resource was last
        /// modified.</param>
        /// <param name="ocpCreationTime">The file creation time.</param>
        /// <param name="ocpBatchFileIsdirectory">Whether the object represents
        /// a directory.</param>
        /// <param name="ocpBatchFileUrl">The URL of the file.</param>
        /// <param name="ocpBatchFileMode">The file mode attribute in octal
        /// format.</param>
        /// <param name="contentType">The content type of the file.</param>
        /// <param name="contentLength">The length of the file.</param>
        public FileGetPropertiesFromComputeNodeHeaders(System.Guid? clientRequestId = default(System.Guid?), System.Guid? requestId = default(System.Guid?), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? ocpCreationTime = default(System.DateTime?), bool? ocpBatchFileIsdirectory = default(bool?), string ocpBatchFileUrl = default(string), string ocpBatchFileMode = default(string), string contentType = default(string), long? contentLength = default(long?))
        {
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            LastModified = lastModified;
            OcpCreationTime = ocpCreationTime;
            OcpBatchFileIsdirectory = ocpBatchFileIsdirectory;
            OcpBatchFileUrl = ocpBatchFileUrl;
            OcpBatchFileMode = ocpBatchFileMode;
            ContentType = contentType;
            ContentLength = contentLength;
        }

        /// <summary>
        /// Gets or sets the client-request-id provided by the client during
        /// the request. This will be returned only if the
        /// return-client-request-id parameter was set to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "client-request-id")]
        public System.Guid? ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier for the request that was made to
        /// the Batch service. If a request is consistently failing and you
        /// have verified that the request is properly formulated, you may use
        /// this value to report the error to Microsoft. In your report,
        /// include the value of this request ID, the approximate time that the
        /// request was made, the Batch account against which the request was
        /// made, and the region that account resides in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "request-id")]
        public System.Guid? RequestId { get; set; }

        /// <summary>
        /// Gets or sets the ETag HTTP response header. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. In particular, you can pass the ETag to one of
        /// the If-Modified-Since, If-Unmodified-Since, If-Match or
        /// If-None-Match headers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the time at which the resource was last modified.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Last-Modified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the file creation time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-creation-time")]
        public System.DateTime? OcpCreationTime { get; set; }

        /// <summary>
        /// Gets or sets whether the object represents a directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-isdirectory")]
        public bool? OcpBatchFileIsdirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-url")]
        public string OcpBatchFileUrl { get; set; }

        /// <summary>
        /// Gets or sets the file mode attribute in octal format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-mode")]
        public string OcpBatchFileMode { get; set; }

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Content-Length")]
        public long? ContentLength { get; set; }

    }
}
