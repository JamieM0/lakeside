using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

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

        public static void AnimatePanelSideways(Panel pnl, Point endPoint)
        {
            Point startPoint = pnl.Location;
            int diff = Math.Abs(endPoint.X - startPoint.X);
            bool left = false;
            if (endPoint.X < startPoint.X)
                left = true;
            if (!left)
            {
                for (int i = 0; i < diff; i++)
                {
                    int x = pnl.Location.X;
                    pnl.Location = new Point(x++, pnl.Location.Y);
                    pnl.Refresh();
                }
            }
            else
            {
                for (int i = 0; i < diff; i++)
                {
                    int x = pnl.Location.X;
                    x--;
                    pnl.Location = new Point(x, pnl.Location.Y);
                    pnl.Refresh();
                }
            }
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

        public int cachedCourseChoiceID { get; set; }
        public bool previousGuest { get; set; }

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
