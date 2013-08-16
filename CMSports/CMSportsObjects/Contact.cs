﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CMSportsObjects
{
    public class Contact
    {
        private Address address;
        private string email;
        private string homePhone;
        private string name;
        private string workPhone;
    
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                string regex = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}$";
                if (!Regex.IsMatch(value, @regex, RegexOptions.IgnoreCase)) {
                    throw new NotImplementedException("The email address you entered is not valid.");
                }
                email = value;
            }
        }

        public string HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
            }
        }

        public string WorkPhone
        {
            get
            {
                return workPhone;
            }
            set
            {
                workPhone = value;
            }
        }
    }
}
