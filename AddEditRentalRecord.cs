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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _db = new CarRentalEntities();
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
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    errorMessage += "Error: Please Enter Missing Data.\n\r";
                    isValid = false;
                }

                if (dateOut > dateIn)
                {
                    errorMessage += "Error: Illegal Date Selection.\n\r";
                    isValid = false;
                }

                //if(isValid == true)
                if (isValid)
                {
                    //Declare an object of the recorf to be added
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record objedct
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                    //Populate record object with values from the form
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = Convert.ToDecimal(cost);
                    rentalRecord.TypeOfCarID = Convert.ToInt32(cbTypeOfCar.SelectedValue);
                    
                    //If not in edit moade, then add the record object to the database
                    if (!isEditMode)
                        _db.CarRentalRecords.Add(rentalRecord);

                    //Save changes made to the entity
                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {customerName}" +
                                        $"\nRental Date: {dateOut}" +
                                        $"\nReturn Date: {dateIn}" +
                                        $"\nCost: {cost.ToString("C")}" +
                                        $"\nCar Type: {carType}" +
                                        $"\nTHANK YOU FOR YOUR BUSINESS");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Select * from TypesOfCars
            //var cars = carRentalEntities.TypesOfCars.ToList();

            var cars = _db.TypesOfCars
                .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model })
                .ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource = cars;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
