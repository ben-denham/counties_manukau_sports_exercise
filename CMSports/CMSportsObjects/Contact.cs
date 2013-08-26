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
                if (Validation.ValidName(value))
                {
                    name = value;
                }
                else
                {
                    throw new System.ArgumentException();
                }
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
                if (Validation.ValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new System.ArgumentException();
                }
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
