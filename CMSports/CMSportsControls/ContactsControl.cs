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
        public ContactsControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            contactsListView.Items.Clear();
        }

        public void Populate(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                ListViewItem listItem = new ListViewItem(contact.Name);
                listItem.SubItems.Add(contact.Email);
                listItem.SubItems.Add(contact.Address.ToString());
                listItem.SubItems.Add(contact.HomePhone);
                listItem.SubItems.Add(contact.WorkPhone);
                contactsListView.Items.Add(listItem);
            }
        }
    }
}
