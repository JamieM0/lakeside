using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside.DAL
{
    public class PodDAL : DAL
    {
        public bool AddNewPod(Pod p)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Pod VALUES('{p.FriendlyName}','{p.Description}','{p.Type}','{p.Capacity}','{p.Location}','{p.Price}')");

            return ExecuteNonQuery(command);
        }

        public int CountPods(string type)
        {
            //Set SQL query command text to valid insert statement using values from the Guest class.
            string query = ($"SELECT COUNT(*) FROM Pod WHERE Type = '{type}'");

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", type);
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
