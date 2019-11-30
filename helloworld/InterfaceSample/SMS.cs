using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{

    public class A
    {
        public void doA()
        {

        }
    }
    public class B : A
    {
        public void doB()
        {

        }
    }
    public class StudentManagment
    {
        private readonly IDBManager _dBManager;
        public StudentManagment(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }
        public void SaveStudent()
        {
            _dBManager.Save();
        }
    }
    public interface IDBManager
    {
        void Save();
    }

    public class CosmosDB : IDBManager
    {
        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class MongoDB : IDBManager
    {
        public void Save()
        {
            // do something to save
        }
    }
    public class SQLDB : IDBManager
    {
        public void Save()
        {
            // do something to save
        }
    }
    public class AllDB : IDBManager
    {
        public void Save()
        {
            IDBManager dBManager1 = new MongoDB();
            dBManager1.Save();
        }
    }
    public class OracleDB : IDBManager
    {
        public void Save()
        {
            // do something to save
        }
        static void Main(string[] args)
        {
            InterfaceSample2.Client client = new InterfaceSample2.Client();
            client.DoSomething();
            return;
            IDBManager dBManager = new CosmosDB();
            StudentManagment studentManagment = new StudentManagment(dBManager);
            studentManagment.SaveStudent();

            //B _B = new B();
            //_B.doA();
            //_B.doB();

        }
    }

}
