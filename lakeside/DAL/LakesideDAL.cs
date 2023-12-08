using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lakeside.DAL
{
    public class LakesideDAL : DAL
    {
        public int AddNewGuest(Guest g)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Guest VALUES('{g.Forename}','{g.Surname}','{g.Email}','{g.Number}','{g.Street}','{g.CityTown}','{g.Postcode}','{g.Country}')");

            object obj = ExecuteScalar($"INSERT INTO Guest VALUES('{g.Forename}','{g.Surname}','{g.Email}','{g.Number}','{g.Street}','{g.CityTown}','{g.Postcode}','{g.Country}')");
            return Convert.ToInt32(obj);
        }

        public Guest[] SearchGuests(string search)
        {
            Guest[] allGuests = new Guest[50];
            Guest[] guests;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Guest WHERE Forename LIKE '{search}%' OR Surname LIKE '{search}%' OR Email LIKE '%{search}%' OR guest_id LIKE '{search}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allGuests[i] = new Guest(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), int.Parse(String.Format($"{reader[0]}")));
                            i++;
                        }

                        //Check for duplicates in allGuests
                        allGuests = allGuests.Distinct().ToArray();

                        guests = new Guest[i];
                        for (int l = 0; l < guests.Length; l++)
                        {
                            guests[l] = allGuests[l];
                        }
                    }
                }
            }

            return guests;
        }

        public Guest GuestLookup(int id)
        {
            Guest result=new Guest();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Guest WHERE guest_id = {id}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            result = new Guest(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), id);
                        }
                    }
                }
            }

            return result;
        }

        public bool UpdateGuest(Guest g)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Guest SET forename = '{g.Forename}', surname = '{g.Surname}', email = '{g.Email}', mobilePhone = '{g.Number}', streetname = '{g.Street}', townname = '{g.CityTown}', postcode = '{g.Postcode}', country = '{g.Country}' WHERE guest_id = {g.GuestID}");

            return ExecuteNonQuery(command);
        }
    }
}
