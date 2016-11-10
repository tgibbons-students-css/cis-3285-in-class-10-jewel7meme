using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurrencyTrader.Contracts;

namespace CurrencyTrader
{
    public class TradeDataUpdate : ITradeDataUpdate
    {
        ListBox.ObjectCollection tradItems;
        public TradeDataUpdate(ListBox.ObjectCollection items)
        {
            this.tradItems = items;
        }

        public void UpdateTradeData(IEnumerable<string> lines)
        {
            foreach (string line in lines)
            {
                tradItems.Add(line);
            }
        }
    }
}
