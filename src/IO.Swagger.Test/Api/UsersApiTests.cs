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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test AssociateHomePageToUser
        /// </summary>
        [Test]
        public void AssociateHomePageToUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //string rkHomePageId = null;
            //instance.AssociateHomePageToUser(rkUserId, rkHomePageId);
            
        }
        
        /// <summary>
        /// Test AssociateRoleToUser
        /// </summary>
        [Test]
        public void AssociateRoleToUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //string rkRoleId = null;
            //instance.AssociateRoleToUser(rkUserId, rkRoleId);
            
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //Password body = null;
            //var response = instance.ChangePassword(rkUserId, body);
            //Assert.IsInstanceOf<Password> (response, "response is Password");
        }
        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User body = null;
            //var response = instance.CreateUser(body);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //instance.DeleteUser(rkUserId);
            
        }
        
        /// <summary>
        /// Test DisassociateHomepageFromUser
        /// </summary>
        [Test]
        public void DisassociateHomepageFromUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //string rkHomePageId = null;
            //instance.DisassociateHomepageFromUser(rkUserId, rkHomePageId);
            
        }
        
        /// <summary>
        /// Test DisassociateRoleFromUser
        /// </summary>
        [Test]
        public void DisassociateRoleFromUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //string rkRoleId = null;
            //instance.DisassociateRoleFromUser(rkUserId, rkRoleId);
            
        }
        
        /// <summary>
        /// Test GetGroupsOfUser
        /// </summary>
        [Test]
        public void GetGroupsOfUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //var response = instance.GetGroupsOfUser(rkUserId);
            //Assert.IsInstanceOf<List<UserGroup>> (response, "response is List<UserGroup>");
        }
        
        /// <summary>
        /// Test GetHomepagesByUserId
        /// </summary>
        [Test]
        public void GetHomepagesByUserIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //var response = instance.GetHomepagesByUserId(rkUserId);
            //Assert.IsInstanceOf<List<Homepage>> (response, "response is List<Homepage>");
        }
        
        /// <summary>
        /// Test GetRolesByUserId
        /// </summary>
        [Test]
        public void GetRolesByUserIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //var response = instance.GetRolesByUserId(rkUserId);
            //Assert.IsInstanceOf<List<Role>> (response, "response is List<Role>");
        }
        
        /// <summary>
        /// Test GetUserById
        /// </summary>
        [Test]
        public void GetUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //var response = instance.GetUserById(rkUserId);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //List<string> name = null;
            //List<string> description = null;
            //List<string> subDescription = null;
            //bool? builtin = null;
            //List<string> lastLogin = null;
            //List<string> lastLogout = null;
            //List<string> email = null;
            //var response = instance.GetUsers(id, name, description, subDescription, builtin, lastLogin, lastLogout, email);
            //Assert.IsInstanceOf<List<User>> (response, "response is List<User>");
        }
        
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkUserId = null;
            //User body = null;
            //var response = instance.UpdateUser(rkUserId, body);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
    }

}
