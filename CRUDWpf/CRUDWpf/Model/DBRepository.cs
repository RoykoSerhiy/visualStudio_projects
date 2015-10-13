using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWpf.Model
{
    class DBRepository : IRepository
    {
        static string connectionString =
             ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

        static string sql;

        private List<Worker> _workers = new List<Worker>();
       // private int _nextId = 1;

        public DBRepository()
        {
            _workers = GetAll().ToList();
        }
       
        public IEnumerable<Worker> GetAll()
        {
            List<Worker> res = new List<Worker>();
            sql = "select Id ,  fName , lName , Position , Phone from Workers";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Worker tmp = new Worker();
                        tmp.Id = Convert.ToInt32(reader["Id"]);
                        tmp.FirstName = reader["fName"].ToString();
                        tmp.LastName = reader["lName"].ToString();
                        tmp.Position = reader["Position"].ToString();
                        tmp.Phone = reader["Phone"].ToString();

                        res.Add(tmp);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return res;
        }

        public Worker Get(int id)
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
                    res.FirstName = reader["fName"].ToString();
                    res.LastName = reader["lName"].ToString();
                    res.Position = reader["Position"].ToString();
                    res.Phone = reader["Phone"].ToString();



                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return res;
        }

        public Worker Add(Worker w)
        {
            sql = "insert into Workers values ('" + w.FirstName + "', '" + w.LastName + "', '" + w.Position + "', '" + w.Phone + "');";

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
                throw ex;
            }
            return w;
        }

        public void Remove(int id)
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
                throw ex;
            }
        }

        public bool Update(Worker w)
        {

            //int ID = _workers.FindIndex(wr => w.Id == w.Id);
            sql = "update Workers set fName = '" + w.FirstName + "', lName = '" + w.LastName + "', Position = '" + w.Position + "', Phone = '" + w.Phone + "' where id =" + w.Id;

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
                throw ex;
            }
            return true;
        }
    }
}
