using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BT1.DB
{
    public class Animal_Access
    {
        private Animal_Access() { }
        private static Animal_Access instance;
        public static Animal_Access Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Animal_Access();
                }
                return instance;
            }

        }
        public int CountMilkCow()
        {

            string query = "SELECT Milk FROM Animal WHERE Name = 'Cow'";

            object result = DB_Access.Instance.ExecuteScalar(query);

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        public int CountMilkSheep()
        {
            string query = "SELECT Milk FROM Animal WHERE Name = 'Sheep'";

            object result = DB_Access.Instance.ExecuteScalar(query);

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0; 
        }

        public int CountMilkGoat()
        {
            string query = "SELECT Milk FROM Animal WHERE Name = 'Goat'";

            object result = DB_Access.Instance.ExecuteScalar(query);

           
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0; 
        }
        public void Reset()
        {
            string query = " DELETE FROM Animal";
            DB_Access.Instance.DeleteData(query);
        }
        public int CountChildCow()
        {
            string query = "SELECT Child FROM Animal WHERE Name = 'Cow'";
            object result = DB_Access.Instance.ExecuteScalar(query);

            
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0; 
        }
        public int CountChildSheep()
        {
            string query = "SELECT Child FROM Animal WHERE Name = 'Sheep'";
            object result = DB_Access.Instance.ExecuteScalar(query);

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0; 
        }
        public int CountChildGoat()
        {
            string query = "SELECT Child FROM Animal WHERE Name = 'Goat'";
            object result = DB_Access.Instance.ExecuteScalar(query);

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }
        public void Insert(int num, int child, int milk, string name)
        {
            string query = "INSERT INTO Animal (Number, Child, Milk, Name) VALUES (@Number, @Child, @Milk, @Name)";

            using (SqlConnection connection = DB_Access.Connect())
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Number", num);
                command.Parameters.AddWithValue("@Child", child);
                command.Parameters.AddWithValue("@Milk", milk);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
