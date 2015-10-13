using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list.codes
{
    class DBDepository : IDepository
    {
        static string connectionString =
               ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

        static string sql;
        public List<Worker> GetWorkers()
        {
            List<Worker> res = new List<Worker>();
            sql = "select Id ,  fName , lName , Position , Phone from Workers";
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Worker tmp = new Worker();
                        tmp.Id = Convert.ToInt32(reader["Id"]);
                        tmp.fName = reader["fName"].ToString();
                        tmp.lName = reader["lName"].ToString();
                        tmp.Position = reader["Position"].ToString();
                        tmp.Phone = reader["Phone"].ToString();

                        res.Add(tmp);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }


        public Worker GetWorkerById(int id)
        {
            sql = "select Id , fName , lName , Position , Phone from Workers where id = " + id;
            Worker res = new Worker();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    
                   
                   res.Id = Convert.ToInt32(reader["Id"]);
                   res.fName = reader["fName"].ToString();
                   res.lName = reader["lName"].ToString();
                   res.Position = reader["Position"].ToString();
                   res.Phone = reader["Phone"].ToString();

                       
                    
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }





        public void AddWorker(Worker w)
        {
            sql = "insert into Workers values ('" + w.fName + "', '" + w.lName + "', '" + w.Position + "', '" + w.Phone + "');";
        
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DeleteWorker(int id)
        {
            sql = "delete from Workers where id = " + id;
           
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void UpdateWorker(int id, Worker w)
        {
            sql = "update Workers set fName = '" + w.fName + "', lName = '" + w.lName + "', Position = '" + w.Position + "', Phone = '" + w.Phone + "' where id =" + id;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
