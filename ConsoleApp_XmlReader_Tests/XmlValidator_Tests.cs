using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_XmlReader.Contracts;
using ConsoleApp_XmlReader.Class;
using System.Xml;
using System.Xml.Linq;
using ConsoleApp_XmlReader_Tests.Mocks;
using System.IO;

namespace ConsoleApp_XmlReader_Tests
{
    [TestClass]
    public class XmlValidator_Tests
    {
        private readonly IXmlValidator _xmlValidator;

        public XmlValidator_Tests()
        {
            _xmlValidator = new XmlValidator();
        }

        [TestMethod]
        public void IXmlValid_ShouldBeTrue()
        {
            StringReader stringReader = new StringReader(XsdMock.xmlSchemaDefinition);

            var result = _xmlValidator.IsXmlValid(XmlMock.CreateValidXml(), stringReader);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IXmlValid_ShouldBeFalse()
        {
            StringReader stringReader = new StringReader(XsdMock.xmlSchemaDefinition);

            var result = _xmlValidator.IsXmlValid(XmlMock.CreateInvalidXml(), stringReader);

            Assert.IsFalse(result);
        }
    }
}
