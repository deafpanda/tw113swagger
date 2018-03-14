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
    ///  Class for testing HomepagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HomepagesApiTests
    {
        private HomepagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HomepagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HomepagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HomepagesApi
            //Assert.IsInstanceOfType(typeof(HomepagesApi), instance, "instance is a HomepagesApi");
        }

        
        /// <summary>
        /// Test GetAll
        /// </summary>
        [Test]
        public void GetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //List<string> name = null;
            //List<string> description = null;
            //List<string> subDescription = null;
            //List<string> trackingId = null;
            //var response = instance.GetAll(id, name, description, subDescription, trackingId);
            //Assert.IsInstanceOf<List<Homepage>> (response, "response is List<Homepage>");
        }
        
        /// <summary>
        /// Test GetHomepageById
        /// </summary>
        [Test]
        public void GetHomepageByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkHomepageId = null;
            //var response = instance.GetHomepageById(rkHomepageId);
            //Assert.IsInstanceOf<Homepage> (response, "response is Homepage");
        }
        
    }

}
