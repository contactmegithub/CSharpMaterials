using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Program
    {
        void PrintMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        int CalculateAge(DateTime DOB)
        {
            var result = (int)DateTime.Now.Subtract(DOB).TotalDays / 365;
            return result;
        }

        public void CalculateMyAgeAndPrint()
        {
            Console.WriteLine("Please enter you date of birth in the below format \n ddMMyyyy");
            var result = Console.ReadLine();
            DateTime DateOfBirth = DateTime.ParseExact(result, "ddMMyyyy", null);

            int Age = CalculateAge(DateOfBirth);

            string OutputMessage = $"Your Age is {Age}";

            PrintMessage(OutputMessage);

        }

        public static void Main(string[] args)
        {
            Program dotNetDemo = new Program();

            dotNetDemo.CalculateMyAgeAndPrint();
        }
    }
}
