using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CMSportsObjects
{
    public class Contact
    {
        private string name;
        private string email;
        private Address address;
        private string homePhone;
        private string workPhone;

        public Contact()
        {
            address = new Address();
        }

        public Contact(string name, string email, Address address, string homePhone, string workPhone)
        {
            Name = name;
            Email = email;
            Address = address;
            HomePhone = homePhone;
            WorkPhone = workPhone;
        }
    
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
                    throw new ArgumentException("The email address you entered is not valid.");
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
