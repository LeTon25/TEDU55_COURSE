using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterSample
{
    public class Client
    {
        private IStockXMLTarget _stockXMLTarget;
        public Client(IStockXMLTarget stockXMLTarget)
        {
            _stockXMLTarget = stockXMLTarget;
        }

        public XmlDocument GetXMLStock(string stockKey)
        {
            return _stockXMLTarget.GetStockInformationXML(stockKey);
        }
    }
}
