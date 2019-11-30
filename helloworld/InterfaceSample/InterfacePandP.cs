using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample2
{
    //class Customer
    //{
    //    private int _CustType;

    //    public int CustType
    //    {
    //        get { return _CustType; }
    //        set { _CustType = value; }
    //    }

    //    public double getDiscount(double TotalSales)
    //    {
    //        if (_CustType == 1)
    //        {
    //            return TotalSales - 100;
    //        }
    //        else
    //        {
    //            return TotalSales - 50;
    //        }
    //    }
    //}


    class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
    
    class GoldCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
    class DimondCustomer : GoldCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }






































    public interface ISMS
    {
        void StoreInformation();
    }
    public class StudentManagment : ISMS
    {
        private readonly IDBManager _dBManager;
        public StudentManagment(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }
        public void StoreInformation()
        {
            _dBManager.Insert();
        }
    }

    public interface IDBManager
    {
        void Insert();
    }
    public class SQLDB : IDBManager
    {
        public void Insert()
        {
            Console.WriteLine("Stored into SQL");
            Console.ReadLine();
        }
    }

    public class OracleDB : IDBManager
    {
        public void Insert()
        {
            //open connection
            //
            Console.WriteLine("Stored into OracleDB");
            Console.ReadLine();
        }
    }
    public class Cosmos : IDBManager
    {
        public void Insert()
        {
            //open connection
            //
            Console.WriteLine("Stored into Cosmos");
            Console.ReadLine();
        }
    }









    public class Client
    {
        public void DoSomething()
        {
            IDBManager dBManager = new Cosmos();
            ISMS sMS = new StudentManagment(dBManager);
            sMS.StoreInformation();
        }
    }




}
