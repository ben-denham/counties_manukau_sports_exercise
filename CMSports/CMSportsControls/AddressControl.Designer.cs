﻿namespace CMSportsControls
{
    partial class AddressControl
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
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.suburbLabel = new System.Windows.Forms.Label();
            this.streetNoTextBox = new System.Windows.Forms.TextBox();
            this.streetNoLabel = new System.Windows.Forms.Label();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.streetNameLabel = new System.Windows.Forms.Label();
            this.addressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.postcodeTextBox);
            this.addressGroupBox.Controls.Add(this.postcodeLabel);
            this.addressGroupBox.Controls.Add(this.suburbTextBox);
            this.addressGroupBox.Controls.Add(this.suburbLabel);
            this.addressGroupBox.Controls.Add(this.streetNoTextBox);
            this.addressGroupBox.Controls.Add(this.streetNoLabel);
            this.addressGroupBox.Controls.Add(this.streetNameTextBox);
            this.addressGroupBox.Controls.Add(this.streetNameLabel);
            this.addressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressGroupBox.Location = new System.Drawing.Point(0, 0);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(333, 136);
            this.addressGroupBox.TabIndex = 0;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "&Address";
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(154, 32);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(173, 20);
            this.postcodeTextBox.TabIndex = 3;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(151, 16);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(52, 13);
            this.postcodeLabel.TabIndex = 2;
            this.postcodeLabel.Text = "&Postcode";
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.Location = new System.Drawing.Point(9, 110);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(318, 20);
            this.suburbTextBox.TabIndex = 7;
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Location = new System.Drawing.Point(6, 94);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(41, 13);
            this.suburbLabel.TabIndex = 6;
            this.suburbLabel.Text = "S&uburb";
            // 
            // streetNoTextBox
            // 
            this.streetNoTextBox.Location = new System.Drawing.Point(9, 32);
            this.streetNoTextBox.Name = "streetNoTextBox";
            this.streetNoTextBox.Size = new System.Drawing.Size(139, 20);
            this.streetNoTextBox.TabIndex = 1;
            // 
            // streetNoLabel
            // 
            this.streetNoLabel.AutoSize = true;
            this.streetNoLabel.Location = new System.Drawing.Point(6, 16);
            this.streetNoLabel.Name = "streetNoLabel";
            this.streetNoLabel.Size = new System.Drawing.Size(55, 13);
            this.streetNoLabel.TabIndex = 0;
            this.streetNoLabel.Text = "Street N&o.";
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(9, 71);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.streetNameTextBox.TabIndex = 5;
            // 
            // streetNameLabel
            // 
            this.streetNameLabel.AutoSize = true;
            this.streetNameLabel.Location = new System.Drawing.Point(6, 55);
            this.streetNameLabel.Name = "streetNameLabel";
            this.streetNameLabel.Size = new System.Drawing.Size(66, 13);
            this.streetNameLabel.TabIndex = 4;
            this.streetNameLabel.Text = "S&treet Name";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressGroupBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(333, 136);
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.TextBox streetNoTextBox;
        private System.Windows.Forms.Label streetNoLabel;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.Label streetNameLabel;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.Label suburbLabel;
    }
}
