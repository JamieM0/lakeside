using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lakeside
{
    class Lakeside
    {
        public static Guest currentlySelectedGuest = new Guest();
        public static object lastSearched = new object();
        public static bool debug = false;
        
        public static void Notifier(int notificationType)
        {
            /* Notification Type:
             0: Error, 1: No (Other Negative), 2: Neutral / Info, 3: Yes / OK 
            
            Notifications only have 1 type of text - no title. This is to avoid being too cramped.

             */
        }
    }

    public class Notification
    {
        public PictureBox _pbIcon { get; set; }
        public string _text { get; set; }
        public int _notificationType { get; set; }

    }

    public class Guest
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string CityTown { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public int GuestID { get; set; }

        public Guest()
        {
            Forename = "";
            Surname = "";
            Email = "";
            Number = "";
            Street = "";
            CityTown = "";
            Postcode = "";
            Country = "";
        }

        public Guest(string forename, string surname, string email, string number, string street, string citytown, string postcode, string country, int id)
        {
            Forename = forename;
            Surname = surname;
            Email = email;
            Number = number;
            Street = street;
            CityTown = citytown;
            Postcode = postcode;
            Country = country;
            GuestID = id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Guest g = (Guest)obj;
            // Replace 'YourProperty' with the actual property you want to compare
            return GuestID == g.GuestID;
        }

        // You should also override GetHashCode when you override Equals
        public override int GetHashCode()
        {
            // Replace 'YourProperty' with the actual property you used in Equals
            return GuestID.GetHashCode();
        }
    }
}
