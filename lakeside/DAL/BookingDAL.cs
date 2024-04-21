using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using lakeside.Models;

namespace lakeside.DAL
{
    class BookingDAL : DAL
    {
        public DataTable GetAvailablePods(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format($"SELECT pod_id AS pod_id, name AS Name, description AS Description, type AS Type, capacity AS Capacity, location AS Location, pricePPPN AS Price FROM Pod WHERE pod_id NOT IN( SELECT pod_id FROM Booking WHERE(checkInDate <= '{start.ToString("yyyy-MM-dd")}' AND checkOutDate >= '{start.ToString("yyyy-MM-dd")}') OR(checkInDate < '{end.ToString("yyyy-MM-dd")}' AND checkOutDate >= '{end.ToString("yyyy-MM-dd")}') OR ('{start.ToString("yyyy-MM-dd")}' <= checkInDate AND '{end.ToString("yyyy-MM-dd")}' >= checkInDate) ); ");
            return RunSelectQueryOnTable(command);
        }

        public DataTable GetBookedPods(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format($"SELECT pod_id AS pod_id, name AS Name, location AS Location FROM Pod WHERE pod_id IN(SELECT pod_id FROM Booking WHERE(checkInDate = '{start.ToString("yyyy-MM-dd")}' AND checkOutDate = '{end.ToString("yyyy-MM-dd")}' AND bookingType = 'full') ); ");
            return RunSelectQueryOnTable(command);
        }

        public Booking GetBooking(Pod pod, DateTime start, DateTime end)
        {
            Booking result = new Booking();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Booking WHERE pod_id = {pod.PodID} AND checkInDate = '{start.ToString("MM/dd/yyyy")}' AND checkOutDate = '{end.ToString("MM/dd/yyyy")}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //bool newGuests = false;
                            //if (int.Parse(String.Format($"{reader[12]}")) == 1)
                            //    newGuests = true;

                            result = new Booking(int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[2]}"), start, end, DateTime.Parse(String.Format($"{reader[5]}")),
                                int.Parse(String.Format($"{reader[6]}")), 0.0, DateTime.Parse(String.Format($"{reader[9]}")), int.Parse(String.Format($"{reader[10]}")),
                                int.Parse(String.Format($"{reader[1]}")), int.Parse(String.Format($"{reader[7]}")), Convert.ToBoolean(Convert.ToInt16(String.Format($"{reader[11]}"))));
                        }
                    }
                }
            }

            return result;
        }

        public int GetNumberOfGuestsInBooking(Booking b)
        {
            SqlCommand command = new SqlCommand();
            object obj = ExecuteScalar($"SELECT COUNT(*) AS NumberOfGuests FROM GuestBooking WHERE booking_id = {b.BookingID}; ");
            return Convert.ToInt32(obj);
        }

        public Guest GetLeadBooker(Booking b)
        {
            SqlCommand command = new SqlCommand();
            object obj = ExecuteScalar($"SELECT guest_id FROM GuestBooking WHERE booking_id = {b.BookingID} AND typeGuest = 'lead'; ");
            int guestID = Convert.ToInt32(obj);
            LakesideDAL GuestDAL = new LakesideDAL();
            return GuestDAL.GuestLookup(guestID);
        }

        public int AddNewBooking(Booking b)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            //command.CommandText = string.Format
            int previousGuests = 0;
            if (b.PreviousGuests)
                previousGuests = 1;
            object obj = ExecuteScalar($"INSERT INTO Booking OUTPUT INSERTED.booking_id " +
                $"VALUES('{b.PodID}','{b.BookingType}','{b.CheckInDate.ToString("MM/dd/yyyy")}','{b.CheckOutDate.ToString("MM/dd/yyyy")}'," +
                $"'{b.DateBooked.ToString("MM/dd/yyyy")}','{b.NumberOccupants}','{b.DiscountPercent}'," +
                $"'{b.DepositPaid}','{b.DepositPayDate.ToString("MM/dd/yyyy")}'," +
                $"'{b.BookedBy}','{previousGuests}')");

            return Convert.ToInt32(obj);
        }

        public List<Booking> GetAllProvisionalBookings()
        {
            //Get all bookings from the database
            List<Booking> allBookings = new List<Booking>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Booking WHERE bookingType = 'provisional'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            Booking booking = new Booking();
                            booking.BookingID = Convert.ToInt32(reader[0]);
                            booking.BookingType = String.Format($"{reader[2]}");
                            booking.CheckInDate = DateTime.Parse(String.Format($"{reader[3]}"));
                            booking.CheckOutDate = DateTime.Parse(String.Format($"{reader[4]}"));
                            booking.DateBooked = DateTime.Parse(String.Format($"{reader[5]}"));
                            booking.NumberOccupants = int.Parse(String.Format($"{reader[6]}"));
                            booking.DepositPaid = 0.0;
                            booking.DepositPayDate = DateTime.Parse(String.Format($"{reader[9]}"));
                            booking.BookedBy = int.Parse(String.Format($"{reader[10]}"));
                            booking.PodID = int.Parse(String.Format($"{reader[1]}"));
                            try
                            {
                                booking.DiscountPercent = int.Parse(String.Format($"{reader[7]}"));
                            }
                            catch (Exception ex)
                            {
                                booking.DiscountPercent = 0;
                            }
                            booking.PreviousGuests = Convert.ToBoolean(Convert.ToInt16(String.Format($"{reader[11]}")));
                            allBookings.Add(booking);
                            i++;
                        }
                    }
                }
            }

            return allBookings;
        }

        public bool ConvertToFullBooking(Booking b)
        {
            //This method converts the booking type to be 'full'
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Booking SET bookingType = 'full' WHERE booking_id = {b.BookingID}");

            return ExecuteNonQuery(command);
        }

        public bool ConvertToPaidBooking(Booking b)
        {
            //This method converts the booking type to be 'full'
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Booking SET bookingType = 'paid' WHERE booking_id = {b.BookingID}");

            return ExecuteNonQuery(command);
        }

        public bool RemoveBookings()
        {
            List<Booking> bookings = new List<Booking>();
            bookings = GetAllProvisionalBookings();
            foreach(Booking b in bookings)
            {
                if((DateTime.Now.Date - b.DateBooked).Days > 3)
                {
                    //This method converts the booking type to be 'full'
                    SqlCommand command = new SqlCommand();

                    //Set SQL query command text to valid insert statement using values from the Guest class.
                    command.CommandText = string.Format($"UPDATE Booking SET bookingType = 'removed' WHERE booking_id = {b.BookingID}");

                    ExecuteNonQuery(command);
                }
            }
            return true;
        }
    }
}
