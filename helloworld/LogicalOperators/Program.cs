using System;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            int x = 2;
            int y = 2;
            int z = 3;

            string LastName = string.Empty;
            string Initial = string.Empty;

            if (!(LastName == string.Empty))
            {
                ///store the record
            }
            else
            {
                LastName = Initial;
                ///store the record
            }

            if (x == 1 & y == 2)
            {

            }

            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }

            if (a || b)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }

            /* lets change the value of  a and b */
            a = false;
            b = true;

            if (a && b)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }

            if (!(a && b))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            Console.ReadLine();
        }
    }
}