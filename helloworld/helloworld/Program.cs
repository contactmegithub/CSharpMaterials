using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Program
    {
        public static void PrintStar(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void PrintStarLines(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Program.PrintStar(number - i);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            var result = Console.ReadLine();
            int number = Convert.ToInt32(result);

            Program.PrintStarLines(number);


            Console.ReadLine();
        }
    }
}
