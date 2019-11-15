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
            int Number1 = 10;
            int Number2 = 10;
            int Number3 = 10;
            int Number4 = 10;

            if (!(Number1 == Number2 || Number3 == Number4))
            {

            }














            if (!(Number1 == Number2))
            {
                Console.WriteLine("All are matched with any of three");
            }

            int result = 50;
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

            if (!(x == y && x + y == 30))
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