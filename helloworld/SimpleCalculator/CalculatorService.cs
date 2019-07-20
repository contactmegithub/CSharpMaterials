using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class CalculatorService
    {
        public static string FirstNumber { get; set; }
        public static string SecondNumber { get; set; }
        public static string Operator { get; set; }
        public static string ErrorMessage { get; set; }


        private static bool Validate()
        {
            string[] AvailableOperators = new string[] { "A", "M", "S", "D" };
            if (string.IsNullOrEmpty(FirstNumber))
            {
                ErrorMessage = "First number is empty";
                return false;
            }
            else if (string.IsNullOrEmpty(SecondNumber))
            {
                ErrorMessage = "Second number is empty";
                return false;
            }
            else if (!int.TryParse(FirstNumber, out _))
            {
                ErrorMessage = "First Number - Invalid number format";
                return false;
            }
            else if (!int.TryParse(SecondNumber, out _))
            {
                ErrorMessage = "Second Number - Invalid number format";
                return false;
            }
            else if (!AvailableOperators.Contains(Operator))
            {
                ErrorMessage = "Invalid Operation";
                return false;
            }
            return true;
        }

        private static int Operation(string Operator, int firstNumber, int secondNumber)
        {
            switch (Operator)
            {
                case "A":
                    return firstNumber + secondNumber;
                case "M":
                    return firstNumber * secondNumber;
                case "S":
                    return firstNumber - secondNumber;
                case "D":
                    return firstNumber / secondNumber;
                default:
                    return 0;
            }
        }



        public static int Calculate()
        {
            if (!Validate())
                return 0;
            else
                return Operation(Operator, Convert.ToInt32(FirstNumber), Convert.ToInt32(SecondNumber));
        }
    }
}
