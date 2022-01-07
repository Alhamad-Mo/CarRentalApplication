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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                //Query Our Database for Record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //Launch AddEditVehicle Window With Data
                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                //Query Our Database for Record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                //Delete Vehicle Listing
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

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
            var records = _db.CarRentalRecords.Select(q => new 
            { 
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
