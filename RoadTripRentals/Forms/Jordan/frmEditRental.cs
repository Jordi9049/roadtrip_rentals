using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTripRentals.Forms.Jordan
{
    public partial class frmEditRental : Form
    {
        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daCustomers, daRental, daRentalCost, daRentalCar;
        DataSet dsRoadTripRentals = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails;


        DataRow drCustomer;

        String sqlNames, sqlCustomerDetails, sqlRental;

        String connStr;

        SqlDataAdapter daCarDetails, daCarDetailss;
        SqlCommandBuilder cmdBCarDetails, cmdBRentalCar;
        SqlCommand cmdCarDetail, cmdRental, cmdRentalCar, cmdRentalCars;
        DataRow drCarDetails;
        String sqlCarDetails, sqlCarDetailsDetails;


        SqlDataAdapter daPayment, daPaymentType, daPaymentss;
        SqlCommandBuilder cmdBPayment, cmdBRental, cmdBRentalCost;
        SqlCommand cmdPaymentType;
        DataRow drPayment, drRental;
        String sqlRentalCar, sqlRentalCost, sqlPayment, sqlPaymentsDetails;


        private int previousSelectedCustomer = -1;
        private bool isMessageBoxShown = false;


        public frmEditRental()
        {
            InitializeComponent();
            Load += frmEditRental_Load;

        }

        private void frmEditRental_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            cmdRentalCar = new SqlCommand(sqlRentalCar, conn);
            cmdRentalCar.Parameters.Add("@RentalID", SqlDbType.Int);


            ClearCustomer();
            btnAddItem.Enabled = false;

            int no;

            for (int i = 0; i < 26; i++)
            {
                var btn = (Button)pnlButtons.Controls["btn" + (char)(65 + i)];  // access buttons by name
                btn.Text = "" + (char)(65 + i);
                btn.Enabled = false;
                btn.Click += new EventHandler(button1_Click);
                btns[i] = btn;
            }

            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //connStr = Properties.Resources.connectionStr;
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //get surnames for alphabet buttons

            sqlNames = @"Select surname from customer order by surname";
            daNames = new SqlDataAdapter(sqlNames, connStr);

            daNames.Fill(dsRoadTripRentals, "Names");

            //enable relevant alpha buttons
            foreach (DataRow dr in dsRoadTripRentals.Tables["Names"].Rows)
            {
                no = (int)dr["Surname"].ToString()[0] - 65;
                btns[no].Enabled = true;
                btns[no].BackColor = Color.Black;
                btns[no].BackColor = Color.White;

            }

            // setup dataAdapter for customer details for the listbox
            sqlCustomerDetails = @"Select customerID, title, surname, forename, surname +', ' + Forename as name, street, city, county, postcode, postcode, telephoneno from customer where surname LIKE @Letter order by surname, forename ";
            conn = new SqlConnection(connStr);
            cmdCustomerDetails = new SqlCommand(sqlCustomerDetails, conn);
            cmdCustomerDetails.Parameters.Add("@Letter", SqlDbType.VarChar);
            daCustomers = new SqlDataAdapter(cmdCustomerDetails);
            daCustomers.FillSchema(dsRoadTripRentals, SchemaType.Source, "Customer");

            //CarDetails DGV
            sqlCarDetails = @"select * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlCarDetails, connStr);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");

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

            int noRows = dsRoadTripRentals.Tables["PaymentType"].Rows.Count;

            getNumber();



            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Model.ModelID, Model.ModelDesc FROM Model INNER JOIN CarDetails ON Model.ModelID = CarDetails.ModelID", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAddModelID.DataSource = dt;
                    cmbAddModelID.DisplayMember = "ModelDesc";
                    cmbAddModelID.ValueMember = "ModelID";
                }

                using (SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT RentalCostID, RentalCost 
        FROM RentalCost 
        WHERE RentalCostID IN (
            SELECT DISTINCT RentalCostID 
            FROM CarDetails
        )
    ", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAddRentalCostID.DataSource = dt;
                    cmbAddRentalCostID.DisplayMember = "RentalCost";
                    cmbAddRentalCostID.ValueMember = "RentalCostID";
                }
            }

            // Clear the car details labels
            lblCarReg.Text = "";
            lblModelID.Text = "";
            lblColour.Text = "";
            lblMileage.Text = "";
            lblFuelType.Text = "";
            lblNoSeats.Text = "";
            lblYear.Text = "";
            lblRentalCostID.Text = "";

            chkConfirmCarSelection.Enabled = false;
            chkConfirmCarSelection.Visible = false;
            pnlBooking.Enabled = false;
            pnlPayment.Enabled = false;
            btnResetFilters.Visible = false;

            sqlRental = @"select * from Rental where CustomerID = @CustomerID";
            cmdRental = new SqlCommand(sqlRental, conn);
            cmdRental.Parameters.Add("@CustomerID", SqlDbType.Int); // Assuming CustomerID is of type Int
            daRental = new SqlDataAdapter(cmdRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");

            // After initializing cmdRentalCar and cmdRental
            cmdPaymentType = new SqlCommand("SELECT * FROM PaymentType WHERE PaymentID = @PaymentID", conn);
            cmdPaymentType.Parameters.Add("@PaymentID", SqlDbType.Int); // Assuming PaymentID is of type Int

            daPaymentType = new SqlDataAdapter(cmdPaymentType);
            daPaymentType.FillSchema(dsRoadTripRentals, SchemaType.Source, "PaymentType");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            panelCarDetails.Enabled = false;
            Button b = (Button)sender;
            // get customer details for listbox - use selected button layer for parameter
            String str = b.Text;

            //empty dataset table customer
            dsRoadTripRentals.Tables["Customer"].Clear();

            fillListBoxCustomers(str);

            //clear any previously selected dogs/kennels by emptying the dataset tables
            //dsRoadTripRentals.Tables["Dog"].Clear();
            //dsRoadTripRentals.Tables["Kennel"].Clear();

            ClearCustomer();

            panel3.Enabled = true;
            pnlBooking.Enabled = false;
        }

        private void PopulateRentalListbox()
        {
            cmdRental.Parameters.Clear();
            cmdRental.Parameters.AddWithValue("@CustomerID", lstCustomer.SelectedValue);

            daRental.SelectCommand = cmdRental;

            dsRoadTripRentals.Tables["Rental"].Clear();

            daRental.Fill(dsRoadTripRentals, "Rental");

            lstRental.DataSource = dsRoadTripRentals.Tables["Rental"];
            lstRental.DisplayMember = "RentalID";
            lstRental.ValueMember = "RentalID";

            lstRental.SelectedIndex = -1;
        }




        private void fillListBoxCustomers(String str)
        {
            // get all customer details for listbox - use wildcard for parameter
            cmdCustomerDetails.Parameters["@Letter"].Value = str + "%";
            daCustomers.Fill(dsRoadTripRentals, "Customer");

            //fill listbox

            lstCustomer.DataSource = dsRoadTripRentals.Tables["Customer"];
            lstCustomer.DisplayMember = "name";
            lstCustomer.ValueMember = "CustomerID";
        }

        private void cmbModelID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnResetFilters.Visible = true;
            if (cmbAddModelID.SelectedItem != null)
            {
                string modelID = cmbAddModelID.SelectedValue.ToString();
                int noSeats = (int)txtAddNoSeats.Value;

                string rentalCostID = cmbAddRentalCostID.SelectedValue != null ? cmbAddRentalCostID.SelectedValue.ToString() : null;

                sqlCarDetails = "SELECT * FROM CarDetails WHERE ModelID = @ModelID AND NoSeats = @NoSeats" + (rentalCostID != null ? " AND RentalCostID = @RentalCostID" : "");
                daCarDetails = new SqlDataAdapter(sqlCarDetails, conn);
                daCarDetails.SelectCommand.Parameters.AddWithValue("@ModelID", modelID);
                daCarDetails.SelectCommand.Parameters.AddWithValue("@NoSeats", noSeats);
                if (rentalCostID != null)
                {
                    daCarDetails.SelectCommand.Parameters.AddWithValue("@RentalCostID", rentalCostID);
                }

                // Ensure the DataSet and DataTable are not null before trying to clear it.
                if (dsRoadTripRentals != null && dsRoadTripRentals.Tables.Contains("CarDetails"))
                {
                    dsRoadTripRentals.Tables["CarDetails"].Clear();
                    daCarDetails.Fill(dsRoadTripRentals, "CarDetails");
                    dgvCars.DataSource = dsRoadTripRentals.Tables["CarDetails"];
                }
                else
                {
                    // Log an error message or throw an exception.
                    Console.WriteLine("DataSet or DataTable is null.");
                }
            }
        }



        private void cmbAddRentalCostID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnResetFilters.Visible = true;
            if (cmbAddRentalCostID.SelectedItem != null)
            {
                if (cmbAddRentalCostID.SelectedValue is DataRowView) return;

                string rentalCostID = cmbAddRentalCostID.SelectedValue.ToString();
                string modelID = cmbAddModelID.SelectedValue.ToString();
                int noSeats = (int)txtAddNoSeats.Value;

                sqlCarDetails = @"
            SELECT * 
            FROM CarDetails 
            WHERE RentalCostID = @RentalCostID AND ModelID = @ModelID AND NoSeats = @NoSeats";
                daCarDetails = new SqlDataAdapter(sqlCarDetails, conn);
                daCarDetails.SelectCommand.Parameters.AddWithValue("@RentalCostID", rentalCostID);
                daCarDetails.SelectCommand.Parameters.AddWithValue("@ModelID", modelID);
                daCarDetails.SelectCommand.Parameters.AddWithValue("@NoSeats", noSeats);

                // Ensure the DataSet and DataTable are not null before trying to clear it.
                if (dsRoadTripRentals != null && dsRoadTripRentals.Tables.Contains("CarDetails"))
                {
                    dsRoadTripRentals.Tables["CarDetails"].Clear();
                    daCarDetails.Fill(dsRoadTripRentals, "CarDetails");
                    dgvCars.DataSource = dsRoadTripRentals.Tables["CarDetails"];
                }
                else
                {
                    // Log an error message or throw an exception.
                    Console.WriteLine("DataSet or DataTable is null.");
                }
            }
        }





        private void txtAddNoSeats_ValueChanged(object sender, EventArgs e)
        {
            btnResetFilters.Visible = true;
            cmbModelID_SelectedIndexChanged(sender, e);
        }



        private void lstCustomer_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            String title = "";

            drCustomer = dsRoadTripRentals.Tables["Customer"].Rows.Find(lstCustomer.SelectedValue);

            if (drCustomer["Title"].ToString() == "Mr")
                title = "Mr";
            if (drCustomer["Title"].ToString() == "Mrs")
                title = "Mrs";
            if (drCustomer["Title"].ToString() == "Miss")
                title = "Miss";
            if (drCustomer["Title"].ToString() == "Ms")
                title = "Ms";


            lblCust0.Text = drCustomer["CustomerID"].ToString();
            lblCust1.Text = title + " " + drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();
            lblCust2.Text = drCustomer["Street"].ToString();
            lblCust3.Text = drCustomer["City"].ToString();
            lblCust4.Text = drCustomer["County"].ToString();
            lblCust5.Text = drCustomer["Postcode"].ToString();

            panelCarDetails.Enabled = true;
            dgvCars.ClearSelection();

            chkConfirmCarSelection.Enabled = false;
            chkConfirmCarSelection.Visible = false;
            pnlBooking.Enabled = false;

            // Populate dgvCars and display the Confirm Selection checkbox only after a customer is selected
            if (lstCustomer.SelectedItems.Count > 0)
            {
                ResetCarDetails();  // Make sure this method populates dgvCars with all cars and doesn't clear it

                // Enable the Confirm Selection checkbox
                chkConfirmCarSelection.Enabled = true;

                // Call the method to populate rentals for the selected customer
                PopulateRentalListbox();

                // Hide the customer if there are no bookings
                if (lstRental.Items.Count == 0)
                {
                    MessageBox.Show("No bookings found for this customer.", "Error");
                    lstCustomer.ClearSelected();
                    panel3.Enabled = false;
                    panelMajor.Enabled = false;

                    return;
                }

            }
        }

        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0) // Make sure there is a selected row
            {
                DataGridViewRow row = dgvCars.SelectedRows[0];
                // Assume you have labels or other controls to display the selected car details
                lblCarReg.Text = row.Cells["CarReg"].Value.ToString();
                lblModelID.Text = row.Cells["ModelID"].Value.ToString();
                lblColour.Text = row.Cells["Colour"].Value.ToString();
                lblMileage.Text = Convert.ToDecimal(row.Cells["Mileage"].Value).ToString();
                lblFuelType.Text = row.Cells["FuelType"].Value.ToString();
                lblNoSeats.Text = Convert.ToDecimal(row.Cells["NoSeats"].Value).ToString();
                lblYear.Text = Convert.ToDecimal(row.Cells["Year"].Value).ToString();
                lblRentalCostID.Text = row.Cells["RentalCostID"].Value.ToString();

                // Enable the confirm selection checkbox
                chkConfirmCarSelection.Enabled = true;
                chkConfirmCarSelection.Visible = true;
                CalculateTotalCost();
            }
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMessageBoxShown)
            {
                isMessageBoxShown = false; 
                return; // Skip the event handler
            }

            if (lvwRental.Items.Count > 0 && MessageBox.Show("If you proceed with a new customer, the bookings will be cleared. Do you want to proceed?", "Clear bookings", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                isMessageBoxShown = true;
                if (previousSelectedCustomer != -1)
                {
                    lstCustomer.SelectedIndex = previousSelectedCustomer;
                }
                else
                {
                    lstCustomer.ClearSelected();
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                lvwRental.Items.Clear();
                previousSelectedCustomer = lstCustomer.SelectedIndex;
            }
        }



        private void ResetCarDetails()
        {
            // If the DataSet and DataTable are not null, fill the DataGridView with all cars
            if (dsRoadTripRentals != null && dsRoadTripRentals.Tables.Contains("CarDetails"))
            {
                dsRoadTripRentals.Tables["CarDetails"].Clear();
                daCarDetails.SelectCommand.CommandText = "SELECT * FROM CarDetails";
                daCarDetails.Fill(dsRoadTripRentals, "CarDetails");
                dgvCars.DataSource = dsRoadTripRentals.Tables["CarDetails"];
                btnResetFilters.Visible = false;
            }
            else
            {
                // Log an error message or throw an exception.
                Console.WriteLine("DataSet or DataTable is null.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rentalId = Convert.ToInt32(lstRental.SelectedValue);

            // Delete RentalCar rows for the specified RentalID
            DataRow[] rentalCarRows = dsRoadTripRentals.Tables["RentalCar"].Select($"RentalID = {rentalId}");
            foreach (DataRow rentalCarRow in rentalCarRows)
            {
                rentalCarRow.Delete();
            }

            // Delete Rental row for the specified RentalID
            DataRow rentalRow = dsRoadTripRentals.Tables["Rental"].Rows.Find(rentalId);
            if (rentalRow != null)
            {
                rentalRow.Delete();
            }

            // Delete PaymentType rows for the specified PaymentID
            int paymentId = Convert.ToInt32(txtPaymentID.Text);
            DataRow[] paymentRows = dsRoadTripRentals.Tables["PaymentType"].Select($"PaymentID = {paymentId}");
            foreach (DataRow paymentRow in paymentRows)
            {
                paymentRow.Delete();
            }

            // Create the delete commands for the data adapter
            SqlCommand deleteRentalCarCommand = new SqlCommand("DELETE FROM RentalCar WHERE RentalID = @RentalID");
            deleteRentalCarCommand.Parameters.AddWithValue("@RentalID", rentalId);

            SqlCommand deleteRentalCommand = new SqlCommand("DELETE FROM Rental WHERE RentalID = @RentalID");
            deleteRentalCommand.Parameters.AddWithValue("@RentalID", rentalId);

            SqlCommand deletePaymentCommand = new SqlCommand("DELETE FROM PaymentType WHERE PaymentID = @PaymentID");
            deletePaymentCommand.Parameters.AddWithValue("@PaymentID", paymentId);

            // Assign the delete commands to the data adapter
            daRentalCar.DeleteCommand = deleteRentalCarCommand;
            daRental.DeleteCommand = deleteRentalCommand;
            daPayment.DeleteCommand = deletePaymentCommand;

            // Assign the connection object to the delete commands
            daRentalCar.DeleteCommand.Connection = conn;
            daRental.DeleteCommand.Connection = conn;
            daPayment.DeleteCommand.Connection = conn;

            // Perform the updates on the dataset
            daRentalCar.Update(dsRoadTripRentals, "RentalCar");
            daRental.Update(dsRoadTripRentals, "Rental");
            daPayment.Update(dsRoadTripRentals, "PaymentType");

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Assign the connection object to the UpdateCommand if it is not null
                if (daRentalCar.UpdateCommand != null)
                {
                    daRentalCar.UpdateCommand.Connection = conn;
                }

                // Open the connection
                conn.Open();

                // Update the dataset with the changes
                daRental.Update(dsRoadTripRentals, "Rental");
                daRentalCar.Update(dsRoadTripRentals, "RentalCar");
                daPayment.Update(dsRoadTripRentals, "PaymentType");

                // Clear the dataset and refill it with fresh data
                dsRoadTripRentals.Clear();
                daRental.Fill(dsRoadTripRentals, "Rental");
                daRentalCar.Fill(dsRoadTripRentals, "RentalCar");
                daPayment.Fill(dsRoadTripRentals, "PaymentType");

                // Show a message indicating successful deletion
                MessageBox.Show("Rental has been deleted successfully.");
            }
        }




            private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainRentals newSubForm = new frmMainRentals();
            OpenSubFormInPanel(newSubForm);
        }

        private void lstRental_Click(object sender, EventArgs e)
        {
            panelMajor.Enabled = true;
            dtpStartDate.Enabled = true;
            cmbNoOfDays.Enabled = true;
            lvwRental.Enabled = true;

            lvwRental.Items.Clear();

            if (lstRental.Items.Count != 0)
            {
                DataRow drRental = dsRoadTripRentals.Tables["Rental"].Rows.Find(lstRental.SelectedValue);

                txtPaymentID.Text = drRental["PaymentID"].ToString();
                cmbNoOfDays.Text = drRental["NoDays"].ToString();
                cmbNoOfDays.Text = drRental["NoDays"].ToString();

                // Set the PaymentDate from the selected rental
                if (drRental.Table.Columns.Contains("PaymentDate")) // Check if the PaymentDate column exists
                {
                    if (!DBNull.Value.Equals(drRental["PaymentDate"])) // Check if the PaymentDate value is not null
                    {
                        dtpPaymentDate.Value = Convert.ToDateTime(drRental["PaymentDate"]);
                    }
                    else
                    {
                        dtpPaymentDate.Value = DateTime.Now;
                    }
                }
                // Get the paymentID from the selected rental
                int paymentID = Convert.ToInt32(drRental["PaymentID"]);

                // Retrieve PaymentType from the database based on PaymentID
                string paymentQuery = "SELECT * FROM PaymentType WHERE PaymentID = @PaymentID";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(paymentQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", paymentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbPaymentType.Text = reader["PaymentType"].ToString();
                            }
                        }
                    }
                }

                lblBookingDate.Text = (Convert.ToDateTime(drRental["StartDatetime"].ToString())).ToShortDateString();

                dtpStartDate.MinDate = DateTime.MinValue;  // Set MinDate to the earliest possible date
                dtpStartDate.Value = Convert.ToDateTime(drRental["StartDatetime"].ToString());

                dsRoadTripRentals.Tables["RentalCar"].Clear();

                cmdRentalCar.Parameters["@RentalID"].Value = lstRental.SelectedValue;

                daRentalCar.Fill(dsRoadTripRentals, "RentalCar");

                decimal overallCost = 0;

                foreach (DataRow dr in dsRoadTripRentals.Tables["RentalCar"].Rows)
                {
                    if (dr["RentalID"].ToString() == lstRental.Text)
                    {
                        // Get car registration
                        string carReg = dr["CarReg"].ToString();

                        // Get rental duration
                        decimal duration = Convert.ToDecimal(cmbNoOfDays.Text);

                        // Get RentalCostID and daily rental cost for this car
                        DataRow[] carDetails = dsRoadTripRentals.Tables["CarDetails"].Select($"CarReg = '{carReg}'");
                        int rentalCostID = (int)carDetails[0]["RentalCostID"];
                        DataRow[] rentalCosts = dsRoadTripRentals.Tables["RentalCost"].Select($"RentalCostID = {rentalCostID}");
                        decimal dailyRentalCost = (decimal)rentalCosts[0]["RentalCost"];

                        // Calculate total cost
                        decimal totalCost = duration * dailyRentalCost;

                        // Create a ListViewItem with the car registration and total cost
                        ListViewItem item = new ListViewItem(new[] { carReg, totalCost.ToString("C") });

                        lvwRental.Items.Add(item);

                        // Add this total cost to the overall cost
                        overallCost += totalCost;
                    }
                }

                // Set the overall cost in lblFinalCost
                lblFinalCost.Text = overallCost.ToString("C");



                btnAdd.Enabled = true;
                btnDelete.Enabled = true;

            }
        }




        private void chkConfirmCarSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmCarSelection.Checked)
            {
                // If the selection is confirmed, enable the date booked DateTimePicker
                pnlBooking.Enabled = true;
                dgvCars.Enabled = false;
                dgvCars.Visible = false;
                panelCarDetails.Enabled = false;
                pnlPayment.Enabled = false;
                btnResetFilters.Visible = false;
                UpdateAddItemButtonState();
                lblSelectCar.Text = "Selected Car";

            }
            else
            {
                // If the selection is not confirmed, disable the date booked DateTimePicker
                pnlBooking.Enabled = false;
                dgvCars.Enabled = true;
                dgvCars.Visible = true;
                panelCarDetails.Enabled = true;
                ResetCarDetails();
                lblSelectCar.Text = "Select Car";
            }
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetCarDetails();
        }

        private void cmbNoOfDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
            pnlPayment.Enabled = true;
            UpdateAddItemButtonState();

            decimal duration = Convert.ToDecimal(cmbNoOfDays.SelectedItem);

            foreach (ListViewItem item in lvwRental.Items)
            {
                string carReg = item.SubItems[0].Text;

                DataRow[] carDetails = dsRoadTripRentals.Tables["CarDetails"].Select($"CarReg = '{carReg}'");
                int rentalCostID = (int)carDetails[0]["RentalCostID"];

                DataRow[] rentalCosts = dsRoadTripRentals.Tables["RentalCost"].Select($"RentalCostID = {rentalCostID}");
                decimal dailyRentalCost = (decimal)rentalCosts[0]["RentalCost"];

                decimal totalCost = duration * dailyRentalCost;
                item.SubItems[1].Text = totalCost.ToString("C");
            }

            // Calculate the overall cost by summing up all the total costs
            decimal overallCost = 0;
            foreach (ListViewItem item in lvwRental.Items)
            {
                decimal totalCost;
                if (decimal.TryParse(item.SubItems[1].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out totalCost))
                {
                    overallCost += totalCost;
                }
                else
                {
                    // Handle the case where the total cost is not a valid decimal
                    MessageBox.Show("Invalid total cost for car: " + item.SubItems[0].Text);
                }
            }

            // Update the lblFinalCost with the overall cost
            lblFinalCost.Text = overallCost.ToString("C");

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvwRental.SelectedItems.Count != 0)
            {
                var item = lvwRental.SelectedItems[0];
                lvwRental.Items.Remove(item);
            }
        }

        public class MyPayments
        {
            public int PaymentID { get; set; }
            public string PaymentType { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rentalId = Convert.ToInt32(lstRental.SelectedValue);

            DataRow drRental = dsRoadTripRentals.Tables["Rental"].Rows.Find(rentalId);

            // Update the Rental details
            drRental["NoDays"] = int.Parse(cmbNoOfDays.Text);

            // Get the customer ID, car registration, and start date
            int customerId = int.Parse(lblCust0.Text);
            DateTime startDate = DateTime.Now;

            // Remove rental cars that are not in the updated lvwRental list
            var existingRentalCars = dsRoadTripRentals.Tables["RentalCar"].Select($"RentalID = {rentalId}");
            foreach (DataRow existingRentalCar in existingRentalCars)
            {
                string carReg = existingRentalCar["CarReg"].ToString();
                bool found = false;
                foreach (ListViewItem item in lvwRental.Items)
                {
                    if (item.Text == carReg)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    existingRentalCar.Delete();
                }
            }

            // Update the RentalCar table based on the items in lvwRental
            foreach (ListViewItem item in lvwRental.Items)
            {
                string carReg = item.Text;

                var existingRentalCar = dsRoadTripRentals.Tables["RentalCar"].AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("RentalID") == rentalId && row.Field<string>("CarReg") == carReg);

                if (existingRentalCar == null)
                {
                    // If the rental car doesn't exist, create a new DataRow and add it to the DataTable
                    DataRow newRentalCar = dsRoadTripRentals.Tables["RentalCar"].NewRow();
                    newRentalCar["RentalID"] = rentalId;
                    newRentalCar["CarReg"] = carReg;
                    dsRoadTripRentals.Tables["RentalCar"].Rows.Add(newRentalCar);
                }
            }



            // Create the update command for the Rental table
            var updateRentalCommand = new SqlCommand("UPDATE Rental SET NoDays = @NoDays WHERE RentalID = @RentalID");
            updateRentalCommand.Parameters.Add("@NoDays", SqlDbType.Int, 4, "NoDays");
            updateRentalCommand.Parameters.Add("@RentalID", SqlDbType.Int, 4, "RentalID");

            // Assign the update command to the data adapter
            daRental.UpdateCommand = updateRentalCommand;

            // Create a SqlConnection object and assign it to the UpdateCommand
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                daRental.UpdateCommand.Connection = conn;

                // Open the connection
                conn.Open();

                // Update the dataset with the changes
                daRental.Update(dsRoadTripRentals, "Rental");
                daRentalCar.Update(dsRoadTripRentals, "RentalCar");

                // Show a message indicating successful update
                MessageBox.Show("Rental details have been updated successfully.");

            }

        }


        private void ResetForm()
        {
            // Reset all the controls
            cmbNoOfDays.SelectedIndex = -1;
            cmbPaymentType.SelectedIndex = -1;
            lblCust0.Text = "";
            dgvCars.ClearSelection();
            lvwRental.Items.Clear();
            lblTotalCost.Text = "";
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





        private void getNumber()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(PaymentID) FROM PaymentType", conn);
                    int maxPaymentID = (int)cmd.ExecuteScalar();
                    txtPaymentID.Text = (maxPaymentID + 1).ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching the next PaymentID: " + ex.Message);
            }
        }

        private void CalculateTotalCost()
        {
            if (cmbNoOfDays.SelectedItem != null && dgvCars.SelectedRows.Count > 0)
            {
                decimal duration = Convert.ToDecimal(cmbNoOfDays.SelectedItem);

                // Obtain the RentalCostID from the selected row in dgvCars
                int rentalCostID = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["RentalCostID"].Value);

                // Lookup the corresponding RentalCost in the RentalCost
                DataRow[] foundRows = dsRoadTripRentals.Tables["RentalCost"].Select("RentalCostID = " + rentalCostID);
                if (foundRows.Length > 0)
                {
                    decimal dailyRentalCost = Convert.ToDecimal(foundRows[0]["RentalCost"]);

                    decimal totalCost = duration * dailyRentalCost;
                    lblTotalCost.Text = totalCost.ToString("C");
                }
                else
                {
                    // Handle the case where no corresponding RentalCost is found for the given RentalCostID
                    MessageBox.Show("No corresponding RentalCost found for the selected car.");
                }
            }
        }



        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Make sure all necessary data is selected
            if (dgvCars.SelectedRows.Count > 0 && cmbNoOfDays.SelectedItem != null && cmbPaymentType.SelectedItem != null)
            {
                // Get the selected car's registration number
                string carReg = dgvCars.SelectedRows[0].Cells["CarReg"].Value.ToString();

                // Check if this car is already added to the ListView
                foreach (ListViewItem item in lvwRental.Items)
                {
                    if (item.SubItems[0].Text == carReg)
                    {
                        MessageBox.Show("This car is already added.", "Booking");
                        return; // Exit the method here
                    }
                }

                // Get the selected rental ID
                int rentalId = Convert.ToInt32(lstRental.SelectedValue);

                // Find the corresponding rental car row based on the car registration and rental ID
                DataRow rentalCarRow = dsRoadTripRentals.Tables["RentalCar"].AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("RentalID") == rentalId && row.Field<string>("CarReg") == carReg);

                // Find the corresponding car details row based on the car registration
                DataRow carDetailsRow = dsRoadTripRentals.Tables["CarDetails"].AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("CarReg") == carReg);

                // Retrieve the rental cost ID from the car details row
                int rentalCostId = Convert.ToInt32(carDetailsRow["RentalCostID"]);

                // Find the corresponding rental cost row based on the rental cost ID
                DataRow rentalCostRow = dsRoadTripRentals.Tables["RentalCost"].AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("RentalCostID") == rentalCostId);

                // Retrieve the rental cost from the rental cost row
                decimal dailyRentalCost = Convert.ToDecimal(rentalCostRow["RentalCost"]);

                // Calculate the total cost
                decimal duration = Convert.ToDecimal(cmbNoOfDays.SelectedItem);
                decimal totalCost = duration * dailyRentalCost;

                // Get the selected payment type
                string paymentType = cmbPaymentType.SelectedItem.ToString();

                // Get the selected booking date
                DateTime bookingDate = dtpStartDate.Value;

                // Calculate the end date of the booking with a 1-day grace period
                DateTime endDate = bookingDate.AddDays((double)duration + 1);

                DateTime paymentDate = dtpPaymentDate.Value;

                // Create a new ListViewItem with these details
                ListViewItem listItem = new ListViewItem(new[] { carReg, totalCost.ToString("C"), paymentType, bookingDate.ToString("d"), duration.ToString(), paymentDate.ToString("d") });

                // Add the item to the ListView
                lvwRental.Items.Add(listItem);
                pnlPayment.Enabled = false;
                pnlBooking.Enabled = false;

                // Reset car details after adding a new item
                ResetCarDetails();
                btnResetFilters.Visible = false;


                // Clear selected car in dgvCars
                dgvCars.ClearSelection();

                // Reset labels
                lblCarReg.Text = "";
                lblModelID.Text = "";
                lblColour.Text = "";
                lblMileage.Text = "";
                lblFuelType.Text = "";
                lblNoSeats.Text = "";
                lblYear.Text = "";
                lblRentalCostID.Text = "";

                // Disable the confirm selection checkbox
                chkConfirmCarSelection.Checked = false;
                chkConfirmCarSelection.Enabled = false;
                chkConfirmCarSelection.Visible = false;

                // Enable the cars DataGridView
                dgvCars.Enabled = true;
                dgvCars.Visible = true;
                panelCarDetails.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a car, rental duration, payment type, and booking date.");
            }
        }



        private void UpdateAddItemButtonState()
        {
            // Enable the Add Item button only if both panelBooking and pnlPayment are enabled
            btnAddItem.Enabled = pnlBooking.Enabled && pnlPayment.Enabled;
        }





        private void ClearCustomer()
        {
            lstCustomer.SelectedIndex = -1;

            lblCust0.Text = "";
            lblCust1.Text = "";
            lblCust2.Text = "";
            lblCust3.Text = "";
            lblCust4.Text = "";
            lblCust5.Text = "";
        }

    }



}

