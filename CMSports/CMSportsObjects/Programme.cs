using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSportsObjects
{
    public class Programme
    {
        private string name;
        private string description;
        private List<Contact> contacts;
        private List<Event> events;

        public Programme()
        {
            contacts = new List<Contact>();
            events = new List<Event>();
        }

        public Programme(string name, string description)
        {
            Name = name;
            Description = description;
            contacts = new List<Contact>();
            events = new List<Event>();
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

        public List<Event> Events
        {
            get
            {
                return events;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
