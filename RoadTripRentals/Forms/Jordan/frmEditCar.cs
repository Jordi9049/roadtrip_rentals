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
    public partial class frmEditCar : Form
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
        private string carReg;

        public frmEditCar(string carReg)
        {
            InitializeComponent();

            this.carReg = carReg;
        }

        private void frmEditCar_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Car' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlCarDetails = @"select * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlCarDetails, connStr);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");

            // Load data into ModelID ComboBox
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT ModelID, ModelDesc FROM Model", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbEditModelID.DataSource = dt;
                    cmbEditModelID.DisplayMember = "ModelDesc";
                    cmbEditModelID.ValueMember = "ModelID";
                }
            }

            // Load data into RentalCostID ComboBox
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT RentalCostID, RentalCost FROM RentalCost", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbEditRentalCostID.DataSource = dt;
                    cmbEditRentalCostID.DisplayMember = "RentalCost";
                    cmbEditRentalCostID.ValueMember = "RentalCostID";
                }
            }

            PopulateColourComboBox(cmbEditColour);  // in frmEditCar_Load


            // Load the car details.
            DataRow carRow = dsRoadTripRentals.Tables["CarDetails"].Rows.Find(carReg);

            if (carRow != null)
            {
                lblEditCarReg.Text = carRow["CarReg"].ToString();
                cmbEditModelID.SelectedValue = carRow["ModelID"];
                cmbEditColour.SelectedItem = carRow["Colour"].ToString();
                txtEditMileage.Value = Convert.ToDecimal(carRow["Mileage"]);
                cmbEditFuelType.Text = carRow["FuelType"].ToString();
                txtEditNoSeats.Value = Convert.ToDecimal(carRow["NoSeats"]);
                txtEditYear.Value = Convert.ToDecimal(carRow["Year"]);
                cmbEditRentalCostID.SelectedValue = carRow["RentalCostID"];
            }
            else
            {
                MessageBox.Show("Car not found.");
            }

            // Now you can set the SelectedValue
            cmbEditModelID.SelectedValue = carRow["ModelID"];
            cmbEditRentalCostID.SelectedValue = carRow["RentalCostID"];
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            frmMainCar newSubForm = new frmMainCar();
            OpenSubFormInPanel(newSubForm);
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            MyCar myCar = new MyCar();
            bool ok = true;
            errP.Clear();

            try
            {
                myCar.ModelID = cmbEditModelID.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditModelID, MyEx.validate());
            }

            //COLOUR
            try
            {
                myCar.Colour = cmbEditColour.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditColour, MyEx.validate());
            }

            //MILEAGE
            try
            {
                myCar.Mileage = (int)txtEditMileage.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditMileage, MyEx.validate());
            }

            //FUEL TYPE
            try
            {
                myCar.FuelType = cmbEditFuelType.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditFuelType, MyEx.validate());
            }

            //NO SEATS
            try
            {
                myCar.NoSeats = (int)txtEditNoSeats.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditNoSeats, MyEx.validate());
            }

            //YEAR
            try
            {
                myCar.Year = (int)txtEditYear.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditYear, MyEx.validate());
            }

            //RENTAL COST ID
            try
            {
                myCar.RentalCostID = (int)cmbEditRentalCostID.SelectedValue;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditRentalCostID, MyEx.validate());
            }

            if (ok)
            {
                DataRow drCar = dsRoadTripRentals.Tables["CarDetails"].Rows.Find(myCar.CarReg);

                if (drCar != null)
                {
                    drCar["ModelID"] = myCar.ModelID;
                    drCar["Colour"] = myCar.Colour;
                    drCar["Mileage"] = myCar.Mileage;
                    drCar["FuelType"] = myCar.FuelType;
                    drCar["NoSeats"] = myCar.NoSeats;
                    drCar["Year"] = myCar.Year;
                    drCar["RentalCostID"] = myCar.RentalCostID;

                    daCarDetails.Update(dsRoadTripRentals, "CarDetails");

                    MessageBox.Show("Car Updated");
                }
                else
                {
                    MessageBox.Show("Car not found.");
                }
            }
        }

        private void PopulateColourComboBox(ComboBox comboBox)
        {
            string[] colours = new string[]
            {
        "Red",
        "Blue",
        "Green",
        "Yellow",
        "Black",
        "White",
        "Gray",
        "Silver",
        "Purple",
        "Orange",
        "Brown",
        "Pink"
                // Add more colours as needed
            };

            foreach (string colour in colours)
            {
                comboBox.Items.Add(colour);
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
