using System;
using ConsoleApp_XmlReader.Contracts;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.IO;

namespace ConsoleApp_XmlReader.Class
{
    public class XmlValidator : IXmlValidator
    {
        public bool IsXmlValid(XDocument xDocument, StringReader xmlSchemaDefinition)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", XmlReader.Create(xmlSchemaDefinition));

            bool errors = false;

            xDocument.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            return !errors;
        }
    }
}
