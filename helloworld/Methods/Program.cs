using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Car : interfaceName, interfaceName2
    {
        public void Body()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            // Some  company secreat
        }

        public void Engine()
        {
            throw new NotImplementedException();
        }

        public void Fittings()
        {
            throw new NotImplementedException();
        }

        public void someadditional()
        {
            throw new NotImplementedException();
        }

        public void TestDrive()
        {
            throw new NotImplementedException();
        }

        void interfaceName2.someadditional()
        {
            throw new NotImplementedException();
        }

        void interfaceName.wheel()
        {
            throw new NotImplementedException();
        }

        void interfaceName2.wheel()
        {
            throw new NotImplementedException();
        }
    }
    public class CarV2 : interfaceName
    {
        public void Body()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Engine()
        {
            throw new NotImplementedException();
        }

        public void Fittings()
        {
            throw new NotImplementedException();
        }

        public void TestDrive()
        {
            throw new NotImplementedException();
        }

        public void wheel()
        {
            throw new NotImplementedException();
        }
    }
    public interface interfaceName
    {
        void wheel();
        void Engine();
        void Body();
        void Fittings();
        void TestDrive();
        void Deliver();
    }
    public interface interfaceName2
    {
        void someadditional();
        void wheel();
    }


    public class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    public class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }
    public class goldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
    public class DimondCustomer : goldCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
    public class PlatinumCustomer : DimondCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
    public class GetClientDiscount
    {
        public void GetDiscount()
        {
            interfaceName interfaceName = new Car();
            interfaceName.Deliver();

            Car car = new Car();
            car.Deliver();

            Customer customer = new PlatinumCustomer();
            var result = customer.getDiscount(1000);
        }
    }



















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

        public int Add(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        public int Add(int n1, int n2, int n3)
        {
            var result = n1 + n2 + n3;
            return result;
        }

        public int Add(int n1, int n2, int n3, int n4)
        {
            return 0;
        }
        public int Add(int n1, int n2, int n3, int n4, int n5)
        {
            return 0;
        }
        public int Add(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            return 0;
        }
        public int Add(int n1, int n2, int n3, int n4, int n5, int n6, int n7)
        {
            return 0;
        }


        public void database(string fname, string lname)
        {
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
            GetClientDiscount getClientDiscount = new GetClientDiscount();
            getClientDiscount.GetDiscount();


        }
    }
}
