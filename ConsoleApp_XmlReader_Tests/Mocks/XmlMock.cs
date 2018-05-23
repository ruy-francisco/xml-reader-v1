using System.Xml.Linq;

namespace ConsoleApp_XmlReader_Tests.Mocks
{
    public static class XmlMock
    {
        public static XDocument CreateValidXml()
        {
            return new XDocument(
                new XElement("Root",
                    new XElement("Child1", "content1"),
                    new XElement("Child2", "content1")
                )
            );
        }

        public static XDocument CreateInvalidXml()
        {
            return new XDocument(
                new XElement("Root",
                    new XElement("Child1", "content1"),
                    new XElement("Child3", "content3")
                )
            );
        }
    }
}
