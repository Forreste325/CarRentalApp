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
    
    public partial class ManageRentalRecords : Form
    {

        private readonly CarRentalEntities _carDB;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _carDB = new CarRentalEntities();
        }
        private void buttonNewRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent; //says this forms parent is the parent of ManageVehicleListing
            addRentalRecord.Show();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //query Db for record
                var record = _carDB.CarRentalRecords.FirstOrDefault(q => q.Id == id);

                //launch AddEditVehicle window with data object from above
                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent; //says this forms parent is the parent of ManageVehicleListing
                addEditRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row cast into Int to compare with id value
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                var record = _carDB.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                //delete vehicle from table
                _carDB.CarRentalRecords.Remove(record);
                _carDB.SaveChangesAsync();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            var records = _carDB.CarRentalRecords.Select(t => new
            {
                Customer = t.CustomerName,
                DateOut = t.DateRented,
                DateIn = t.DateReturned,
                t.Id,
                t.Cost,
                Car = t.TypesOfCar.Make + " " + t.TypesOfCar.Model,
            }).ToList();

            gvRecordList.DataSource = records;
            //after generated, set the header to ID (we know the first column is id)

            //Manual change of license plate to something more legible
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";

            //get the value, but you donmt need to see it
            gvRecordList.Columns["Id"].Visible = false;
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            gvRecordList.Refresh();
        }

        private void buttonEditRecord_Click_1(object sender, EventArgs e)
        {

        }

        private void manageVehicleListingLabel_Click(object sender, EventArgs e)
        {

        }

        private void gvRecordList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
