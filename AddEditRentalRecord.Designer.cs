
namespace CarRentalApplication
{
    partial class AddEditRentalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditRentalRecord));
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(89, 138);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(269, 22);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(89, 228);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(269, 22);
            this.dtRented.TabIndex = 3;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(485, 228);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(269, 22);
            this.dtReturned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Returned";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(90, 329);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(282, 24);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type of Car";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(523, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(485, 138);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(269, 22);
            this.tbCost.TabIndex = 10;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(482, 117);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(40, 18);
            this.Cost.TabIndex = 11;
            this.Cost.Text = "Cost";
            this.Cost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(156, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 69);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Add Rental Record";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(365, 360);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 17);
            this.lblRecordId.TabIndex = 14;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 445);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordId;
    }
}

