using System;

namespace IfElseStatment
{

    public class nullabletest
    {
        public int? somevalue { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            nullabletest _nullabletest = new nullabletest();
            var result545 = _nullabletest.somevalue ?? 200;
            var result45 = _nullabletest?.somevalue.ToString();
            int? someValu = null;




            /* local variable definition */
            int a = 100;
            int b = 100;

            string result3 = a > 100 ? "Yes it is greaterthan 100" : "No it is not greaterthan 100";
            int Age = 50;
            int salary = 2000;
            if (!false)
            {
               // string result3 = a > 100 ? "Yes it is greaterthan 100" : "No it is not greaterthan 100";
            }
            //Age < 60   = ture
            
            
            //salary >= 2000 == true
            // b > a == false
            //              True
            if(Age < 60)
            {
                if(salary >= 2000 || b > a)
                {
                    if(true)
                    {

                    }
                }
            }

            if (Age < 60 && (salary >= 2000 || b > a))
            {
                // Loan sanctioned
            }
            string result = a > 100 ? "Yes it is greaterthan 100" : "No it is not greaterthan 100";


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
    }
}
