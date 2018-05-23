using System.Xml.Linq;
using System.IO;

namespace ConsoleApp_XmlReader.Contracts
{
    public interface IXmlValidator
    {
        bool IsXmlValid(XDocument xDocument, StringReader xmlSchemaDefinition);
    }
}
