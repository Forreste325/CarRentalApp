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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities _carDB;

        //the null at the end means the constructor is optional. 
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _carDB = new CarRentalEntities();
            
        }
        //overloading controller
        public AddEditVehicle(TypesOfCar carToEdit, ManageVehicleListing manageVehicleListing = null) //takes Object of typeOfCar and sends data to Method- constructor
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _carDB = new CarRentalEntities();
                PopulateFields(carToEdit);
            }
        }
        private void PopulateFields(TypesOfCar car) //takes object of car from TypesOfCarr
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePlate.Text = car.LicensePlate;


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (isEditMode)
            {
                try
                {
                    //Edit vehicle code here
                    var id = int.Parse(lblId.Text);
                    var car = _carDB.TypesOfCars.FirstOrDefault(t => t.Id == id);
                    car.Make = tbMake.Text;
                    car.Model = tbModel.Text;
                    car.VIN = tbVIN.Text;
                    car.Year = int.Parse(tbYear.Text);
                    car.LicensePlate = tbLicensePlate.Text;

                    _carDB.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                //finally {  }
            }
            else
            {
                //Add vehicle code here
                var newCar = new TypesOfCar()
                {
                    Make = tbMake.Text,
                    LicensePlate = tbLicensePlate.Text,
                    Model = tbModel.Text,
                    VIN = tbVIN.Text,
                    Year = int.Parse(tbYear.Text)

                };

                _carDB.TypesOfCars.Add(newCar);
                
            }
            _carDB.SaveChanges();
            _manageVehicleListing.PopulateGrid();
            MessageBox.Show("Insert Operation Completed.");
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
