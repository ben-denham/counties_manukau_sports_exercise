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
            this.organisationContacts = new CMSportsControls.ContactsControl();
            this.organisationEventsGroupBox = new System.Windows.Forms.GroupBox();
            this.organisationEventsListView = new System.Windows.Forms.ListView();
            this.organisationDeleteButton = new System.Windows.Forms.Button();
            this.organisationSaveButton = new System.Windows.Forms.Button();
            this.organisationSizeTextBox = new System.Windows.Forms.TextBox();
            this.organisationSizeLabel = new System.Windows.Forms.Label();
            this.organisationAddressAddressControl = new CMSportsControls.AddressControl();
            this.organisationNameTextBox = new System.Windows.Forms.TextBox();
            this.organisationNameLabel = new System.Windows.Forms.Label();
            this.programsTabPage = new System.Windows.Forms.TabPage();
            this.programNewButton = new System.Windows.Forms.Button();
            this.programDeleteButton = new System.Windows.Forms.Button();
            this.programSaveButton = new System.Windows.Forms.Button();
            this.programEventsGroupBox = new System.Windows.Forms.GroupBox();
            this.programEventsListView = new System.Windows.Forms.ListView();
            this.programDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.programContacts = new CMSportsControls.ContactsControl();
            this.programListView = new System.Windows.Forms.ListView();
            this.programNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTabPage = new System.Windows.Forms.TabPage();
            this.eventListView = new System.Windows.Forms.ListView();
            this.eventNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventOrganisationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventProgramColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainTabControl.SuspendLayout();
            this.organisationsTabPage.SuspendLayout();
            this.organisationEventsGroupBox.SuspendLayout();
            this.programsTabPage.SuspendLayout();
            this.programEventsGroupBox.SuspendLayout();
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
            // 
            // organisationsTabPage
            // 
            this.organisationsTabPage.Controls.Add(this.organisationTypeTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationTypeLabel);
            this.organisationsTabPage.Controls.Add(this.organisationListView);
            this.organisationsTabPage.Controls.Add(this.newClubButton);
            this.organisationsTabPage.Controls.Add(this.newSchoolButton);
            this.organisationsTabPage.Controls.Add(this.organisationContacts);
            this.organisationsTabPage.Controls.Add(this.organisationEventsGroupBox);
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
            // organisationContacts
            // 
            this.organisationContacts.Location = new System.Drawing.Point(398, 148);
            this.organisationContacts.Name = "organisationContacts";
            this.organisationContacts.Size = new System.Drawing.Size(672, 234);
            this.organisationContacts.TabIndex = 6;
            // 
            // organisationEventsGroupBox
            // 
            this.organisationEventsGroupBox.Controls.Add(this.organisationEventsListView);
            this.organisationEventsGroupBox.Location = new System.Drawing.Point(398, 388);
            this.organisationEventsGroupBox.Name = "organisationEventsGroupBox";
            this.organisationEventsGroupBox.Size = new System.Drawing.Size(672, 162);
            this.organisationEventsGroupBox.TabIndex = 7;
            this.organisationEventsGroupBox.TabStop = false;
            this.organisationEventsGroupBox.Text = "&Events";
            // 
            // organisationEventsListView
            // 
            this.organisationEventsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organisationEventsListView.Location = new System.Drawing.Point(3, 16);
            this.organisationEventsListView.Name = "organisationEventsListView";
            this.organisationEventsListView.Size = new System.Drawing.Size(666, 143);
            this.organisationEventsListView.TabIndex = 0;
            this.organisationEventsListView.UseCompatibleStateImageBehavior = false;
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
            // organisationAddressAddressControl
            // 
            this.organisationAddressAddressControl.Location = new System.Drawing.Point(737, 6);
            this.organisationAddressAddressControl.Name = "organisationAddressAddressControl";
            this.organisationAddressAddressControl.Size = new System.Drawing.Size(333, 136);
            this.organisationAddressAddressControl.TabIndex = 5;
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
            this.programsTabPage.Controls.Add(this.programNewButton);
            this.programsTabPage.Controls.Add(this.programDeleteButton);
            this.programsTabPage.Controls.Add(this.programSaveButton);
            this.programsTabPage.Controls.Add(this.programEventsGroupBox);
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
            this.programNewButton.TabIndex = 11;
            this.programNewButton.Text = "&New Program";
            this.programNewButton.UseVisualStyleBackColor = true;
            this.programNewButton.Click += new System.EventHandler(this.programNewButton_Click);
            // 
            // programDeleteButton
            // 
            this.programDeleteButton.Location = new System.Drawing.Point(826, 6);
            this.programDeleteButton.Name = "programDeleteButton";
            this.programDeleteButton.Size = new System.Drawing.Size(113, 23);
            this.programDeleteButton.TabIndex = 10;
            this.programDeleteButton.Text = "&Delete Program";
            this.programDeleteButton.UseVisualStyleBackColor = true;
            this.programDeleteButton.Click += new System.EventHandler(this.programDeleteButton_Click);
            // 
            // programSaveButton
            // 
            this.programSaveButton.Location = new System.Drawing.Point(697, 6);
            this.programSaveButton.Name = "programSaveButton";
            this.programSaveButton.Size = new System.Drawing.Size(113, 23);
            this.programSaveButton.TabIndex = 9;
            this.programSaveButton.Text = "&Save Program";
            this.programSaveButton.UseVisualStyleBackColor = true;
            this.programSaveButton.Click += new System.EventHandler(this.programSaveButton_Click);
            // 
            // programEventsGroupBox
            // 
            this.programEventsGroupBox.Controls.Add(this.programEventsListView);
            this.programEventsGroupBox.Location = new System.Drawing.Point(398, 388);
            this.programEventsGroupBox.Name = "programEventsGroupBox";
            this.programEventsGroupBox.Size = new System.Drawing.Size(672, 162);
            this.programEventsGroupBox.TabIndex = 8;
            this.programEventsGroupBox.TabStop = false;
            this.programEventsGroupBox.Text = "&Events";
            // 
            // programEventsListView
            // 
            this.programEventsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programEventsListView.Location = new System.Drawing.Point(3, 16);
            this.programEventsListView.Name = "programEventsListView";
            this.programEventsListView.Size = new System.Drawing.Size(666, 143);
            this.programEventsListView.TabIndex = 0;
            this.programEventsListView.UseCompatibleStateImageBehavior = false;
            // 
            // programDescriptionTextBox
            // 
            this.programDescriptionTextBox.Location = new System.Drawing.Point(401, 45);
            this.programDescriptionTextBox.Multiline = true;
            this.programDescriptionTextBox.Name = "programDescriptionTextBox";
            this.programDescriptionTextBox.Size = new System.Drawing.Size(667, 97);
            this.programDescriptionTextBox.TabIndex = 5;
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(398, 29);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(102, 13);
            this.programDescriptionLabel.TabIndex = 4;
            this.programDescriptionLabel.Text = "Program D&escription";
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Location = new System.Drawing.Point(481, 6);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.programNameTextBox.TabIndex = 3;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(398, 9);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(77, 13);
            this.programNameLabel.TabIndex = 2;
            this.programNameLabel.Text = "Program &Name";
            // 
            // programContacts
            // 
            this.programContacts.Location = new System.Drawing.Point(398, 148);
            this.programContacts.Name = "programContacts";
            this.programContacts.Size = new System.Drawing.Size(672, 234);
            this.programContacts.TabIndex = 1;
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
            this.eventTabPage.Controls.Add(this.eventListView);
            this.eventTabPage.Location = new System.Drawing.Point(4, 22);
            this.eventTabPage.Name = "eventTabPage";
            this.eventTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventTabPage.Size = new System.Drawing.Size(1076, 556);
            this.eventTabPage.TabIndex = 2;
            this.eventTabPage.Text = "Events";
            this.eventTabPage.UseVisualStyleBackColor = true;
            // 
            // eventListView
            // 
            this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventNameColumnHeader,
            this.eventDateColumnHeader,
            this.eventOrganisationColumnHeader,
            this.eventProgramColumnHeader});
            this.eventListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventListView.FullRowSelect = true;
            this.eventListView.Location = new System.Drawing.Point(3, 3);
            this.eventListView.Name = "eventListView";
            this.eventListView.Size = new System.Drawing.Size(389, 550);
            this.eventListView.TabIndex = 1;
            this.eventListView.UseCompatibleStateImageBehavior = false;
            this.eventListView.View = System.Windows.Forms.View.Details;
            // 
            // eventNameColumnHeader
            // 
            this.eventNameColumnHeader.Text = "Name";
            this.eventNameColumnHeader.Width = 100;
            // 
            // eventDateColumnHeader
            // 
            this.eventDateColumnHeader.Text = "Date";
            this.eventDateColumnHeader.Width = 95;
            // 
            // eventOrganisationColumnHeader
            // 
            this.eventOrganisationColumnHeader.Text = "Organisation";
            this.eventOrganisationColumnHeader.Width = 95;
            // 
            // eventProgramColumnHeader
            // 
            this.eventProgramColumnHeader.Text = "Program";
            this.eventProgramColumnHeader.Width = 95;
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
            this.organisationEventsGroupBox.ResumeLayout(false);
            this.programsTabPage.ResumeLayout(false);
            this.programsTabPage.PerformLayout();
            this.programEventsGroupBox.ResumeLayout(false);
            this.eventTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.ListView organisationEventsListView;
        private System.Windows.Forms.Button organisationDeleteButton;
        private System.Windows.Forms.GroupBox organisationEventsGroupBox;
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
        private System.Windows.Forms.GroupBox programEventsGroupBox;
        private System.Windows.Forms.ListView programEventsListView;
        private System.Windows.Forms.Button programDeleteButton;
        private System.Windows.Forms.Button programSaveButton;
        private System.Windows.Forms.Button programNewButton;
        private System.Windows.Forms.TabPage eventTabPage;
        private System.Windows.Forms.ListView eventListView;
        private System.Windows.Forms.ColumnHeader eventNameColumnHeader;
        private System.Windows.Forms.ColumnHeader eventDateColumnHeader;
        private System.Windows.Forms.ColumnHeader eventOrganisationColumnHeader;
        private System.Windows.Forms.ColumnHeader eventProgramColumnHeader;
    }
}

