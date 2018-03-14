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
    public interface IPermissionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search for permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions or those that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>List&lt;Permission&gt;</returns>
        List<Permission> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null);

        /// <summary>
        /// Search for permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions or those that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>ApiResponse of List&lt;Permission&gt;</returns>
        ApiResponse<List<Permission>> GetAllWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null);
        /// <summary>
        /// Get permission details by Id
        /// </summary>
        /// <remarks>
        /// Returns the details of a single permission.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Permission</returns>
        Permission GetPermissionById (string rkPermissionId);

        /// <summary>
        /// Get permission details by Id
        /// </summary>
        /// <remarks>
        /// Returns the details of a single permission.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>ApiResponse of Permission</returns>
        ApiResponse<Permission> GetPermissionByIdWithHttpInfo (string rkPermissionId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search for permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions or those that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>Task of List&lt;Permission&gt;</returns>
        System.Threading.Tasks.Task<List<Permission>> GetAllAsync (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null);

        /// <summary>
        /// Search for permissions
        /// </summary>
        /// <remarks>
        /// Returns a list of all permissions or those that match the provided filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Permission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Permission>>> GetAllAsyncWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null);
        /// <summary>
        /// Get permission details by Id
        /// </summary>
        /// <remarks>
        /// Returns the details of a single permission.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Task of Permission</returns>
        System.Threading.Tasks.Task<Permission> GetPermissionByIdAsync (string rkPermissionId);

        /// <summary>
        /// Get permission details by Id
        /// </summary>
        /// <remarks>
        /// Returns the details of a single permission.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        System.Threading.Tasks.Task<ApiResponse<Permission>> GetPermissionByIdAsyncWithHttpInfo (string rkPermissionId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PermissionsApi : IPermissionsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissionsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Search for permissions Returns a list of all permissions or those that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>List&lt;Permission&gt;</returns>
        public List<Permission> GetAll (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null)
        {
             ApiResponse<List<Permission>> localVarResponse = GetAllWithHttpInfo(id, name, description, subDescription, target, category);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for permissions Returns a list of all permissions or those that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>ApiResponse of List&lt;Permission&gt;</returns>
        public ApiResponse< List<Permission> > GetAllWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null)
        {

            var localVarPath = "/permissions";
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
            if (target != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "target", target)); // query parameter
            if (category != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "category", category)); // query parameter


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

            return new ApiResponse<List<Permission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Permission>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Permission>)));
        }

        /// <summary>
        /// Search for permissions Returns a list of all permissions or those that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>Task of List&lt;Permission&gt;</returns>
        public async System.Threading.Tasks.Task<List<Permission>> GetAllAsync (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null)
        {
             ApiResponse<List<Permission>> localVarResponse = await GetAllAsyncWithHttpInfo(id, name, description, subDescription, target, category);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for permissions Returns a list of all permissions or those that match the provided filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">IDs of permissions to fetch. (optional)</param>
        /// <param name="name">Names of permissions to fetch. (optional)</param>
        /// <param name="description">Descriptions of permissions to fetch. (optional)</param>
        /// <param name="subDescription">Substring matching for description. (optional)</param>
        /// <param name="target">Targets of permissions to fetch. (optional)</param>
        /// <param name="category">Categories of permissions to fetch. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Permission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Permission>>> GetAllAsyncWithHttpInfo (List<string> id = null, List<string> name = null, List<string> description = null, List<string> subDescription = null, List<string> target = null, List<string> category = null)
        {

            var localVarPath = "/permissions";
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
            if (target != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "target", target)); // query parameter
            if (category != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "category", category)); // query parameter


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

            return new ApiResponse<List<Permission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Permission>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Permission>)));
        }

        /// <summary>
        /// Get permission details by Id Returns the details of a single permission.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Permission</returns>
        public Permission GetPermissionById (string rkPermissionId)
        {
             ApiResponse<Permission> localVarResponse = GetPermissionByIdWithHttpInfo(rkPermissionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get permission details by Id Returns the details of a single permission.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>ApiResponse of Permission</returns>
        public ApiResponse< Permission > GetPermissionByIdWithHttpInfo (string rkPermissionId)
        {
            // verify the required parameter 'rkPermissionId' is set
            if (rkPermissionId == null)
                throw new ApiException(400, "Missing required parameter 'rkPermissionId' when calling PermissionsApi->GetPermissionById");

            var localVarPath = "/permissions/{rkPermissionId}";
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

            if (rkPermissionId != null) localVarPathParams.Add("rkPermissionId", this.Configuration.ApiClient.ParameterToString(rkPermissionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPermissionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Permission>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Permission) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Permission)));
        }

        /// <summary>
        /// Get permission details by Id Returns the details of a single permission.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Task of Permission</returns>
        public async System.Threading.Tasks.Task<Permission> GetPermissionByIdAsync (string rkPermissionId)
        {
             ApiResponse<Permission> localVarResponse = await GetPermissionByIdAsyncWithHttpInfo(rkPermissionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get permission details by Id Returns the details of a single permission.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkPermissionId">rkPermissionId to fetch</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Permission>> GetPermissionByIdAsyncWithHttpInfo (string rkPermissionId)
        {
            // verify the required parameter 'rkPermissionId' is set
            if (rkPermissionId == null)
                throw new ApiException(400, "Missing required parameter 'rkPermissionId' when calling PermissionsApi->GetPermissionById");

            var localVarPath = "/permissions/{rkPermissionId}";
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

            if (rkPermissionId != null) localVarPathParams.Add("rkPermissionId", this.Configuration.ApiClient.ParameterToString(rkPermissionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPermissionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Permission>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Permission) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Permission)));
        }

    }
}
