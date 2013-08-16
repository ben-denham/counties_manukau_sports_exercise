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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.contactsGroupBox.Controls.Add(this.button2);
            this.contactsGroupBox.Controls.Add(this.button1);
            this.contactsGroupBox.Controls.Add(this.addButton);
            this.contactsGroupBox.Controls.Add(this.contactsListView);
            this.contactsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.contactsGroupBox.Name = "contactsGroupBox";
            this.contactsGroupBox.Size = new System.Drawing.Size(333, 234);
            this.contactsGroupBox.TabIndex = 0;
            this.contactsGroupBox.TabStop = false;
            this.contactsGroupBox.Text = "&Contacts";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remo&ve Contact";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit C&ontact";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 205);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ne&w Contact";
            this.addButton.UseVisualStyleBackColor = true;
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
            this.contactsListView.Size = new System.Drawing.Size(327, 183);
            this.contactsListView.TabIndex = 0;
            this.contactsListView.UseCompatibleStateImageBehavior = false;
            this.contactsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            // 
            // homePhoneColumnHeader
            // 
            this.homePhoneColumnHeader.Text = "Home Phone";
            // 
            // workPhoneColumnHeader
            // 
            this.workPhoneColumnHeader.Text = "Work Phone";
            // 
            // ContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactsGroupBox);
            this.Name = "ContactsControl";
            this.Size = new System.Drawing.Size(333, 234);
            this.contactsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contactsGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView contactsListView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader homePhoneColumnHeader;
        private System.Windows.Forms.ColumnHeader workPhoneColumnHeader;
    }
}
