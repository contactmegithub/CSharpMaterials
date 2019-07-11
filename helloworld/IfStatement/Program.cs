using System;

namespace DecisionMaking
{
    public class MainClass
    {
        public int GetMax(int a, int b)
        {
            int c = 0;

            if (a > b)
                c = a;

            else
            {
                c = b;
            }

            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 10;

            MainClass _MainClass = new MainClass();
            var result = _MainClass.GetMax(20, 10);
            Console.WriteLine(result + " is a large number");
            /* check the boolean condition using if statement */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine();
        }
    }
}