namespace CMSportsControls
{
    partial class ContactForm
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
            this.contactAddressControl = new CMSportsControls.AddressControl();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneLabel = new System.Windows.Forms.Label();
            this.workPhoneTextBox = new System.Windows.Forms.TextBox();
            this.workPhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contactAddressControl
            // 
            this.contactAddressControl.Location = new System.Drawing.Point(12, 117);
            this.contactAddressControl.Name = "contactAddressControl";
            this.contactAddressControl.Size = new System.Drawing.Size(333, 136);
            this.contactAddressControl.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(270, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(189, 259);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(112, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Contact &Name";
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Location = new System.Drawing.Point(112, 64);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.homePhoneTextBox.TabIndex = 5;
            // 
            // homePhoneLabel
            // 
            this.homePhoneLabel.AutoSize = true;
            this.homePhoneLabel.Location = new System.Drawing.Point(9, 67);
            this.homePhoneLabel.Name = "homePhoneLabel";
            this.homePhoneLabel.Size = new System.Drawing.Size(69, 13);
            this.homePhoneLabel.TabIndex = 4;
            this.homePhoneLabel.Text = "&Home Phone";
            // 
            // workPhoneTextBox
            // 
            this.workPhoneTextBox.Location = new System.Drawing.Point(112, 91);
            this.workPhoneTextBox.Name = "workPhoneTextBox";
            this.workPhoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.workPhoneTextBox.TabIndex = 7;
            // 
            // workPhoneLabel
            // 
            this.workPhoneLabel.AutoSize = true;
            this.workPhoneLabel.Location = new System.Drawing.Point(9, 94);
            this.workPhoneLabel.Name = "workPhoneLabel";
            this.workPhoneLabel.Size = new System.Drawing.Size(67, 13);
            this.workPhoneLabel.TabIndex = 6;
            this.workPhoneLabel.Text = "&Work Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 41);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "&Email Address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(112, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(233, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // ContactForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(357, 294);
            this.Controls.Add(this.workPhoneTextBox);
            this.Controls.Add(this.workPhoneLabel);
            this.Controls.Add(this.homePhoneTextBox);
            this.Controls.Add(this.homePhoneLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.contactAddressControl);
            this.Name = "ContactForm";
            this.Text = "Contact Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMSportsControls.AddressControl contactAddressControl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.TextBox workPhoneTextBox;
        private System.Windows.Forms.Label workPhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}