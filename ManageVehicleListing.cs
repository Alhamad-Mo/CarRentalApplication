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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //Select * From TypesOfCars
            //var cars = _db.TypesOfCars.ToList();

            //Select Id AS CarId, Name AS CarName From TypesOfCars
            //var cars = _db.TypesOfCars.Select(q => new { CarId = q.Id, CarName = q.Make }).ToList();

            var cars = _db.TypesOfCars
                .Select(q => new 
                { 
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber, 
                    Id = q.Id
                })
                .ToList();

            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.ShowDialog();
            addEditVehicle.MdiParent = this.MdiParent;
            
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                //Query Our Database for Record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                //Launch AddEditVehicle Window With Data
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.ShowDialog();
                addEditVehicle.MdiParent = this.MdiParent;
                

                gvVehicleList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                //Query Our Database for Record
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Car?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                
                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle Listing
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
                //Simple Refresh Option
                PopulateGrid();
        }

        //New Function to PopulateGrid. Can be called anytime we need a grid refresh
        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvVehicleList.Columns["Id"].Visible = false;
        }
    }
}
