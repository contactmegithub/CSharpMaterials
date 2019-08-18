using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    public class Program
    {
        public static void ifSample()
        {
            /* local variable definition */
            int a = 10;
            if (false)
            {
            }
            /* check the boolean condition using if statement */
            if (a < 20)
                Console.WriteLine("a is less than 20");
            Console.WriteLine("a is less than 20");

            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine();
        }
        public static void ifelseSample()
        {
            /* local variable definition */
            int a = 100;

            /* check the boolean condition */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            else
            {
                /* if condition is false then print the following */
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine();
        }
        public static void EelseifSample()
        {
            int a = 90;

            if (a > 100)
                Console.WriteLine("a greater than 100");
            else if (a > 90)
                Console.WriteLine("a greater than 90");
            else if(a > 80)
                Console.WriteLine("a greater than 80");
            else if(a > 70)
                Console.WriteLine("a greater than 70");
            else if(a > 60)
                Console.WriteLine("a greater than 60");
            else if(a > 50)
                Console.WriteLine("a greater than 50");
            else
                Console.WriteLine("a lesthan or equal to 50");
        }
        public static void nestedIfStatment()
        {
            //* local variable definition */
            int a = 100;
            int b = 200;

            /* check the boolean condition */
            if (a == 100)
            {

                /* if condition is true then check the following */
                if (b == 200)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
            Console.ReadLine();
        }
        public static void switchStatment()
        {
            /* local variable definition */
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
            Console.ReadLine();
        }
        public static string switchStatment(char grade)
        {
            /* local variable definition */

            switch (grade)
            {
                case 'A':
                    return "Excellent!";
                case 'B':
                case 'C':
                    return "Well done";
                case 'D':
                    return "You passed";
                case 'F':
                    return "Better try again";
                default:
                    return "Invalid grade";
            }

        }
        public static void nestedSwitch()
        {
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("This is part of outer switch ");

                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("This is part of inner switch ");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
            Console.ReadLine();
        }

        public enum Gender
        {
            Male,
            Female,
            Trans,
            Others
        }
        public static void PrintWelcomeText(string FirstName, string LastName, Gender gender)
        {
            switch (gender)
            {
                case Gender.Female:
                    Console.WriteLine("Welcome Mis." + FirstName + " " + LastName);
                    break;
                case Gender.Male:
                    Console.WriteLine("Welcome Mr." + FirstName + " " + LastName);
                    break;
                case Gender.Trans:
                    Console.WriteLine("Welcome Mis." + FirstName + " " + LastName);
                    break;
                case Gender.Others:
                    Console.WriteLine("Welcome " + FirstName + " " + LastName);
                    break;
                default:
                    Console.WriteLine("Invalid gender");
                    break;
            }
        }
        public static void Main(string[] args)
        {
            switchStatment();
            PrintWelcomeText("Abinaya", "Ganesan", Gender.Female);
            PrintWelcomeText("Mohammed", "Yasin", Gender.Male);
            PrintWelcomeText("Pavithra", "Selvaraj", Gender.Trans);
            PrintWelcomeText("Unknown", "Sample", Gender.Others);
            PrintWelcomeText("", "", (Gender)10);
        }
    }
}
