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
    public partial class frmEditRentalCost : Form
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

        public int RentalCostIdToEdit { get; set; }

        public frmEditRentalCost(int rentalCostID)
        {
            InitializeComponent();
            RentalCostIdToEdit = rentalCostID;
        }


        private void frmEditRentalCost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.RentalCost' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlRentalCost = @"select * from RentalCost";
            daRentalCost = new SqlDataAdapter(sqlRentalCost, connStr);
            cmdBRentalCost = new SqlCommandBuilder(daRentalCost);
            daRentalCost.FillSchema(dsRoadTripRentals, SchemaType.Source, "RentalCost");
            daRentalCost.Fill(dsRoadTripRentals, "RentalCost");

            LoadRentalCost(RentalCostIdToEdit);
        }

        public class MyRentalCost
        {
            public int RentalCostID { get; set; }
            public decimal RentalCost { get; set; }
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            MyRentalCost myRentalCost = new MyRentalCost();
            bool ok = true;
            errP.Clear();

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
                DataRow drRentalCost = dsRoadTripRentals.Tables["RentalCost"].Rows.Find(RentalCostIdToEdit);

                drRentalCost["RentalCost"] = myRentalCost.RentalCost;

                try
                {
                    daRentalCost.Update(dsRoadTripRentals, "RentalCost");

                    // If no exceptions are thrown, show the "Rental Cost Updated" message
                    MessageBox.Show("Rental Cost Updated");

                    // Go directly to the MainRentalCost form after editing
                    frmMainRentalCost newSubForm = new frmMainRentalCost();
                    OpenSubFormInPanel(newSubForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadRentalCost(int rentalCostId)
        {
            DataRow drRentalCost = dsRoadTripRentals.Tables["RentalCost"].Rows.Find(rentalCostId);
            if (drRentalCost != null)
            {
                txtRentalCostID.Text = drRentalCost["RentalCostID"].ToString();
                txtRentalCost.Value = Convert.ToDecimal(drRentalCost["RentalCost"]);
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainRentalCost newSubForm = new frmMainRentalCost();
            OpenSubFormInPanel(newSubForm);
        }


        void clearEditForm()
        {
            txtRentalCost.Value = txtRentalCost.Minimum;
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
