namespace CMSports
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.organisationsTabPage = new System.Windows.Forms.TabPage();
            this.organisationTypeTextBox = new System.Windows.Forms.TextBox();
            this.organisationTypeLabel = new System.Windows.Forms.Label();
            this.organisationListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newClubButton = new System.Windows.Forms.Button();
            this.newSchoolButton = new System.Windows.Forms.Button();
            this.organisationDeleteButton = new System.Windows.Forms.Button();
            this.organisationSaveButton = new System.Windows.Forms.Button();
            this.organisationSizeTextBox = new System.Windows.Forms.TextBox();
            this.organisationSizeLabel = new System.Windows.Forms.Label();
            this.organisationNameTextBox = new System.Windows.Forms.TextBox();
            this.organisationNameLabel = new System.Windows.Forms.Label();
            this.programsTabPage = new System.Windows.Forms.TabPage();
            this.programNewButton = new System.Windows.Forms.Button();
            this.programDeleteButton = new System.Windows.Forms.Button();
            this.programSaveButton = new System.Windows.Forms.Button();
            this.programDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programListView = new System.Windows.Forms.ListView();
            this.programNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventsTabPage = new System.Windows.Forms.TabPage();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.eventNewButton = new System.Windows.Forms.Button();
            this.eventDeleteButton = new System.Windows.Forms.Button();
            this.eventSaveButton = new System.Windows.Forms.Button();
            this.eventEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventEndLabel = new System.Windows.Forms.Label();
            this.eventProgramComboBox = new System.Windows.Forms.ComboBox();
            this.eventOrganisationComboBox = new System.Windows.Forms.ComboBox();
            this.eventProgramLabel = new System.Windows.Forms.Label();
            this.eventOrganisationLabel = new System.Windows.Forms.Label();
            this.eventStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventStartLabel = new System.Windows.Forms.Label();
            this.eventCapacityTextBox = new System.Windows.Forms.TextBox();
            this.eventCapacityLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventOrganisationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventProgramColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organisationEventListView = new CMSportsControls.EventListView();
            this.organisationContacts = new CMSportsControls.ContactsControl();
            this.organisationAddressAddressControl = new CMSportsControls.AddressControl();
            this.programEventListView = new CMSportsControls.EventListView();
            this.programContacts = new CMSportsControls.ContactsControl();
            this.eventContacts = new CMSportsControls.ContactsControl();
            this.eventAddressControl = new CMSportsControls.AddressControl();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfOrgsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.averageNumberOfEventsPerOrgTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numberOfClubsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.averageOrgSizeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.averageClubSizeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.largestClubTextBox = new System.Windows.Forms.TextBox();
            this.organisationGroupBox = new System.Windows.Forms.GroupBox();
            this.programGroupBox = new System.Windows.Forms.GroupBox();
            this.eventGroupBox = new System.Windows.Forms.GroupBox();
            this.schoolGroupBox = new System.Windows.Forms.GroupBox();
            this.clubGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.smallestClubTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.organisationsTabPage.SuspendLayout();
            this.programsTabPage.SuspendLayout();
            this.eventsTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            this.organisationGroupBox.SuspendLayout();
            this.programGroupBox.SuspendLayout();
            this.eventGroupBox.SuspendLayout();
            this.schoolGroupBox.SuspendLayout();
            this.clubGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.organisationsTabPage);
            this.mainTabControl.Controls.Add(this.programsTabPage);
            this.mainTabControl.Controls.Add(this.eventsTabPage);
            this.mainTabControl.Controls.Add(this.reportsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1084, 582);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // organisationsTabPage
            // 
            this.organisationsTabPage.Controls.Add(this.organisationEventListView);
            this.organisationsTabPage.Controls.Add(this.organisationTypeTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationTypeLabel);
            this.organisationsTabPage.Controls.Add(this.organisationListView);
            this.organisationsTabPage.Controls.Add(this.newClubButton);
            this.organisationsTabPage.Controls.Add(this.newSchoolButton);
            this.organisationsTabPage.Controls.Add(this.organisationContacts);
            this.organisationsTabPage.Controls.Add(this.organisationDeleteButton);
            this.organisationsTabPage.Controls.Add(this.organisationSaveButton);
            this.organisationsTabPage.Controls.Add(this.organisationSizeTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationSizeLabel);
            this.organisationsTabPage.Controls.Add(this.organisationAddressAddressControl);
            this.organisationsTabPage.Controls.Add(this.organisationNameTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationNameLabel);
            this.organisationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.organisationsTabPage.Name = "organisationsTabPage";
            this.organisationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organisationsTabPage.Size = new System.Drawing.Size(1076, 556);
            this.organisationsTabPage.TabIndex = 0;
            this.organisationsTabPage.Text = "Organisations";
            this.organisationsTabPage.UseVisualStyleBackColor = true;
            // 
            // organisationTypeTextBox
            // 
            this.organisationTypeTextBox.Location = new System.Drawing.Point(498, 32);
            this.organisationTypeTextBox.Name = "organisationTypeTextBox";
            this.organisationTypeTextBox.ReadOnly = true;
            this.organisationTypeTextBox.Size = new System.Drawing.Size(233, 20);
            this.organisationTypeTextBox.TabIndex = 14;
            // 
            // organisationTypeLabel
            // 
            this.organisationTypeLabel.AutoSize = true;
            this.organisationTypeLabel.Location = new System.Drawing.Point(395, 35);
            this.organisationTypeLabel.Name = "organisationTypeLabel";
            this.organisationTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.organisationTypeLabel.TabIndex = 13;
            this.organisationTypeLabel.Text = "Organisation Type";
            // 
            // organisationListView
            // 
            this.organisationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.typeColumnHeader,
            this.sizeColumnHeader});
            this.organisationListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.organisationListView.FullRowSelect = true;
            this.organisationListView.Location = new System.Drawing.Point(3, 3);
            this.organisationListView.MultiSelect = false;
            this.organisationListView.Name = "organisationListView";
            this.organisationListView.Size = new System.Drawing.Size(389, 550);
            this.organisationListView.TabIndex = 12;
            this.organisationListView.UseCompatibleStateImageBehavior = false;
            this.organisationListView.View = System.Windows.Forms.View.Details;
            this.organisationListView.SelectedIndexChanged += new System.EventHandler(this.organisationListView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 200;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 105;
            // 
            // sizeColumnHeader
            // 
            this.sizeColumnHeader.Text = "Size";
            this.sizeColumnHeader.Width = 80;
            // 
            // newClubButton
            // 
            this.newClubButton.Location = new System.Drawing.Point(573, 119);
            this.newClubButton.Name = "newClubButton";
            this.newClubButton.Size = new System.Drawing.Size(158, 23);
            this.newClubButton.TabIndex = 11;
            this.newClubButton.Text = "New Clu&b";
            this.newClubButton.UseVisualStyleBackColor = true;
            this.newClubButton.Click += new System.EventHandler(this.newClubButton_Click);
            // 
            // newSchoolButton
            // 
            this.newSchoolButton.Location = new System.Drawing.Point(573, 90);
            this.newSchoolButton.Name = "newSchoolButton";
            this.newSchoolButton.Size = new System.Drawing.Size(158, 23);
            this.newSchoolButton.TabIndex = 10;
            this.newSchoolButton.Text = "New Sc&hool";
            this.newSchoolButton.UseVisualStyleBackColor = true;
            this.newSchoolButton.Click += new System.EventHandler(this.newSchoolButton_Click);
            // 
            // organisationDeleteButton
            // 
            this.organisationDeleteButton.Enabled = false;
            this.organisationDeleteButton.Location = new System.Drawing.Point(398, 119);
            this.organisationDeleteButton.Name = "organisationDeleteButton";
            this.organisationDeleteButton.Size = new System.Drawing.Size(158, 23);
            this.organisationDeleteButton.TabIndex = 9;
            this.organisationDeleteButton.Text = "&Delete Organisation";
            this.organisationDeleteButton.UseVisualStyleBackColor = true;
            this.organisationDeleteButton.Click += new System.EventHandler(this.organisationDeleteButton_Click);
            // 
            // organisationSaveButton
            // 
            this.organisationSaveButton.Enabled = false;
            this.organisationSaveButton.Location = new System.Drawing.Point(398, 90);
            this.organisationSaveButton.Name = "organisationSaveButton";
            this.organisationSaveButton.Size = new System.Drawing.Size(158, 23);
            this.organisationSaveButton.TabIndex = 8;
            this.organisationSaveButton.Text = "&Save Organisation";
            this.organisationSaveButton.UseVisualStyleBackColor = true;
            this.organisationSaveButton.Click += new System.EventHandler(this.organisationSaveButton_Click);
            // 
            // organisationSizeTextBox
            // 
            this.organisationSizeTextBox.Location = new System.Drawing.Point(498, 58);
            this.organisationSizeTextBox.Name = "organisationSizeTextBox";
            this.organisationSizeTextBox.Size = new System.Drawing.Size(233, 20);
            this.organisationSizeTextBox.TabIndex = 4;
            // 
            // organisationSizeLabel
            // 
            this.organisationSizeLabel.AutoSize = true;
            this.organisationSizeLabel.Location = new System.Drawing.Point(395, 61);
            this.organisationSizeLabel.Name = "organisationSizeLabel";
            this.organisationSizeLabel.Size = new System.Drawing.Size(89, 13);
            this.organisationSizeLabel.TabIndex = 3;
            this.organisationSizeLabel.Text = "Organisation S&ize";
            // 
            // organisationNameTextBox
            // 
            this.organisationNameTextBox.Location = new System.Drawing.Point(498, 6);
            this.organisationNameTextBox.Name = "organisationNameTextBox";
            this.organisationNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.organisationNameTextBox.TabIndex = 2;
            // 
            // organisationNameLabel
            // 
            this.organisationNameLabel.AutoSize = true;
            this.organisationNameLabel.Location = new System.Drawing.Point(395, 9);
            this.organisationNameLabel.Name = "organisationNameLabel";
            this.organisationNameLabel.Size = new System.Drawing.Size(97, 13);
            this.organisationNameLabel.TabIndex = 1;
            this.organisationNameLabel.Text = "Organisation &Name";
            // 
            // programsTabPage
            // 
            this.programsTabPage.Controls.Add(this.programEventListView);
            this.programsTabPage.Controls.Add(this.programNewButton);
            this.programsTabPage.Controls.Add(this.programDeleteButton);
            this.programsTabPage.Controls.Add(this.programSaveButton);
            this.programsTabPage.Controls.Add(this.programDescriptionTextBox);
            this.programsTabPage.Controls.Add(this.programDescriptionLabel);
            this.programsTabPage.Controls.Add(this.programNameTextBox);
            this.programsTabPage.Controls.Add(this.programNameLabel);
            this.programsTabPage.Controls.Add(this.programContacts);
            this.programsTabPage.Controls.Add(this.programListView);
            this.programsTabPage.Location = new System.Drawing.Point(4, 22);
            this.programsTabPage.Name = "programsTabPage";
            this.programsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.programsTabPage.Size = new System.Drawing.Size(1076, 556);
            this.programsTabPage.TabIndex = 1;
            this.programsTabPage.Text = "Programs";
            this.programsTabPage.UseVisualStyleBackColor = true;
            // 
            // programNewButton
            // 
            this.programNewButton.Location = new System.Drawing.Point(954, 6);
            this.programNewButton.Name = "programNewButton";
            this.programNewButton.Size = new System.Drawing.Size(113, 23);
            this.programNewButton.TabIndex = 9;
            this.programNewButton.Text = "&New Program";
            this.programNewButton.UseVisualStyleBackColor = true;
            this.programNewButton.Click += new System.EventHandler(this.programNewButton_Click);
            // 
            // programDeleteButton
            // 
            this.programDeleteButton.Enabled = false;
            this.programDeleteButton.Location = new System.Drawing.Point(826, 6);
            this.programDeleteButton.Name = "programDeleteButton";
            this.programDeleteButton.Size = new System.Drawing.Size(113, 23);
            this.programDeleteButton.TabIndex = 8;
            this.programDeleteButton.Text = "&Delete Program";
            this.programDeleteButton.UseVisualStyleBackColor = true;
            this.programDeleteButton.Click += new System.EventHandler(this.programDeleteButton_Click);
            // 
            // programSaveButton
            // 
            this.programSaveButton.Enabled = false;
            this.programSaveButton.Location = new System.Drawing.Point(697, 6);
            this.programSaveButton.Name = "programSaveButton";
            this.programSaveButton.Size = new System.Drawing.Size(113, 23);
            this.programSaveButton.TabIndex = 7;
            this.programSaveButton.Text = "&Save Program";
            this.programSaveButton.UseVisualStyleBackColor = true;
            this.programSaveButton.Click += new System.EventHandler(this.programSaveButton_Click);
            // 
            // programDescriptionTextBox
            // 
            this.programDescriptionTextBox.Location = new System.Drawing.Point(401, 45);
            this.programDescriptionTextBox.Multiline = true;
            this.programDescriptionTextBox.Name = "programDescriptionTextBox";
            this.programDescriptionTextBox.Size = new System.Drawing.Size(667, 97);
            this.programDescriptionTextBox.TabIndex = 4;
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(398, 29);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(102, 13);
            this.programDescriptionLabel.TabIndex = 3;
            this.programDescriptionLabel.Text = "Program D&escription";
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Location = new System.Drawing.Point(481, 6);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.programNameTextBox.TabIndex = 2;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(398, 9);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(77, 13);
            this.programNameLabel.TabIndex = 1;
            this.programNameLabel.Text = "Program &Name";
            // 
            // programListView
            // 
            this.programListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.programNameColumnHeader,
            this.programDescriptionColumnHeader});
            this.programListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.programListView.FullRowSelect = true;
            this.programListView.Location = new System.Drawing.Point(3, 3);
            this.programListView.Name = "programListView";
            this.programListView.Size = new System.Drawing.Size(389, 550);
            this.programListView.TabIndex = 0;
            this.programListView.UseCompatibleStateImageBehavior = false;
            this.programListView.View = System.Windows.Forms.View.Details;
            this.programListView.SelectedIndexChanged += new System.EventHandler(this.programListView_SelectedIndexChanged);
            // 
            // programNameColumnHeader
            // 
            this.programNameColumnHeader.Text = "Name";
            this.programNameColumnHeader.Width = 150;
            // 
            // programDescriptionColumnHeader
            // 
            this.programDescriptionColumnHeader.Text = "Description";
            this.programDescriptionColumnHeader.Width = 235;
            // 
            // eventsTabPage
            // 
            this.eventsTabPage.Controls.Add(this.eventDescriptionTextBox);
            this.eventsTabPage.Controls.Add(this.eventDescriptionLabel);
            this.eventsTabPage.Controls.Add(this.eventNewButton);
            this.eventsTabPage.Controls.Add(this.eventDeleteButton);
            this.eventsTabPage.Controls.Add(this.eventSaveButton);
            this.eventsTabPage.Controls.Add(this.eventEndDateTimePicker);
            this.eventsTabPage.Controls.Add(this.eventEndLabel);
            this.eventsTabPage.Controls.Add(this.eventProgramComboBox);
            this.eventsTabPage.Controls.Add(this.eventOrganisationComboBox);
            this.eventsTabPage.Controls.Add(this.eventProgramLabel);
            this.eventsTabPage.Controls.Add(this.eventOrganisationLabel);
            this.eventsTabPage.Controls.Add(this.eventStartDateTimePicker);
            this.eventsTabPage.Controls.Add(this.eventStartLabel);
            this.eventsTabPage.Controls.Add(this.eventCapacityTextBox);
            this.eventsTabPage.Controls.Add(this.eventCapacityLabel);
            this.eventsTabPage.Controls.Add(this.eventNameTextBox);
            this.eventsTabPage.Controls.Add(this.eventNameLabel);
            this.eventsTabPage.Controls.Add(this.eventContacts);
            this.eventsTabPage.Controls.Add(this.eventAddressControl);
            this.eventsTabPage.Controls.Add(this.eventListView);
            this.eventsTabPage.Location = new System.Drawing.Point(4, 22);
            this.eventsTabPage.Name = "eventsTabPage";
            this.eventsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventsTabPage.Size = new System.Drawing.Size(1076, 556);
            this.eventsTabPage.TabIndex = 2;
            this.eventsTabPage.Text = "Events";
            this.eventsTabPage.UseVisualStyleBackColor = true;
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(401, 183);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(667, 96);
            this.eventDescriptionTextBox.TabIndex = 19;
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(398, 167);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.eventDescriptionLabel.TabIndex = 18;
            this.eventDescriptionLabel.Text = "Event D&escription";
            // 
            // eventNewButton
            // 
            this.eventNewButton.Location = new System.Drawing.Point(979, 525);
            this.eventNewButton.Name = "eventNewButton";
            this.eventNewButton.Size = new System.Drawing.Size(89, 23);
            this.eventNewButton.TabIndex = 17;
            this.eventNewButton.Text = "&New Event";
            this.eventNewButton.UseVisualStyleBackColor = true;
            this.eventNewButton.Click += new System.EventHandler(this.eventNewButton_Click);
            // 
            // eventDeleteButton
            // 
            this.eventDeleteButton.Enabled = false;
            this.eventDeleteButton.Location = new System.Drawing.Point(884, 525);
            this.eventDeleteButton.Name = "eventDeleteButton";
            this.eventDeleteButton.Size = new System.Drawing.Size(89, 23);
            this.eventDeleteButton.TabIndex = 16;
            this.eventDeleteButton.Text = "&Delete Event";
            this.eventDeleteButton.UseVisualStyleBackColor = false;
            this.eventDeleteButton.Click += new System.EventHandler(this.eventDeleteButton_Click);
            // 
            // eventSaveButton
            // 
            this.eventSaveButton.Enabled = false;
            this.eventSaveButton.Location = new System.Drawing.Point(789, 525);
            this.eventSaveButton.Name = "eventSaveButton";
            this.eventSaveButton.Size = new System.Drawing.Size(89, 23);
            this.eventSaveButton.TabIndex = 15;
            this.eventSaveButton.Text = "&Save Event";
            this.eventSaveButton.UseVisualStyleBackColor = true;
            this.eventSaveButton.Click += new System.EventHandler(this.eventSaveButton_Click);
            // 
            // eventEndDateTimePicker
            // 
            this.eventEndDateTimePicker.Checked = false;
            this.eventEndDateTimePicker.CustomFormat = "HH:mm ttMMMMdd, yyyy";
            this.eventEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventEndDateTimePicker.Location = new System.Drawing.Point(498, 90);
            this.eventEndDateTimePicker.Name = "eventEndDateTimePicker";
            this.eventEndDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.eventEndDateTimePicker.TabIndex = 8;
            // 
            // eventEndLabel
            // 
            this.eventEndLabel.AutoSize = true;
            this.eventEndLabel.Location = new System.Drawing.Point(398, 93);
            this.eventEndLabel.Name = "eventEndLabel";
            this.eventEndLabel.Size = new System.Drawing.Size(52, 13);
            this.eventEndLabel.TabIndex = 7;
            this.eventEndLabel.Text = "E&nd Time";
            // 
            // eventProgramComboBox
            // 
            this.eventProgramComboBox.DisplayMember = "Name";
            this.eventProgramComboBox.FormattingEnabled = true;
            this.eventProgramComboBox.Location = new System.Drawing.Point(498, 143);
            this.eventProgramComboBox.Name = "eventProgramComboBox";
            this.eventProgramComboBox.Size = new System.Drawing.Size(233, 21);
            this.eventProgramComboBox.TabIndex = 12;
            // 
            // eventOrganisationComboBox
            // 
            this.eventOrganisationComboBox.DisplayMember = "Name";
            this.eventOrganisationComboBox.FormattingEnabled = true;
            this.eventOrganisationComboBox.Location = new System.Drawing.Point(498, 116);
            this.eventOrganisationComboBox.Name = "eventOrganisationComboBox";
            this.eventOrganisationComboBox.Size = new System.Drawing.Size(233, 21);
            this.eventOrganisationComboBox.TabIndex = 10;
            // 
            // eventProgramLabel
            // 
            this.eventProgramLabel.AutoSize = true;
            this.eventProgramLabel.Location = new System.Drawing.Point(398, 146);
            this.eventProgramLabel.Name = "eventProgramLabel";
            this.eventProgramLabel.Size = new System.Drawing.Size(46, 13);
            this.eventProgramLabel.TabIndex = 11;
            this.eventProgramLabel.Text = "&Program";
            // 
            // eventOrganisationLabel
            // 
            this.eventOrganisationLabel.AutoSize = true;
            this.eventOrganisationLabel.Location = new System.Drawing.Point(398, 119);
            this.eventOrganisationLabel.Name = "eventOrganisationLabel";
            this.eventOrganisationLabel.Size = new System.Drawing.Size(66, 13);
            this.eventOrganisationLabel.TabIndex = 9;
            this.eventOrganisationLabel.Text = "&Organisation";
            // 
            // eventStartDateTimePicker
            // 
            this.eventStartDateTimePicker.CustomFormat = "HH:mm ttMMMMdd, yyyy";
            this.eventStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventStartDateTimePicker.Location = new System.Drawing.Point(498, 61);
            this.eventStartDateTimePicker.Name = "eventStartDateTimePicker";
            this.eventStartDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.eventStartDateTimePicker.TabIndex = 6;
            // 
            // eventStartLabel
            // 
            this.eventStartLabel.AutoSize = true;
            this.eventStartLabel.Location = new System.Drawing.Point(398, 64);
            this.eventStartLabel.Name = "eventStartLabel";
            this.eventStartLabel.Size = new System.Drawing.Size(55, 13);
            this.eventStartLabel.TabIndex = 5;
            this.eventStartLabel.Text = "S&tart Time";
            // 
            // eventCapacityTextBox
            // 
            this.eventCapacityTextBox.Location = new System.Drawing.Point(498, 32);
            this.eventCapacityTextBox.Name = "eventCapacityTextBox";
            this.eventCapacityTextBox.Size = new System.Drawing.Size(233, 20);
            this.eventCapacityTextBox.TabIndex = 4;
            // 
            // eventCapacityLabel
            // 
            this.eventCapacityLabel.AutoSize = true;
            this.eventCapacityLabel.Location = new System.Drawing.Point(398, 35);
            this.eventCapacityLabel.Name = "eventCapacityLabel";
            this.eventCapacityLabel.Size = new System.Drawing.Size(48, 13);
            this.eventCapacityLabel.TabIndex = 3;
            this.eventCapacityLabel.Text = "&Capacity";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(498, 6);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(570, 20);
            this.eventNameTextBox.TabIndex = 2;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(398, 9);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(66, 13);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "Event &Name";
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventNameColumnHeader,
            this.eventOrganisationColumnHeader,
            this.eventProgramColumnHeader});
            this.eventListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventListView.FullRowSelect = true;
            this.eventListView.Location = new System.Drawing.Point(3, 3);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(389, 550);
            this.eventListView.TabIndex = 0;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            this.eventListView.SelectedIndexChanged += new System.EventHandler(this.eventListView_SelectedIndexChanged);
            // 
            // eventNameColumnHeader
            // 
            this.eventNameColumnHeader.Text = "Name";
            this.eventNameColumnHeader.Width = 125;
            // 
            // eventOrganisationColumnHeader
            // 
            this.eventOrganisationColumnHeader.Text = "Organisation";
            this.eventOrganisationColumnHeader.Width = 130;
            // 
            // eventProgramColumnHeader
            // 
            this.eventProgramColumnHeader.Text = "Program";
            this.eventProgramColumnHeader.Width = 130;
            // 
            // organisationEventListView
            // 
            this.organisationEventListView.Location = new System.Drawing.Point(398, 388);
            this.organisationEventListView.Name = "organisationEventListView";
            this.organisationEventListView.Size = new System.Drawing.Size(672, 162);
            this.organisationEventListView.TabIndex = 15;
            // 
            // organisationContacts
            // 
            this.organisationContacts.Location = new System.Drawing.Point(398, 148);
            this.organisationContacts.Name = "organisationContacts";
            this.organisationContacts.Size = new System.Drawing.Size(672, 234);
            this.organisationContacts.TabIndex = 6;
            // 
            // organisationAddressAddressControl
            // 
            this.organisationAddressAddressControl.Location = new System.Drawing.Point(737, 6);
            this.organisationAddressAddressControl.Name = "organisationAddressAddressControl";
            this.organisationAddressAddressControl.Size = new System.Drawing.Size(333, 136);
            this.organisationAddressAddressControl.TabIndex = 5;
            // 
            // programEventListView
            // 
            this.programEventListView.Location = new System.Drawing.Point(398, 388);
            this.programEventListView.Name = "programEventListView";
            this.programEventListView.Size = new System.Drawing.Size(672, 162);
            this.programEventListView.TabIndex = 10;
            // 
            // programContacts
            // 
            this.programContacts.Location = new System.Drawing.Point(398, 148);
            this.programContacts.Name = "programContacts";
            this.programContacts.Size = new System.Drawing.Size(672, 234);
            this.programContacts.TabIndex = 5;
            // 
            // eventContacts
            // 
            this.eventContacts.Location = new System.Drawing.Point(398, 285);
            this.eventContacts.Name = "eventContacts";
            this.eventContacts.Size = new System.Drawing.Size(672, 234);
            this.eventContacts.TabIndex = 14;
            // 
            // eventAddressControl
            // 
            this.eventAddressControl.Location = new System.Drawing.Point(737, 28);
            this.eventAddressControl.Name = "eventAddressControl";
            this.eventAddressControl.Size = new System.Drawing.Size(333, 136);
            this.eventAddressControl.TabIndex = 13;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.programGroupBox);
            this.reportsTabPage.Controls.Add(this.organisationGroupBox);
            this.reportsTabPage.Controls.Add(this.eventGroupBox);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(1076, 556);
            this.reportsTabPage.TabIndex = 3;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of organisations";
            // 
            // numberOfOrgsTextBox
            // 
            this.numberOfOrgsTextBox.Location = new System.Drawing.Point(146, 21);
            this.numberOfOrgsTextBox.Name = "numberOfOrgsTextBox";
            this.numberOfOrgsTextBox.ReadOnly = true;
            this.numberOfOrgsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfOrgsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of programs";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of events";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average number of events per organisation";
            // 
            // averageNumberOfEventsPerOrgTextBox
            // 
            this.averageNumberOfEventsPerOrgTextBox.Location = new System.Drawing.Point(479, 21);
            this.averageNumberOfEventsPerOrgTextBox.Name = "averageNumberOfEventsPerOrgTextBox";
            this.averageNumberOfEventsPerOrgTextBox.ReadOnly = true;
            this.averageNumberOfEventsPerOrgTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageNumberOfEventsPerOrgTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Average number of events per program";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(222, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Average length of events";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Longest event";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(123, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Shortest event";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(123, 101);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Number of clubs";
            // 
            // numberOfClubsTextBox
            // 
            this.numberOfClubsTextBox.Location = new System.Drawing.Point(140, 20);
            this.numberOfClubsTextBox.Name = "numberOfClubsTextBox";
            this.numberOfClubsTextBox.ReadOnly = true;
            this.numberOfClubsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfClubsTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of schools";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(123, 27);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Average organisation size";
            // 
            // averageOrgSizeTextBox
            // 
            this.averageOrgSizeTextBox.Location = new System.Drawing.Point(146, 47);
            this.averageOrgSizeTextBox.Name = "averageOrgSizeTextBox";
            this.averageOrgSizeTextBox.ReadOnly = true;
            this.averageOrgSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageOrgSizeTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Average club size";
            // 
            // averageClubSizeTextBox
            // 
            this.averageClubSizeTextBox.Location = new System.Drawing.Point(140, 48);
            this.averageClubSizeTextBox.Name = "averageClubSizeTextBox";
            this.averageClubSizeTextBox.ReadOnly = true;
            this.averageClubSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageClubSizeTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Average school size";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(125, 53);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Largest school";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(125, 79);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Largest club";
            // 
            // largestClubTextBox
            // 
            this.largestClubTextBox.Location = new System.Drawing.Point(140, 74);
            this.largestClubTextBox.Name = "largestClubTextBox";
            this.largestClubTextBox.ReadOnly = true;
            this.largestClubTextBox.Size = new System.Drawing.Size(100, 20);
            this.largestClubTextBox.TabIndex = 1;
            // 
            // organisationGroupBox
            // 
            this.organisationGroupBox.Controls.Add(this.label4);
            this.organisationGroupBox.Controls.Add(this.averageNumberOfEventsPerOrgTextBox);
            this.organisationGroupBox.Controls.Add(this.schoolGroupBox);
            this.organisationGroupBox.Controls.Add(this.clubGroupBox);
            this.organisationGroupBox.Controls.Add(this.label1);
            this.organisationGroupBox.Controls.Add(this.numberOfOrgsTextBox);
            this.organisationGroupBox.Controls.Add(this.label11);
            this.organisationGroupBox.Controls.Add(this.averageOrgSizeTextBox);
            this.organisationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.organisationGroupBox.Name = "organisationGroupBox";
            this.organisationGroupBox.Size = new System.Drawing.Size(1062, 263);
            this.organisationGroupBox.TabIndex = 2;
            this.organisationGroupBox.TabStop = false;
            this.organisationGroupBox.Text = "Organisation Statistics";
            // 
            // programGroupBox
            // 
            this.programGroupBox.Controls.Add(this.label2);
            this.programGroupBox.Controls.Add(this.textBox2);
            this.programGroupBox.Controls.Add(this.label5);
            this.programGroupBox.Controls.Add(this.textBox5);
            this.programGroupBox.Location = new System.Drawing.Point(6, 275);
            this.programGroupBox.Name = "programGroupBox";
            this.programGroupBox.Size = new System.Drawing.Size(549, 275);
            this.programGroupBox.TabIndex = 2;
            this.programGroupBox.TabStop = false;
            this.programGroupBox.Text = "Program Statistics";
            // 
            // eventGroupBox
            // 
            this.eventGroupBox.Controls.Add(this.label3);
            this.eventGroupBox.Controls.Add(this.textBox3);
            this.eventGroupBox.Controls.Add(this.label6);
            this.eventGroupBox.Controls.Add(this.textBox6);
            this.eventGroupBox.Controls.Add(this.label7);
            this.eventGroupBox.Controls.Add(this.label8);
            this.eventGroupBox.Controls.Add(this.textBox7);
            this.eventGroupBox.Controls.Add(this.textBox8);
            this.eventGroupBox.Location = new System.Drawing.Point(561, 275);
            this.eventGroupBox.Name = "eventGroupBox";
            this.eventGroupBox.Size = new System.Drawing.Size(507, 275);
            this.eventGroupBox.TabIndex = 2;
            this.eventGroupBox.TabStop = false;
            this.eventGroupBox.Text = "Event Statistics";
            // 
            // schoolGroupBox
            // 
            this.schoolGroupBox.Controls.Add(this.label10);
            this.schoolGroupBox.Controls.Add(this.textBox10);
            this.schoolGroupBox.Controls.Add(this.label13);
            this.schoolGroupBox.Controls.Add(this.textBox13);
            this.schoolGroupBox.Controls.Add(this.label16);
            this.schoolGroupBox.Controls.Add(this.textBox16);
            this.schoolGroupBox.Controls.Add(this.label14);
            this.schoolGroupBox.Controls.Add(this.textBox14);
            this.schoolGroupBox.Location = new System.Drawing.Point(555, 77);
            this.schoolGroupBox.Name = "schoolGroupBox";
            this.schoolGroupBox.Size = new System.Drawing.Size(501, 180);
            this.schoolGroupBox.TabIndex = 2;
            this.schoolGroupBox.TabStop = false;
            this.schoolGroupBox.Text = "School Statictics";
            // 
            // clubGroupBox
            // 
            this.clubGroupBox.Controls.Add(this.label9);
            this.clubGroupBox.Controls.Add(this.numberOfClubsTextBox);
            this.clubGroupBox.Controls.Add(this.label12);
            this.clubGroupBox.Controls.Add(this.averageClubSizeTextBox);
            this.clubGroupBox.Controls.Add(this.label17);
            this.clubGroupBox.Controls.Add(this.smallestClubTextBox);
            this.clubGroupBox.Controls.Add(this.label15);
            this.clubGroupBox.Controls.Add(this.largestClubTextBox);
            this.clubGroupBox.Location = new System.Drawing.Point(6, 77);
            this.clubGroupBox.Name = "clubGroupBox";
            this.clubGroupBox.Size = new System.Drawing.Size(543, 180);
            this.clubGroupBox.TabIndex = 2;
            this.clubGroupBox.TabStop = false;
            this.clubGroupBox.Text = "Club Statistics";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(125, 104);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Smallest school";
            // 
            // smallestClubTextBox
            // 
            this.smallestClubTextBox.Location = new System.Drawing.Point(140, 101);
            this.smallestClubTextBox.Name = "smallestClubTextBox";
            this.smallestClubTextBox.ReadOnly = true;
            this.smallestClubTextBox.Size = new System.Drawing.Size(100, 20);
            this.smallestClubTextBox.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Smallest club";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 582);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Counties Manukau Sports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.organisationsTabPage.ResumeLayout(false);
            this.organisationsTabPage.PerformLayout();
            this.programsTabPage.ResumeLayout(false);
            this.programsTabPage.PerformLayout();
            this.eventsTabPage.ResumeLayout(false);
            this.eventsTabPage.PerformLayout();
            this.reportsTabPage.ResumeLayout(false);
            this.organisationGroupBox.ResumeLayout(false);
            this.organisationGroupBox.PerformLayout();
            this.programGroupBox.ResumeLayout(false);
            this.programGroupBox.PerformLayout();
            this.eventGroupBox.ResumeLayout(false);
            this.eventGroupBox.PerformLayout();
            this.schoolGroupBox.ResumeLayout(false);
            this.schoolGroupBox.PerformLayout();
            this.clubGroupBox.ResumeLayout(false);
            this.clubGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage organisationsTabPage;
        private System.Windows.Forms.TextBox organisationNameTextBox;
        private System.Windows.Forms.Label organisationNameLabel;
        private CMSportsControls.AddressControl organisationAddressAddressControl;
        private System.Windows.Forms.TextBox organisationSizeTextBox;
        private System.Windows.Forms.Label organisationSizeLabel;
        private System.Windows.Forms.Button organisationSaveButton;
        private System.Windows.Forms.Button organisationDeleteButton;
        private CMSportsControls.ContactsControl organisationContacts;
        private System.Windows.Forms.Button newClubButton;
        private System.Windows.Forms.Button newSchoolButton;
        private System.Windows.Forms.ListView organisationListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader sizeColumnHeader;
        private System.Windows.Forms.TextBox organisationTypeTextBox;
        private System.Windows.Forms.Label organisationTypeLabel;
        private System.Windows.Forms.TabPage programsTabPage;
        private System.Windows.Forms.ListView programListView;
        private System.Windows.Forms.ColumnHeader programNameColumnHeader;
        private System.Windows.Forms.ColumnHeader programDescriptionColumnHeader;
        private System.Windows.Forms.Label programNameLabel;
        private CMSportsControls.ContactsControl programContacts;
        private System.Windows.Forms.TextBox programDescriptionTextBox;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.Button programDeleteButton;
        private System.Windows.Forms.Button programSaveButton;
        private System.Windows.Forms.Button programNewButton;
        private System.Windows.Forms.TabPage eventsTabPage;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader eventNameColumnHeader;
        private System.Windows.Forms.ColumnHeader eventOrganisationColumnHeader;
        private System.Windows.Forms.ColumnHeader eventProgramColumnHeader;
        private CMSportsControls.ContactsControl eventContacts;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label eventNameLabel;
        private CMSportsControls.AddressControl eventAddressControl;
        private System.Windows.Forms.TextBox eventCapacityTextBox;
        private System.Windows.Forms.Label eventCapacityLabel;
        private System.Windows.Forms.Label eventStartLabel;
        private System.Windows.Forms.DateTimePicker eventStartDateTimePicker;
        private System.Windows.Forms.ComboBox eventProgramComboBox;
        private System.Windows.Forms.Label eventProgramLabel;
        private System.Windows.Forms.Label eventOrganisationLabel;
        private System.Windows.Forms.DateTimePicker eventEndDateTimePicker;
        private System.Windows.Forms.Label eventEndLabel;
        private System.Windows.Forms.Button eventNewButton;
        private System.Windows.Forms.Button eventDeleteButton;
        private System.Windows.Forms.Button eventSaveButton;
        private System.Windows.Forms.ComboBox eventOrganisationComboBox;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.Label eventDescriptionLabel;
        private CMSportsControls.EventListView organisationEventListView;
        private CMSportsControls.EventListView programEventListView;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox averageNumberOfEventsPerOrgTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox numberOfOrgsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox programGroupBox;
        private System.Windows.Forms.GroupBox organisationGroupBox;
        private System.Windows.Forms.GroupBox schoolGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.GroupBox clubGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numberOfClubsTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox averageClubSizeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox largestClubTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox averageOrgSizeTextBox;
        private System.Windows.Forms.GroupBox eventGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox smallestClubTextBox;
    }
}

