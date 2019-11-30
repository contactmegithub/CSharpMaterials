using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ThrowSample
    {
        public void M1()
        {
            try
            {
                M2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void M2()
        {
            try
            {
                M3();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void M3()
        {
            try
            {
                test("rtggsgs");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void test(string gender)
        {
            if (!gender.Equals("Male") || !gender.Equals("Female"))
            {
                //log into file "applicationLogs.txt"
                throw new ArgumentException("Gender not matched with valid data");
            }
        }
        static void Main(string[] args)
        {
            ThrowSample _ThrowSample = new ThrowSample();
            try
            {

                _ThrowSample.M1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
