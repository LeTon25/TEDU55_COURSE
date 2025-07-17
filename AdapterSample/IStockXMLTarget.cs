using System;
using System.Xml;

namespace AdapterSample
{
    public interface IStockXMLTarget
    {
        XmlDocument GetStockInformationXML(string stockKey);
    }
}
