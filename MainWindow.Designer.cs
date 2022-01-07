
namespace CarRentalApplication
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.manageVehicleListing = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsiLoginText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleListing,
            this.manageRentalRecords,
            this.manageUsersToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(785, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // manageVehicleListing
            // 
            this.manageVehicleListing.Name = "manageVehicleListing";
            this.manageVehicleListing.Size = new System.Drawing.Size(175, 24);
            this.manageVehicleListing.Text = "Manage Vehicle Listing";
            this.manageVehicleListing.Click += new System.EventHandler(this.manageVehicleListingToolStripMenuItem_Click);
            // 
            // manageRentalRecords
            // 
            this.manageRentalRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecord,
            this.viewArchive,
            this.toolStripMenuItem3});
            this.manageRentalRecords.Name = "manageRentalRecords";
            this.manageRentalRecords.Size = new System.Drawing.Size(180, 24);
            this.manageRentalRecords.Text = "Manage Rental Records";
            // 
            // addRentalRecord
            // 
            this.addRentalRecord.Name = "addRentalRecord";
            this.addRentalRecord.Size = new System.Drawing.Size(217, 26);
            this.addRentalRecord.Text = "Add Rental Record";
            this.addRentalRecord.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // viewArchive
            // 
            this.viewArchive.Name = "viewArchive";
            this.viewArchive.Size = new System.Drawing.Size(217, 26);
            this.viewArchive.Text = "View Archive";
            this.viewArchive.Click += new System.EventHandler(this.viewArchiveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem3.Text = "Edit Rental Record";
            // 
            // manageUsersToolStripMenuItem1
            // 
            this.manageUsersToolStripMenuItem1.Name = "manageUsersToolStripMenuItem1";
            this.manageUsersToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem1.Text = "Manage Users";
            this.manageUsersToolStripMenuItem1.Click += new System.EventHandler(this.manageUsersToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLoginText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsiLoginText
            // 
            this.tsiLoginText.Name = "tsiLoginText";
            this.tsiLoginText.Size = new System.Drawing.Size(0, 16);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(785, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleListing;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecords;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecord;
        private System.Windows.Forms.ToolStripMenuItem viewArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsiLoginText;
    }
}