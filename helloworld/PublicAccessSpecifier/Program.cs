using System;
using System.Data.SqlClient;

namespace RectangleApplication
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
    public class CreateUserV1
    {
        public void GetUserInformation(string firstName, string lastName )
        {

        }
        public bool ValidateOtherUserInformation()
        {
            return true;
        }
        public bool ValidatePassword()
        {
            return true;
        }
        public bool ValidateUserName()
        {
            return true;
        }

        public SqlConnection OpenDBConnection()
        {
            return new SqlConnection();
        }
        public bool StoreToDB(SqlConnection _SqlConnection, UserInfo _UserInfo)
        {
            return true;
        }
        public bool CloseDBConnection()
        {
            return true;
        }
        public void SendNotificationToUser()
        {

        }
    }
    public class CreateUserV2
    {
        private void GetUserInformation(string firstName, string lastName )
        {

        }
        public bool RegisterUser(UserInfo _UserInfo)
        {
            bool result = false;
            result = ValidateOtherUserInformation();
            if(result==false)
            {
                Console.WriteLine("ValidateOtherUserInformation validation failed");
                return false;
            }
            result = ValidatePassword();
            if (result == false)
            {
                Console.WriteLine("ValidateOtherUserInformation validation failed");
                return false;
            }
            result = ValidateUserName();
            if (result == false)
            {
                Console.WriteLine("ValidateOtherUserInformation validation failed");
                return false;
            }
            var connection = OpenDBConnection();
            StoreToDB(connection, _UserInfo);
            result = CloseDBConnection();
            if (result == false)
            {
                Console.WriteLine("ValidateOtherUserInformation validation failed");
                return false;
            }
            SendNotificationToUser();
            return result;
        }
        private bool ValidateOtherUserInformation()
        {
            return true;
        }
        private bool ValidatePassword()
        {
            return true;
        }
        private bool ValidateUserName()
        {
            return true;
        }

        private SqlConnection OpenDBConnection()
        {
            return new SqlConnection();
        }
        private bool StoreToDB(SqlConnection _SqlConnection, UserInfo _UserInfo)
        {
            return true;
        }
        private bool CloseDBConnection()
        {
            return true;
        }
        private void SendNotificationToUser()
        {

        }
    }

    public class Client
    {
        public void Registration(UserInfo _UserInfo)
        {
            CreateUserV2 _CreateUser = new CreateUserV2();

            _CreateUser.RegisterUser(_UserInfo);

        }
    }























    class Rectangle
    {
        //member variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}