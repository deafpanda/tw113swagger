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
    ///  Class for testing NodesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NodesApiTests
    {
        private NodesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NodesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NodesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NodesApi
            //Assert.IsInstanceOfType(typeof(NodesApi), instance, "instance is a NodesApi");
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
        /// Test CreateNode
        /// </summary>
        [Test]
        public void CreateNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Node body = null;
            //var response = instance.CreateNode(body);
            //Assert.IsInstanceOf<Node> (response, "response is Node");
        }
        
        /// <summary>
        /// Test CreateNodeAcl
        /// </summary>
        [Test]
        public void CreateNodeAclTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //Object body = null;
            //var response = instance.CreateNodeAcl(rkNodeId, body);
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
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
        /// Test DeleteNode
        /// </summary>
        [Test]
        public void DeleteNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //instance.DeleteNode(rkNodeId);
            
        }
        
        /// <summary>
        /// Test DeleteNodeCustomProperty
        /// </summary>
        [Test]
        public void DeleteNodeCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //string propertyName = null;
            //instance.DeleteNodeCustomProperty(rkNodeId, propertyName);
            
        }
        
        /// <summary>
        /// Test GetCustomProperties
        /// </summary>
        [Test]
        public void GetCustomPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //var response = instance.GetCustomProperties(rkNodeId);
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
        /// Test GetNodeAcl
        /// </summary>
        [Test]
        public void GetNodeAclTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //var response = instance.GetNodeAcl(rkNodeId);
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
        }
        
        /// <summary>
        /// Test GetNodeById
        /// </summary>
        [Test]
        public void GetNodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //var response = instance.GetNodeById(rkNodeId);
            //Assert.IsInstanceOf<Node> (response, "response is Node");
        }
        
        /// <summary>
        /// Test GetNodeParentGroups
        /// </summary>
        [Test]
        public void GetNodeParentGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //var response = instance.GetNodeParentGroups(rkNodeId);
            //Assert.IsInstanceOf<List<NodeGroupPath>> (response, "response is List<NodeGroupPath>");
        }
        
        /// <summary>
        /// Test GetNodes
        /// </summary>
        [Test]
        public void GetNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> id = null;
            //List<string> oid = null;
            //List<string> name = null;
            //List<string> subName = null;
            //List<string> icName = null;
            //List<string> description = null;
            //List<string> subDescription = null;
            //List<string> make = null;
            //List<string> model = null;
            //List<string> version = null;
            //List<string> licensedFeature = null;
            //List<string> maxSeverity = null;
            //List<string> elementCount = null;
            //bool? hasFailures = null;
            //List<string> lastCheck = null;
            //bool? isDisabled = null;
            //List<string> modifiedTime = null;
            //List<string> importedTime = null;
            //List<string> trackingId = null;
            //List<string> type = null;
            //List<string> lastRegistration = null;
            //List<string> rmiHost = null;
            //List<string> rmiPort = null;
            //bool? auditEnabled = null;
            //bool? eventGeneratorInstalled = null;
            //bool? eventGeneratorEnabled = null;
            //bool? realTimeEnabled = null;
            //List<string> agentVersion = null;
            //List<string> proxyHost = null;
            //List<string> proxyPort = null;
            //bool? isSocksProxy = null;
            //List<string> commonAgentUuid = null;
            //List<string> commonAgentOsName = null;
            //List<string> commonAgentOsVersion = null;
            //List<string> commonAgentVersion = null;
            //List<string> commonAgentCapabilities = null;
            //List<string> macAddress = null;
            //List<string> ipAddress = null;
            //List<string> tag = null;
            //List<string> customProperty = null;
            //string importedTimeRange = null;
            //var response = instance.GetNodes(pageLimit, pageStart, id, oid, name, subName, icName, description, subDescription, make, model, version, licensedFeature, maxSeverity, elementCount, hasFailures, lastCheck, isDisabled, modifiedTime, importedTime, trackingId, type, lastRegistration, rmiHost, rmiPort, auditEnabled, eventGeneratorInstalled, eventGeneratorEnabled, realTimeEnabled, agentVersion, proxyHost, proxyPort, isSocksProxy, commonAgentUuid, commonAgentOsName, commonAgentOsVersion, commonAgentVersion, commonAgentCapabilities, macAddress, ipAddress, tag, customProperty, importedTimeRange);
            //Assert.IsInstanceOf<List<Node>> (response, "response is List<Node>");
        }
        
        /// <summary>
        /// Test GetRuleRunRequestById
        /// </summary>
        [Test]
        public void GetRuleRunRequestByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.GetRuleRunRequestById(requestId);
            //Assert.IsInstanceOf<RuleRunRequestCommand> (response, "response is RuleRunRequestCommand");
        }
        
        /// <summary>
        /// Test RestartNodes
        /// </summary>
        [Test]
        public void RestartNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NodeRestart body = null;
            //var response = instance.RestartNodes(body);
            //Assert.IsInstanceOf<NodeRestartResult> (response, "response is NodeRestartResult");
        }
        
        /// <summary>
        /// Test RetireNode
        /// </summary>
        [Test]
        public void RetireNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //instance.RetireNode(rkNodeId);
            
        }
        
        /// <summary>
        /// Test RuleRunRequest
        /// </summary>
        [Test]
        public void RuleRunRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RuleRunRequestCommand body = null;
            //var response = instance.RuleRunRequest(body);
            //Assert.IsInstanceOf<RuleRunRequestCommand> (response, "response is RuleRunRequestCommand");
        }
        
        /// <summary>
        /// Test SetNodeCustomProperty
        /// </summary>
        [Test]
        public void SetNodeCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //string propertyName = null;
            //PropertyValue body = null;
            //instance.SetNodeCustomProperty(rkNodeId, propertyName, body);
            
        }
        
        /// <summary>
        /// Test UnregisterCommonAgent
        /// </summary>
        [Test]
        public void UnregisterCommonAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //instance.UnregisterCommonAgent(rkNodeId);
            
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
        /// Test UpdateNode
        /// </summary>
        [Test]
        public void UpdateNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeId = null;
            //Node body = null;
            //var response = instance.UpdateNode(rkNodeId, body);
            //Assert.IsInstanceOf<Node> (response, "response is Node");
        }
        
    }

}