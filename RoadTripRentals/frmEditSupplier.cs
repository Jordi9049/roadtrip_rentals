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
    public partial class frmEditSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;

        public frmEditSupplier()
        {
            InitializeComponent();
        }

        private void frmEditSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (btnEditSupplier.Text == "Edit")
            {                
                txtSupplierName.Enabled = true;
                txtStreet.Enabled = true;
                txtTown.Enabled = true;
                txtCounty.Enabled = true;
                txtPostcode.Enabled = true;
                txtTelNo.Enabled = true;
                txtEmail.Enabled = true;
                                
                btnEditSupplier.Text = "Save";
            }
            else
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
                        drSupplier.BeginEdit();

                        drSupplier["SupplierNo"] = mySupplier.SupplierNo;
                        drSupplier["SupplierName"] = mySupplier.SupplierName;
                        drSupplier["SupplierStreet"] = mySupplier.Street;
                        drSupplier["SupplierTown"] = mySupplier.Town;
                        drSupplier["SupplierCounty"] = mySupplier.County;
                        drSupplier["SupplierPostCode"] = mySupplier.Postcode;
                        drSupplier["SupplierTelNo"] = mySupplier.SupplierTelNo;
                        drSupplier["SupplierEmail"] = mySupplier.SupplierEmail;
                        
                        drSupplier.EndEdit();
                        daSupplier.Update(dsRoadTripRentals, "Supplier");

                        MessageBox.Show("Supplier Details Updated", "Supplier");

                        txtSupplierName.Enabled = false;
                        txtStreet.Enabled = false;
                        txtTown.Enabled = false;
                        txtCounty.Enabled = false;
                        txtPostcode.Enabled = false;
                        txtTelNo.Enabled = false;
                        txtEmail.Enabled = false;

                        btnEditSupplier.Text = "Edit";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Supplier No: " + lblSupplierNoValue.Text + "?", "Edit Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
           // connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsRoadTripRentals, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsRoadTripRentals, "Supplier");

            lblSupplierNoValue.Text = MyGlobals.selectedSupplierNo.ToString();

            drSupplier = dsRoadTripRentals.Tables["Supplier"].Rows.Find(lblSupplierNoValue.Text);

            txtSupplierName.Text = drSupplier["SupplierName"].ToString();
            txtStreet.Text = drSupplier["SupplierStreet"].ToString();
            txtTown.Text = drSupplier["SupplierTown"].ToString();
            txtCounty.Text = drSupplier["SupplierCounty"].ToString();
            txtPostcode.Text = drSupplier["SupplierPostCode"].ToString();
            txtTelNo.Text = drSupplier["SupplierTelNo"].ToString();
            txtEmail.Text = drSupplier["SupplierEmail"].ToString();
        }
    }
}
