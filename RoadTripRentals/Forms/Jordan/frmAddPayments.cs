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
    public partial class frmAddPayments : Form
    {
        SqlDataAdapter daPayments, daRental, daPaymentss;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBPayments, cmdBRental;
        SqlCommand cmdPaymentsDetails ;
        DataRow drPayments;
        SqlConnection conn;
        String connStr, sqlPayments, sqlRental, sqlPaymentsDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;


        public frmAddPayments()
        {
            InitializeComponent();
        }


        private void frmAddPayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Payments' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlPayments = @"select * from PaymentType";
            daPayments = new SqlDataAdapter(sqlPayments, connStr);
            cmdBPayments = new SqlCommandBuilder(daPayments);
            daPayments.FillSchema(dsRoadTripRentals, SchemaType.Source, "PaymentType");
            daPayments.Fill(dsRoadTripRentals, "PaymentType");

            int noRows = dsRoadTripRentals.Tables["PaymentType"].Rows.Count;

            // Rental table
            sqlRental = @"select * from Rental";
            daRental = new SqlDataAdapter(sqlRental, connStr);
            cmdBRental = new SqlCommandBuilder(daRental);
            daRental.FillSchema(dsRoadTripRentals, SchemaType.Source, "Rental");
            daRental.Fill(dsRoadTripRentals, "Rental");


            if (noRows == 0)
                txtPaymentID.Text = "10000";
            else
            {
                getNumber();
            }
        }

        public class MyPayments
        {
            public int PaymentID { get; set; }
            public string PaymentType { get; set; }

            public DateTime PaymentDate { get; set; }
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyPayments myPayments = new MyPayments();
            bool ok = true;
            errP.Clear();

            // PaymentID
            try
            {
                myPayments.PaymentID = Convert.ToInt32(txtPaymentID.Text.Trim());
                // drPayments["PaymentID"] = myPayments.PaymentID; // Remove this line
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtPaymentID, ex.Message);
            }

            // PaymentType
            try
            {
                myPayments.PaymentType = cmbPaymentType.Text.Trim(); // NumericUpDown.Value returns a decimal
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(cmbPaymentType, ex.Message);
            }



            if (ok)
            {
                DataRow drPayments = dsRoadTripRentals.Tables["PaymentType"].NewRow();

                drPayments["PaymentID"] = myPayments.PaymentID;
                drPayments["PaymentType"] = myPayments.PaymentType;
               

                // PaymentID is auto-incremented in the database, so no need to set it here

                try
                {
                    dsRoadTripRentals.Tables["PaymentType"].Rows.Add(drPayments);
                    daPayments.Update(dsRoadTripRentals, "PaymentType");

                    // If no exceptions are thrown, show the "Rental Cost Added" message
                    MessageBox.Show("Rental Cost Added");

                    if (MessageBox.Show("Do you wish to add another payment?", "Add Rental Cost", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber();
                    }
                    else
                    {
                        frmMainPayments newSubForm = new frmMainPayments();
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
            frmMainPayments newSubForm = new frmMainPayments();
            OpenSubFormInPanel(newSubForm);
        }


        void clearAddForm()
        {
            cmbPaymentType.SelectedIndex = -1;
        }


        private void getNumber()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(PaymentID) FROM PaymentType", conn);
                    int maxPaymentID = (int)cmd.ExecuteScalar();
                    txtPaymentID.Text = (maxPaymentID + 1).ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching the next PaymentID: " + ex.Message);
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
