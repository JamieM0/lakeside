using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside
{
    class Lakeside
    {
        
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
    }
}
