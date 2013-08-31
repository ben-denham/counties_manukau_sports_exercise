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
        private string description;
        private List<Contact> contacts;
        private Organisation organisation;
        private Programme program;

        public Event()
        {
            contacts = new List<Contact>();
        }

        public Event(string name, Address address, int capacity, DateTime startTime, DateTime endTime, string description, Organisation organisation, Programme program)
        {
            contacts = new List<Contact>();
            Name = name;
            Address = address;
            Capacity = capacity;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
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

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
                if (Organisation != null)
                {
                    organisation.Events.Remove(this);
                }
                organisation = value;
                if (organisation.Events.IndexOf(this) == -1)
                {
                    organisation.Events.Add(this);
                }
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
                if (Program != null)
                {
                    program.Events.Remove(this);
                }
                program = value;
                if (program.Events.IndexOf(this) == -1)
                {
                    program.Events.Add(this);
                }
            }
        }

        public void Dispose()
        {
            Organisation.Events.Remove(this);
            program.Events.Remove(this);
        }
    }
}
