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
using CMSportsControls;

namespace CMSports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Organisation> organisations = new List<Organisation>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Organisation org1 = new School("Tyndale", 140, new Address("Murphy's Road", "123a", "Flat Bush", 2012));
            var address1 = new Address("Contact's Road", "321", "Farm Cove", 2015);
            var contact1 = new Contact("Ben Denham", "contact@gmail.com", address1, "(09) 123 1234", "027456124");
            org1.Contacts.Add(contact1);

            Organisation org2 = new Club("Macleans", 1000, new Address("Beach Road", "567", "Bucklands Beach", 2017));
            var address2 = new Address("Contact's Road", "123", "Howick", 2011);
            var contact2 = new Contact("Dirk de Boer", "dirk@gmail.com", address2, "(09) 163 7894", "023577124");
            org2.Contacts.Add(contact2);

            organisations.Add(org1);
            organisations.Add(org2);

            populateOrganisationListView(organisations);
        }

        private void populateOrganisationListView(List<Organisation> organisations)
        {
            foreach (Organisation organisation in organisations)
            {
                ListViewItem listItem = new ListViewItem(organisation.Name);
                listItem.SubItems.Add(organisation.Type);
                listItem.SubItems.Add(organisation.Size.ToString());
                organisationListView.Items.Add(listItem);
            }
        }

        private void organisationListView_ItemActivate(object sender, EventArgs e)
        {
            int selectedIndex = organisationListView.SelectedIndices[0];
            Organisation organisation = organisations[selectedIndex];
            clearOrganisationFields();
            populateOrganisationFields(organisation);
        }

        private void clearOrganisationFields()
        {
            organisationNameTextBox.Clear();
            organisationTypeTextBox.Clear();
            organisationSizeTextBox.Clear();
            organisationAddressAddressControl.Clear();
            organisationContacts.Clear();
            organisationEventsListView.Clear();
        }

        private void populateOrganisationFields(Organisation organisation)
        {
            organisationNameTextBox.Text = organisation.Name;
            organisationTypeTextBox.Text = organisation.Type;
            organisationSizeTextBox.Text = organisation.Size.ToString();
            organisationAddressAddressControl.Populate(organisation.Address);
            organisationContacts.Populate(organisation.Contacts);
        }
    }
}
