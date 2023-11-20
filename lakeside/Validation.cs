using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                return "Not a valid email address.";
        }

        public static string PhoneNumber(string phoneNumber)
        {
            // Add your own phone number validation logic here
            return null;
        }

        public static string UKPostcode(string postcode)
        {
            // Add your own UK postcode validation logic here
            return null;
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
