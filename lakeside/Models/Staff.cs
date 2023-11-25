using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.DAL
{
    public class Staff
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string CityTown { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Position { get; set; }
        public int StaffID { get; set; }

        public Staff()
        {
            Forename = "";
            Surname = "";
            Email = "";
            Number = "";
            Street = "";
            CityTown = "";
            Postcode = "";
            Country = "";
            Position = "";
        }

        public Staff(string forename, string surname, string email, string number, string street, string citytown, string postcode, string country, int id, string position)
        {
            Forename = forename;
            Surname = surname;
            Email = email;
            Number = number;
            Street = street;
            CityTown = citytown;
            Postcode = postcode;
            Country = country;
            StaffID = id;
            Position = position;
        }
    }
}
