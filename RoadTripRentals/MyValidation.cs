using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MyValidation
    {
        public static bool validLength(string txt, int min, int max)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txt))
                ok = false;

            else if (txt.Length < min || txt.Length > max)
                ok = false;

            return ok;
        }


        public static bool validLengthDouble(double value, double min, double max)
        {
            bool ok = true;

            if (value < min || value > max)
                ok = false;

            return ok;
        }

        public static bool validNumber(string txt)
        {
            bool ok = true;

            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                    ok = false;
            }
            return ok;
        }


        public static bool validLetter(string txt)    //allows alphabetic characters 
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }


        public static bool validLetterWhitespace(string txt)    //allows alphabetic characters and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }


        public static bool validLetterNumberWhitespace(string txt)    //allows alphanumeric and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(char.IsNumber(txt[x])))
                        ok = false;
                }
            }
            return ok;

        }


        public static bool validForename(string txt)    //allows alphabetic, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }


        public static bool validSurname(string txt)     //allows alphabetic, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')) && !(txt[x].Equals('\'')))
                        ok = false;
                }
            }
            return ok;
        }

            //public static bool IsValidStreetNo(int streetNo) NO LONGER USED AS STREET NO AND NAME MERGED
            //{
            //    // Check if the street number is a positive value
            //    return streetNo > 0;
            //}

        public static bool validDogDOB(string txt)
        {
            DateTime currentDate = DateTime.Now;
            DateTime dogDoB = Convert.ToDateTime(txt);

            TimeSpan t = currentDate - dogDoB;
            double NoOfDays = t.TotalDays;

            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (NoOfDays <= 56)
                    ok = false;
            }
            return ok;
        }

        public static bool validColour(string txt)     //allows alphabetic, & and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('&')) && !(txt[x].Equals('\'')))
                        ok = false;
                }
            }
            return ok;
        }

        public static String firstLetterEachWordToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }

            //go through array and check for spaces. Make any lowercase letters after a space uppercase
            else
            {
                for (int x = 1; x < array.Length; x++)
                {
                    if (array[x - 1] == ' ')
                    {
                        if (Char.IsLower(array[x]))
                        {
                            array[x] = Char.ToUpper(array[x]);
                        }
                    }
                    else
                        array[x] = Char.ToLower(array[x]);
                }
            }
            return new string(array);
        }


        public static String EachLetterToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }
            }
            return new string(array);
        }


        public static bool validEmail(string txt)   //check text before and after @ symbol and at least one '.' after @ symbol
        {
            bool ok = true;
            string email = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else if (!(Regex.IsMatch(txt, email)))                
            {
                ok = false;
            }

            return ok;  
        }

        public static bool validFuelType(string fuelType)
        {
            string[] validFuelTypes = { "Petrol", "Diesel", "Electric", "Hybrid" };
            return validFuelTypes.Contains(fuelType, StringComparer.OrdinalIgnoreCase);
        }

        public static bool validYear(int? year)
        {
            if (!year.HasValue)
            {
                return false; // Year not specified (blank field)
            }

            int currentYear = DateTime.Now.Year;
            return year.Value >= 1950 && year.Value <= currentYear;
        }


        public static bool validCarReg(string carReg)
        {
            // Use regular expression pattern to match alphanumeric characters only
            string pattern = @"^[a-zA-Z0-9]+$";

            // Check if the carReg matches the pattern and the length is within the specified range
            return Regex.IsMatch(carReg, pattern) && carReg.Length >= 6 && carReg.Length <= 10;
        }


    }
}
