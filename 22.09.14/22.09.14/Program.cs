using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
            //string connectionString1 = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=MagazinBD;Integrated Security = True";
            //SqlConnection conn = null;
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                }

                //conn = new SqlConnection(connectionString);
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
