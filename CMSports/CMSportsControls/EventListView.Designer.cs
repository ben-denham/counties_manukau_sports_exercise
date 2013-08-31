namespace CMSportsControls
{
    partial class EventListView
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
            this.eventListGroupBox = new System.Windows.Forms.GroupBox();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organistationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventListGroupBox
            // 
            this.eventListGroupBox.Controls.Add(this.eventsListView);
            this.eventListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.eventListGroupBox.Name = "eventListGroupBox";
            this.eventListGroupBox.Size = new System.Drawing.Size(672, 162);
            this.eventListGroupBox.TabIndex = 0;
            this.eventListGroupBox.TabStop = false;
            this.eventListGroupBox.Text = "Events";
            // 
            // eventsListView
            // 
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.organistationColumnHeader,
            this.programColumnHeader,
            this.startTimeColumnHeader,
            this.endTimeColumnHeader});
            this.eventsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsListView.Location = new System.Drawing.Point(3, 16);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(666, 143);
            this.eventsListView.TabIndex = 0;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 122;
            // 
            // organistationColumnHeader
            // 
            this.organistationColumnHeader.Text = "Organisation";
            this.organistationColumnHeader.Width = 120;
            // 
            // programColumnHeader
            // 
            this.programColumnHeader.Text = "Program";
            this.programColumnHeader.Width = 120;
            // 
            // startTimeColumnHeader
            // 
            this.startTimeColumnHeader.Text = "Start Time";
            this.startTimeColumnHeader.Width = 150;
            // 
            // endTimeColumnHeader
            // 
            this.endTimeColumnHeader.Text = "End Time";
            this.endTimeColumnHeader.Width = 150;
            // 
            // EventListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventListGroupBox);
            this.Name = "EventListView";
            this.Size = new System.Drawing.Size(672, 162);
            this.eventListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox eventListGroupBox;
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader organistationColumnHeader;
        private System.Windows.Forms.ColumnHeader programColumnHeader;
        private System.Windows.Forms.ColumnHeader startTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader endTimeColumnHeader;
    }
}
