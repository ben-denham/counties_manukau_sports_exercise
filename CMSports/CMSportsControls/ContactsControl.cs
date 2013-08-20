using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMSportsObjects;

namespace CMSportsControls
{
    public partial class ContactsControl : UserControl
    {
        private List<Contact> contacts;
        Contact selectedContact;

        public ContactsControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            contactsListView.Items.Clear();
            addButton.Enabled = false;
            editButton.Enabled = false;
            removeButton.Enabled = false;
        }

        public void Populate(List<Contact> contacts)
        {
            Clear();
            foreach (Contact contact in contacts)
            {
                ListViewItem listItem = new ListViewItem(contact.Name);
                listItem.SubItems.Add(contact.Email);
                listItem.SubItems.Add(contact.Address.ToString());
                listItem.SubItems.Add(contact.HomePhone);
                listItem.SubItems.Add(contact.WorkPhone);
                contactsListView.Items.Add(listItem);
            }
            this.contacts = contacts;
            addButton.Enabled = true;
        }

        private void contactsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (contactsListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = contactsListView.SelectedIndices[0];
                selectedContact = contacts[selectedIndex];
                editButton.Enabled = true;
                removeButton.Enabled = true;
            }
            else
            {
                selectedContact = null;
                editButton.Enabled = false;
                removeButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            ContactForm contactForm = new ContactForm(newContact);
            DialogResult result = contactForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                contacts.Add(newContact);
                Populate(contacts);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            contacts.Remove(selectedContact);
            Populate(contacts);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(selectedContact);
            DialogResult result = contactForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Populate(contacts);
            }
        }
    }
}
