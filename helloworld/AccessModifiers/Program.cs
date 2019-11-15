using DecisionMaking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Payment
    {
        public void MakePayment()
        {

        }
    }


    public class Electronics: Payment
    {
        public void Sell()
        {
            MakePayment();
        }
    }
    public class Vegitables: Payment
    {
        public void Sell()
        {
            MakePayment();
        }
    }
    public class Cloths: Payment
    {
        public void Sell()
        {
            MakePayment();
        }
    }
    public class Wood: Payment
    {
        public void Sell()
        {
            MakePayment();
        }
    }




    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    }
    public class DBManagment
    {
        public int Store()
        {
            OpenDBConnection();
            StoreDataIntoDB();
            CloseConnection();
            return 0;
        }
        private void OpenDBConnection()
        {
            // create DB Connection
        }

        private int StoreDataIntoDB()
        {
            // store to DB

            return 0;
        }

        protected void CloseConnection()
        {
            // store to DB
        }
    }

    public class UserManagment : DBManagment
    {

        public string Save(User user)
        {
            if (!IsValid(user))
                return "User Information invalid";

            if (!CheckUserName(user.UserName))
                return "User name already exist";
            CloseConnection();
            var result =  Store();
            if (result == 0)
                return "Server Error. Please try after some time";
            else
                return "User Created Successfully";
        }
        private bool IsValid(User user)
        {
            // Validate information logic
            return true;
        }
        private bool CheckUserName(string userName)
        {
            // Validate user name
            return true;
        }
       

    }


    public class Exce005
    {
        public void AreaOfCircle(float r)
        {
            float a = (float)3.14 * r;
            // here we have used funtion overload with 1 parameter.  
            Console.WriteLine("Area of a circle: {0}", a);
        }
        public void AreaOfSquare(float l, float b)
        {
            float x = (float)l * b;
            // here we have used funtion overload with 2 parameters.  
            Console.WriteLine("Area of a rectangle: {0}", x);
        }
        public void AreaTriangle(float a, float b, float c)
        {
            float s = (float)(a * b * c) / 2;
            // here we have used funtion overload with 3 parameters.  
            Console.WriteLine("Area of a circle: {0}", s);
        }
    }

    public class client
    {
        public void doSomeOperation()
        {
            Exce005 exce005 = new Exce005();

            exce005.AreaOfSquare(0, 0);


            Polymorphism polymorphism = new Polymorphism();
            polymorphism.Area(0, 0, 0);

        }
    }













    public class Polymorphism
    {
        public void Area(float r)
        {
            float a = (float)3.14 * r;
            // here we have used funtion overload with 1 parameter.  
            Console.WriteLine("Area of a circle: {0}", a);
        }
        public void Area(float l, float b)
        {
            float x = (float)l * b;
            // here we have used funtion overload with 2 parameters.  
            Console.WriteLine("Area of a rectangle: {0}", x);
        }
        public void Area(float a, float b, float c)
        {
            float s = (float)(a * b * c) / 2;
            // here we have used funtion overload with 3 parameters.  
            Console.WriteLine("Area of a circle: {0}", s);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {



            MainClass _MainClass = new MainClass();

            _MainClass.GetMax(5,2);







            User _User = new User();
            UserManagment userManagment = new UserManagment();
            var reslut = userManagment.Save(_User);

            Polymorphism ob = new Polymorphism();

            ob.Area(2.0f);
            ob.Area(20.0f, 30.0f);
            ob.Area(2.0f, 3.0f, 4.0f);

            Console.ReadLine();
            Console.WriteLine("dfsdf");
        }
    }
}
