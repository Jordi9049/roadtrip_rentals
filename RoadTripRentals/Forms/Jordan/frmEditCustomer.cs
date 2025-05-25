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

    public partial class frmEditCustomer : Form
    {

        SqlDataAdapter daCustomer, daCustomers;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        SqlCommand cmdCustomerDetails;
        DataRow drCustomer;
        String connStr, sqlCustomer;

        bool custSelected = false;
        int custNoSelected = 0;

        private void frmEditCustomer_Load(object sender, EventArgs e)
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

            LoadCustomerData(custNoSelected);

        }

        public frmEditCustomer(int customerID)
        {
            InitializeComponent();
            custNoSelected = customerID;
        }

      

        private void LoadCustomerData(int customerID)
        {
            DataRow customerRow = dsRoadTripRentals.Tables["Customer"].Rows.Find(customerID);

            if (customerRow != null)
            {
                lblEditCustNoValue.Text = customerRow["CustomerID"].ToString();
                cmbEditTitle.Text = customerRow["Title"].ToString();
                txtEditForename.Text = customerRow["Forename"].ToString();
                txtEditSurname.Text = customerRow["Surname"].ToString();
                txtEditStreet.Text = customerRow["Street"].ToString();
                txtEditTown.Text = customerRow["City"].ToString();
                txtEditCounty.Text = customerRow["County"].ToString();
                txtEditPostcode.Text = customerRow["Postcode"].ToString();
                txtEditEmail.Text = customerRow["EmailAddress"].ToString();
                txtEditTelNo.Text = customerRow["TelephoneNo"].ToString();
            }
            else
            {
                MessageBox.Show("Customer not found.");
            }
        }


        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            frmMainCustomer newSubForm = new frmMainCustomer();
            OpenSubFormInPanel(newSubForm);
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();

            //Exception catching

            //CUSTOMER ID
            try
            {
                myCustomer.CustomerID = Convert.ToInt32(lblEditCustNoValue.Text.Trim());  //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblEditCustomerNo, MyEx.validate());
            }

            //TITLE
            try
            {
                myCustomer.Title = cmbEditTitle.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditTitle, MyEx.validate());
            }

            //SURNAME
            try
            {
                myCustomer.Surname = txtEditSurname.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSurname, MyEx.validate());
            }

            //FORENAME
            try
            {
                myCustomer.Forename = txtEditForename.Text.Trim();  //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditForename, MyEx.validate());
            }

            //STREET NAME
            try
            {
                myCustomer.Street = txtEditStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditStreet, MyEx.validate());
            }

            //CITY/TOWN
            try
            {
                myCustomer.Town = txtEditTown.Text.Trim();   //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditTown, MyEx.validate());
            }

            //COUNTY
            try
            {
                myCustomer.County = txtEditCounty.Text.Trim();   //passed to Customer class to check 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditCounty, MyEx.validate());
            }

            //POSTCODE
            try
            {
                myCustomer.Postcode = txtEditPostcode.Text.Trim();   //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditPostcode, MyEx.validate());
            }


            //EMAIL
            try
            {
                myCustomer.Email = txtEditEmail.Text.Trim();   //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditEmail, MyEx.validate());
            }

            //TELNO
            try
            {
                myCustomer.TelNo = txtEditTelNo.Text.Trim(); //passed to Customer class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditTelNo, MyEx.validate());
            }

            try
            {
                if (ok)
                {
                    int customerID = Convert.ToInt32(lblEditCustNoValue.Text);
                    DataRow customerRow = dsRoadTripRentals.Tables["Customer"].Rows.Find(customerID);

                    if (customerRow != null)
                    {
                        customerRow["Title"] = myCustomer.Title;
                        customerRow["Forename"] = myCustomer.Forename;
                        customerRow["Surname"] = myCustomer.Surname;
                        customerRow["Street"] = myCustomer.Street;
                        customerRow["City"] = myCustomer.Town;
                        customerRow["County"] = myCustomer.County;
                        customerRow["Postcode"] = myCustomer.Postcode;
                        customerRow["EmailAddress"] = myCustomer.Email;
                        customerRow["TelephoneNo"] = myCustomer.TelNo;

                        daCustomer.Update(dsRoadTripRentals, "Customer");

                        MessageBox.Show("Customer Updated");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
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
            cmbEditTitle.SelectedIndex = -1;
            txtEditForename.Clear();
            txtEditSurname.Clear();
            txtEditStreet.Clear();
            txtEditTown.Clear();
            txtEditCounty.Clear();
            txtEditPostcode.Clear();
            txtEditEmail.Clear();
            txtEditTelNo.Clear();
        }

        private void OpenSubFormInPanel(Form subForm)
        {
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            // Replace 'panelSub' with the name of the Panel control in your main form.
            panelSub.Controls.Clear();
            panelSub.Controls.Add(subForm);

            subForm.Show();
        }

    }


}
