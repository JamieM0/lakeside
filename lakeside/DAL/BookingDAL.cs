﻿using System;
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
            command.CommandText = string.Format($"SELECT * FROM Pod WHERE pod_id NOT IN( SELECT pod_id FROM Booking WHERE(checkInDate <= '{start.ToString("yyyy-MM-dd")}' AND checkOutDate >= '{start.ToString("yyyy-MM-dd")}') OR(checkInDate < '{end.ToString("yyyy-MM-dd")}' AND checkOutDate >= '{end.ToString("yyyy-MM-dd")}') OR ('{start.ToString("yyyy-MM-dd")}' <= checkInDate AND '{end.ToString("yyyy-MM-dd")}' >= checkInDate) ); ");
            return RunSelectQueryOnTable(command);
        }

        public bool AddNewBooking(Booking b)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Booking VALUES('{b.PodID}','{b.BookingType}','{b.CheckInDate}','{b.CheckOutDate}','{b.DateBooked}','{b.NumberOccupants}','{b.DepositPaid}','{b.DepositPayDate}','{b.BookedBy}')");

            return ExecuteNonQuery(command);
        }
    }
}