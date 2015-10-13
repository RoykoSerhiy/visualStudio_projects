using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static string connectionString =
                ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

       

        static decimal? StoredProcParamRun(decimal a, decimal b , char act)
        {
            decimal? res = null;
            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd =
                          new SqlCommand("Calc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@n1", a));
                    cmd.Parameters.Add(new SqlParameter("@n2", b));
                    cmd.Parameters.Add(new SqlParameter("@action", act));
                    SqlParameter outputParam =
                        new SqlParameter("@res", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output
                        };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();
                    res = (decimal?)outputParam.Value;
                    
                   
                    Console.WriteLine(a +" "+act+ " " + b + " = "+ res);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return res;
        }
        static void Main(string[] args)
        {
            StoredProcParamRun((decimal)22.1, (decimal)55.5, '+');
        }
    }
}
