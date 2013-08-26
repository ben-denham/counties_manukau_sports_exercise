using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions

namespace CMSportsObjects
{
    public static class Validation
    {
        public static bool ValidName(string name)
        {
            // More than 1 character
            // Not more than 130 char
            // No numbers or symbols other than dash, apostrophe or space
            Regex r = new Regex("^[a-zA-Z][a-zA-Z'- ]*[a-zA-Z]?$");
            if (r.IsMatch(name) && name.Length > 1 && name.Length < 130)
            {
                return true;
            }
            return false;
        }

        public static bool ValidEmail(string email)
        {
            return true;
        }

        public static bool ValidSize(int size)
        {
            return true;
        }

        public static bool ValidPhone(int phone)
        {
            return true;
        }
    }
}
