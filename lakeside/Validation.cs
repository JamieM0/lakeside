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
        public static bool Name(string name)
        {
            string pattern = @"^[\p{L}\p{M}' \.\-]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(name);
        }

        public static bool Email(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public static bool PhoneNumber(string phoneNumber)
        {
            // Add your own phone number validation logic here
            return true;
        }

        public static bool UKPostcode(string postcode)
        {
            // Add your own UK postcode validation logic here
            return true;
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
