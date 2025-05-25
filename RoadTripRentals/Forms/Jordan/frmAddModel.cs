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
    public partial class frmAddModel : Form
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

        public frmAddModel()
        {
            InitializeComponent();
        }

        private void frmAddModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Model' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlModel = @"select * from Model";
            daModel = new SqlDataAdapter(sqlModel, connStr);
            cmdBModel = new SqlCommandBuilder(daModel);
            daModel.FillSchema(dsRoadTripRentals, SchemaType.Source, "Model");
            daModel.Fill(dsRoadTripRentals, "Model");

            //dgvModels.DataSource = dsRoadTripRentals.Tables["Model"];

            //Resize the DataGridView columns to fit the newly loaded content.
           // dgvModels.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //btnDelModel.Click += btnDelModel_Click;
        }


        private void btnAddAdd_Click(object sender, EventArgs e)
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
                    DataRow drModel = dsRoadTripRentals.Tables["Model"].NewRow();

                    drModel["ModelID"] = myModel.ModelID;
                    drModel["ModelDesc"] = myModel.Description;
                    drModel["Make"] = myModel.Make;

                    try
                    {
                        dsRoadTripRentals.Tables["Model"].Rows.Add(drModel);
                        daModel.Update(dsRoadTripRentals, "Model");

                        // If no exceptions are thrown, show the "Model Added" message
                        MessageBox.Show("Model Added");

                        if (MessageBox.Show("Do you wish to add another model?", "Add Model", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clearAddForm();
                        }
                        else
                        {
                            frmMainModel newSubForm = new frmMainModel();
                            OpenSubFormInPanel(newSubForm);
                        }
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("The model ID '" + myModel.ModelID + "' already exists. Please enter a unique model ID.", "Duplicate Model ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
