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
    
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _carDB;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //select * from TypesOfCars in LINQ instead of SQL
            //var cars = _carDB.TypesOfCars.ToList();
            var roles = _carDB.Roles.ToList();
            comboBoxRoles.DataSource = roles;
            comboBoxRoles.ValueMember = "id";
            comboBoxRoles.DisplayMember = "name";

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsername.Text;
                var roleId = (int)comboBoxRoles.SelectedValue;
                var password = Utils.DefaultHashedPassword();
                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true,
                };

                _carDB.Users.Add(user);
                _carDB.SaveChanges();

                var userId = user.id;

                var userRole = new UserRole
                {
                    roleid = roleId,
                    userid = userId
                };

                _carDB.UserRoles.Add(userRole);
                _carDB.SaveChanges();

                MessageBox.Show($"New user, {username} added");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error has occured");
            }
        }
    }
}
