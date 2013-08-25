namespace CMSportsControls
{
    partial class ContactsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contactsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homePhoneColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workPhoneColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsGroupBox
            // 
            this.contactsGroupBox.Controls.Add(this.removeButton);
            this.contactsGroupBox.Controls.Add(this.editButton);
            this.contactsGroupBox.Controls.Add(this.addButton);
            this.contactsGroupBox.Controls.Add(this.contactsListView);
            this.contactsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.contactsGroupBox.Name = "contactsGroupBox";
            this.contactsGroupBox.Size = new System.Drawing.Size(672, 234);
            this.contactsGroupBox.TabIndex = 0;
            this.contactsGroupBox.TabStop = false;
            this.contactsGroupBox.Text = "&Contacts";
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(571, 205);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(95, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remo&ve Contact";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(470, 205);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit C&ontact";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(369, 205);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ne&w Contact";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // contactsListView
            // 
            this.contactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.emailColumnHeader,
            this.addressColumnHeader,
            this.homePhoneColumnHeader,
            this.workPhoneColumnHeader});
            this.contactsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactsListView.FullRowSelect = true;
            this.contactsListView.Location = new System.Drawing.Point(3, 16);
            this.contactsListView.MultiSelect = false;
            this.contactsListView.Name = "contactsListView";
            this.contactsListView.Size = new System.Drawing.Size(666, 183);
            this.contactsListView.TabIndex = 0;
            this.contactsListView.UseCompatibleStateImageBehavior = false;
            this.contactsListView.View = System.Windows.Forms.View.Details;
            this.contactsListView.SelectedIndexChanged += new System.EventHandler(this.contactsListView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 120;
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            this.emailColumnHeader.Width = 120;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.Width = 210;
            // 
            // homePhoneColumnHeader
            // 
            this.homePhoneColumnHeader.Text = "Home Phone";
            this.homePhoneColumnHeader.Width = 106;
            // 
            // workPhoneColumnHeader
            // 
            this.workPhoneColumnHeader.Text = "Work Phone";
            this.workPhoneColumnHeader.Width = 106;
            // 
            // ContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactsGroupBox);
            this.Name = "ContactsControl";
            this.Size = new System.Drawing.Size(672, 234);
            this.contactsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contactsGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView contactsListView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader homePhoneColumnHeader;
        private System.Windows.Forms.ColumnHeader workPhoneColumnHeader;
    }
}
