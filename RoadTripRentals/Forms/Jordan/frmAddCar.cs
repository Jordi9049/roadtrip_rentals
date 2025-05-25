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
    public partial class frmAddCar : Form
    {
        SqlDataAdapter daCarDetails, daCarDetailss;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBCarDetails;
        SqlCommand cmdCarDetailsDetails;
        DataRow drCarDetails;
        SqlConnection conn;
        String sqlCarDetails, sqlCarDetailsDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        //private string connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
        private string connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";

        public frmAddCar()
        {
            InitializeComponent();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainCar newSubForm = new frmMainCar();
            OpenSubFormInPanel(newSubForm);
        }




        private void frmAddCar_Load(object sender, EventArgs e)
        {
            sqlCarDetails = @"select * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlCarDetails, connStr);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");

            cmbAddColour.Items.Add("Red");
            cmbAddColour.Items.Add("Blue");
            cmbAddColour.Items.Add("Green");

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT ModelID, ModelDesc FROM Model", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAddModelID.DataSource = dt;
                    cmbAddModelID.DisplayMember = "ModelDesc";
                    cmbAddModelID.ValueMember = "ModelID";
                }

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT RentalCostID, RentalCost FROM RentalCost", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAddRentalCostID.DataSource = dt;
                    cmbAddRentalCostID.DisplayMember = "RentalCost";
                    cmbAddRentalCostID.ValueMember = "RentalCostID";
                }

            }
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyCar myCar = new MyCar();
            bool ok = true;
            errP.Clear();

            //CAR REG
            try
            {
                myCar.CarReg = txtAddCarReg.Text.Trim().Replace(" ", "");
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCarReg, MyEx.validate());
            }

            try
            {
                myCar.ModelID = cmbAddModelID.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddModelID, MyEx.validate());
            }

            //COLOUR
            try
            {
                myCar.Colour = cmbAddColour.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddColour, MyEx.validate());
            }

            //MILEAGE
            try
            {
                myCar.Mileage = (int)txtAddMileage.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddMileage, MyEx.validate());
            }

            //FUEL TYPE
            try
            {
                myCar.FuelType = cmbAddFuelType.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddFuelType, MyEx.validate());
            }

            //NO SEATS
            try
            {
                myCar.NoSeats = (int)txtAddNoSeats.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddNoSeats, MyEx.validate());
            }

            //YEAR
            try
            {
                myCar.Year = (int)txtAddYear.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddYear, MyEx.validate());
            }

            //RENTAL COST ID
            try
            {
                myCar.RentalCostID = (int)cmbAddRentalCostID.SelectedValue;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddRentalCostID, MyEx.validate());
            }


            try
            {
                if (ok)
                {
                    DataRow drCar = dsRoadTripRentals.Tables["CarDetails"].NewRow();

                    drCar["CarReg"] = myCar.CarReg;
                    drCar["ModelID"] = myCar.ModelID;
                    drCar["Colour"] = myCar.Colour;
                    drCar["Mileage"] = myCar.Mileage;
                    drCar["FuelType"] = myCar.FuelType;
                    drCar["NoSeats"] = myCar.NoSeats;
                    drCar["Year"] = myCar.Year;
                    drCar["RentalCostID"] = myCar.RentalCostID;

                    try
                    {
                        dsRoadTripRentals.Tables["CarDetails"].Rows.Add(drCar);
                        daCarDetails.Update(dsRoadTripRentals, "CarDetails");

                        // If no exceptions are thrown, show the "Car Added" message
                        MessageBox.Show("Car Added");

                        if (MessageBox.Show("Do you wish to add another car?", "Add Car", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clearAddForm();
                        }
                        else
                        {
                            frmMainCar newSubForm = new frmMainCar();
                            OpenSubFormInPanel(newSubForm);
                        }
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("The car registration number '" + myCar.CarReg + "' already exists. Please enter a unique registration number.", "Duplicate Car Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }


        void clearAddForm()
        {
            txtAddCarReg.Clear();
            cmbAddModelID.SelectedIndex = -1;
            cmbAddColour.SelectedIndex = -1;
            txtAddMileage.Value = 1;
            cmbAddFuelType.SelectedIndex = -1;
            txtAddNoSeats.Value = 2;
            txtAddYear.Value = 1950;
            cmbAddRentalCostID.SelectedIndex = -1;
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
