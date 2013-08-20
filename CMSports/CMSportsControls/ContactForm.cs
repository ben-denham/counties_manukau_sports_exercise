using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMSportsObjects;

namespace CMSportsControls
{
    public partial class ContactForm : Form
    {
        private Contact activeContact;

        public Contact ActiveContact
        {
            get
            {
                return activeContact;
            }
        }

        public ContactForm(Contact contact)
        {
            InitializeComponent();
            Populate(contact);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveContact();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Populate(Contact contact)
        {
            activeContact = contact;
            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            homePhoneTextBox.Text = contact.HomePhone;
            workPhoneTextBox.Text = contact.WorkPhone;
            contactAddressControl.Populate(contact.Address);
        }

        private Contact saveContact()
        {
            activeContact.Name = nameTextBox.Text;
            activeContact.Email = emailTextBox.Text;
            activeContact.HomePhone = homePhoneTextBox.Text;
            activeContact.WorkPhone = workPhoneTextBox.Text;
            activeContact.Address = contactAddressControl.GetAddress();
            return activeContact;
        }
    }
}
