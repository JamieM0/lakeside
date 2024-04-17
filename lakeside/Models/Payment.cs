using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingID { get; set; }
        public double PaymentValue { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment()
        {
            Id = 0;
            BookingID = 0;
            PaymentValue = 0;
            PaymentMethod = "";
            PaymentDate = DateTime.Now;
        }

        public Payment(int id, int bookingID, double paymentValue, string paymentMethod, DateTime paymentDate)
        {
            Id = id;
            BookingID = bookingID;
            PaymentValue = paymentValue;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }

        public Payment(int bookingID, double paymentValue, string paymentMethod, DateTime paymentDate)
        {
            BookingID = bookingID;
            PaymentValue = paymentValue;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }
    }
}
