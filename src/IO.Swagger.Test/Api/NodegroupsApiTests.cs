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
    ///  Class for testing NodegroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NodegroupsApiTests
    {
        private NodegroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NodegroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NodegroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NodegroupsApi
            //Assert.IsInstanceOfType(typeof(NodegroupsApi), instance, "instance is a NodegroupsApi");
        }

        
        /// <summary>
        /// Test AssociateNodeGroupableToNodeGroup
        /// </summary>
        [Test]
        public void AssociateNodeGroupableToNodeGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkParentId = null;
            //string rkChildId = null;
            //instance.AssociateNodeGroupableToNodeGroup(rkParentId, rkChildId);
            
        }
        
        /// <summary>
        /// Test CreateNodeGroup
        /// </summary>
        [Test]
        public void CreateNodeGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NodeGroup body = null;
            //var response = instance.CreateNodeGroup(body);
            //Assert.IsInstanceOf<NodeGroup> (response, "response is NodeGroup");
        }
        
        /// <summary>
        /// Test DeleteNodeGroup
        /// </summary>
        [Test]
        public void DeleteNodeGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeGroupId = null;
            //instance.DeleteNodeGroup(rkNodeGroupId);
            
        }
        
        /// <summary>
        /// Test DisassociateNodeGroupableToNodeGroup
        /// </summary>
        [Test]
        public void DisassociateNodeGroupableToNodeGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkParentId = null;
            //string rkChildId = null;
            //instance.DisassociateNodeGroupableToNodeGroup(rkParentId, rkChildId);
            
        }
        
        /// <summary>
        /// Test GetNodeGroupChildren
        /// </summary>
        [Test]
        public void GetNodeGroupChildrenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeGroupId = null;
            //var response = instance.GetNodeGroupChildren(rkNodeGroupId);
            //Assert.IsInstanceOf<List<NodeGroupChild>> (response, "response is List<NodeGroupChild>");
        }
        
        /// <summary>
        /// Test GetNodeGroupDescendantNodes
        /// </summary>
        [Test]
        public void GetNodeGroupDescendantNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkNodeGroupId = null;
            //var response = instance.GetNodeGroupDescendantNodes(rkNodeGroupId);
            //Assert.IsInstanceOf<List<NodeGroupChild>> (response, "response is List<NodeGroupChild>");
        }
        
        /// <summary>
        /// Test GetNodeGroups
        /// </summary>
        [Test]
        public void GetNodeGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> id = null;
            //List<string> name = null;
            //List<string> description = null;
            //List<string> subDescription = null;
            //List<string> modifiedTime = null;
            //List<string> importedTime = null;
            //List<string> trackingId = null;
            //List<string> type = null;
            //var response = instance.GetNodeGroups(pageLimit, pageStart, id, name, description, subDescription, modifiedTime, importedTime, trackingId, type);
            //Assert.IsInstanceOf<List<NodeGroup>> (response, "response is List<NodeGroup>");
        }
        
        /// <summary>
        /// Test GetRootNodeGroup
        /// </summary>
        [Test]
        public void GetRootNodeGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRootNodeGroup();
            //Assert.IsInstanceOf<NodeGroup> (response, "response is NodeGroup");
        }
        
    }

}
