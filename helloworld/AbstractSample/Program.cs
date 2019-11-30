using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    public class BaseCar
    {
        public void CreateWheel()
        {
            //
        }
        public int CreateBody()
        {
            return 0;
        }
        public virtual void CreateEngine()
        {
            //
        }
        public void Painting()
        {

        }
        public void TestDrive()
        {

        }
        public void Deliver()
        {

        }
    }
    public class DiselCar: BaseCar
    {
        public override void CreateEngine()
        {
            //
        }
      
    }
    public abstract class BaseEmployee
    {
        public string EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeAddress { get; set; }

        public void GetEmployeeDetails(int id)
        {
            // returns employee details
        }

        public abstract double CalculateSalary(int hoursWorked);

    }

    public class FullTimeEmployee : BaseEmployee
    {
        public override double CalculateSalary(int hoursWorked)
        {
            return hoursWorked * 60.00 + 3700;
        }
    }


    public class ContractEmployee : BaseEmployee
    {
        public override double CalculateSalary(int hoursWorked)
        {
            return hoursWorked * 65.00;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiselCar _DiselCar = new DiselCar();
            _DiselCar.CreateBody();
            _DiselCar.CreateEngine();


            BaseEmployee _BaseEmployee = new FullTimeEmployee();
            _BaseEmployee.GetEmployeeDetails(0);
            _BaseEmployee.CalculateSalary(0);
        }
    }
}
