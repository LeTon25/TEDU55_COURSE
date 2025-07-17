using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterSample
{
    public class StockXMLAdapter : IStockXMLTarget
    {
        public XmlDocument GetStockInformationXML(string stockKey)
        {
            StockJsonAdaptee stockAdaptee = new StockJsonAdaptee();
            string jsonStock = stockAdaptee.GetStockInformartion(stockKey);
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonStock, "StockInformation", true);
            return doc;
        }
    }
}
