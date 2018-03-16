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
    ///  Class for testing RulegroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RulegroupsApiTests
    {
        private RulegroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RulegroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RulegroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RulegroupsApi
            //Assert.IsInstanceOfType(typeof(RulegroupsApi), instance, "instance is a RulegroupsApi");
        }

        
        /// <summary>
        /// Test AssociateRuleGroupableToRuleGroup
        /// </summary>
        [Test]
        public void AssociateRuleGroupableToRuleGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkRuleGroupableId = null;
            //string rkRuleGroupId = null;
            //instance.AssociateRuleGroupableToRuleGroup(rkRuleGroupableId, rkRuleGroupId);
            
        }
        
        /// <summary>
        /// Test CreateRuleGroup
        /// </summary>
        [Test]
        public void CreateRuleGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RuleGroup body = null;
            //var response = instance.CreateRuleGroup(body);
            //Assert.IsInstanceOf<RuleGroup> (response, "response is RuleGroup");
        }
        
        /// <summary>
        /// Test DeleteRuleGroup
        /// </summary>
        [Test]
        public void DeleteRuleGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkRuleGroupId = null;
            //instance.DeleteRuleGroup(rkRuleGroupId);
            
        }
        
        /// <summary>
        /// Test DisassociateRuleGroupableFromRuleGroup
        /// </summary>
        [Test]
        public void DisassociateRuleGroupableFromRuleGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkRuleGroupableId = null;
            //string rkRuleGroupId = null;
            //instance.DisassociateRuleGroupableFromRuleGroup(rkRuleGroupableId, rkRuleGroupId);
            
        }
        
        /// <summary>
        /// Test GetRootRuleGroup
        /// </summary>
        [Test]
        public void GetRootRuleGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRootRuleGroup();
            //Assert.IsInstanceOf<RuleGroup> (response, "response is RuleGroup");
        }
        
        /// <summary>
        /// Test GetRuleGroupById
        /// </summary>
        [Test]
        public void GetRuleGroupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkRuleGroupId = null;
            //var response = instance.GetRuleGroupById(rkRuleGroupId);
            //Assert.IsInstanceOf<RuleGroup> (response, "response is RuleGroup");
        }
        
        /// <summary>
        /// Test GetRuleGroups
        /// </summary>
        [Test]
        public void GetRuleGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> description = null;
            //List<string> id = null;
            //List<string> importedTime = null;
            //List<string> modifiedTime = null;
            //List<string> name = null;
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> subDescription = null;
            //List<string> trackingId = null;
            //var response = instance.GetRuleGroups(description, id, importedTime, modifiedTime, name, pageLimit, pageStart, subDescription, trackingId);
            //Assert.IsInstanceOf<RuleGroup> (response, "response is RuleGroup");
        }
        
    }

}
