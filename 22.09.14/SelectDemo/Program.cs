using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._14
{
    class Program
    {
       static string connectionString =
                ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

       static string sql;

       static void Select()
       {
           sql = "select Id , fName , lName , Position , Phone from Workers";
           try
           {


               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   SqlCommand cmd = new SqlCommand(sql, conn);
                   SqlDataReader reader = cmd.ExecuteReader();

                   while (reader.Read())
                   {
                       Console.WriteLine(reader["Id"] + " " + reader["fName"] + " " +
                           reader["lName"] + " "
                           + reader["Position"] + " "
                           + reader["Phone"]);
                   }
               }

           }
           catch (SqlException ex)
           {
               Console.WriteLine(ex.Message);
           }

       }
       static void Update()
       {
           sql = "update Workers set fName='Vasiliy Kozel' where fName='Vasya'";
           try
           {


               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   SqlCommand cmd = new SqlCommand(sql, conn);
                   int row = cmd.ExecuteNonQuery();

                   Console.WriteLine(row + " recs was modified");
               }

           }
           catch (SqlException ex)
           {
               Console.WriteLine(ex.Message);
           }
       }
       static void SelectCount()
       {
           sql = "select count(Id) from Workers";
           try
           {


               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   SqlCommand cmd = new SqlCommand(sql, conn);

                   object obj = cmd.ExecuteScalar();

                   Console.WriteLine("Amount of recound: " + obj);
               }

           }
           catch (SqlException ex)
           {
               Console.WriteLine(ex.Message);
           }
       }
       static void StoredProcRun()
       {
            try
           {


               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   SqlCommand cmd =
                         new SqlCommand("HellUser", conn);
                   cmd.CommandType = CommandType.StoredProcedure;
                   SqlDataReader reader = cmd.ExecuteReader();
                   while (reader.Read())
                   {
                       Console.WriteLine("Res of Stor proc " + reader["Result"]);
                   }
               }

           }
           catch (SqlException ex)
           {
               Console.WriteLine(ex.Message);
           }
           
       }
       static void StoredProcParamRun(int a , int b)
       {
           try
           {


               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   SqlCommand cmd =
                         new SqlCommand("Add", conn);
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.Add(new SqlParameter("@n1" , a));
                   cmd.Parameters.Add(new SqlParameter("@n2", b));
                   SqlParameter outputParam =
                       new SqlParameter("@res", SqlDbType.Int)
                       {
                           Direction = ParameterDirection.Output
                       };
                   cmd.Parameters.Add(outputParam);

                   cmd.ExecuteNonQuery();
                   int? res = (int)outputParam.Value;
                   Console.WriteLine("RES : " + res);

               }

           }
           catch (SqlException ex)
           {
               Console.WriteLine(ex.Message);
           }
       }
        static void Main(string[] args)
        {
            Select();
            Console.WriteLine();
            Update();
            Console.WriteLine();
            Select();
            Console.WriteLine();
            SelectCount();
            Console.WriteLine();
            StoredProcRun();
            Console.WriteLine();
            StoredProcParamRun(2 , 5);
        }
    }
}
