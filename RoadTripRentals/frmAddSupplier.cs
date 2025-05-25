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
    public partial class frmAddSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsRoadTripRentals, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsRoadTripRentals, "Supplier");

            int noRows = dsRoadTripRentals.Tables["Supplier"].Rows.Count;

            if (noRows == 0)
                lblSupplierNoValue.Text = "1001";
            else
            {
                getNumber(noRows);                
            }

            errP.Clear();
            clearAddForm();
        }

        private void getNumber(int noRows)
        {
            drSupplier = dsRoadTripRentals.Tables["Supplier"].Rows[noRows - 1];
            lblSupplierNoValue.Text = (int.Parse(drSupplier["SupplierNo"].ToString()) + 1).ToString();
        }

        void clearAddForm()
        {
            txtSupplierName.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtPostcode.Clear();
            txtTelNo.Clear();
            txtEmail.Clear();
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupplier.SupplierNo = Convert.ToInt32(lblSupplierNoValue.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblSupplierNoValue, MyEx.validate());
            }

            try
            {
                mySupplier.SupplierName = txtSupplierName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSupplierName, MyEx.validate());
            }

            
            try
            {
                mySupplier.Street = txtStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtStreet, MyEx.validate());
            }

            
            try
            {
                mySupplier.Town = txtTown.Text.Trim(); 
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTown, MyEx.validate());
            }

            
            try
            {
                mySupplier.County = txtCounty.Text.Trim();  
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCounty, MyEx.validate());
            }

            
            try
            {
                mySupplier.Postcode = txtPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPostcode, MyEx.validate());
            }

            try
            {
                mySupplier.SupplierTelNo = txtTelNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTelNo, MyEx.validate());
            }

            try
            {
                mySupplier.SupplierEmail = txtEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEmail, MyEx.validate());
            }

            try
            {
                if (ok)
                {
                    drSupplier = dsRoadTripRentals.Tables["Supplier"].NewRow();

                    drSupplier["SupplierNo"] = mySupplier.SupplierNo;
                    drSupplier["SupplierName"] = mySupplier.SupplierName;
                    drSupplier["SupplierStreet"] = mySupplier.Street;
                    drSupplier["SupplierTown"] = mySupplier.Town;
                    drSupplier["SupplierCounty"] = mySupplier.County;
                    drSupplier["SupplierPostCode"] = mySupplier.Postcode;
                    drSupplier["SupplierTelNo"] = mySupplier.SupplierTelNo;
                    drSupplier["SupplierEmail"] = mySupplier.SupplierEmail;

                    dsRoadTripRentals.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsRoadTripRentals, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you want to add another supplier?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsRoadTripRentals.Tables["Supplier"].Rows.Count);
                    }
                    else
                        Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void frmAddSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
        }

       
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Supplier No: " + lblSupplierNoValue.Text + "?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
    }
}
