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
    ///  Class for testing PermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PermissionsApiTests
    {
        private PermissionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PermissionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PermissionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PermissionsApi
            //Assert.IsInstanceOfType(typeof(PermissionsApi), instance, "instance is a PermissionsApi");
        }

        
        /// <summary>
        /// Test GetAll
        /// </summary>
        [Test]
        public void GetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> category = null;
            //List<string> description = null;
            //List<string> id = null;
            //List<string> name = null;
            //List<string> subDescription = null;
            //List<string> target = null;
            //var response = instance.GetAll(category, description, id, name, subDescription, target);
            //Assert.IsInstanceOf<Permission> (response, "response is Permission");
        }
        
        /// <summary>
        /// Test GetPermissionById
        /// </summary>
        [Test]
        public void GetPermissionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkPermissionId = null;
            //var response = instance.GetPermissionById(rkPermissionId);
            //Assert.IsInstanceOf<Permission> (response, "response is Permission");
        }
        
    }

}
