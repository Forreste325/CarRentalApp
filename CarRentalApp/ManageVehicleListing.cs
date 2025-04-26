using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        //call an instance of the Db, which is called CarRentalEntities
        //and use it as _carDB
        private readonly CarRentalEntities _carDB;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //create variable, get typesOfcars Table from Db, return as list
            //same as Select * from TypesOfCars
            ////var cars = _carDB.TypesOfCars.ToList();
            ///
            /*
             * THIS CAN BE USED TO CREATE DIFFERENT VIEWS FOR LOGINS IF DONE RIGHT
             * 
             */
            /// lambda expression that takes the identifier q and returns the object with two objects with
            /// name and id as part of them, the names are aliases as you decide them (Name, ID, q)
            /*var cars = _carDB.TypesOfCars
                .Select(q => new { CarId = q.Id, CarName = q.Make })
                .ToList();*/
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void PopulateGrid() 
        { 
            var cars = _carDB.TypesOfCars
                .Select(q => new
                {
                    
                    Make = q.Make,   //grayed out because ref is same as name
                    q.Model,         //option to clean up code
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlate = q.LicensePlate,
                    q.Id,

                }).ToList();
            //bind cars to gridview
            gvVehicleList.DataSource = cars;
            //after generated, set the header to ID (we know the first column is id)

            //Manual change of license plate to something more legible
            gvVehicleList.Columns[4].HeaderText = "License Plate";

            //get the value, but you donmt need to see it
            gvVehicleList.Columns["Id"].Visible = false;

            //unused but saved to see how they work
            /* gvVehicleList.Columns[0].HeaderText = "ID";
             gvVehicleList.Columns[1].HeaderText = "NAME";*/
        }

        private void buttonNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent; //says this forms parent is the parent of ManageVehicleListing
            addEditVehicle.Show();
        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //query Db for record
                var car = _carDB.TypesOfCars.FirstOrDefault(q => q.Id == id);
                //launch AddEditVehicle window with data object from above
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.MdiParent = this.MdiParent; //says this forms parent is the parent of ManageVehicleListing
                addEditVehicle.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                var car = _carDB.TypesOfCars.FirstOrDefault(q => q.Id == id);               

               DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                   "Delete", MessageBoxButtons.YesNoCancel, 
                   MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    // delete vehicle from table
                _carDB.TypesOfCars.Remove(car);
                    _carDB.SaveChangesAsync();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            gvVehicleList.Refresh();            
        }
    }
}
