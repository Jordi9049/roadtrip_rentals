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
using static RoadTripRentals.RoadTripRentalsDataSet;

namespace RoadTripRentals
{
    public partial class frmDeleteSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;

        public frmDeleteSupplier()
        {
            InitializeComponent();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list.", "Select Supplier");
            }
            else
            {
                drSupplier = dsRoadTripRentals.Tables["Supplier"].Rows.Find(dgvSupplier.SelectedRows[0].Cells[0].Value);

                string tempName = drSupplier["SupplierName"].ToString();

                if (MessageBox.Show("Are you sure you want to delete supplier " + tempName + "?", "Delete Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsRoadTripRentals, "Supplier");
                }
            }
        }

        private void frmDeleteSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {            
            MyGlobals.frmClosing = true;
            
        }

        private void frmDeleteSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsRoadTripRentals, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsRoadTripRentals, "Supplier");

            dgvSupplier.DataSource = dsRoadTripRentals.Tables["Supplier"];

            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
