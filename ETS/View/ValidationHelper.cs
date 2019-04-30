using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//...
using System.Text.RegularExpressions;

namespace View
{
    public static class ValidationHelper
    {
        public static bool LettersOnly(string input)
        {
            if(input != "" && Regex.Match(input, "^[a-zA-Z]*$" ).Success)
            {
                return true;
            }
            return false;
        }

        public static bool NumberOnly(string input)
        {
            if (input != "" && Regex.Match(input, @"^\d*$").Success)
            {
                return true;
            }
            return false;
        }
        public static bool NumberWithDashOrDecimal(string input)
        {
            if (input != "" && Regex.Match(input, @"^[\d\-\.]+$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsEmail(string input)
        {
            if (input != "" && Regex.Match(input, @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$").Success)
            {
                return true;
            }
            return false;
        }
    }
}
