using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class StudentManagment
    {

        public bool CheckUserNameExist()
        {
            //
            return true;
        }

        public bool InputValidation()
        {
            //
            return true;
        }

        public void OpenConnection()
        {

        }

        public int Store()
        {
            return 0;
        }

        public void CloseConnection()
        {

        }
    }

    public class StudentManagmentV2
    {
        public void Register()
        {
            CheckUserNameExist();
            InputValidation();
            OpenConnection();
            Store();
            CloseConnection();
        }
        private bool CheckUserNameExist()
        {
            //
            return true;
        }

        private bool InputValidation()
        {
            //
            return true;
        }

        private void OpenConnection()
        {

        }

        private int Store()
        {
            return 0;
        }

        private  void CloseConnection()
        {

        }
    }


    public class Client
    {

        public void Registration()
        {
            StudentManagmentV2 _StudentManagment = new StudentManagmentV2();
            _StudentManagment.Register();
        }


    }


























    class AccessModifiersSample
    {
    }
}
