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

namespace lakeside.DAL
{
    class BookingDAL : DAL
    {
        public DataTable GetAvailablePods(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("SELECT * FROM Pod WHERE pod_id NOT IN( SELECT pod_id FROM Booking WHERE(checkInDate <= '2020-01-01' AND checkOutDate >= '2020-01-01') OR(checkInDate < '2020-01-05' AND checkOutDate >= '2020-01-05') OR ('2020-01-01' <= checkInDate AND '2020-01-05' >= checkInDate) ); ");
            return RunSelectQueryOnTable(command);
        }
    }
}
