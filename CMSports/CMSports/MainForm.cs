﻿using System;
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

        private BindingList<Organisation> organisations = new BindingList<Organisation>();
        private BindingList<Programme> programs = new BindingList<Programme>();
        private BindingList<Event> events = new BindingList<Event>();

        private Organisation activeOrganisation;
        private Programme activeProgram;
        private Event activeEvent;

        private void MainForm_Load(object sender, EventArgs e)
        {
            eventOrganisationComboBox.DataSource = new BindingSource() { DataSource = organisations };
            eventProgramComboBox.DataSource = new BindingSource() { DataSource = programs };

            eventEndDateTimePicker.Value = DateTime.Now.AddHours(1);

            Organisation org1 = new School("Tyndale", 140, new Address("Murphy's Road", "123a", "Flat Bush", 2012));
            var address1 = new Address("Contact's Road", "321", "Farm Cove", 2015);
            var contact1 = new Contact("Ben Denham", "contact@gmail.com", address1, "(09) 123 1234", "02745624");
            org1.Contacts.Add(contact1);

            Organisation org2 = new Club("Macleans", 1000, new Address("Beach Road", "567", "Bucklands Beach", 2017));
            var address2 = new Address("Contact's Road", "123", "Howick", 2011);
            var contact2 = new Contact("Dirk de Boer", "dirk@gmail.com", address2, "(09) 163 7894", "023577124");
            org2.Contacts.Add(contact2);

            organisations.Add(org1);
            organisations.Add(org2);

            Programme prog1 = new Programme("Coaching", "Our Awesome coaching program.");
            var address3 = new Address("Contact's Road", "456", "Flat Bush", 2014);
            var contact3 = new Contact("Joe Bloggs", "joe@gmail.com", address3, "(09) 683 1254", "027451544");
            prog1.Contacts.Add(contact3);
            Programme prog2 = new Programme("Fitness", "Our cool fitness program.");
            var address4 = new Address("Contact's Road", "654", "Botany", 2018);
            var contact4 = new Contact("Borris Jones", "borris@gmail.com", address4, "(09) 565 2356", "027496334");
            prog2.Contacts.Add(contact4);

            programs.Add(prog1);
            programs.Add(prog2);

            refreshOrganisationListView();
            refreshProgramListView();
            refreshEventListView();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0:
                    if (activeOrganisation != null)
                    {
                        populateOrganisationFields(activeOrganisation);
                    }
                    break;
                case 1:
                    if (activeProgram != null)
                    {
                        populateProgramFields(activeProgram);
                    }
                    break;
                case 2:
                    if (activeEvent != null)
                    {
                        populateEventFields(activeEvent);
                    }
                    break;
                case 3:
                    
                    break;
                    
            }
        }

        /* Organisations Tab */

        private void refreshOrganisationListView()
        {
            organisationListView.Items.Clear();
            foreach (Organisation organisation in organisations)
            {
                ListViewItem listItem = new ListViewItem(organisation.Name);
                listItem.SubItems.Add(organisation.Type);
                listItem.SubItems.Add(organisation.Size.ToString());
                organisationListView.Items.Add(listItem);
            }
        }

        private void refreshOrganisationEventsListView()
        {
            if (activeOrganisation != null)
            {
                organisationEventListView.Populate(activeOrganisation.Events);
            }
        }

        private void clearOrganisationFields()
        {
            organisationNameTextBox.Clear();
            organisationTypeTextBox.Clear();
            organisationSizeTextBox.Clear();
            organisationAddressAddressControl.Clear();
            organisationContacts.Clear();
            organisationEventListView.Clear();
            organisationSaveButton.Enabled = false;
            organisationDeleteButton.Enabled = false;
        }

        private void populateOrganisationFields(Organisation organisation)
        {
            clearOrganisationFields();
            organisationNameTextBox.Text = organisation.Name;
            organisationTypeTextBox.Text = organisation.Type;
            organisationSizeTextBox.Text = organisation.Size.ToString();
            organisationAddressAddressControl.Populate(organisation.Address);
            organisationContacts.Populate(organisation.Contacts);
            organisationSaveButton.Enabled = true;
            organisationDeleteButton.Enabled = true;
            refreshOrganisationEventsListView();
        }

        private void organisationSaveButton_Click(object sender, EventArgs e)
        {
            saveOrganisation(activeOrganisation);
            refreshOrganisationListView();
            populateOrganisationFields(activeOrganisation);
        }

        private void saveOrganisation(Organisation organisation)
        {
            organisation.Name = organisationNameTextBox.Text;
            organisation.Size = Convert.ToInt32(organisationSizeTextBox.Text);
            organisation.Address = organisationAddressAddressControl.GetAddress();
            int index = organisations.IndexOf(organisation);
            if (index == -1)
            {
                organisations.Add(organisation);
            }
        }

        private void organisationDeleteButton_Click(object sender, EventArgs e)
        {
            organisations.Remove(activeOrganisation);
            activeOrganisation.Dispose();
            activeOrganisation = null;
            refreshOrganisationListView();
            clearOrganisationFields();
        }

        private void newSchoolButton_Click(object sender, EventArgs e)
        {
            Organisation newSchool = new School();
            organisations.Add(newSchool);
            activeOrganisation = newSchool;
            populateOrganisationFields(newSchool);
        }

        private void newClubButton_Click(object sender, EventArgs e)
        {
            Organisation newClub = new Club();
            organisations.Add(newClub);
            activeOrganisation = newClub;
            populateOrganisationFields(newClub);
        }

        private void organisationListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (organisationListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = organisationListView.SelectedIndices[0];
                activeOrganisation = organisations[selectedIndex];
                populateOrganisationFields(activeOrganisation);
            }
            else
            {
                activeOrganisation = null;
                clearOrganisationFields();
            }
        }

        /* Programs Tab */

        private void refreshProgramListView()
        {
            programListView.Items.Clear();
            foreach (Programme program in programs)
            {
                ListViewItem listItem = new ListViewItem(program.Name);
                listItem.SubItems.Add(program.Description);
                programListView.Items.Add(listItem);
            }
        }

        private void refreshProgramEventsListView()
        {
            if (activeProgram != null)
            {
                programEventListView.Populate(activeProgram.Events);
            }
        }

        private void clearProgramFields()
        {
            programNameTextBox.Clear();
            programDescriptionTextBox.Clear();
            programContacts.Clear();
            programEventListView.Clear();
            programSaveButton.Enabled = false;
            programDeleteButton.Enabled = false;
        }

        private void populateProgramFields(Programme program)
        {
            clearProgramFields();
            programNameTextBox.Text = program.Name;
            programDescriptionTextBox.Text = program.Description;
            programContacts.Populate(program.Contacts);
            programSaveButton.Enabled = true;
            programDeleteButton.Enabled = true;
            refreshProgramEventsListView();
        }

        private void programSaveButton_Click(object sender, EventArgs e)
        {
            saveProgram(activeProgram);
            refreshProgramListView();
            populateProgramFields(activeProgram);
        }

        private void saveProgram(Programme program)
        {
            program.Name = programNameTextBox.Text;
            program.Description = programDescriptionTextBox.Text;
            int index = programs.IndexOf(program);
            if (index == -1)
            {
                programs.Add(program);
            }
        }

        private void programDeleteButton_Click(object sender, EventArgs e)
        {
            programs.Remove(activeProgram);
            activeProgram.Dispose();
            activeProgram = null;
            refreshProgramListView();
            clearProgramFields();
        }

        private void programNewButton_Click(object sender, EventArgs e)
        {
            Programme newProgram = new Programme();
            programs.Add(newProgram);
            activeProgram = newProgram;
            populateProgramFields(newProgram);
        }

        private void programListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (programListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = programListView.SelectedIndices[0];
                activeProgram = programs[selectedIndex];
                populateProgramFields(activeProgram);
            }
            else
            {
                activeProgram = null;
                clearProgramFields();
            }
        }

        /* Events Tab */

        private void refreshEventListView()
        {
            eventListView.Items.Clear();
            foreach (Event cmsEvent in events)
            {
                ListViewItem listItem = new ListViewItem(cmsEvent.Name);
                if (cmsEvent.Organisation != null)
                {
                    listItem.SubItems.Add(cmsEvent.Organisation.ToString());
                }
                if (cmsEvent.Program != null)
                {
                    listItem.SubItems.Add(cmsEvent.Program.ToString());
                }
                eventListView.Items.Add(listItem);
            }
        }

        private void clearEventFields()
        {
            eventNameTextBox.Clear();
            eventCapacityTextBox.Clear();
            eventAddressControl.Clear();
            eventStartDateTimePicker.Value = DateTime.Now;
            eventEndDateTimePicker.Value = DateTime.Now.AddHours(1);
            eventOrganisationComboBox.SelectedIndex = -1;
            eventProgramComboBox.SelectedIndex = -1;
            eventDescriptionTextBox.Clear();
            eventContacts.Clear();
            eventSaveButton.Enabled = false;
            eventDeleteButton.Enabled = false;
        }

        private void populateEventFields(Event cmsEvent)
        {
            clearEventFields();
            eventNameTextBox.Text = cmsEvent.Name;
            eventCapacityTextBox.Text = cmsEvent.Capacity.ToString();
            eventAddressControl.Populate(cmsEvent.Address);
            if (cmsEvent.StartTime > DateTime.MinValue && cmsEvent.StartTime < DateTime.MaxValue)
            {
                eventStartDateTimePicker.Value = cmsEvent.StartTime;
            }
            if (cmsEvent.EndTime > DateTime.MinValue && cmsEvent.EndTime < DateTime.MaxValue)
            {
                eventEndDateTimePicker.Value = cmsEvent.EndTime;
            }
            eventOrganisationComboBox.SelectedIndex = organisations.IndexOf(cmsEvent.Organisation);
            eventProgramComboBox.SelectedIndex = programs.IndexOf(cmsEvent.Program);
            eventDescriptionTextBox.Text = cmsEvent.Description;
            eventContacts.Populate(cmsEvent.Contacts);
            eventSaveButton.Enabled = true;
            eventDeleteButton.Enabled = true;
        }

        private void eventSaveButton_Click(object sender, EventArgs e)
        {
            saveEvent(activeEvent);
            refreshEventListView();
            populateEventFields(activeEvent);
        }

        private void saveEvent(Event cmsEvent)
        {
            cmsEvent.Name = eventNameTextBox.Text;
            cmsEvent.Capacity = Convert.ToInt32(eventCapacityTextBox.Text);
            cmsEvent.Address = eventAddressControl.GetAddress();
            cmsEvent.StartTime = eventStartDateTimePicker.Value;
            cmsEvent.EndTime = eventEndDateTimePicker.Value;
            cmsEvent.Organisation = (Organisation) eventOrganisationComboBox.SelectedItem;
            cmsEvent.Program = (Programme) eventProgramComboBox.SelectedItem;
            cmsEvent.Description = eventDescriptionTextBox.Text;
            int index = events.IndexOf(cmsEvent);
            if (index == -1)
            {
                events.Add(cmsEvent);
            }
        }

        private void eventDeleteButton_Click(object sender, EventArgs e)
        {
            events.Remove(activeEvent);
            activeEvent.Dispose();
            activeEvent = null;
            refreshEventListView();
            clearEventFields();
        }

        private void eventNewButton_Click(object sender, EventArgs e)
        {
            Event newEvent = new Event();
            events.Add(newEvent);
            activeEvent = newEvent;
            populateEventFields(newEvent);
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = eventListView.SelectedIndices[0];
                activeEvent = events[selectedIndex];
                populateEventFields(activeEvent);
            }
            else
            {
                activeEvent = null;
                clearEventFields();
            }
        }
    }
}
