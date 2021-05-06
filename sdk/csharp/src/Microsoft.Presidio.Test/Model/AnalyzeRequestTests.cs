/* 
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * OpenAPI spec version: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;
using Microsoft.Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Test
{
    /// <summary>
    ///  Class for testing AnalyzeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnalyzeRequestTests
    {
        private AnalyzeRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            var entities = new List<string>() { "test" };
            instance = new AnalyzeRequest(text:"hello world", language:"en", correlationId:"1234", scoreThreshold:0.4, entities: entities, returnDecisionProcess: false);
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyzeRequest
        /// </summary>
        [Test]
        public void AnalyzeRequestInstanceTest()
        {
            Assert.IsInstanceOfType(typeof(AnalyzeRequest), instance, "variable 'instance' is a AnalyzeRequest");
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Test]
        public void TextTest()
        {
            Assert.IsTrue(instance.Text == "hello world");
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            Assert.IsTrue(instance.Language == "en");
        }
        /// <summary>
        /// Test the property 'CorrelationId'
        /// </summary>
        [Test]
        public void CorrelationIdTest()
        {
            Assert.IsTrue(instance.CorrelationId == "1234");
        }
        /// <summary>
        /// Test the property 'ScoreThreshold'
        /// </summary>
        [Test]
        public void ScoreThresholdTest()
        {
            Assert.IsTrue(instance.ScoreThreshold == 0.4);
        }
        /// <summary>
        /// Test the property 'Entities'
        /// </summary>
        [Test]
        public void EntitiesTest()
        {
            Assert.IsTrue(instance.Entities.Count.Equals(1));
        }
        /// <summary>
        /// Test the property 'ReturnDecisionProcess'
        /// </summary>
        [Test]
        public void ReturnDecisionProcessTest()
        {
            Assert.IsFalse(instance.ReturnDecisionProcess.Value);
        }

    }

}
