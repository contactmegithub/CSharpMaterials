using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subtraction;


namespace Calculator
{
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

    public class Client : Subraction
    {
        public void doSomeOperation()
        {
            base.Subrtact(0, 0);
        }
    }





    public class Program
    {
        static void Main(string[] args)
        {
            Subraction _Subraction = new Subraction();
            //_Subraction.Subrtact(0,0);
        }
    }
}
