using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingConsole
{
    public class StockDetails
    {
        public int AppleCount { get; set; }
        public int BananaCount { get; set; }
        public int OrangeCount { get; set; }
        public int LemonCount { get; set; }
        public static StockDetails operator+(StockDetails stock, StockDetails stockDetails)
        {
            return null;
        }
    }
    public class Program
    {
        private readonly StockDetails stockDetails = null;
        Program(StockDetails stockDetails)
        {
            this.stockDetails = stockDetails;
        }


        static void Main(string[] args)
        {

            
        }
    }
}
