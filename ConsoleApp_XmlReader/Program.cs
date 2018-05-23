using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using ConsoleApp_XmlReader.Class;

namespace ConsoleApp_XmlReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = Path.GetFullPath("/users/ruy/Documents/Training/XML/input.xml");
            string xsdPath = Path.GetFullPath("/users/ruy/Documents/Training/XML/validationSchema.xsd");

            XElement inputXml = XElement.Load(xmlPath);
            XDocument xmlDocument = new XDocument(inputXml);

            StringReader xmlSchemaDefinition = new StringReader(File.ReadAllText(xsdPath));

            XmlValidator xmlValidator = new XmlValidator();

            var isXmlValid = xmlValidator.IsXmlValid(xmlDocument, xmlSchemaDefinition);
        }
    }
}
