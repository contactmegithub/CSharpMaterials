using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{

    public abstract class MyFirstAbstraceClass
    {
        public int GetFullTimeEmployeeSalary(int hour)
        {
            int salary = hour * 1000;
            return salary;
        }
        public abstract int GetPartTimeSalary(int hours);
        public abstract int GetContractTimeSalary(int hours);
    }

    public class EmployeeManagment : MyFirstAbstraceClass
    {
        public override int GetContractTimeSalary(int hours)
        {
            int salary = base.GetFullTimeEmployeeSalary(hours) + 50;
            return salary;
        }

        public override int GetPartTimeSalary(int hours)
        {
            int salary = hours * 600;
            return salary;
        }
    }







    public interface InterfaceSample
    {
        void doStep1();
        void doStep2();
        void doStep3();
        void doStep4();
        void doStep5();
        void doStep6();
    }


    public class InterfaceClass : InterfaceSample
    {
        public void doStep1()
        {
            throw new NotImplementedException();
        }

        public void doStep2()
        {
            throw new NotImplementedException();
        }

        public void doStep3()
        {
            throw new NotImplementedException();
        }

        public void doStep4()
        {
            throw new NotImplementedException();
        }

        public void doStep5()
        {
            throw new NotImplementedException();
        }

        public void doStep6()
        {
            throw new NotImplementedException();
        }
    }




    public class Automobile
    {
        protected void GetEngine()
        {

        }
        protected void GetWheel()
        {

        }
        protected void Assembly()
        {

        }
        public void GetRicshaw()
        {
            GetEngine();
            GetEngine();
            Assembly();
        }
    }
    public class Car : Automobile
    {
       
        public void GetCar()
        {
            GetEngine();
            GetEngine();
            Assembly();
        }
    }
    public class Client
    {
        public void DispatchVechicle()
        {
            Automobile automobile = new Automobile();
        }
    }



















    public interface IFirstInterface
    {
        int Add(int a, int b);
        int Add(int a, int b, int c);
        int Add(int a, int b, int c, int d);
        int Add(int a, int b, int c, int d, int e);
        int Add(int a, int b, int c, int d, int e, int f);
        int Add(params int[] a);
    }
    public interface ISubtraction
    {
        int Sub(int a, int b);
        int Sub(int a, int b, int c);
        int Sub(int a, int b, int c, int d);
        int Sub(int a, int b, int c, int d, int e);
        int Sub(int a, int b, int c, int d, int e, int f);
        int Sub(params int[] a);
    }

    public class AdditionService : IFirstInterface, ISubtraction
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public int Add(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }

        public int Add(int a, int b, int c, int d, int e, int f)
        {
            return a + b + c + d + e + f;
        }

        public int Add(params int[] a)
        {
            return a.Sum();
        }

        public int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b, int c, int d, int e)
        {
            throw new NotImplementedException();
        }

        public int Sub(int a, int b, int c, int d, int e, int f)
        {
            throw new NotImplementedException();
        }

        public int Sub(params int[] a)
        {
            throw new NotImplementedException();
        }
    }



    class Program
    {
        static void Main2(string[] args)
        {
            IFirstInterface _IFirstInterface = new AdditionService();

            var result1 = _IFirstInterface.Add(1, 2);
            var result2 = _IFirstInterface.Add(1, 2, 3);
            var result3 = _IFirstInterface.Add(1, 2, 3, 4);
            var result4 = _IFirstInterface.Add(1, 2, 3, 4, 5);
            var result5 = _IFirstInterface.Add(1, 2, 3, 4, 5, 6);
            var result6 = _IFirstInterface.Add(1, 2, 3, 4, 5, 6, 7);

            Console.ReadLine();
        }
    }
}
