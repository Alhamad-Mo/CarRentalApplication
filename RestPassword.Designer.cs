
namespace CarRentalApplication
{
    partial class RestPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(126, 58);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(238, 22);
            this.tbNewPassword.TabIndex = 2;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(126, 143);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(238, 22);
            this.tbConfirmPassword.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F);
            this.btnReset.Location = new System.Drawing.Point(149, 188);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(186, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RestPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 237);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestPassword";
            this.Text = "Rest Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnReset;
    }
}