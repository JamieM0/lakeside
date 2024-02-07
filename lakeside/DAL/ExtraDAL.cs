using lakeside.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lakeside.DAL;

namespace lakeside.DAL
{
    public class ExtraDAL : DAL
    {
        public bool AddNewExtra(Extra e)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Extra VALUES('{e.ExtraName}','{e.Description}','{e.Price}')");

            return ExecuteNonQuery(command);
        }

        public Extra[] SearchExtras(string search)
        {
            Extra[] allExtras = new Extra[100];
            Extra[] extras;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Extra WHERE extraName LIKE '%{search}%' OR extra_id LIKE '{search}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allExtras[i] = new Extra(int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), double.Parse(String.Format($"{reader[3]}")));
                            i++;
                        }

                        //Check for duplicates in allGuests
                        allExtras = allExtras.Distinct().ToArray();

                        extras = new Extra[i];
                        for (int l = 0; l < extras.Length; l++)
                        {
                            extras[l] = allExtras[l];
                        }
                    }
                }
            }

            return extras;
        }

        public bool UpdateExtra(Extra e)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Extra SET extraName = '{e.ExtraName}', extraDescription = '{e.Description}', extraCost = '{e.Price}' WHERE extra_id = {e.ExtraID}");

            return ExecuteNonQuery(command);
        }

        //Maybe use a normal datagrid rather than searching for a simple one like this to display that skill.

        public Extra ExtraLookup(int id)
        {
            Extra result = new Extra();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Extra WHERE extra_id = {id}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Extra(int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), double.Parse(String.Format($"{reader[3]}")));
                        }
                    }
                }
            }

            return result;
        }

        public List<Extra> GetExtraFromBooking(Booking b)
        {
            List<Extra> extras = new List<Extra>();
            List<int> extraIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM BookingExtras WHERE booking_id = {b.BookingID}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            extraIDs.Add(Convert.ToInt32(reader[0]));
                            extras.Add(ExtraLookup(extraIDs[i]));
                            i++;
                        }
                    }
                }
            }

            return extras;
        }
    }
}
