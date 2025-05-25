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
    public partial class frmEditModel : Form
    {
        SqlDataAdapter daModel, daModels;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBModel;
        SqlCommand cmdModelDetails;
        DataRow drModel;
        SqlConnection conn;
        String connStr, sqlModel, sqlModelDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        private string ModelID;

        public frmEditModel(string ModelID)
        {
            InitializeComponent();
            this.ModelID = ModelID;
        }

        private void frmEditModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Model' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlModel = @"select * from Model";
            daModel = new SqlDataAdapter(sqlModel, connStr);
            cmdBModel = new SqlCommandBuilder(daModel);
            daModel.FillSchema(dsRoadTripRentals, SchemaType.Source, "Model");
            daModel.Fill(dsRoadTripRentals, "Model");

            DataRow drModel = dsRoadTripRentals.Tables["Model"].Rows.Find(ModelID);

            if (drModel != null)
            {
                txtModel.Text = drModel["ModelID"].ToString();
                txtMake.Text = drModel["Make"].ToString();
                txtDesc.Text = drModel["ModelDesc"].ToString();
            }
        }


        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            MyModel myModel = new MyModel();
            bool ok = true;
            errP.Clear();

            // ModelID
            try
            {
                myModel.ModelID = txtModel.Text.Trim();
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtModel, ex.Message);
            }

            // Make
            try
            {
                myModel.Make = txtMake.Text.Trim();
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtMake, ex.Message);
            }

            // Description
            try
            {
                myModel.Description = txtDesc.Text.Trim();
            }
            catch (Exception ex)
            {
                ok = false;
                errP.SetError(txtDesc, ex.Message);
            }


            try
            {
                if (ok)
                {
                    DataRow drModel = dsRoadTripRentals.Tables["Model"].Rows.Find(myModel.ModelID);

                    if (drModel != null)
                    {
                        drModel["ModelDesc"] = myModel.Description;
                        drModel["Make"] = myModel.Make;

                        try
                        {
                            daModel.Update(dsRoadTripRentals, "Model");

                            // If no exceptions are thrown, show the "Model Updated" message
                            MessageBox.Show("Model Updated");

                            frmMainModel newSubForm = new frmMainModel();
                            OpenSubFormInPanel(newSubForm);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Model not found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }


        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            frmMainModel newSubForm = new frmMainModel();
            OpenSubFormInPanel(newSubForm);
        }


        void clearAddForm()
        {
            txtModel.Clear();
            txtDesc.Clear();
            txtMake.Clear();
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
