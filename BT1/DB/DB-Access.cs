using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.DB
{
    public class DB_Access
    {
        private static DB_Access instance;
        public static DB_Access Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB_Access();
                }
                return instance;
            }
        }
        public DB_Access() { }
        public static SqlConnection Connect()
        {
            string connect = @"Data Source=LAPTOP-VC1H556C\MSSQLSERVER01;Initial Catalog=BT1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect); 
            return con;
        }
        public int ExecuteQuery(string query)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery(); 
                con.Close();
                return result;
            }
        }
        public object ExecuteScalar(string query)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar(); 
                con.Close();
                return result;
            }
        }


        public int InsertData(string query)
        {
            try
            {
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; 
            }
        }

        
        public int DeleteData(string query)
        {
            try
            {
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; 
            }
        }
    }
}
