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
    public partial class frmAddRentalCost : Form
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


        public frmAddRentalCost()
        {
            InitializeComponent();
        }


        private void frmAddRentalCost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.RentalCost' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlRentalCost = @"select * from RentalCost";
            daRentalCost = new SqlDataAdapter(sqlRentalCost, connStr);
            cmdBRentalCost = new SqlCommandBuilder(daRentalCost);
            daRentalCost.FillSchema(dsRoadTripRentals, SchemaType.Source, "RentalCost");
            daRentalCost.Fill(dsRoadTripRentals, "RentalCost");

            int noRows = dsRoadTripRentals.Tables["RentalCost"].Rows.Count;

            if (noRows == 0)
                txtRentalCostID.Text = "10000";
            else
            {
                getNumber();
            }
        }

        public class MyRentalCost
        {
            public int RentalCostID { get; set; }
            public decimal RentalCost { get; set; }
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyRentalCost myRentalCost = new MyRentalCost();
            bool ok = true;
            errP.Clear();

            // RentalCostID
            try
            {
                myRentalCost.RentalCostID = Convert.ToInt32(txtRentalCostID.Text.Trim());
                // drRentalCost["RentalCostID"] = myRentalCost.RentalCostID; // Remove this line
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtRentalCostID, ex.Message);
            }

            // RentalCost
            try
            {
                myRentalCost.RentalCost = txtRentalCost.Value; // NumericUpDown.Value returns a decimal
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtRentalCost, ex.Message);
            }


            if (ok)
            {
                DataRow drRentalCost = dsRoadTripRentals.Tables["RentalCost"].NewRow();

                drRentalCost["RentalCostID"] = myRentalCost.RentalCostID;

                drRentalCost["RentalCost"] = myRentalCost.RentalCost;

                // RentalCostID is auto-incremented in the database, so no need to set it here

                try
                {
                    dsRoadTripRentals.Tables["RentalCost"].Rows.Add(drRentalCost);
                    daRentalCost.Update(dsRoadTripRentals, "RentalCost");


                    // If no exceptions are thrown, show the "Rental Cost Added" message
                    MessageBox.Show("Rental Cost Added");



                    if (MessageBox.Show("Do you wish to add another rental cost?", "Add Rental Cost", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber();
                    }
                    else
                    {
                        frmMainRentalCost newSubForm = new frmMainRentalCost();
                        OpenSubFormInPanel(newSubForm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainRentalCost newSubForm = new frmMainRentalCost();
            OpenSubFormInPanel(newSubForm);
        }


        void clearAddForm()
        {
            txtRentalCost.Value = txtRentalCost.Minimum;
        }


        private void getNumber()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(RentalCostID) FROM RentalCost", conn);
                    int maxRentalCostId = (int)cmd.ExecuteScalar();
                    txtRentalCostID.Text = (maxRentalCostId + 1).ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching the next RentalCostID: " + ex.Message);
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
