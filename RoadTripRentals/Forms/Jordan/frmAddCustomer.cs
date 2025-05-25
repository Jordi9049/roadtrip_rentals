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
    public partial class frmAddCustomer : Form
    {
        SqlDataAdapter daCustomer;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        SqlConnection conn;
        String connStr, sqlCustomer;
        

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Customer' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsRoadTripRentals, SchemaType.Source, "Customer");
            daCustomer.Fill(dsRoadTripRentals, "Customer");

            //dgvCustomers.DataSource = dsRoadTripRentals.Tables["Customer"];

            //Resize the DataGridView columns to fit the newly loaded content.
            //dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int noRows = dsRoadTripRentals.Tables["Customer"].Rows.Count;

            if (noRows == 0)
                lblAddCustNoValue.Text = "10000";
            else
            {
                getNumber();
            }

            errP.Clear();
            clearAddForm();
        }

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainCustomer newSubForm = new frmMainCustomer();
            OpenSubFormInPanel(newSubForm);
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();

            //Exception catching

            //CUSTOMER ID
            try
            {
                myCustomer.CustomerID = Convert.ToInt32(lblAddCustNoValue.Text.Trim());  //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddCustomerNo, MyEx.validate());
            }

            //TITLE
            try
            {
                myCustomer.Title = cmbAddTitle.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddTitle, MyEx.validate());
            }

            //SURNAME
            try
            {
                myCustomer.Surname = txtAddSurname.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSurname, MyEx.validate());
            }

            //FORENAME
            try
            {
                myCustomer.Forename = txtAddForename.Text.Trim();  //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddForename, MyEx.validate());
            }

            //STREET NAME
            try
            {
                myCustomer.Street = txtAddStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyEx.validate());
            }

            //CITY/TOWN
            try
            {
                myCustomer.Town = txtAddTown.Text.Trim();   //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTown, MyEx.validate());
            }

            //COUNTY
            try
            {
                myCustomer.County = txtAddCounty.Text.Trim();   //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyEx.validate());
            }

            //POSTCODE
            try
            {
                myCustomer.Postcode = txtAddPostcode.Text.Trim();   //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyEx.validate());
            }


            //EMAIL
            try
            {
                myCustomer.Email = txtAddEmail.Text.Trim();   //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyEx.validate());
            }

            //TELNO
            try
            {
                myCustomer.TelNo = txtAddTelNo.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTelNo, MyEx.validate());
            }

            try
            {
                if (ok)
                {
                    drCustomer = dsRoadTripRentals.Tables["Customer"].NewRow();

                    drCustomer["CustomerID"] = myCustomer.CustomerID;
                    drCustomer["Title"] = myCustomer.Title;
                    drCustomer["Forename"] = myCustomer.Forename;
                    drCustomer["Surname"] = myCustomer.Surname;
                    drCustomer["Street"] = myCustomer.Street;
                    drCustomer["City"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["Postcode"] = myCustomer.Postcode;
                    drCustomer["EmailAddress"] = myCustomer.Email;
                    drCustomer["TelephoneNo"] = myCustomer.TelNo;

                    dsRoadTripRentals.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsRoadTripRentals, "Customer");

                    MessageBox.Show("Customer Added");

                    if (MessageBox.Show("Do you wish to add another customer?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber();
                    }
                    else
                    {
                        frmMainCustomer newSubForm = new frmMainCustomer();
                        OpenSubFormInPanel(newSubForm);
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void getNumber()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(CustomerID) FROM Customer", conn);
                    int maxCustomerId = (int)cmd.ExecuteScalar();
                    lblAddCustNoValue.Text = (maxCustomerId + 1).ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching the next CustomerID: " + ex.Message);
            }
        }


        void clearAddForm()
        {
            cmbAddTitle.SelectedIndex = -1;
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddEmail.Clear();
            txtAddTelNo.Clear();
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
