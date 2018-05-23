﻿namespace ConsoleApp_XmlReader_Tests.Mocks
{
    public static class XsdMock
    {
        public static readonly string xmlSchemaDefinition = @"
            <xsd:schema xmlns:xsd='http://www.w3.org/2001/XMLSchema'>  
            <xsd:element name='Root'>  
            <xsd:complexType>  
                <xsd:sequence>  
                <xsd:element name='Child1' minOccurs='1' maxOccurs='1'/>  
                <xsd:element name='Child2' minOccurs='1' maxOccurs='1'/>  
                </xsd:sequence>  
            </xsd:complexType>  
            </xsd:element>  
            </xsd:schema>";
    }
}
