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
            command.CommandText = string.Format($"SELECT pod_id AS pod_id, name AS Name, location AS Location FROM Pod WHERE pod_id IN(SELECT pod_id FROM Booking WHERE(checkInDate = '{start.ToString("yyyy-MM-dd")}' AND checkOutDate = '{end.ToString("yyyy-MM-dd")}') ); ");
            return RunSelectQueryOnTable(command);
        }

        public Booking GetBooking(Pod pod, DateTime start, DateTime end)
        {
            Booking result = new Booking();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Booking WHERE pod_id = {pod.PodID} AND checkInDate = '{start.ToString("dd/MM/yyyy")}' AND checkOutDate = '{end.ToString("dd/MM/yyyy")}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Booking(int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[2]}"), start, end, DateTime.Parse(String.Format($"{reader[5]}")),
                                int.Parse(String.Format($"{reader[6]}")), 0.0, DateTime.Parse(String.Format($"{reader[9]}")), int.Parse(String.Format($"{reader[10]}")), 
                                int.Parse(String.Format($"{reader[1]}")), int.Parse(String.Format($"{reader[7]}")));
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

        public int AddNewBooking(Booking b)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            //command.CommandText = string.Format

            object obj = ExecuteScalar($"INSERT INTO Booking OUTPUT INSERTED.booking_id " +
                $"VALUES('{b.PodID}','{b.BookingType}','{b.CheckInDate}','{b.CheckOutDate}'," +
                $"'{b.DateBooked}','{b.NumberOccupants}','{b.DiscountPercent}'," +
                $"'{b.DepositPaid}','{b.DepositPayDate}'," +
                $"'{b.BookedBy}')");

            return Convert.ToInt32(obj);
        }
    }
}
