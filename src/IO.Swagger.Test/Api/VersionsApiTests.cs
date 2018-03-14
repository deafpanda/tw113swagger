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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing VersionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VersionsApiTests
    {
        private VersionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VersionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VersionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VersionsApi
            //Assert.IsInstanceOfType(typeof(VersionsApi), instance, "instance is a VersionsApi");
        }

        
        /// <summary>
        /// Test CreateCustomPropertyType
        /// </summary>
        [Test]
        public void CreateCustomPropertyTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomPropertyType body = null;
            //var response = instance.CreateCustomPropertyType(body);
            //Assert.IsInstanceOf<CustomPropertyType> (response, "response is CustomPropertyType");
        }
        
        /// <summary>
        /// Test CreateVersionRequest
        /// </summary>
        [Test]
        public void CreateVersionRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateVersionRequest body = null;
            //var response = instance.CreateVersionRequest(body);
            //Assert.IsInstanceOf<CreateVersionRequest> (response, "response is CreateVersionRequest");
        }
        
        /// <summary>
        /// Test DeleteCustomPropertyType
        /// </summary>
        [Test]
        public void DeleteCustomPropertyTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkCustomPropertyTypeId = null;
            //instance.DeleteCustomPropertyType(rkCustomPropertyTypeId);
            
        }
        
        /// <summary>
        /// Test DeleteElementVersion
        /// </summary>
        [Test]
        public void DeleteElementVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //instance.DeleteElementVersion(rkVersionId);
            
        }
        
        /// <summary>
        /// Test DeleteElementVersionCustomProperty
        /// </summary>
        [Test]
        public void DeleteElementVersionCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //string propertyName = null;
            //instance.DeleteElementVersionCustomProperty(rkVersionId, propertyName);
            
        }
        
        /// <summary>
        /// Test GetAuditDataByReadableKeyVersionId
        /// </summary>
        [Test]
        public void GetAuditDataByReadableKeyVersionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //var response = instance.GetAuditDataByReadableKeyVersionId(rkVersionId);
            //Assert.IsInstanceOf<List<AuditInfo>> (response, "response is List<AuditInfo>");
        }
        
        /// <summary>
        /// Test GetCreateVersionRequestById
        /// </summary>
        [Test]
        public void GetCreateVersionRequestByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.GetCreateVersionRequestById(requestId);
            //Assert.IsInstanceOf<CreateVersionRequest> (response, "response is CreateVersionRequest");
        }
        
        /// <summary>
        /// Test GetCustomProperties
        /// </summary>
        [Test]
        public void GetCustomPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //var response = instance.GetCustomProperties(rkVersionId);
            //Assert.IsInstanceOf<CustomProperties> (response, "response is CustomProperties");
        }
        
        /// <summary>
        /// Test GetCustomPropertyTypeById
        /// </summary>
        [Test]
        public void GetCustomPropertyTypeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkCustomPropertyTypeId = null;
            //var response = instance.GetCustomPropertyTypeById(rkCustomPropertyTypeId);
            //Assert.IsInstanceOf<CustomPropertyType> (response, "response is CustomPropertyType");
        }
        
        /// <summary>
        /// Test GetCustomPropertyTypes
        /// </summary>
        [Test]
        public void GetCustomPropertyTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //List<string> type = null;
            //List<string> name = null;
            //List<string> description = null;
            //List<string> subDescription = null;
            //bool? inheritDefault = null;
            //List<string> defaultValue = null;
            //List<string> minValue = null;
            //List<string> maxValue = null;
            //List<string> availableValues = null;
            //List<string> maxCharacters = null;
            //bool? allowMultilineValues = null;
            //List<string> textEditorWidth = null;
            //var response = instance.GetCustomPropertyTypes(id, type, name, description, subDescription, inheritDefault, defaultValue, minValue, maxValue, availableValues, maxCharacters, allowMultilineValues, textEditorWidth);
            //Assert.IsInstanceOf<List<CustomPropertyType>> (response, "response is List<CustomPropertyType>");
        }
        
        /// <summary>
        /// Test GetElementVersionAttributes
        /// </summary>
        [Test]
        public void GetElementVersionAttributesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //var response = instance.GetElementVersionAttributes(rkVersionId);
            //Assert.IsInstanceOf<Dictionary<string, ValueTypeAttribute>> (response, "response is Dictionary<string, ValueTypeAttribute>");
        }
        
        /// <summary>
        /// Test GetElementVersionContent
        /// </summary>
        [Test]
        public void GetElementVersionContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //string sizeLimit = null;
            //var response = instance.GetElementVersionContent(rkVersionId, sizeLimit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetElementVersionDetailsById
        /// </summary>
        [Test]
        public void GetElementVersionDetailsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //var response = instance.GetElementVersionDetailsById(rkVersionId);
            //Assert.IsInstanceOf<ElementVersion> (response, "response is ElementVersion");
        }
        
        /// <summary>
        /// Test GetElementVersionsExtract
        /// </summary>
        [Test]
        public void GetElementVersionsExtractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //string timeDetectedRange = null;
            //string timeReceivedRange = null;
            //string previousId = null;
            //var response = instance.GetElementVersionsExtract(pageLimit, timeDetectedRange, timeReceivedRange, previousId);
            //Assert.IsInstanceOf<List<ElementVersionWithAttributes>> (response, "response is List<ElementVersionWithAttributes>");
        }
        
        /// <summary>
        /// Test GetHistoricalElementVersions
        /// </summary>
        [Test]
        public void GetHistoricalElementVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> id = null;
            //List<string> elementName = null;
            //List<string> nodeLabel = null;
            //List<string> ruleName = null;
            //List<string> elementId = null;
            //List<string> nodeId = null;
            //List<string> ruleId = null;
            //List<string> baselineVersion = null;
            //List<string> changeType = null;
            //bool? exists = null;
            //List<string> severity = null;
            //List<string> timeDetected = null;
            //List<string> timeReceived = null;
            //List<string> promotionComment = null;
            //List<string> approvalId = null;
            //bool? outsideMaintenanceWindow = null;
            //List<string> scanId = null;
            //List<string> md5 = null;
            //List<string> sha1 = null;
            //List<string> sha256 = null;
            //List<string> sha512 = null;
            //List<string> hash = null;
            //string timeDetectedRange = null;
            //string timeReceivedRange = null;
            //string at = null;
            //bool? isPromoted = null;
            //string severityRange = null;
            //var response = instance.GetHistoricalElementVersions(pageLimit, pageStart, id, elementName, nodeLabel, ruleName, elementId, nodeId, ruleId, baselineVersion, changeType, exists, severity, timeDetected, timeReceived, promotionComment, approvalId, outsideMaintenanceWindow, scanId, md5, sha1, sha256, sha512, hash, timeDetectedRange, timeReceivedRange, at, isPromoted, severityRange);
            //Assert.IsInstanceOf<List<ElementVersion>> (response, "response is List<ElementVersion>");
        }
        
        /// <summary>
        /// Test GetLatestElementVersions
        /// </summary>
        [Test]
        public void GetLatestElementVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> id = null;
            //List<string> elementName = null;
            //List<string> nodeLabel = null;
            //List<string> ruleName = null;
            //List<string> elementId = null;
            //List<string> nodeId = null;
            //List<string> ruleId = null;
            //List<string> baselineVersion = null;
            //List<string> changeType = null;
            //bool? exists = null;
            //List<string> severity = null;
            //List<string> timeDetected = null;
            //List<string> timeReceived = null;
            //List<string> promotionComment = null;
            //List<string> approvalId = null;
            //bool? outsideMaintenanceWindow = null;
            //List<string> scanId = null;
            //List<string> md5 = null;
            //List<string> sha1 = null;
            //List<string> sha256 = null;
            //List<string> sha512 = null;
            //List<string> hash = null;
            //string timeDetectedRange = null;
            //string timeReceivedRange = null;
            //bool? isPromoted = null;
            //string severityRange = null;
            //var response = instance.GetLatestElementVersions(pageLimit, pageStart, id, elementName, nodeLabel, ruleName, elementId, nodeId, ruleId, baselineVersion, changeType, exists, severity, timeDetected, timeReceived, promotionComment, approvalId, outsideMaintenanceWindow, scanId, md5, sha1, sha256, sha512, hash, timeDetectedRange, timeReceivedRange, isPromoted, severityRange);
            //Assert.IsInstanceOf<List<ElementVersion>> (response, "response is List<ElementVersion>");
        }
        
        /// <summary>
        /// Test GetPromoteRequestById
        /// </summary>
        [Test]
        public void GetPromoteRequestByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.GetPromoteRequestById(requestId);
            //Assert.IsInstanceOf<CreateVersionRequest> (response, "response is CreateVersionRequest");
        }
        
        /// <summary>
        /// Test PromoteRequest
        /// </summary>
        [Test]
        public void PromoteRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PromoteRequestCommand body = null;
            //var response = instance.PromoteRequest(body);
            //Assert.IsInstanceOf<PromoteRequestCommand> (response, "response is PromoteRequestCommand");
        }
        
        /// <summary>
        /// Test SetElementVersionCustomProperty
        /// </summary>
        [Test]
        public void SetElementVersionCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //string propertyName = null;
            //PropertyValue body = null;
            //instance.SetElementVersionCustomProperty(rkVersionId, propertyName, body);
            
        }
        
        /// <summary>
        /// Test UpdateCustomPropertyType
        /// </summary>
        [Test]
        public void UpdateCustomPropertyTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomPropertyType body = null;
            //string rkCustomPropertyTypeId = null;
            //var response = instance.UpdateCustomPropertyType(body, rkCustomPropertyTypeId);
            //Assert.IsInstanceOf<CustomPropertyType> (response, "response is CustomPropertyType");
        }
        
        /// <summary>
        /// Test UpdateElementVersion
        /// </summary>
        [Test]
        public void UpdateElementVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkVersionId = null;
            //ElementVersionSeverity body = null;
            //var response = instance.UpdateElementVersion(rkVersionId, body);
            //Assert.IsInstanceOf<ElementVersion> (response, "response is ElementVersion");
        }
        
    }

}