﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside.DAL;
using lakeside.Models;

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

            object obj = ExecuteScalar($"INSERT INTO Guest OUTPUT INSERTED.guest_id VALUES('{g.Forename}','{g.Surname}','{g.Email}','{g.Number}','{g.Street}','{g.CityTown}','{g.Postcode}','{g.Country}')");
            return Convert.ToInt32(obj);
        }

        public Guest[] SearchGuests(string search)
        {
            List<Guest> allGuests = new List<Guest>();
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
                            allGuests.Add(new Guest(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), int.Parse(String.Format($"{reader[0]}"))));
                            i++;
                        }

                        //Check for duplicates in allGuests
                        //allGuests = allGuests.Distinct().ToArray();

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

        public bool RegisterForCourse(Guest g, Course c, Booking b)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO GuestCouseBooking VALUES('{b.BookingID}','{g.GuestID}','{c.CourseID}','','','','')");

            return ExecuteNonQuery(command);
            
        }

        public bool AddToBooking(Guest g, Booking b, bool leadBooker)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            string typeGuest="standard";
            if (leadBooker)
                typeGuest = "lead";

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO GuestBooking VALUES('{b.BookingID}','{g.GuestID}','{typeGuest}')");

            return ExecuteNonQuery(command);
        }

        public int CountGuests()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("SELECT COUNT(*) FROM Guest");
            return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Guest"));
        }

        public List<Guest> GetGuestFromBooking(Booking b)
        {
            List<Guest> guests = new List<Guest>();
            List<int> guestIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM GuestBooking WHERE booking_id = {b.BookingID}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            guestIDs.Add(Convert.ToInt32(reader[1]));
                            guests.Add(GuestLookup(guestIDs[i]));
                            i++;
                        }
                    }
                }
            }

            return guests;
        }
    }
}
