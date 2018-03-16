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
    public interface IReportsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a report (since 1.11)
        /// </summary>
        /// <remarks>
        /// Removes a report.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns></returns>
        void DeleteReport (string rkReportId);

        /// <summary>
        /// Delete a report (since 1.11)
        /// </summary>
        /// <remarks>
        /// Removes a report.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReportWithHttpInfo (string rkReportId);
        /// <summary>
        /// List reports (since 1.9)
        /// </summary>
        /// <remarks>
        /// Returns a list of all reports or those that match the filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Report</returns>
        Report GetReports (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null);

        /// <summary>
        /// List reports (since 1.9)
        /// </summary>
        /// <remarks>
        /// Returns a list of all reports or those that match the filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>ApiResponse of Report</returns>
        ApiResponse<Report> GetReportsWithHttpInfo (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a report (since 1.11)
        /// </summary>
        /// <remarks>
        /// Removes a report.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReportAsync (string rkReportId);

        /// <summary>
        /// Delete a report (since 1.11)
        /// </summary>
        /// <remarks>
        /// Removes a report.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReportAsyncWithHttpInfo (string rkReportId);
        /// <summary>
        /// List reports (since 1.9)
        /// </summary>
        /// <remarks>
        /// Returns a list of all reports or those that match the filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Task of Report</returns>
        System.Threading.Tasks.Task<Report> GetReportsAsync (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null);

        /// <summary>
        /// List reports (since 1.9)
        /// </summary>
        /// <remarks>
        /// Returns a list of all reports or those that match the filter criteria.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Task of ApiResponse (Report)</returns>
        System.Threading.Tasks.Task<ApiResponse<Report>> GetReportsAsyncWithHttpInfo (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportsApi : IReportsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Delete a report (since 1.11) Removes a report.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns></returns>
        public void DeleteReport (string rkReportId)
        {
             DeleteReportWithHttpInfo(rkReportId);
        }

        /// <summary>
        /// Delete a report (since 1.11) Removes a report.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReportWithHttpInfo (string rkReportId)
        {
            // verify the required parameter 'rkReportId' is set
            if (rkReportId == null)
                throw new ApiException(400, "Missing required parameter 'rkReportId' when calling ReportsApi->DeleteReport");

            var localVarPath = "/reports/{rkReportId}";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rkReportId != null) localVarPathParams.Add("rkReportId", this.Configuration.ApiClient.ParameterToString(rkReportId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a report (since 1.11) Removes a report.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReportAsync (string rkReportId)
        {
             await DeleteReportAsyncWithHttpInfo(rkReportId);

        }

        /// <summary>
        /// Delete a report (since 1.11) Removes a report.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rkReportId">ID of report to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReportAsyncWithHttpInfo (string rkReportId)
        {
            // verify the required parameter 'rkReportId' is set
            if (rkReportId == null)
                throw new ApiException(400, "Missing required parameter 'rkReportId' when calling ReportsApi->DeleteReport");

            var localVarPath = "/reports/{rkReportId}";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rkReportId != null) localVarPathParams.Add("rkReportId", this.Configuration.ApiClient.ParameterToString(rkReportId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List reports (since 1.9) Returns a list of all reports or those that match the filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Report</returns>
        public Report GetReports (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null)
        {
             ApiResponse<Report> localVarResponse = GetReportsWithHttpInfo(description, id, name, subDescription, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List reports (since 1.9) Returns a list of all reports or those that match the filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>ApiResponse of Report</returns>
        public ApiResponse< Report > GetReportsWithHttpInfo (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null)
        {

            var localVarPath = "/reports";
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

            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "description", description)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "name", name)); // query parameter
            if (subDescription != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sub_description", subDescription)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "type", type)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Report>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Report) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Report)));
        }

        /// <summary>
        /// List reports (since 1.9) Returns a list of all reports or those that match the filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Task of Report</returns>
        public async System.Threading.Tasks.Task<Report> GetReportsAsync (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null)
        {
             ApiResponse<Report> localVarResponse = await GetReportsAsyncWithHttpInfo(description, id, name, subDescription, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List reports (since 1.9) Returns a list of all reports or those that match the filter criteria.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description">Description of the report (optional)</param>
        /// <param name="id">Id of the report (optional)</param>
        /// <param name="name">Name of the report (optional)</param>
        /// <param name="subDescription">Support for like search for description parameter. (optional)</param>
        /// <param name="type">Template name for this report (optional)</param>
        /// <returns>Task of ApiResponse (Report)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Report>> GetReportsAsyncWithHttpInfo (List<string> description = null, List<string> id = null, List<string> name = null, List<string> subDescription = null, List<string> type = null)
        {

            var localVarPath = "/reports";
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

            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "description", description)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "name", name)); // query parameter
            if (subDescription != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sub_description", subDescription)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "type", type)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Report>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Report) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Report)));
        }

    }
}
