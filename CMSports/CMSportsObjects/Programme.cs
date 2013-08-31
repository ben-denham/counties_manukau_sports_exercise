using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CMSportsObjects
{
    public class Programme : INotifyPropertyChanged
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
                NotifyPropertyChanged();
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            foreach (Event cmsEvent in Events)
            {
                cmsEvent.Program = null;
            }
        }
    }
}
