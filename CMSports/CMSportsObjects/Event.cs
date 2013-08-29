using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSportsObjects
{
    public class Event
    {
        private string name;
        private Address address;
        private int capacity;
        private DateTime date;
        private List<Contact> contacts;
        private Organisation organisation;
        private Programme program;

        public Event()
        {
            contacts = new List<Contact>();
        }

        public Event(string name, Address address, int capacity, DateTime date, Organisation organisation, Programme program)
        {
            contacts = new List<Contact>();
            Name = name;
            Address = address;
            Capacity = capacity;
            Date = date;
            Organisation = organisation;
            Program = program;
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

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public List<Contact> Contacts
        {
            get
            {
                return contacts;
            }
        }

        public Organisation Organisation
        {
            get
            {
                return organisation;
            }
            set
            {
                organisation = value;
            }
        }

        public Programme Program
        {
            get
            {
                return program;
            }
            set
            {
                program = value;
            }
        }
    }
}
