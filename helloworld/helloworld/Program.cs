using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Program
    {
        public string ConcatName(string FristName, string LastName)
        {
            return $"{FristName} {LastName}";
        }
        public int diagonalDifference(List<List<int>> arr2)
        {
            List<List<int>> arr = new List<List<int>>() { new List<int> {11,2,4 },
            new List<int> {4,5,6 },
            new List<int> { 10,8,-12}};
            int result = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                result += arr[i].ElementAt(i);
            }
            for (int i = 0; i < arr.Count(); i++)
            {
                result -= arr[i].ElementAt(arr[i].Count() - 1 - i);
            }
            if (result < 0)
                result = result * -1;
            return result;
        }
        void PrintMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        int CalculateAge(DateTime DOB)
        {
            var result = (int)DateTime.Now.Subtract(DOB).TotalDays / 365;
            return result;
        }

        internal void CalculateMyAgeAndPrint()
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
            dotNetDemo.diagonalDifference(null);
            dotNetDemo.CalculateMyAgeAndPrint();
        }
    }
}
