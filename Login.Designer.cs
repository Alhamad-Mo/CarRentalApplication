
namespace CarRentalApplication
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Font = new System.Drawing.Font("Bernard MT Condensed", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(310, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(152, 68);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPassword.Location = new System.Drawing.Point(203, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(195, 26);
            this.tbPassword.TabIndex = 18;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(3, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 18);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(203, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(195, 22);
            this.tbUsername.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(190, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 143);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(298, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 52);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 415);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLogin;
    }
}