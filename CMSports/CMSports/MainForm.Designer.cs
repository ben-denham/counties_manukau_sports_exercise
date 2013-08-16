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
            this.organisationSaveButton = new System.Windows.Forms.Button();
            this.organisationEventsListView = new System.Windows.Forms.ListView();
            this.organisationSizeTextBox = new System.Windows.Forms.TextBox();
            this.organisationSizeLabel = new System.Windows.Forms.Label();
            this.organisationNameTextBox = new System.Windows.Forms.TextBox();
            this.organisationNameLabel = new System.Windows.Forms.Label();
            this.organisationsListBox = new System.Windows.Forms.ListBox();
            this.organisationDeleteButton = new System.Windows.Forms.Button();
            this.organisationEventsGroupBox = new System.Windows.Forms.GroupBox();
            this.contactsControl1 = new CMSportsControls.ContactsControl();
            this.organisationAddressAddressControl = new CMSportsControls.AddressControl();
            this.mainTabControl.SuspendLayout();
            this.organisationsTabPage.SuspendLayout();
            this.organisationEventsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.organisationsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(664, 660);
            this.mainTabControl.TabIndex = 0;
            // 
            // organisationsTabPage
            // 
            this.organisationsTabPage.Controls.Add(this.contactsControl1);
            this.organisationsTabPage.Controls.Add(this.organisationEventsGroupBox);
            this.organisationsTabPage.Controls.Add(this.organisationDeleteButton);
            this.organisationsTabPage.Controls.Add(this.organisationSaveButton);
            this.organisationsTabPage.Controls.Add(this.organisationSizeTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationSizeLabel);
            this.organisationsTabPage.Controls.Add(this.organisationAddressAddressControl);
            this.organisationsTabPage.Controls.Add(this.organisationNameTextBox);
            this.organisationsTabPage.Controls.Add(this.organisationNameLabel);
            this.organisationsTabPage.Controls.Add(this.organisationsListBox);
            this.organisationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.organisationsTabPage.Name = "organisationsTabPage";
            this.organisationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organisationsTabPage.Size = new System.Drawing.Size(656, 634);
            this.organisationsTabPage.TabIndex = 0;
            this.organisationsTabPage.Text = "Organisations";
            this.organisationsTabPage.UseVisualStyleBackColor = true;
            // 
            // organisationSaveButton
            // 
            this.organisationSaveButton.Location = new System.Drawing.Point(423, 603);
            this.organisationSaveButton.Name = "organisationSaveButton";
            this.organisationSaveButton.Size = new System.Drawing.Size(108, 23);
            this.organisationSaveButton.TabIndex = 8;
            this.organisationSaveButton.Text = "&Save Organisation";
            this.organisationSaveButton.UseVisualStyleBackColor = true;
            // 
            // organisationEventsListView
            // 
            this.organisationEventsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organisationEventsListView.Location = new System.Drawing.Point(3, 16);
            this.organisationEventsListView.Name = "organisationEventsListView";
            this.organisationEventsListView.Size = new System.Drawing.Size(327, 137);
            this.organisationEventsListView.TabIndex = 0;
            this.organisationEventsListView.UseCompatibleStateImageBehavior = false;
            // 
            // organisationSizeTextBox
            // 
            this.organisationSizeTextBox.Location = new System.Drawing.Point(415, 36);
            this.organisationSizeTextBox.Name = "organisationSizeTextBox";
            this.organisationSizeTextBox.Size = new System.Drawing.Size(233, 20);
            this.organisationSizeTextBox.TabIndex = 4;
            // 
            // organisationSizeLabel
            // 
            this.organisationSizeLabel.AutoSize = true;
            this.organisationSizeLabel.Location = new System.Drawing.Point(312, 39);
            this.organisationSizeLabel.Name = "organisationSizeLabel";
            this.organisationSizeLabel.Size = new System.Drawing.Size(89, 13);
            this.organisationSizeLabel.TabIndex = 3;
            this.organisationSizeLabel.Text = "Organisation S&ize";
            // 
            // organisationNameTextBox
            // 
            this.organisationNameTextBox.Location = new System.Drawing.Point(415, 10);
            this.organisationNameTextBox.Name = "organisationNameTextBox";
            this.organisationNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.organisationNameTextBox.TabIndex = 2;
            // 
            // organisationNameLabel
            // 
            this.organisationNameLabel.AutoSize = true;
            this.organisationNameLabel.Location = new System.Drawing.Point(312, 13);
            this.organisationNameLabel.Name = "organisationNameLabel";
            this.organisationNameLabel.Size = new System.Drawing.Size(97, 13);
            this.organisationNameLabel.TabIndex = 1;
            this.organisationNameLabel.Text = "Organisation &Name";
            // 
            // organisationsListBox
            // 
            this.organisationsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.organisationsListBox.FormattingEnabled = true;
            this.organisationsListBox.Location = new System.Drawing.Point(3, 3);
            this.organisationsListBox.Name = "organisationsListBox";
            this.organisationsListBox.Size = new System.Drawing.Size(306, 628);
            this.organisationsListBox.TabIndex = 0;
            // 
            // organisationDeleteButton
            // 
            this.organisationDeleteButton.Location = new System.Drawing.Point(537, 603);
            this.organisationDeleteButton.Name = "organisationDeleteButton";
            this.organisationDeleteButton.Size = new System.Drawing.Size(108, 23);
            this.organisationDeleteButton.TabIndex = 9;
            this.organisationDeleteButton.Text = "&Delete Organisation";
            this.organisationDeleteButton.UseVisualStyleBackColor = true;
            // 
            // organisationEventsGroupBox
            // 
            this.organisationEventsGroupBox.Controls.Add(this.organisationEventsListView);
            this.organisationEventsGroupBox.Location = new System.Drawing.Point(315, 444);
            this.organisationEventsGroupBox.Name = "organisationEventsGroupBox";
            this.organisationEventsGroupBox.Size = new System.Drawing.Size(333, 156);
            this.organisationEventsGroupBox.TabIndex = 7;
            this.organisationEventsGroupBox.TabStop = false;
            this.organisationEventsGroupBox.Text = "&Events";
            // 
            // contactsControl1
            // 
            this.contactsControl1.Location = new System.Drawing.Point(315, 204);
            this.contactsControl1.Name = "contactsControl1";
            this.contactsControl1.Size = new System.Drawing.Size(333, 234);
            this.contactsControl1.TabIndex = 6;
            // 
            // organisationAddressAddressControl
            // 
            this.organisationAddressAddressControl.Location = new System.Drawing.Point(315, 62);
            this.organisationAddressAddressControl.Name = "organisationAddressAddressControl";
            this.organisationAddressAddressControl.Size = new System.Drawing.Size(333, 136);
            this.organisationAddressAddressControl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AcceptButton = this.organisationSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 660);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Counties Manukau Sports";
            this.mainTabControl.ResumeLayout(false);
            this.organisationsTabPage.ResumeLayout(false);
            this.organisationsTabPage.PerformLayout();
            this.organisationEventsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage organisationsTabPage;
        private System.Windows.Forms.ListBox organisationsListBox;
        private System.Windows.Forms.TextBox organisationNameTextBox;
        private System.Windows.Forms.Label organisationNameLabel;
        private CMSportsControls.AddressControl organisationAddressAddressControl;
        private System.Windows.Forms.TextBox organisationSizeTextBox;
        private System.Windows.Forms.Label organisationSizeLabel;
        private System.Windows.Forms.Button organisationSaveButton;
        private System.Windows.Forms.ListView organisationEventsListView;
        private System.Windows.Forms.Button organisationDeleteButton;
        private System.Windows.Forms.GroupBox organisationEventsGroupBox;
        private CMSportsControls.ContactsControl contactsControl1;
    }
}

