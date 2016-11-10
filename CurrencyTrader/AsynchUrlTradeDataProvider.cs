using CurrencyTrader;
using CurrencyTrader.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader
{
    public class AsynchUrlTradeDataProvider : ITradeDataProvider

    {
        private readonly String url;
        UrlTradeDataProvider SynchTradeProvider;
        public AsynchUrlTradeDataProvider(string url)
        {
            this.url = url;
            SynchTradeProvider = new UrlTradeDataProvider(url);
        }
        public IEnumerable<string> GetTradeData()
        {
            //return SynchTradeProvider.GetTradeData();
            Task.Run(() => SynchTradeProvider.GetTradeData());
        }

        
    }
}
