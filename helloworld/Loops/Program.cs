using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {

        #region While samples
        public static void WSample1()
        {
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            Console.ReadLine();
        }
        #endregion

        #region for Samples
        public static void ForSample1()
        {

            /* for loop execution new changes*/


            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("value of a: {0}", a);
            }
            Console.ReadLine();
        }
        #endregion

        #region do while samples
        public static void DowhileSample1()
        {
            /* local variable definition */
            int a = 1000000;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 20);


            Console.ReadLine();
        }
        #endregion

        #region nested loops
        public static void NestedLoopSample1()
        {
            /* local variable definition */
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if (j > (i / j)) Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();
        }
        #endregion

        #region Loop Control Statements
        public static void BreakStatmet()
        {
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
                
                if (a > 15)
                {
                    /* terminate the loop using break statement */
                    break;
                }
            }
            Console.ReadLine();
        }

        public static void ContinueStatmet()
        {
            /* local variable definition */
            int a = 10;

            /* do loop execution */
            do
            {
                if (a == 15)
                {
                    /* skip the iteration */
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
            Console.ReadLine();
        }
        #endregion
        public static void LoopSamples()
        {
            ForSample1();
        }
        public static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                        continue;
                    Console.WriteLine($"{i},{j}");
                }
            }

        }
    }
}
