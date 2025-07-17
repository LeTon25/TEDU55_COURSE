using AdapterSample;

StockXMLAdapter xmlAdapter = new StockXMLAdapter();
Client client = new Client(xmlAdapter);
var xmlResult = client.GetXMLStock("TSLA");


Console.WriteLine(xmlResult.OuterXml);
