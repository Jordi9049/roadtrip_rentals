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
    public partial class frmMainRentalCost : Form
    {
        SqlDataAdapter daRentalCost, daRentalCosts;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBRentalCost;
        SqlCommand cmdRentalCostDetails;
        DataRow drRentalCost;
        SqlConnection conn;
        String connStr, sqlRentalCost, sqlRentalCostDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        private void frmMainRentalCost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.RentalCost' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlRentalCost = @"select * from RentalCost";
            daRentalCost = new SqlDataAdapter(sqlRentalCost, connStr);
            cmdBRentalCost = new SqlCommandBuilder(daRentalCost);
            daRentalCost.FillSchema(dsRoadTripRentals, SchemaType.Source, "RentalCost");
            daRentalCost.Fill(dsRoadTripRentals, "RentalCost");

            dgvRentalCosts.DataSource = dsRoadTripRentals.Tables["RentalCost"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvRentalCosts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //btnDelRentalCost.Click += btnDelRentalCost_Click;
        }

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        private void btnDelRentalCost_Click(object sender, EventArgs e)
        {
            if (dgvRentalCosts.SelectedRows.Count > 0)
            {
                string RentalCostID = Convert.ToString(dgvRentalCosts.SelectedRows[0].Cells["RentalCostID"].Value);

                // Check if any car is associated with this RentalCost.
                string sqlCheck = "SELECT COUNT(*) FROM CarDetails WHERE RentalCostID = @RentalCostID";

                // Open the SQL connection
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@RentalCostID", RentalCostID);

                int count = (int)cmdCheck.ExecuteScalar();

                // Close the SQL connection
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("This Rental Cost is assigned to one or more cars and cannot be deleted. Please reassign or this remove this Rental Cost from the Car(s) assocaitd with it.", "Cannot Delete");
                    return;
                }

                // Ask for confirmation before deleting the RentalCost
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected Rental Cost?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rentalCostIdInt = Convert.ToInt32(RentalCostID);
                    DataRow RentalCostRow = dsRoadTripRentals.Tables["RentalCost"].AsEnumerable().SingleOrDefault(row => row.Field<int>("RentalCostID") == rentalCostIdInt);

                    if (RentalCostRow != null)
                    {
                        // Delete the RentalCost from the dataset and update the database
                        RentalCostRow.Delete();
                        daRentalCost.Update(dsRoadTripRentals, "RentalCost");

                        MessageBox.Show("Rental Cost Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Rental Cost not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a RentalCost to delete.");
            }
        }



        private void btnEditRentalCost_Click(object sender, EventArgs e)
        {
            if (dgvRentalCosts.SelectedRows.Count > 0)
            {
                int RentalCostID = Convert.ToInt32(dgvRentalCosts.SelectedRows[0].Cells["RentalCostID"].Value);

                frmEditRentalCost newSubForm = new frmEditRentalCost(RentalCostID);
                OpenSubFormInPanel(newSubForm);
            }
            else
            {
                MessageBox.Show("Please select a RentalCost to edit.");
            }
        }

        public frmMainRentalCost()
        {
            InitializeComponent();
            //frmSettings.ApplyColorScheme(this);
        }

        private void btnAddRentalCost_Click(object sender, EventArgs e)
        {
            frmAddRentalCost addRentalCostForm = new frmAddRentalCost();
            OpenSubFormInPanel(addRentalCostForm);
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
