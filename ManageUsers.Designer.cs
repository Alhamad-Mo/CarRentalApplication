
namespace CarRentalApplication
{
    partial class ManageUsers
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
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.Location = new System.Drawing.Point(582, 484);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(232, 75);
            this.btnDeactivateUser.TabIndex = 23;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(315, 483);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(192, 44);
            this.btnResetPassword.TabIndex = 22;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(56, 483);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(192, 44);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 68);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(13, 128);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.RowHeadersWidth = 60;
            this.gvUserList.RowTemplate.Height = 24;
            this.gvUserList.Size = new System.Drawing.Size(777, 342);
            this.gvUserList.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(13, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 31);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 651);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.Button btnRefresh;
    }
}