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
    ///  Class for testing ElementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ElementsApiTests
    {
        private ElementsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ElementsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ElementsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ElementsApi
            //Assert.IsInstanceOfType(typeof(ElementsApi), instance, "instance is a ElementsApi");
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
        /// Test DeleteElement
        /// </summary>
        [Test]
        public void DeleteElementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkElementId = null;
            //instance.DeleteElement(rkElementId);
            
        }
        
        /// <summary>
        /// Test DeleteElementCustomProperty
        /// </summary>
        [Test]
        public void DeleteElementCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkElementId = null;
            //string propertyName = null;
            //instance.DeleteElementCustomProperty(rkElementId, propertyName);
            
        }
        
        /// <summary>
        /// Test GetCustomProperties
        /// </summary>
        [Test]
        public void GetCustomPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkElementId = null;
            //var response = instance.GetCustomProperties(rkElementId);
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
        /// Test GetElements
        /// </summary>
        [Test]
        public void GetElementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageLimit = null;
            //List<string> id = null;
            //List<string> name = null;
            //List<string> nodeId = null;
            //List<string> ruleId = null;
            //string previousId = null;
            //string pageStart = null;
            //var response = instance.GetElements(pageLimit, id, name, nodeId, ruleId, previousId, pageStart);
            //Assert.IsInstanceOf<List<Element>> (response, "response is List<Element>");
        }
        
        /// <summary>
        /// Test SetElementCustomProperty
        /// </summary>
        [Test]
        public void SetElementCustomPropertyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rkElementId = null;
            //string propertyName = null;
            //PropertyValue body = null;
            //instance.SetElementCustomProperty(rkElementId, propertyName, body);
            
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
        
    }

}