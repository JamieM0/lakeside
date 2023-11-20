using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace lakeside
{
    public class Validation
    {
        //ALL VALIDATION CLASSES RETURN TEXT. THIS IS TO GIVE ACCURATE ERROR MESSAGE. IF TEXT NULL OR "", THEN NO ERROR.

        public static string Name(string name)
        {
            if (name.Length > 45)
                return "Name too long. Max length is 45 characters.";
            if (!name.Contains(' '))
                return "You must enter at least one forename and a surname.";
            if (name.Length < 3)
                return "Name must be at least 3 charactes long.";
            string pattern = @"^[\p{L}\p{M}' \.\-]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
                return null;
            else
                return "Name contains illegal characters.";
        }

        public static string Email(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
                return null;
            else
                return "Not a valid email address. (Domain extension must be >=2 & <=7 characters).";
        }

        public static string PhoneNumber(string phoneNumber)
        {
            // Add your own phone number validation logic here
            if(phoneNumber.Length<1)
                return "Phone number cannot be empty.";
            if (phoneNumber[0] != '7')
                return "Mobile Number must start with a 7. \r\n(+44 is included).";
            if(phoneNumber.Length>10)
                return "Mobile Number is too long! \r\nShould be 10 numbers.";
            if (phoneNumber.Length < 10)
                return "Mobile Number is too short! \r\nShould be 10 numbers.";
            
            return null;
        }

        public static string UKPostcode(string postcode)
        {
            if (postcode.Length < 1)
                return "Postcode cannot be empty.";
            string pattern = @"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(postcode))
                return null;
            else
                return "Not a valid UK postcode.";
        }

        public static string UKCityTown(string citytown)
        {
            if (citytown.Length < 1)
                return "City/Town cannot be empty.";
            string[] towncitynames = File.ReadAllLines("uktownscities.txt");
            if (towncitynames.Contains(citytown))
                return null;
            else
                return "Not a valid UK city or town.";
        }
        
        public static string StreetName(string address)
        {
            if (address.Length < 1)
                return "Street name cannot be empty.";
            if (address.Length > 45)
                return "Street name too long. Max length is 45 characters.";
            if (address.Length < 3)
                return "Street name must be at least 3 characters long.";
            string pattern = @"^[0-9a-zA-Z\s\-\,]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(address))
                return null;
            else
                return "Not a valid address. \r\nOnly letters, numbers, spaces, hyphens and commas allowed.";
        }
    }

    //public class ValidationParts
    //{
    //    public static bool MaxLength(string input, int length)
    //    {
    //        return input.Length <= length;
    //    }

    //    public static bool OnlyLetters(string input)
    //    {
    //        return input.All(Char.IsLetter);
    //    }

    //    public static bool ContainsChar(string input, char character, int maxNum)
    //    {
    //        int count = input.Count(c => c == character);
    //        return count <= maxNum;
    //    }
    //}
}
