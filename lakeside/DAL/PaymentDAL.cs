using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside.DAL
{
    class PaymentDAL : DAL
    {
        public bool MakePayment(Payment payment)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Payment VALUES('{payment.BookingID}','{payment.PaymentValue}','{payment.PaymentMethod}','{payment.PaymentDate.ToString("MM/dd/yyyy")}')");

            return ExecuteNonQuery(command);
        }
    }
}
