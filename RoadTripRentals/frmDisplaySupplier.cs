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
    public partial class frmDisplaySupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsRoadTripRentals = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;

        public frmDisplaySupplier()
        {
            InitializeComponent();
        }

        private void frmDisplaySupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
            

        }

        private void dgvSupplier_Click(object sender, EventArgs e)
        {
            object selectedValue = dgvSupplier.SelectedRows[0].Cells[0].Value;
            if (selectedValue != DBNull.Value)
            { 
                MyGlobals.selectedSupplierNo = Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells[0].Value);
            }
        }

        private void frmDisplaySupplier_Load(object sender, EventArgs e)
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
