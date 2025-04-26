using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    
    public partial class Login : Form
    {
        private readonly CarRentalEntities _carDB;
        public Login()
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = textBoxUsername.Text.Trim();
                var password = textBoxPW.Text;             

                var hashed_password = Utils.HashPassword(password);

                var user = _carDB.Users.FirstOrDefault(t => t.username == username && 
                                                            t.password == hashed_password &&
                                                            t.isActive == true);
                if (user == null)
                { MessageBox.Show("Non-valid credentials"); }
                else 
                {  
                    //var role = user.UserRoles.FirstOrDefault();//no condition needed so absent lambda
                    //var roleShortName = role.Role.shortname;
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
        
            catch (Exception)
                {
                   MessageBox.Show("Nope");
                }
        }
    }
}
