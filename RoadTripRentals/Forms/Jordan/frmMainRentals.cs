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
    public partial class frmMainRentals : Form
    {
        SqlDataAdapter daRental, daRentals;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBRental;
        SqlCommand cmdRentalDetails;
        DataRow drRental;
        SqlConnection conn;
        String connStr, sqlRental, sqlRentalDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        private void frmMainRentals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Rental' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlRental = @"select * from Rental";
            daRental = new SqlDataAdapter(sqlRental, connStr);
            cmdBRental = new SqlCommandBuilder(daRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");
            daRental.Fill(dsRoadTripRentals, "Rental");

            dgvRentals.DataSource = dsRoadTripRentals.Tables["Rental"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //btnDelRental.Click += btnDelRental_Click;
        }

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;


        private void btnEditRental_Click(object sender, EventArgs e)
        {
            frmEditRental newSubForm = new frmEditRental();
            OpenSubFormInPanel(newSubForm);
        }

        private void btnDelRental_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {
                int RentalID = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells["RentalID"].Value);

                // Ask for confirmation before deleting the Rental
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected Rental type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Find the Rental in the dataset using LINQ
                    DataRow RentalRow = dsRoadTripRentals.Tables["Rental"].AsEnumerable().SingleOrDefault(row => row.Field<int>("RentalID") == RentalID);

                    if (RentalRow != null)
                    {
                        // Delete the Rental from the dataset and update the database
                        RentalRow.Delete();
                        daRental.Update(dsRoadTripRentals, "Rental");

                        MessageBox.Show("Rental Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Rental not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Rental to delete.");
            }
        }

        public frmMainRentals()
        {
            InitializeComponent();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            frmAddRentals addRentalForm = new frmAddRentals();
            OpenSubFormInPanel(addRentalForm);
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
