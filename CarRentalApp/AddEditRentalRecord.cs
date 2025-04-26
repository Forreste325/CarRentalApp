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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _carDB;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _carDB = new CarRentalEntities();

        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";

            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _carDB = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            customerNameTextBox.Text = recordToEdit.CustomerName;
            rentalPickupDatePicker.Value = (DateTime)recordToEdit.DateRented;
            returnDateDatePicker.Value = (DateTime)recordToEdit.DateReturned; //value returns dateTime                
            costTextBox.Text = recordToEdit.Cost.ToString();
            labelRecordId.Text = recordToEdit.Id.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = customerNameTextBox.Text;
                var dateOut = rentalPickupDatePicker.Value;
                var dateIn = returnDateDatePicker.Value; //value returns dateTime                
                double cost = Convert.ToDouble(costTextBox.Text);

                string carType = carSelectionComboBox.SelectedItem.ToString();
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Please enter missing data\n\r";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Bad date selection\n\r";
                }
                //if(isValid == true) either way
                if (isValid)
                {
                    //Declare an object of the record to be added
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database
                        //and place the result in the record object
                        var id = int.Parse(labelRecordId.Text);
                        var recordRecord = _carDB.CarRentalRecords.FirstOrDefault(t => t.Id == id);
                    }
                    //Populate  record object with values from the form
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)carSelectionComboBox.SelectedValue;
                    //If not in edit mode, then add the record object the the DB 
                    if (!isEditMode)
                        _carDB.CarRentalRecords.Add(rentalRecord);
                    //save chnages
                    _carDB.SaveChangesAsync();            
                                                                                        
                   MessageBox.Show($"Thank you for renting the {carType} from " +
                            $"{dateOut} to {dateIn}, {customerName}. Cost: {cost}");                    
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void carSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select * from TypesOfCars in LINQ instead of SQL
            //var cars = _carDB.TypesOfCars.ToList();

            var cars = _carDB.TypesOfCars
               .Select(q => new { q.Id, Name = q.Make + " " + q.Model })
               .ToList();

            carSelectionComboBox.DisplayMember = "Name";
            carSelectionComboBox.ValueMember = "Id";
            carSelectionComboBox.DataSource = cars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
