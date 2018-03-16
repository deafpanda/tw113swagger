/* 
 * Tripwire Enterprise TE REST API User Guide & Reference
 *
 * The TE REST API allows automation of many aspects of Tripwire Enterprise
 *
 * OpenAPI spec version: 1.13.0.bmaster.r20180119190259-8b60eaa.b1753
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
    public interface ICSRFApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get CSRF token (since 1.2)
        /// </summary>
        /// <remarks>
        /// The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        Token GetCSRFToken ();

        /// <summary>
        /// Get CSRF token (since 1.2)
        /// </summary>
        /// <remarks>
        /// The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> GetCSRFTokenWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get CSRF token (since 1.2)
        /// </summary>
        /// <remarks>
        /// The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> GetCSRFTokenAsync ();

        /// <summary>
        /// Get CSRF token (since 1.2)
        /// </summary>
        /// <remarks>
        /// The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> GetCSRFTokenAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CSRFApi : ICSRFApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CSRFApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CSRFApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSRFApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CSRFApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Get CSRF token (since 1.2) The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        public Token GetCSRFToken ()
        {
             ApiResponse<Token> localVarResponse = GetCSRFTokenWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get CSRF token (since 1.2) The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > GetCSRFTokenWithHttpInfo ()
        {

            var localVarPath = "/csrf-token";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCSRFToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
        }

        /// <summary>
        /// Get CSRF token (since 1.2) The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> GetCSRFTokenAsync ()
        {
             ApiResponse<Token> localVarResponse = await GetCSRFTokenAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get CSRF token (since 1.2) The HTTP header described by the response model must be submitted with any request that modifies data (POST/PUT/DELETE). It is not required with GET requests that simply retrieve data.  Use the returned tokenName as the HTTP header name, and the returned tokenValue as the value for that header.  The tokenValues are only valid for the current session. This endpoint will only return this information on the first request per session. As a best practice, this should be your client application&#39;s first request.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> GetCSRFTokenAsyncWithHttpInfo ()
        {

            var localVarPath = "/csrf-token";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCSRFToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
        }

    }
}
