using RoadTripRentals.Forms.Jordan;
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

namespace RoadTripRentals
{
    public partial class frmMainCustomer : Form
    {
        SqlDataAdapter daCustomer, daRental;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBRental;
        String connStr, sqlCustomer, sqlRental;

        public delegate void OpenSubFormRequestHandler(Form subForm);

        public frmMainCustomer()
        {
            InitializeComponent();
        }

        

        private void frmMainCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Customer' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsRoadTripRentals, SchemaType.Source, "Customer");
            daCustomer.Fill(dsRoadTripRentals, "Customer");

            sqlRental = @"select * from Rental";
            daRental = new SqlDataAdapter(sqlRental, connStr);
            cmdBRental = new SqlCommandBuilder(daRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");
            daRental.Fill(dsRoadTripRentals, "Rental");
            dgvCustomers.DataSource = dsRoadTripRentals.Tables["Customer"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            btnDelCustomer.Click += btnDelCustomer_Click;

        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                // Check if the customer is associated with any rentals
                DataRow[] rentalRows = dsRoadTripRentals.Tables["Rental"].Select($"CustomerID = {customerID}");
                if (rentalRows.Length > 0)
                {
                    MessageBox.Show("Cannot delete the customer because they are associated with rentals.");
                    return;
                }

                // Ask for confirmation before deleting the customer
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the customer from the dataset and update the database
                    DataRow customerRow = dsRoadTripRentals.Tables["Customer"].Rows.Find(customerID);
                    if (customerRow != null)
                    {
                        customerRow.Delete();
                        daCustomer.Update(dsRoadTripRentals, "Customer");

                        MessageBox.Show("Customer Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }
                }
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer newSubForm = new frmAddCustomer();
            OpenSubFormInPanel(newSubForm);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                frmEditCustomer newSubForm = new frmEditCustomer(customerID);
                OpenSubFormInPanel(newSubForm);
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
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
