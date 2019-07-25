using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionTest
    {
        public void DoStep1()
        {

        }
        public void DoStep2()
        {
            // Thre is some issue please try after some time.
        }
        public void DoStep3()
        {
            // Thre is some issue please try after some time.
        }
        public void DoStep4()
        {

        }

        public void DoAllSteps()
        {
            DoStep1();
            DoStep2();
            DoStep3();
            DoStep4();
        }
        public void EditPost()
        {
            DoStep1();
            DoStep2();
            DoStep3();
        }
        public void PostUpdates()
        {
            try
            {
                DoAllSteps();
            }
            catch (Exception ex)
            {
                // Thre is some issue please try after some time.
            }
        }
    }
    class Program
    {
        public static void Test()
        {
            try
            {
                //open dbconnection
                // save data
                //close dbconnection
            }
            catch (Exception ex)
            {
          //
            }
            finally
            {
                // close connection
            }
        }
        public static int Divide(int a, int b)
        {
            try
            {
                Test();
                   var reslut = a / b;
                return reslut;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
           
        }
        public static bool ConvertToInt(string input, ref int resultNumber)
        {
            // resultNumber = 0;ertgerwtgre
            try
            {
                resultNumber += Convert.ToInt32(input);
                return true;
            }
            catch(TimeoutException ex)
            {
                return false;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch(FormatException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void Main(string[] args)
        {
            int i = 5;
            while (i <= 5)
            {
                int firstNumber = 10, secondNumber = 20;
                bool isInCorrectFormat = false;

                Console.Clear();

                while (!isInCorrectFormat)
                {
                    Console.WriteLine("Enter the first number");
                    isInCorrectFormat = ConvertToInt(Console.ReadLine(), ref firstNumber);
                }
                isInCorrectFormat = false;
                while (!isInCorrectFormat)
                {
                    Console.WriteLine("Enter the second number");
                    isInCorrectFormat = ConvertToInt(Console.ReadLine(), ref secondNumber);
                }

                var result = Divide(firstNumber, secondNumber);

                Console.WriteLine("Divide Result = {0}", result);

                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
        }
    }
}
