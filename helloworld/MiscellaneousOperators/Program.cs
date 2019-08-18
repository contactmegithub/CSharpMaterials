using System;

namespace OperatorsAppl
{
    public class Students
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        public void tetMent(dynamic value)
        {
            var result = typeof(Students);

            var result2 = value is Students;
            var result20 = value is int;

            var result3 = value as Students;

        }
        static void Main(string[] args)
        {
            Program _Program = new Program();
            Students _Students = new Students();
            _Program.tetMent(56);

            /* example of sizeof operator */
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of double is {0}", sizeof(double));

            /* example of ternary operator */
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);
            Console.ReadLine();
        }

    }
}