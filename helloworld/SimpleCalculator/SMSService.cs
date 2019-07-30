using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SMSService
    {
        public DataSet GetStudents(string filter)
        {
            DataSet ds = new DataSet();
            string connectionString =
          "Data Source=(local);Initial Catalog=SQLTraining;"
          + "Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter sde = new SqlDataAdapter(filter, connection);
                    sde.Fill(ds);
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
            return ds;
        }
    }
}
