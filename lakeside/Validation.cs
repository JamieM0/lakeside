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
        
        public static string OtherText(string text, string elementName, int maxLength)
        {
            elementName = Char.ToUpper(elementName[0]) + elementName.Substring(1);
            if (text.Length < 1)
                return elementName + " cannot be empty.";
            if (text.Length > maxLength)
                return elementName + $" too long. Max length is {maxLength.ToString()} characters.";
            if (text.Length < 3)
                return elementName + " must be at least 3 characters long.";
            string pattern = @"^[0-9a-zA-Z\s\-\,]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(text))
                return null;
            else
                return $"Not a valid {elementName.ToLower()}. \r\nOnly letters, numbers, spaces, hyphens and commas allowed.";
        }

        public static string NumberRange(string input, int inclusiveMin, int inclusiveMax, string elementName)
        {
            if (input.Length < 1)
                return elementName + " cannot be empty.";
            try
            {
                int number = int.Parse(input);
                if (number > inclusiveMax)
                    return elementName + " cannot be greater than " + inclusiveMax + ".";
                if (number < inclusiveMin)
                    return elementName + " cannot be less than " + inclusiveMin + ".";
                return null;
            }
            catch
            {
                return "Not a valid number.";
            }
        }

        public static string Money(string money)
        {
            string pattern = @"^£?\d+(\.\d{2})?$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(money))
                return "Not a valid money amount. \r\nInclude the decimal (.) and 2 places.";
            return null;
        }

        public static string PodType(string pod, int podsStandard, int podsLuxury)
        {
            if(pod=="Standard" && podsStandard>=10)
                return "Maximum of 10 standard pods allowed.";
            if (pod == "Luxury" && podsLuxury >= 6)
                return "Maximum of 6 luxury pods allowed.";
            return null;
        }

        public static string BookingStartDate(DateTime date,int stayLength)
        {
            if (date < DateTime.Now)
                return "Booking start date cannot be in the past.";
            //Check if date between 20/12 and 20/01
            DateTime startInvalid = new DateTime(date.Year, 12, 20);
            DateTime endInvalid = new DateTime(date.Year, 1, 20).AddYears(1);
            if(date<startInvalid)
            {
                startInvalid = startInvalid.AddYears(-1);
                endInvalid = endInvalid.AddYears(-1);
            }
            //stayLength ++;
            if ((date >= startInvalid && date <= endInvalid) || (date.AddDays(stayLength) >=startInvalid.AddYears(1) && date <= endInvalid.AddYears(1)))
                return "Booking cannot take place between 20/12 and 20/01.";
            if(date<=DateTime.Now.AddMonths(2))
                return "Booking start date must be at least 2 months in the future.";
            return null;
        }

        public static string RequiredLength(string input, int requiredLength, string elementName)
        {
            if (input.Length < 1)
                return elementName + " cannot be empty.";
            try
            {
                int number = input.Length;
                if (number > requiredLength)
                    return elementName + " is too long! Length must be " + requiredLength + ".";
                if (number < requiredLength)
                    return elementName + " is not long enough! Length must be " + requiredLength + ".";
                return null;
            }
            catch
            {
                return "Not a valid number.";
            }
        }
        
        public static string DateCheckOverCurrent(DateTime input, string elementName)
        {
            if (input <= DateTime.Now)
                return elementName + " must be in the future.";
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
