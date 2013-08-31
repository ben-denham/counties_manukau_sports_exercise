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
            this.eventTabPage = new System.Windows.Forms.TabPage();
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
            this.mainTabControl.SuspendLayout();
            this.organisationsTabPage.SuspendLayout();
            this.programsTabPage.SuspendLayout();
            this.eventTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.organisationsTabPage);
            this.mainTabControl.Controls.Add(this.programsTabPage);
            this.mainTabControl.Controls.Add(this.eventTabPage);
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
            // eventTabPage
            // 
            this.eventTabPage.Controls.Add(this.eventDescriptionTextBox);
            this.eventTabPage.Controls.Add(this.eventDescriptionLabel);
            this.eventTabPage.Controls.Add(this.eventNewButton);
            this.eventTabPage.Controls.Add(this.eventDeleteButton);
            this.eventTabPage.Controls.Add(this.eventSaveButton);
            this.eventTabPage.Controls.Add(this.eventEndDateTimePicker);
            this.eventTabPage.Controls.Add(this.eventEndLabel);
            this.eventTabPage.Controls.Add(this.eventProgramComboBox);
            this.eventTabPage.Controls.Add(this.eventOrganisationComboBox);
            this.eventTabPage.Controls.Add(this.eventProgramLabel);
            this.eventTabPage.Controls.Add(this.eventOrganisationLabel);
            this.eventTabPage.Controls.Add(this.eventStartDateTimePicker);
            this.eventTabPage.Controls.Add(this.eventStartLabel);
            this.eventTabPage.Controls.Add(this.eventCapacityTextBox);
            this.eventTabPage.Controls.Add(this.eventCapacityLabel);
            this.eventTabPage.Controls.Add(this.eventNameTextBox);
            this.eventTabPage.Controls.Add(this.eventNameLabel);
            this.eventTabPage.Controls.Add(this.eventContacts);
            this.eventTabPage.Controls.Add(this.eventAddressControl);
            this.eventTabPage.Controls.Add(this.eventListView);
            this.eventTabPage.Location = new System.Drawing.Point(4, 22);
            this.eventTabPage.Name = "eventTabPage";
            this.eventTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventTabPage.Size = new System.Drawing.Size(1076, 556);
            this.eventTabPage.TabIndex = 2;
            this.eventTabPage.Text = "Events";
            this.eventTabPage.UseVisualStyleBackColor = true;
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
            this.eventTabPage.ResumeLayout(false);
            this.eventTabPage.PerformLayout();
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
        private System.Windows.Forms.TabPage eventTabPage;
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
    }
}

