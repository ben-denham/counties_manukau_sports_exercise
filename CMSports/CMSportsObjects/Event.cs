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
        private DateTime startTime;
        private DateTime endTime;
        private List<Contact> contacts;
        private Organisation organisation;
        private Programme program;

        public Event()
        {
            contacts = new List<Contact>();
        }

        public Event(string name, Address address, int capacity, DateTime startTime, DateTime endTime, Organisation organisation, Programme program)
        {
            contacts = new List<Contact>();
            Name = name;
            Address = address;
            Capacity = capacity;
            StartTime = startTime;
            EndTime = endTime;
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

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
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
