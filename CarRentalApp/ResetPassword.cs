using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _carDB;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
            _user = user;
        }

        private void buttonPWReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPW.Text;
                var confirmPassword = tbConfirmPW.Text;
                var user = _carDB.Users.First(t => t.id == _user.id);
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                }
                _user.password = Utils.HashPassword(password);
                _carDB.SaveChanges();

                MessageBox.Show("Password reset");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred");
            }
        }
    }
}
