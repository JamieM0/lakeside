using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    class Invoice
    {
        // Reference to the booking that is selected
        public Booking booking { get; set; }

        // Lead guest of the booking
        //public Guest leadGuest { get; set; }

        // Pod being stayed in for the booking
        //public Pod bookedBod { get; set; }

        // All guests in the booking, including the lead guest, who is ID=0;
        //public List<Guest> guestsStaying { get; set; }

        //public List<Course> coursesSelected { get; set; }
    }
}
