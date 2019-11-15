using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADOApplication
{
    class Program
    {

        public void DataAdapterSample()
        {
            string connectionString =
           "Data Source=(local);Initial Catalog=SQLTraining;"
           + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "select * from Student;";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataAdapter sde = new SqlDataAdapter("Select top 10 * from student", connection);

                    DataSet ds = new DataSet();

                    sde.Fill(ds);
                    var result = ds.GetXml();
                    var res = ds.GetXmlSchema();

                    //GridView1.DataSource = ds;

                    //GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DataAdapterSample();
            string connectionString =
            "Data Source=(local);Initial Catalog=SQLTraining;"
            + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "select * from Student;";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("id:{0}\tfirst_name:{1}\tlast_name:{2}\temail{3}\tgender{4}\tstreet{5}\tCity{6}\tState{7}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                        Thread.Sleep(1000);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
