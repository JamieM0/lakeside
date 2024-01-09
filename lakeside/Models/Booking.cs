using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Booking
    {
        public string BookingType { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime DateBooked { get; set; }
        public int NumberOccupants { get; set; }
        public double DepositPaid { get; set; }
        public DateTime DepositPayDate { get; set; }
        public int BookedBy { get; set; }
        public int PodID { get; set; }
        public int BookingID { get; set; }

        public Booking()
        {
            BookingType = "standard";
            CheckInDate = new DateTime();
            CheckOutDate = new DateTime();
            DateBooked = new DateTime();
            NumberOccupants = 0;
            DepositPaid = 0.0;
            DepositPayDate = new DateTime();
            BookedBy = 0;
            PodID = 0;
            BookingID = 0;
        }

        public Booking(string bookingType, DateTime checkInDate, DateTime checkOutDate, DateTime dateBooked, int numberOccupants, double depositPaid, DateTime depositPayDate, int bookedBy, int podID)
        {
            BookingType = bookingType;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            DateBooked = dateBooked;
            NumberOccupants = numberOccupants;
            DepositPaid = depositPaid;
            DepositPayDate = depositPayDate;
            BookedBy = bookedBy;
            PodID = podID;
        }
    }
}
