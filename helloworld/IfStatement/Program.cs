using System;

namespace DecisionMaking
{
    public class MainClass
    {
        public int GetMax(int a, int b)
        {
            int a1 = 10;
            int b1 = 0;
            int c1 = 10;

            if (true)
            {

            }
            else
            {

            }











            if (true)
                Console.WriteLine("Say something");
            Console.WriteLine("Say something");



            if (false)
            {
                Console.WriteLine("Say something");
            }

            if (a1 == c1)
            {
                Console.WriteLine("a1 equals c1");
            }
            else
            {
                Console.WriteLine("a1 not equals c1");
            }
            Console.WriteLine("a1 equals c1");
            int c = 0;

            if (a > b)
                c = a;
            a = c;

            //else
            //{
            //    c = b;
            //}

            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("I am minor");
            }
            else if (age >= 18 && age < 22)
            {
                Console.WriteLine("Some thing ");
            }
            else if(age >= 22 && age < 30)
            {
                Console.WriteLine("Some thing ");
            }
            else if(age >= 30 && age < 40)
            {
                Console.WriteLine("Some thing ");
            }
            else if(age >= 40 && age < 50)
            {
                Console.WriteLine("Some thing ");
            }
            else
            {
                Console.WriteLine("I am a Senor Person");
            }
        }
    }
}