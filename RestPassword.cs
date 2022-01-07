using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApplication
{
    public partial class RestPassword : Form
    {
        private readonly CarRentalEntities _db;
        private User _user;
        public RestPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _user = user;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNewPassword.Text;
                var confirmPassword = tbConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);
                if (password != confirmPassword)
                {
                    MessageBox.Show($"Password do not match. Please try again!");
                }

                user.password = Utils.HashPassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password was reset successfully!");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occured. Please try again!");
            }
        }
    }
}
