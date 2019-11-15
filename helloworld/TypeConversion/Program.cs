using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    public class Program
    {
        public void ImplisitConverstion()
        {
            string age = "50";
            long logAge = 50;
            decimal decAge = 50.9999999M;

            int intAge = (int)decAge;
        }
        public void ExplisitConverstion()
        {
            string strAge = "50";
            int output = 0;
            var r1 = int.Parse(strAge);
            var r3 = Convert.ToInt32(strAge);
            var result = int.TryParse(strAge, out output);
            decimal intAge = Convert.ToDecimal(strAge);
        }

        public void Calcualte()
        {
            Console.WriteLine("How many apples you have");
            var f1 = Console.ReadLine();
            var g1 = 0;
            var l1 = int.TryParse(f1, out g1);
            
            Console.WriteLine("How many apples you wish to sell");
            var f2 = Console.ReadLine();
            var g2 = 0;
            var l2 = int.TryParse(f2, out g2);

            if (g1 < g2)
            {
                Console.WriteLine("You dont have enough");

            }
            else
            {
                var g3 = g1 - g2;
                Console.WriteLine("You remaining count is = {0}", g3);
            }



        }
        public static void Main(string[] args)
        {
            Program _Program = new Program();
            _Program.Calcualte();
        }
    }
}
