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

    public class guest
    {
        private string Forename { get; set; }
        private string Surname { get; set; }
        private string Email { get; set; }
        private string Number { get; set; }
        private string Street { get; set; }
        private string CityTown { get; set; }
        private string Postcode { get; set; }
        private string Country { get; set; }

        public guest()
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

        public guest(string forename, string surname, string email, string number, string street, string citytown, string postcode, string country)
        {
            Forename = forename;
            Surname = surname;
            Email = email;
            Number = number;
            Street = street;
            CityTown = citytown;
            Postcode = postcode;
            Country = country;
        }
    }
}
