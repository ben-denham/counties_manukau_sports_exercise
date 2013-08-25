using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSportsObjects
{
    public abstract class Organisation
    {
        private string name;
        private Address address;
        private int size;
        private List<Contact> contacts;
        private List<Event> events;

        public Organisation()
        {
            contacts = new List<Contact>();
            events = new List<Event>();
            address = new Address();
        }

        public Organisation(string name, int size, Address address)
        {
            Name = name;
            Size = size;
            Address = address;
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
        }

        public List<Event> Events
        {
            get
            {
                return events;
            }
        }

        public string Type
        {
            get
            {
                return this.GetType().Name.ToString();
            }
        }

    }
}
