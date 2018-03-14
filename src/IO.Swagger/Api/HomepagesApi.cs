/* 
 * Tripwire Enterprise TE REST API User Guide & Reference
 *
 * The TE REST API allows automation of many aspects of Tripwire Enterprise
 *
 * OpenAPI spec version: 1.12.1.bmaster.r20170922182356-4e84151.b1741
 * Contact: support@tripwire.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHomepagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search homepages
        /// </summary>
        /// <remarks>
        /// Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>List&lt;Homepage&gt;</returns>
        List<Homepage> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null);

        /// <summary>
        /// Search homepages
        /// </summary>
        /// <remarks>
        /// Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>ApiResponse of List&lt;Homepage&gt;</returns>
        ApiResponse<List<Homepage>> GetAllWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null);
        /// <summary>
        /// Get homepage details by ID
        /// </summary>
        /// <remarks>
        /// Returns summary details for an individual homepage.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Homepage</returns>
        Homepage GetHomepageById (string rkHomepageId);

        /// <summary>
        /// Get homepage details by ID
        /// </summary>
        /// <remarks>
        /// Returns summary details for an individual homepage.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>ApiResponse of Homepage</returns>
        ApiResponse<Homepage> GetHomepageByIdWithHttpInfo (string rkHomepageId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search homepages
        /// </summary>
        /// <remarks>
        /// Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>Task of List&lt;Homepage&gt;</returns>
        System.Threading.Tasks.Task<List<Homepage>> GetAllAsync (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null);

        /// <summary>
        /// Search homepages
        /// </summary>
        /// <remarks>
        /// Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Homepage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Homepage>>> GetAllAsyncWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null);
        /// <summary>
        /// Get homepage details by ID
        /// </summary>
        /// <remarks>
        /// Returns summary details for an individual homepage.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Task of Homepage</returns>
        System.Threading.Tasks.Task<Homepage> GetHomepageByIdAsync (string rkHomepageId);

        /// <summary>
        /// Get homepage details by ID
        /// </summary>
        /// <remarks>
        /// Returns summary details for an individual homepage.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Task of ApiResponse (Homepage)</returns>
        System.Threading.Tasks.Task<ApiResponse<Homepage>> GetHomepageByIdAsyncWithHttpInfo (string rkHomepageId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HomepagesApi : IHomepagesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomepagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HomepagesApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomepagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HomepagesApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Search homepages Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>List&lt;Homepage&gt;</returns>
        public List<Homepage> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null)
        {
             ApiResponse<List<Homepage>> localVarResponse = GetAllWithHttpInfo(id, name, description, subDescription, trackingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search homepages Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>ApiResponse of List&lt;Homepage&gt;</returns>
        public ApiResponse< List<Homepage> > GetAllWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null)
        {

            var localVarPath = "/homepages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "name", name)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "description", description)); // query parameter
            if (subDescription != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sub_description", subDescription)); // query parameter
            if (trackingId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "trackingId", trackingId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Homepage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Homepage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Homepage>)));
        }

        /// <summary>
        /// Search homepages Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>Task of List&lt;Homepage&gt;</returns>
        public async System.Threading.Tasks.Task<List<Homepage>> GetAllAsync (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null)
        {
             ApiResponse<List<Homepage>> localVarResponse = await GetAllAsyncWithHttpInfo(id, name, description, subDescription, trackingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search homepages Returns a list of all homepages or only those homepages that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of homepages to fetch. (optional)</param>
        /// <param name="name">Names of homepages to fetch. (optional)</param>
        /// <param name="description">Descriptions of homepages to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="trackingId">Tracking IDs of homepages to fetch. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Homepage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Homepage>>> GetAllAsyncWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> trackingId = null)
        {

            var localVarPath = "/homepages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "name", name)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "description", description)); // query parameter
            if (subDescription != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sub_description", subDescription)); // query parameter
            if (trackingId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "trackingId", trackingId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Homepage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Homepage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Homepage>)));
        }

        /// <summary>
        /// Get homepage details by ID Returns summary details for an individual homepage.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Homepage</returns>
        public Homepage GetHomepageById (string rkHomepageId)
        {
             ApiResponse<Homepage> localVarResponse = GetHomepageByIdWithHttpInfo(rkHomepageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get homepage details by ID Returns summary details for an individual homepage.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>ApiResponse of Homepage</returns>
        public ApiResponse< Homepage > GetHomepageByIdWithHttpInfo (string rkHomepageId)
        {
            // verify the required parameter 'rkHomepageId' is set
            if (rkHomepageId == null)
                throw new ApiException(400, "Missing required parameter 'rkHomepageId' when calling HomepagesApi->GetHomepageById");

            var localVarPath = "/homepages/{rkHomepageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rkHomepageId != null) localVarPathParams.Add("rkHomepageId", this.Configuration.ApiClient.ParameterToString(rkHomepageId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHomepageById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Homepage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Homepage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Homepage)));
        }

        /// <summary>
        /// Get homepage details by ID Returns summary details for an individual homepage.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Task of Homepage</returns>
        public async System.Threading.Tasks.Task<Homepage> GetHomepageByIdAsync (string rkHomepageId)
        {
             ApiResponse<Homepage> localVarResponse = await GetHomepageByIdAsyncWithHttpInfo(rkHomepageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get homepage details by ID Returns summary details for an individual homepage.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkHomepageId">rkHomepageId to fetch</param>
        /// <returns>Task of ApiResponse (Homepage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Homepage>> GetHomepageByIdAsyncWithHttpInfo (string rkHomepageId)
        {
            // verify the required parameter 'rkHomepageId' is set
            if (rkHomepageId == null)
                throw new ApiException(400, "Missing required parameter 'rkHomepageId' when calling HomepagesApi->GetHomepageById");

            var localVarPath = "/homepages/{rkHomepageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rkHomepageId != null) localVarPathParams.Add("rkHomepageId", this.Configuration.ApiClient.ParameterToString(rkHomepageId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHomepageById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Homepage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Homepage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Homepage)));
        }

    }
}