using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lakeside
{
    public class LakesideDAL : DAL
    {
        public bool AddNewGuest(Guest g)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Guest VALUES('{g.Forename}','{g.Surname}','{g.Email}','{g.Number}','{g.Street}','{g.CityTown}','{g.Postcode}','{g.Country}')");

            return ExecuteNonQuery(command);
        }
        
        public Guest[] SearchGuests(string search)
        {
            Guest[] guests;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Guest WHERE Forename LIKE '%{search}%' OR Surname LIKE '%{search}%' OR Email LIKE '%{search}%' OR guest_id LIKE '%{search}%'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        int l = 0;
                        guests = new Guest[];
                        while (reader.Read())
                        {
                            guests[i] = new Guest(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"));
                            i++;
                        }
                    }
                }
            }

            return guests;
        }
    }
}
