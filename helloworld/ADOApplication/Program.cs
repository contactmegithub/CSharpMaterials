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
            string gender = "Male' or 1 = 1 or ''='";
            //string gender = "Male";
            string connectionString =
             @"Data Source=MOHAMMED\MSSQLSERVER01;Initial Catalog=Retail;"
             + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "select * from Customer";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                //sqlCommand.Parameters.AddWithValue("@gender", gender);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataAdapter sde = new SqlDataAdapter(sqlCommand);

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

            string gender = "Male";
            string connectionString =
            @"Data Source=MOHAMMED\MSSQLSERVER01;Initial Catalog=Retail;"
            + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "select * from Customer where gender = '" + gender + "'";
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
                        Console.WriteLine("id:{0}\tfirst_name:{1}\tlast_name:{2}\temail{3}\tgender{4}\tcontact{5}",
                            reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                }
                Console.ReadLine();
            }
        }
    }
}
