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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _carDB;
        public ManageUsers()
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }           
                        
        }

        private void buttonResetPW_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                //query Db for record
                var user = _carDB.Users.FirstOrDefault(q => q.id == id);                
                var hashed_password = Utils.DefaultHashedPassword();
                user.password = hashed_password;
                _carDB.SaveChanges();

                MessageBox.Show($"{user.username}'s password has been reset");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                //query Db for record
                var user = _carDB.Users.FirstOrDefault(q => q.id == id);
                //if (user.isActive == true)
                //     user.isActive == flase;
                //else
                //     user.isActive == true;
                user.isActive = user.isActive == true ? false : true;
                _carDB.SaveChanges();

                MessageBox.Show($"{user.username}'s active status has changed");
                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var user = _carDB.Users
                .Select(q => new
                {
                    q.id,
                    q.username,   
                    q.UserRoles.FirstOrDefault().Role.name,         
                    q.isActive                   

                }).ToList();
            //bind cars to gridview
            gvUserList.DataSource = user;                 

            //get the value, but you donmt need to see it
            gvUserList.Columns["id"].Visible = false;

            gvUserList.Columns["username"].HeaderText = "Username";
            gvUserList.Columns["name"].HeaderText = "Role name";
            gvUserList.Columns["isActive"].HeaderText = "Active";
        }
    }
}
