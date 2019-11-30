using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subtraction;


namespace Calculator
{
    public class DBMS
    {
        public void Select()
        {

        }
        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }


    public class ArithmeticOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        private int AddV2(int a, int b, int c)
        {
            return a + b + c;
        }
        protected int AddV3(int a, int b, int c)
        {
            return a + b + c;
        }

        public void test()
        {
            AddV2(0, 0, 0);
            AddV3(0, 0, 0);
        }

    }

    public class Client : DBMS
    {
        public void doSomeOperation()
        {
         
        }
    }





    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the passage");
            var input = Console.ReadLine();

            var result = input.GroupBy(g => g).Select(val => new {
                letter = val.Key,
                count = val.Count()
            });

            foreach (var item in result)
            {
                Console.WriteLine("letter {0} repeats '{1}' times", item.letter, item.count);
            }

            Console.ReadLine();
        }
    }
}
