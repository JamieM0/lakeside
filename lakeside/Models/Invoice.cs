using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        
        // Reference to the booking that is selected
        public Booking booking { get; set; }

        // Lead guest of the booking
        public Guest leadGuest { get; set; }

        // Pod being stayed in for the booking
        public Pod bookedPod { get; set; }

        // All guests in the booking, including the lead guest, who is ID=0;
        //public List<Guest> guestsStaying { get; set; }

        public List<Course> coursesSelected { get; set; }
        public List<Extra> extrasSelected { get; set; }

        public Invoice(Booking Booking, Guest LeadGuest, Pod BookedPod, List<Course> CoursesSelected, List<Extra> ExtrasSelected)
        {
            booking = Booking;
            leadGuest = LeadGuest;
            bookedPod = BookedPod;
            coursesSelected = CoursesSelected;
            extrasSelected = ExtrasSelected;
        }
        public Invoice()
        {
            booking = new Booking();
            leadGuest = new Guest();
            bookedPod = new Pod();
            coursesSelected = new List<Course>();
            extrasSelected = new List<Extra>();
        }
    }
}
