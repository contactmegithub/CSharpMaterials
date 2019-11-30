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
        public static StockDetails operator +(StockDetails _StockDetails, StockDetails _StockDetails2)
        {
            StockDetails _StockDetails3 = new StockDetails()
            {

                AppleCount = _StockDetails.AppleCount + _StockDetails2.AppleCount,
                BananaCount = _StockDetails.BananaCount + _StockDetails2.BananaCount,
                LemonCount = _StockDetails.LemonCount + _StockDetails2.LemonCount,
                OrangeCount = _StockDetails.OrangeCount + _StockDetails2.OrangeCount

            };
            return _StockDetails3;
        }
        public static StockDetails operator -(StockDetails _StockDetails, StockDetails _StockDetails2)
        {
            StockDetails _StockDetails3 = new StockDetails()
            {

                AppleCount = _StockDetails.AppleCount - _StockDetails2.AppleCount,
                BananaCount = _StockDetails.BananaCount - _StockDetails2.BananaCount,
                LemonCount = _StockDetails.LemonCount - _StockDetails2.LemonCount,
                OrangeCount = _StockDetails.OrangeCount - _StockDetails2.OrangeCount

            };
            return _StockDetails3;
        }
        public static StockDetails operator ++(StockDetails _StockDetails)
        {
            StockDetails _StockDetails3 = new StockDetails()
            {

                AppleCount = _StockDetails.AppleCount+10,
                BananaCount = _StockDetails.BananaCount + 10,
                LemonCount = _StockDetails.LemonCount + 10,
                OrangeCount = _StockDetails.OrangeCount + 10,

            };
            return _StockDetails3;
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

            int a = 100;
            int b = 200;
            int c = a + b;

            StockDetails _StockDetails = new StockDetails()
            {
                AppleCount = 10,
                BananaCount = 20,
                LemonCount = 30,
                OrangeCount = 40
            };
            StockDetails _StockDetails2 = new StockDetails()
            {
                AppleCount = 10,
                BananaCount = 20,
                LemonCount = 30,
                OrangeCount = 40
            };


            var result = _StockDetails + _StockDetails2;
            var result2 = _StockDetails - _StockDetails2;
            var result3 = _StockDetails++;
            var result4 = _StockDetails;




        }
    }
}
