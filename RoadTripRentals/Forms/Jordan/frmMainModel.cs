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
    public partial class frmMainModel : Form
    {
        SqlDataAdapter daModel, daModels, daCarDetails;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBModel, cmdBCarDetails;
        SqlCommand cmdModelDetails;
        DataRow drModel;
        SqlConnection conn;
        String connStr, sqlModel, sqlCarDetails, sqlModelDetails;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        private void frmMainModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadTripRentalsDataSet.Model' table. You can move, or remove it, as needed.
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlModel = @"select * from Model";
            daModel = new SqlDataAdapter(sqlModel, connStr);
            cmdBModel = new SqlCommandBuilder(daModel);
            daModel.FillSchema(dsRoadTripRentals, SchemaType.Source, "Model");
            daModel.Fill(dsRoadTripRentals, "Model");

            dgvModels.DataSource = dsRoadTripRentals.Tables["Model"];

            //Resize the DataGridView columns to fit the newly loaded content.
            dgvModels.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            sqlCarDetails = @"select * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlCarDetails, connStr);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");
            //btnDelModel.Click += btnDelModel_Click;
        }

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        private void btnDelModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.SelectedRows.Count > 0)
            {
                string modelID = Convert.ToString(dgvModels.SelectedRows[0].Cells["ModelID"].Value);

                // Check if any car is associated with this model
                DataRow[] carRows = dsRoadTripRentals.Tables["CarDetails"].Select($"ModelID = '{modelID}'");

                if (carRows.Length > 0)
                {
                    MessageBox.Show("This model is assigned to one or more cars and cannot be deleted.", "Cannot Delete");
                    return;
                }

                // Ask for confirmation before deleting the model
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected model?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Find the model in the dataset using LINQ
                    DataRow modelRow = dsRoadTripRentals.Tables["Model"].AsEnumerable().SingleOrDefault(row => row.Field<string>("ModelID") == modelID);

                    if (modelRow != null)
                    {
                        // Delete the model from the dataset and update the database
                        modelRow.Delete();
                        daModel.Update(dsRoadTripRentals, "Model");

                        MessageBox.Show("Model Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Model not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a model to delete.");
            }
        }



        private void btnEditModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.SelectedRows.Count > 0)
            {
                string ModelID = Convert.ToString(dgvModels.SelectedRows[0].Cells["ModelID"].Value);

                frmEditModel newSubForm = new frmEditModel(ModelID);
                OpenSubFormInPanel(newSubForm);
            }
            else
            {
                MessageBox.Show("Please select a Model to edit.");
            }
        }


        public frmMainModel()
        {
            InitializeComponent();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            frmAddModel addModelForm = new frmAddModel(); 
            OpenSubFormInPanel(addModelForm);
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
