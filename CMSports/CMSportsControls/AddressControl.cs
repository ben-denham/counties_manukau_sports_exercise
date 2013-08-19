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
    public partial class AddressControl: UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            streetNoTextBox.Clear();
            streetNameTextBox.Clear();
            suburbTextBox.Clear();
            postcodeTextBox.Clear();
        }

        public void Populate(Address address)
        {
            streetNoTextBox.Text = address.StreetNumber;
            streetNameTextBox.Text = address.StreetName;
            suburbTextBox.Text = address.Suburb;
            postcodeTextBox.Text = address.Postcode.ToString();
        }

        public Address GetAddress()
        {
            Address address = new Address();
            address.StreetNumber = streetNoTextBox.Text;
            address.StreetName = streetNameTextBox.Text;
            address.Suburb = suburbTextBox.Text;
            address.Postcode = Convert.ToInt32(postcodeTextBox.Text);
            return address;
        }
    }
}
