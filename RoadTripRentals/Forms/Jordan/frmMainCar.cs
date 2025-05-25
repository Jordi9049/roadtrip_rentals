using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTripRentals.Forms.Jordan
{
    public partial class frmMainCar : Form
    {
        SqlDataAdapter daNames, daCustomers, daRental, daRentalCost, daRentalCar;
        DataSet dsRoadTripRentals = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails;


        DataRow drCustomer;

        String sqlNames, sqlCustomerDetails, sqlRental;

        String connStr;

        SqlDataAdapter daCarDetails, daCarDetailss;
        SqlCommandBuilder cmdBCarDetails, cmdBRentalCar;
        SqlCommand cmdCarDetails;
        DataRow drCarDetails;
        String sqlCarDetails, sqlCarDetailsDetails;


        SqlDataAdapter daPayment, daPaymentss;
        SqlCommandBuilder cmdBPayment, cmdBRental, cmdBRentalCost;
        SqlCommand cmdPaymentsDetails;
        DataRow drPayment;
        String sqlRentalCar, sqlRentalCost, sqlPayment, sqlPaymentsDetails;

        private void frmMainCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Car' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlCarDetails = @"select * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlCarDetails, connStr);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");

            // setup dataAdapter for customer details for the listbox
            sqlCustomerDetails = @"Select customerID, title, surname, forename, surname +', ' + Forename as name, street, city, county, postcode, postcode, telephoneno from customer where surname LIKE @Letter order by surname, forename ";
            conn = new SqlConnection(connStr);
            cmdCustomerDetails = new SqlCommand(sqlCustomerDetails, conn);
            cmdCustomerDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daCustomers = new SqlDataAdapter(cmdCustomerDetails);
            daCustomers.FillSchema(dsRoadTripRentals, SchemaType.Source, "Customer");


            dgvCars.DataSource = dsRoadTripRentals.Tables["CarDetails"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvCars.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //Rental Cost
            sqlRentalCost = @"select * from RentalCost";
            daRentalCost = new SqlDataAdapter(sqlRentalCost, connStr);
            cmdBRentalCost = new SqlCommandBuilder(daRentalCost);
            daRentalCost.FillSchema(dsRoadTripRentals, SchemaType.Source, "RentalCost");
            daRentalCost.Fill(dsRoadTripRentals, "RentalCost");


            // Rental table
            sqlRental = @"select * from Rental";
            daRental = new SqlDataAdapter(sqlRental, connStr);
            cmdBRental = new SqlCommandBuilder(daRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");
            daRental.Fill(dsRoadTripRentals, "Rental");

            // RentalCar table
            sqlRentalCar = @"select * from RentalCar";
            daRentalCar = new SqlDataAdapter(sqlRentalCar, connStr);
            cmdBRentalCar = new SqlCommandBuilder(daRentalCar);
            daRentalCar.FillSchema(dsRoadTripRentals, SchemaType.Source, "RentalCar");
            daRentalCar.Fill(dsRoadTripRentals, "RentalCar");


            // Payment table
            sqlPayment = @"select * from PaymentType";
            daPayment = new SqlDataAdapter(sqlPayment, connStr);
            cmdBPayment = new SqlCommandBuilder(daPayment);
            daPayment.FillSchema(dsRoadTripRentals, SchemaType.Source, "PaymentType");
            daPayment.Fill(dsRoadTripRentals, "Payment");

            dgvCars.DataSource = dsRoadTripRentals.Tables["CarDetails"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvCars.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //btnDelCar.Click += btnDelCar_Click;
        }

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        private void btnDelCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                string carReg = Convert.ToString(dgvCars.SelectedRows[0].Cells["CarReg"].Value);

                // Check if the dataset contains the necessary tables
                if (dsRoadTripRentals.Tables.Contains("Rental") && dsRoadTripRentals.Tables.Contains("RentalCar"))
                {
                    // Check if the car is associated with any rentals or rental cars
                    DataRow[] rentalCarRows = dsRoadTripRentals.Tables["RentalCar"].Select($"CarReg = '{carReg}'");

                    if (rentalCarRows.Length > 0)
                    {
                        MessageBox.Show("Cannot delete the car because it is associated with rentals or rental cars.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The dataset does not contain the necessary tables to perform the check.");
                    return;
                }

                // Ask for confirmation before deleting the car
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected car?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Find the car in the dataset using LINQ
                    DataRow carRow = dsRoadTripRentals.Tables["CarDetails"].AsEnumerable().SingleOrDefault(row => row.Field<string>("CarReg") == carReg);

                    if (carRow != null)
                    {
                        // Delete the car from the dataset and update the database
                        carRow.Delete();
                        daCarDetails.Update(dsRoadTripRentals, "CarDetails");

                        MessageBox.Show("Car Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Car not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }



        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                string carReg = Convert.ToString(dgvCars.SelectedRows[0].Cells["CarReg"].Value);

                frmEditCar newSubForm = new frmEditCar(carReg);
                OpenSubFormInPanel(newSubForm);
            }
            else
            {
                MessageBox.Show("Please select a car to edit.");
            }
        }


        public frmMainCar()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            frmAddCar addCarForm = new frmAddCar();
            OpenSubFormInPanel(addCarForm);
        }


        private void OpenSubFormInPanel(Form subForm)
        {
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            // Replace 'panel1' with the name of the Panel control in your main form.
            panelSub.Controls.Clear();
            panelSub.Controls.Add(subForm);

            subForm.Show();
        }


    }


}
