using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSportsObjects
{
    public class Organisation
    {
        private string name;
        private Address address;
        private int size;
        private List<Contact> contacts;
        private List<Event> events;

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

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public List<Contact> Contacts
        {
            get
            {
                return contacts;
            }
            set
            {
                contacts = value;
            }
        }

        public List<Event> Events
        {
            get
            {
                return events;
            }
            set
            {
                events = value;
            }
        }
    }
}
