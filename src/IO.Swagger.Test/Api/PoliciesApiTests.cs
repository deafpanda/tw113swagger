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
    ///  Class for testing PoliciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PoliciesApiTests
    {
        private PoliciesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PoliciesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PoliciesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PoliciesApi
            //Assert.IsInstanceOfType(typeof(PoliciesApi), instance, "instance is a PoliciesApi");
        }

        
        /// <summary>
        /// Test DeletePolicy
        /// </summary>
        [Test]
        public void DeletePolicyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkPolicyId = null;
            //instance.DeletePolicy(rkPolicyId);
            
        }
        
        /// <summary>
        /// Test GetIncludedNodes
        /// </summary>
        [Test]
        public void GetIncludedNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkPolicyId = null;
            //var response = instance.GetIncludedNodes(rkPolicyId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetPolicies
        /// </summary>
        [Test]
        public void GetPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> description = null;
            //List<string> id = null;
            //List<string> importedTime = null;
            //string importedTimeRange = null;
            //List<string> modifiedTime = null;
            //List<string> name = null;
            //List<string> nodeScope = null;
            //string pageLimit = null;
            //string pageStart = null;
            //List<string> purgeDataOlderThanDays = null;
            //bool? purgeOldData = null;
            //List<string> subDescription = null;
            //List<string> trackingId = null;
            //var response = instance.GetPolicies(description, id, importedTime, importedTimeRange, modifiedTime, name, nodeScope, pageLimit, pageStart, purgeDataOlderThanDays, purgeOldData, subDescription, trackingId);
            //Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test GetPolicyById
        /// </summary>
        [Test]
        public void GetPolicyByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkPolicyId = null;
            //var response = instance.GetPolicyById(rkPolicyId);
            //Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test RunPolicies
        /// </summary>
        [Test]
        public void RunPoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PolicyRun body = null;
            //instance.RunPolicies(body);
            
        }
        
    }

}
