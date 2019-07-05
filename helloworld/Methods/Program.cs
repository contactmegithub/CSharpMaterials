using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
    }
    class Program
    {
        public int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
        #region Recursive Method Call
        /// <summary>
        /// A method can call itself. This is known as recursion. Following is an example that calculates factorial for a given number using a recursive function −
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        #endregion

        #region Passing Parameters by Value

        #endregion

        static void Main(string[] args)
        {
        }
    }
}
