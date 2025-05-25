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
    public partial class frmMainPayments : Form
    {
        SqlDataAdapter daPayments, daPaymentss, daRental;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBPayments, cmdBRental;
        SqlCommand cmdPaymentsDetails;
        DataRow drPayments;
        SqlConnection conn;
        String connStr, sqlPayments, sqlPaymentsDetails, sqlRental;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        private void frmMainPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.PaymentType' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlPayments = @"select * from PaymentType";
            daPayments = new SqlDataAdapter(sqlPayments, connStr);
            cmdBPayments = new SqlCommandBuilder(daPayments);
            daPayments.FillSchema(dsRoadTripRentals, SchemaType.Source, "PaymentType");
            daPayments.Fill(dsRoadTripRentals, "PaymentType");

            dgvPayments.DataSource = dsRoadTripRentals.Tables["PaymentType"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvPayments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Rental table
            sqlRental = @"select * from Rental";
            daRental = new SqlDataAdapter(sqlRental, connStr);
            cmdBRental = new SqlCommandBuilder(daRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");
            daRental.Fill(dsRoadTripRentals, "Rental");


            //btnDelPayments.Click += btnDelPayments_Click;
        }

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        private void btnDelPayments_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);

                // Check if any rentals are associated with this payment type
                DataRow[] rentalRows = dsRoadTripRentals.Tables["Rental"].Select($"PaymentID = {paymentID}");

                if (rentalRows.Length > 0)
                {
                    MessageBox.Show("This payment type is associated with one or more rentals and cannot be deleted.", "Cannot Delete");
                    return;
                }

                // Ask for confirmation before deleting the payment type
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected payment type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Find the payment type in the dataset using LINQ
                    DataRow paymentRow = dsRoadTripRentals.Tables["PaymentType"].AsEnumerable().SingleOrDefault(row => row.Field<int>("PaymentID") == paymentID);

                    if (paymentRow != null)
                    {
                        // Delete the payment type from the dataset and update the database
                        paymentRow.Delete();
                        daPayments.Update(dsRoadTripRentals, "PaymentType");

                        MessageBox.Show("Payment type Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Payment type not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a payment type to delete.");
            }
        }





        private void btnEditPayments_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                int PaymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);

                // Assuming dsRoadTripRentals is accessible from this method
                DataRow[] rows = dsRoadTripRentals.Tables["PaymentType"].Select($"PaymentID = {PaymentID}");

                if (rows.Length > 0)
                {
                    frmEditPayments newSubForm = new frmEditPayments(rows[0]);
                    OpenSubFormInPanel(newSubForm);
                }
                else
                {
                    MessageBox.Show("No corresponding data found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Payment type to edit.");
            }
        }



        public frmMainPayments()
        {
            InitializeComponent();
        }

        private void btnAddPayments_Click(object sender, EventArgs e)
        {
            frmAddPayments addPaymentsForm = new frmAddPayments();
            OpenSubFormInPanel(addPaymentsForm);
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
