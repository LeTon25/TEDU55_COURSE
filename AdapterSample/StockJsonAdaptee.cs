using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class StockJsonAdaptee
    {
        private List<StockDto> _listStocks;
        public StockJsonAdaptee()
        {
            _listStocks = new List<StockDto>();
            _listStocks.Add(new StockDto
            {
                StockKey = "TSLA",
                StockName = "Tesla, Inc.",
                Open = 160.9,
                High = 165,
                Low = 157.32
            });
            _listStocks.Add(new StockDto
            {
                StockKey = "AMZN",
                StockName = "Amazon.com, Inc.",
                Open = 107.73,
                High = 109.48,
                Low = 104.33
            });
            _listStocks.Add(new StockDto
            {
                StockKey = "AAPL",
                StockName = "Apple Inc.",
                Open = 168.49,
                High = 169.85,
                Low = 167.88
            });
            _listStocks.Add(new StockDto
            {
                StockKey = "MSFT",
                StockName = "Microsoft Corporation",
                Open = 304.01,
                High = 308.93,
                Low = 303.31
            });

        }
        public string GetStockInformartion(string stockKey)
        {
            var result = _listStocks.FirstOrDefault(x => x.StockKey == stockKey);
            return JsonConvert.SerializeObject(result);
        }
    }
}
