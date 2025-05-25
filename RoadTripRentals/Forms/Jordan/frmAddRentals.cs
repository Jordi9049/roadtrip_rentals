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
    public partial class frmAddRentals : Form
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
        SqlCommand cmdCarDetails;
        DataRow drCarDetails;
        String sqlCarDetails, sqlCarDetailsDetails;


        SqlDataAdapter daPayment, daPaymentss;
        SqlCommandBuilder cmdBPayment, cmdBRental, cmdBRentalCost;
        SqlCommand cmdPaymentsDetails;
        DataRow drPayment;
        String sqlRentalCar, sqlRentalCost, sqlPayment, sqlPaymentsDetails;


        private int previousSelectedCustomer = -1;
        private bool isMessageBoxShown = false;



        public frmAddRentals()
        {
            InitializeComponent();
            Load += frmAddRentals_Load;
        }

        private void frmAddRentals_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            ClearCustomer();
            btnAddItem.Enabled = false;

            int no;

            lblBookingDate.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;
            dtpPaymentDate.MinDate = DateTime.Now;

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

            v.Enabled = false;
            v.Visible = false;
            pnlBooking.Enabled = false;
            pnlPayment.Enabled = false;
            btnResetFilters.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCarDetails.Enabled = false;
            Button b = (Button)sender;
            // get customer details for listbox - use selected button layer for parameter
            String str = b.Text;

            //empty dataset table customer
            dsRoadTripRentals.Tables["Customer"].Clear();

            fillListBoxCustomers(str);

            ClearCustomer();

            pnlBooking.Enabled = false;

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

            v.Enabled = false;
            v.Visible = false;
            pnlBooking.Enabled = false;

            // Populate dgvCars and display the Confirm Selection checkbox only after a customer is selected
            if (lstCustomer.SelectedItems.Count > 0)
            {
                ResetCarDetails();  // Make sure this method populates dgvCars with all cars and doesn't clear it

                // Enable the Confirm Selection checkbox
                v.Enabled = true;
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
                v.Enabled = true;
                v.Visible = true;
                CalculateTotalCost();
            }
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMessageBoxShown)
            {
                isMessageBoxShown = false; // Reset the flag
                return; // Skip the event handler
            }

            if (lvwRental.Items.Count > 0 && MessageBox.Show("If you proceed with a new customer, the bookings will be cleared. Do you want to proceed?", "Clear bookings", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                isMessageBoxShown = true; // Set the flag
                if (previousSelectedCustomer != -1)
                {
                    lstCustomer.SelectedIndex = previousSelectedCustomer;
                }
                else
                {
                    lstCustomer.ClearSelected();
                }
            }
            else
            {
                btnAdd.Enabled = false;
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

        private void btnAddCancel_Click(object sender, EventArgs e)
        { 
            frmMainRentals newSubForm = new frmMainRentals();
            OpenSubFormInPanel(newSubForm);
        }

        private void chkConfirmCarSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (v.Checked)
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
            MyPayments myPayments = new MyPayments();

            // Generate a new PaymentID by finding a unique value not already present in the PaymentType table
            int paymentId = GenerateUniquePaymentId();

            if (paymentId == -1)
            {
                // Unable to generate a unique paymentId
                MessageBox.Show("Failed to generate a unique PaymentID. Please try again.");
                return;
            }

            DataRow drPayments = dsRoadTripRentals.Tables["PaymentType"].NewRow();
            drPayments["PaymentID"] = paymentId;
            drPayments["PaymentType"] = cmbPaymentType.Text.Trim();
            dsRoadTripRentals.Tables["PaymentType"].Rows.Add(drPayments);
            daPayment.Update(dsRoadTripRentals, "PaymentType");


            DataRow drRental;
            int rentalId;

            // Get the next RentalID
            int noRows = dsRoadTripRentals.Tables["Rental"].Rows.Count;
            drRental = dsRoadTripRentals.Tables["Rental"].Rows[noRows - 1];
            rentalId = (int.Parse(drRental["RentalID"].ToString()) + 1);

            // Create new Rental row
            drRental = dsRoadTripRentals.Tables["Rental"].NewRow();
            drRental["RentalID"] = rentalId;
            drRental["CustomerID"] = int.Parse(lblCust0.Text);
            drRental["StartDatetime"] = DateTime.Now;
            drRental["NoDays"] = int.Parse(cmbNoOfDays.Text);
            drRental["PaymentID"] = paymentId; // Assign the generated paymentId
            drRental["PaymentDate"] = DateTime.Now; // Set the PaymentDate column to the current date and time

            // Get the customer ID, car registration, and start date you're about to insert
            int customerID = int.Parse(lblCust0.Text);
            string carReg = dgvCars.SelectedRows[0].Cells["CarReg"].Value.ToString();
            DateTime startDate = DateTime.Now; // If you're using another date, use that instead

            foreach (ListViewItem item in lvwRental.Items)
            {
                carReg = item.Text;
                int noDays = int.Parse(cmbNoOfDays.Text);

                var existingRentals = dsRoadTripRentals.Tables["Rental"].AsEnumerable()
                    .Where(r => r.Field<int>("CustomerID") == customerID)
                    .Join(dsRoadTripRentals.Tables["RentalCar"].AsEnumerable(),
                        rental => rental.Field<int>("RentalID"),
                        rentalCar => rentalCar.Field<int>("RentalID"),
                        (rental, rentalCar) => new { Rental = rental, RentalCar = rentalCar })
                    .Where(joined => joined.RentalCar.Field<string>("CarReg") == carReg);

                foreach (var existingRental in existingRentals)
                {
                    DateTime existingStartDate = existingRental.Rental.Field<DateTime>("StartDatetime");
                    int existingNoDays = existingRental.Rental.Field<int>("NoDays");
                    DateTime existingEndDate = existingStartDate.AddDays(existingNoDays);

                    // Check if the new rental date overlaps with the existing rental period
                    if ((startDate >= existingStartDate && startDate <= existingEndDate) ||
                        (startDate.AddDays(noDays) >= existingStartDate && startDate.AddDays(noDays) <= existingEndDate))
                    {
                        MessageBox.Show("You cannot book the same car on overlapping dates.");
                        return;
                    }
                }
            }






            dsRoadTripRentals.Tables["Rental"].Rows.Add(drRental);
            daRental.Update(dsRoadTripRentals, "Rental");
            // Create new RentalCar row for each car in the lvwRental ListView


            foreach (ListViewItem item in lvwRental.Items)
            {
                DataRow drRentalCar = dsRoadTripRentals.Tables["RentalCar"].NewRow();
                drRentalCar["RentalID"] = drRental["RentalID"];
                drRentalCar["CarReg"] = item.Text;

                //// Code to assign TotalCost
                //string costText = item.SubItems[1].Text.Replace("£", string.Empty).Trim();
                //drRentalCar["TotalCost"] = decimal.Parse(costText);

                dsRoadTripRentals.Tables["RentalCar"].Rows.Add(drRentalCar);
                daRentalCar.Update(dsRoadTripRentals, "RentalCar");
            }



            MessageBox.Show("Rental ID:  " + drRental["RentalID"].ToString() + " added to the system");

            DialogResult result = MessageBox.Show("Do you want to add another rental?", "Add Another Rental", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Reset the form to its initial state
                ResetForm();
                btnAdd.Enabled = false;
            }
            else
            {
                frmMainRentals subForm = new frmMainRentals();
                OpenSubFormInPanel(subForm);
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
            // ... etc for all other controls that need resetting
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

        private int GenerateUniquePaymentId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(PaymentID) FROM PaymentType", conn);
                    int maxPaymentID = (int)cmd.ExecuteScalar();
                    int paymentId = maxPaymentID + 1;

                    // Check if the generated paymentId already exists in the PaymentType table
                    while (CheckPaymentIdExists(paymentId))
                    {
                        paymentId++;
                    }

                    return paymentId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating unique PaymentID: " + ex.Message);
                return -1;
            }
        }

        private bool CheckPaymentIdExists(int paymentId)
        {
            return dsRoadTripRentals.Tables["PaymentType"]
                .AsEnumerable()
                .Any(row => row.Field<int>("PaymentID") == paymentId);
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
                    MessageBox.Show("No corresponding Rental Cost found for the selected car.");
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

                // Calculate the total cost
                decimal duration = Convert.ToDecimal(cmbNoOfDays.SelectedItem);

                DataRow[] carDetails = dsRoadTripRentals.Tables["CarDetails"].Select($"CarReg = '{carReg}'");
                int rentalCostID = (int)carDetails[0]["RentalCostID"];

                DataRow[] rentalCosts = dsRoadTripRentals.Tables["RentalCost"].Select($"RentalCostID = {rentalCostID}");
                decimal dailyRentalCost = (decimal)rentalCosts[0]["RentalCost"];

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

                // Calculate the overall cost for all items in the lvwRental ListView
                decimal overallCost = 0;
                foreach (ListViewItem item in lvwRental.Items)
                {
                    decimal itemCost;
                    if (decimal.TryParse(item.SubItems[1].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out itemCost))
                    {
                        overallCost += itemCost;
                    }
                }

                // Update the lblFinalCost with the overall cost
                lblFinalCost.Text = overallCost.ToString("C");


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
                v.Checked = false;
                v.Enabled = false;
                v.Visible = false;
               
                // Enable the cars DataGridView
                dgvCars.Enabled = true;
                dgvCars.Visible = true;
                panelCarDetails.Enabled = true;

                //Rental button confirmation enabled
                btnAdd.Enabled = true;
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

