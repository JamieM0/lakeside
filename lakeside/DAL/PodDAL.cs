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
        
        public Pod[] SearchPods(string search)
        {
            Pod[] allPods = new Pod[100];
            Pod[] pods;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Pod WHERE name LIKE '%{search}%' OR location LIKE '%{search}%' OR pod_id LIKE '{search}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allPods[i] = new Pod(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), Double.Parse($"{reader[6]}"), Convert.ToInt32($"{reader[4]}"), String.Format($"{reader[3]}"), String.Format($"{reader[5]}"), int.Parse(String.Format($"{reader[0]}")));
                            i++;
                        }

                        //Check for duplicates in allGuests
                        allPods = allPods.Distinct().ToArray();

                        pods = new Pod[i];
                        for (int l = 0; l < pods.Length; l++)
                        {
                            pods[l] = allPods[l];
                        }
                    }
                }
            }

            return pods;
        }

        public bool UpdatePod(Pod p)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Pod SET name = '{p.FriendlyName}', description = '{p.Description}', type = '{p.Type}', capacity = '{p.Capacity}', location = '{p.Location}', pricePPPN = '{p.Price}' WHERE pod_id = {p.PodID}");

            return ExecuteNonQuery(command);
        }

        public Pod PodLookup(int id)
        {
            Pod result = new Pod();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Pod WHERE pod_id = {id}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Pod(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), Double.Parse($"{reader[6]}"), Convert.ToInt32($"{reader[4]}"), String.Format($"{reader[3]}"), String.Format($"{reader[5]}"), int.Parse(String.Format($"{reader[0]}")));
                        }
                    }
                }
            }

            return result;
        }
    }
}
