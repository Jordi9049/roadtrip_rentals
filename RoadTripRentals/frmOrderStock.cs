using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RoadTripRentals
{
    public partial class frmOrderStock : Form
    {
        SqlDataAdapter daStockOrder, daStockOrderDetails, daStaff, daSuppliers, daSupplierStock, daModel, daCarDetails;
        DataSet dsRoadTripRentals = new DataSet();
        SqlConnection conn;
        SqlCommand cmdSuppliers, cmdSupplierStock, cmdCarDetails;
        SqlCommandBuilder cmdBStockOrder, cmdBStockOrderDetails, cmdBStaff, cmdBSuppliers, cmdBSupplierStock, cmdBModel;

        DataRow drSupplierStock;
        
        String sqlStockOrder, sqlStockOrderDetails, sqlStaff, sqlSuppliers, sqlSupplierStock, sqlModel, sqlCarDetails;

        String connStr;

        decimal orderTotal = 0;

        bool formLoading;

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        public frmOrderStock()
        {
            InitializeComponent();
        }

        private void frmOrderStock_Load(object sender, EventArgs e)
        {
            formLoading = true;
            
            lblOrderDate.Text = DateTime.Now.ToShortDateString();

            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";

            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";


            // set up dataAdapter to show all supplier stock in the data grid view
            sqlSupplierStock = @"Select * from SupplierStock";
            conn = new SqlConnection(connStr);
            daSupplierStock = new SqlDataAdapter(sqlSupplierStock, conn);
            cmdBSupplierStock = new SqlCommandBuilder(daSupplierStock);
            daSupplierStock.FillSchema(dsRoadTripRentals, SchemaType.Source, "SupplierStock");
            daSupplierStock.Fill(dsRoadTripRentals, "SupplierStock");

            //dgvSupplierStock.DataSource = dsRoadTripRentals.Tables["SupplierStock"];

            //dgvSupplierStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            // set up dataAdapter for Staff details in the combobox
            sqlStaff = @"Select StaffID, StaffForename, StaffSurname from Staff";
            daStaff = new SqlDataAdapter(sqlStaff, conn);
            daStaff.Fill(dsRoadTripRentals, "Staff");

            DataTable dtStaff = dsRoadTripRentals.Tables["Staff"];
            dtStaff.Columns.Add("FullName", typeof(string), "StaffID + ': ' + StaffForename + ' ' + StaffSurname");

            cmbStaff.DataSource = dtStaff;
            cmbStaff.DisplayMember = "FullName";
            cmbStaff.ValueMember = "StaffID";
            cmbStaff.SelectedIndex = -1;

            // set up dataAdapter for supplier details in the combobox
            sqlSuppliers = @"Select SupplierNo, SupplierName from Supplier order by SupplierName";
            daSuppliers = new SqlDataAdapter(sqlSuppliers, conn);
            daSuppliers.Fill(dsRoadTripRentals, "Supplier");
            
            cmbSupplier.DataSource = dsRoadTripRentals.Tables["Supplier"];
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierNo";
            cmbSupplier.SelectedIndex = -1;
            cmbSupplier.Enabled = false;

            //set up dataAdapter for Model details for Datagrid view
            sqlModel = @"Select * from Model";
            daModel = new SqlDataAdapter(sqlModel, conn);
            cmdBModel = new SqlCommandBuilder(daModel);
            daModel.FillSchema(dsRoadTripRentals, SchemaType.Source, "Model");
            daModel.Fill(dsRoadTripRentals, "Model");


            sqlStockOrder = @"SELECT * from StockOrder";
            daStockOrder = new SqlDataAdapter(sqlStockOrder, conn);
            cmdBStockOrder = new SqlCommandBuilder(daStockOrder);
            daStockOrder.FillSchema(dsRoadTripRentals, SchemaType.Source, "StockOrder");
            daStockOrder.Fill(dsRoadTripRentals, "StockOrder");

            sqlStockOrderDetails = @"SELECT * from SupplierStockOrder";
            daStockOrderDetails = new SqlDataAdapter(sqlStockOrderDetails, conn);
            cmdBStockOrderDetails = new SqlCommandBuilder(daStockOrderDetails);
            daStockOrderDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "SupplierStockOrder");
            daStockOrderDetails.Fill(dsRoadTripRentals, "SupplierStockOrder");

            formLoading = false;
            lblAddToOrder.Enabled = false;
        }


        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbStaff.SelectedIndex != -1)
            {
                cmbSupplier.Enabled = true;
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbSupplier.SelectedIndex != -1)
            {
                dgvSupplierStock.Enabled = true;
                lblAddToOrder.Enabled = true;

                if (!formLoading)
                {
                    int supplierNo = (int)cmbSupplier.SelectedValue;
                    sqlSupplierStock = "SELECT * FROM SupplierStock WHERE SupplierNo = @SupplierNo";               
                    //sqlSupplierStock = "SELECT s.SupplierCarReg, m.Make, m.ModelDesc, s.Colour, s.Mileage, s.FuelType, s.NoOfSeats, s.CarYear, s.Price FROM SupplierStock s INNER JOIN Model m ON s.ModelID = m.ModelID WHERE SupplierNo = @SupplierNo";
                    daSupplierStock = new SqlDataAdapter(sqlSupplierStock, conn);
                    daSupplierStock.SelectCommand.Parameters.AddWithValue("@SupplierNo", supplierNo);

                    dsRoadTripRentals.Tables["SupplierStock"].Clear();
                    daSupplierStock.Fill(dsRoadTripRentals, "SupplierStock");

                    dgvSupplierStock.DataSource = dsRoadTripRentals.Tables["SupplierStock"];
                }
            }
        }

        private void lblAddToOrder_Click(object sender, EventArgs e)
        {
            //disable combo boxes so different staff or supplier cannot be added to order
            cmbStaff.Enabled = false;
            cmbSupplier.Enabled = false;

            //set up dataAdapter for car details in listview
            sqlCarDetails = @"SELECT s.SupplierCarReg, s.Price, m.ModelDesc, m.Make FROM SupplierStock s INNER JOIN Model m ON s.ModelID = m.ModelID WHERE s.SupplierCarReg = @SupplierCarReg";
            cmdCarDetails = new SqlCommand(sqlCarDetails, conn);
            cmdCarDetails.Parameters.AddWithValue("@SupplierCarReg", dgvSupplierStock.SelectedRows[0].Cells[0].Value.ToString());
            daCarDetails = new SqlDataAdapter(cmdCarDetails);
            DataTable carDetails = new DataTable();
            daCarDetails.Fill(carDetails);

            bool exits = false;

            if (dgvSupplierStock.SelectedRows.Count == 0)
                MessageBox.Show("Please select a Car", "Car");
            else
            {
                foreach (ListViewItem item in lvwOrderDetails.Items)
                {
                    string selectedCar = item.SubItems[0].Text;
                    foreach (DataGridViewRow row in dgvSupplierStock.SelectedRows)
                    {
                        string supplierCar = row.Cells[0].Value.ToString();
                        if (selectedCar == supplierCar)
                        {
                            MessageBox.Show("Car already added to the order.", "Order");
                            exits = true;
                            break;
                        }
                    }
                }
                if (!exits)
                {
                    foreach (DataRow dr in carDetails.Rows)
                    {
                        if (dr["SupplierCarReg"].ToString() == dgvSupplierStock.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            ListViewItem item = new ListViewItem(dr["SupplierCarReg"].ToString());
                            item.SubItems.Add(dr["Make"].ToString());
                            item.SubItems.Add(dr["ModelDesc"].ToString());
                            item.SubItems.Add(Convert.ToDecimal(dr["Price"]).ToString("0.00"));
                            lvwOrderDetails.Items.Add(item);


                            decimal carPrice = decimal.Parse(dr["Price"].ToString());
                            orderTotal += carPrice;
                            lblOrderTotalValue.Text = orderTotal.ToString("c");
                            break;
                        }

                    }

                }   
            }
        }

        private void lblRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (lvwOrderDetails.SelectedItems.Count != 0) 
            {
                var item = lvwOrderDetails.SelectedItems[0];
                decimal carPrice = Decimal.Parse(item.SubItems[3].Text); 
                orderTotal -= carPrice; 
                lblOrderTotalValue.Text = orderTotal.ToString("c");
                lvwOrderDetails.Items.Remove(item);
               
                if (lvwOrderDetails.Items.Count == 0)
                {
                    cmbStaff.Enabled = true;
                    cmbSupplier.Enabled = true;                    
                }
            }
             
        }


        private void lblCompleteOrder_Click(object sender, EventArgs e)
        {
            DataRow drStockOrder, drStockOrderDetails;
            int OrderNo;
            int noRows = dsRoadTripRentals.Tables["StockOrder"].Rows.Count;

            DateTime orderDeliveryDate = DateTime.Parse(lblOrderDate.Text.Trim());

          
                drStockOrder = dsRoadTripRentals.Tables["StockOrder"].Rows[noRows - 1];
                OrderNo = (int.Parse(drStockOrder["OrderNo"].ToString()) + 1);
           
            if (lvwOrderDetails.Items.Count == 0)
                MessageBox.Show("Please add a car to the order", "Order Details");
            else
            {
                drStockOrder = dsRoadTripRentals.Tables["StockOrder"].NewRow();

                drStockOrder["OrderNo"] = OrderNo;
                drStockOrder["OrderDate"] = DateTime.Parse(lblOrderDate.Text.Trim());
                drStockOrder["OrderDeliveryDate"] = orderDeliveryDate.AddDays(7);
                drStockOrder["OrderDelivered"] = false;
                drStockOrder["StaffID"] = cmbStaff.SelectedValue;
                drStockOrder["SupplierNo"] = cmbSupplier.SelectedValue;

                dsRoadTripRentals.Tables["StockOrder"].Rows.Add(drStockOrder);
                daStockOrder.Update(dsRoadTripRentals, "StockOrder");

                foreach (ListViewItem item in lvwOrderDetails.Items)
                {
                    drStockOrderDetails = dsRoadTripRentals.Tables["SupplierStockOrder"].NewRow();
                    drStockOrderDetails["OrderNo"] = drStockOrder["OrderNo"];
                    drStockOrderDetails["SupplierCarReg"] = item.SubItems[0].Text;
                    dsRoadTripRentals.Tables["SupplierStockOrder"].Rows.Add(drStockOrderDetails);
                    daStockOrderDetails.Update(dsRoadTripRentals, "SupplierStockOrder");
                }

                MessageBox.Show("Order No: " + drStockOrder["OrderNo"].ToString() + " complete");

                ClearOrder();
            }
        }

        private void ClearOrder()
        {
            lvwOrderDetails.Items.Clear();
            lblOrderTotalValue.Text = "";
            cmbStaff.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            orderTotal = 0;
            cmbStaff.Enabled = true;
            cmbSupplier.Enabled = true;
            dgvSupplierStock.DataSource = null;
            dgvSupplierStock.Rows.Clear();
            lblAddToOrder.Enabled = false;
        }

        private void lblCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
