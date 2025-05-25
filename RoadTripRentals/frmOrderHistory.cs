using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RoadTripRentals
{
    public partial class frmOrderHistory : Form
    {
        SqlDataAdapter daStockOrder, daOrderDetails, daCarDetails;
        DataSet dsRoadTripRentals = new DataSet();
        SqlConnection conn;
        SqlCommand cmdStockOrder, cmdStockOrderDetails, cmdOrderDetails, cmdCarDetails;
        SqlCommandBuilder cmdBStockOrder, cmdBStockOrderDetails, cmdBCarDetails;

        DataRow drStockOrder, drOrderDetails, drSupplier, drSupplierStock, drStaff, drModel;

        String sqlStockOrder, sqlStockOrderDetails, sqlOrderDetails, sqlUpdateCars, sqlUpdateOrderDelivered;

        String connStr;

        decimal orderTotal = 0;

        public frmOrderHistory()
        {
            InitializeComponent();
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            // set up dataAdapter to show all order history in the data grid view
            sqlStockOrder = @"SELECT * from StockOrder";
            conn = new SqlConnection(connStr);
            daStockOrder = new SqlDataAdapter(sqlStockOrder, conn);
            cmdBStockOrder = new SqlCommandBuilder(daStockOrder);
            daStockOrder.FillSchema(dsRoadTripRentals, SchemaType.Source, "StockOrder");
            daStockOrder.Fill(dsRoadTripRentals, "StockOrder");

            dgvOrderHistory.DataSource = dsRoadTripRentals.Tables["StockOrder"];

            dgvOrderHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // set up dataAdapter to show all order history details
            sqlStockOrderDetails = @"SELECT * from SupplierStockOrder";
            daOrderDetails = new SqlDataAdapter(sqlStockOrderDetails, conn);
            cmdBStockOrderDetails = new SqlCommandBuilder(daOrderDetails);
            daOrderDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "SupplierStockOrder");
            daOrderDetails.Fill(dsRoadTripRentals, "SupplierStockOrder");

            //set up dataAdapter for Car Details table
            sqlUpdateCars = @"SELECT * from CarDetails";
            daCarDetails = new SqlDataAdapter(sqlUpdateCars, conn);
            cmdBCarDetails = new SqlCommandBuilder(daCarDetails);
            daCarDetails.FillSchema(dsRoadTripRentals, SchemaType.Source, "CarDetails");
            daCarDetails.Fill(dsRoadTripRentals, "CarDetails");
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderHistory.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvOrderHistory.SelectedRows[0];

                int orderNo = Convert.ToInt32(selectedRow.Cells["OrderNo"].Value);

                if (MessageBox.Show("Are you sure you want to delete Order No: " + orderNo + "?", "Delete Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataRow row in dsRoadTripRentals.Tables["SupplierStockOrder"].Rows)
                    {
                        int orderNoValue = Convert.ToInt32(row["OrderNo"]);

                        if (orderNoValue == orderNo)
                        {
                            row.Delete();
                        }
                    }

                    daOrderDetails.Update(dsRoadTripRentals, "SupplierStockOrder");

                    DataRow drStockOrder = dsRoadTripRentals.Tables["StockOrder"].Rows.Find(orderNo);
                    drStockOrder.Delete();
                    daStockOrder.Update(dsRoadTripRentals, "StockOrder");

                }
            }
            else
                MessageBox.Show("Please select an order from the list to delete.", "Delete Order");
        }


        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            //Hide data grid view
            dgvOrderHistory.Visible = false;

            //display order details
            lblOrderNo.Visible = true;
            lblOrderNoValue.Visible = true;
            lblOrderDate.Visible = true;
            lblOrderDateValue.Visible = true;
            lblStaffName.Visible = true;
            lblStaffNameValue.Visible = true;
            lblSupplier.Visible = true;
            lblSupplierValue.Visible = true;
            lvwOrderDetails.Visible = true;
            lblOrderTotal.Visible = true;
            lblOrderTotalValue.Visible = true;
            btnClose.Visible = true;

            //set up dataAdapter for Order Details in listview
            sqlOrderDetails = @"SELECT sso.OrderNo, sso.SupplierCarReg, ss.Price, m.ModelDesc, m.Make 
                              FROM SupplierStockOrder sso 
                              INNER JOIN SupplierStock ss ON sso.SupplierCarReg = ss.SupplierCarReg
                              INNER JOIN Model m ON ss.ModelID = m.ModelID 
                              WHERE sso.OrderNo = @OrderNo";

            cmdOrderDetails = new SqlCommand(sqlOrderDetails, conn);
            cmdOrderDetails.Parameters.AddWithValue("@OrderNo", dgvOrderHistory.SelectedRows[0].Cells[0].Value.ToString());
            daOrderDetails = new SqlDataAdapter(cmdOrderDetails);
            DataTable orderDetails = new DataTable();
            daOrderDetails.Fill(orderDetails);



            //bool exits = false;

            if (dgvOrderHistory.SelectedRows.Count == 0)
                MessageBox.Show("Please select an order to view", "Order Details");
            else
            {
                DataGridViewRow selectedRow = dgvOrderHistory.SelectedRows[0];

                //Get the orderNo from the row that is selected
                int orderNo = Convert.ToInt32(selectedRow.Cells[0].Value);
                drStockOrder = dsRoadTripRentals.Tables["StockOrder"].Rows.Find(orderNo);

                //Get the staffID from the row that is selected
                //int staffID = Convert.ToInt32(selectedRow.Cells[4].Value);
                //drStaff = dsRoadTripRentals.Tables["Staff"].Rows.Find(staffID);

                //Get the SupplierNo from the row that is selected
                //int supplierNo = Convert.ToInt32(selectedRow.Cells[5].Value);
                //drSupplier = dsRoadTripRentals.Tables["Supplier"].Rows.Find(supplierNo);

                lblOrderNoValue.Text = drStockOrder["OrderNo"].ToString();
                DateTime orderDate = (DateTime)drStockOrder["OrderDate"];
                lblOrderDateValue.Text = orderDate.ToString("d");
                lblStaffNameValue.Text = drStockOrder["StaffID"].ToString();
                lblSupplierValue.Text = drStockOrder["SupplierNo"].ToString();

                //lblStaffNameValue.Text = drStaff["StaffForename"].ToString() + " " + drStaff["StaffSurname"].ToString();
                //lblSupplierValue.Text = drSupplier["SupplierName"].ToString();

                foreach (DataRow dr in orderDetails.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["SupplierCarReg"].ToString());
                    item.SubItems.Add(dr["Make"].ToString());
                    item.SubItems.Add(dr["ModelDesc"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(dr["Price"]).ToString("0.00"));
                    lvwOrderDetails.Items.Add(item);

                    decimal carPrice = decimal.Parse(dr["Price"].ToString());
                    orderTotal += carPrice;

                }

                lblOrderTotalValue.Text = orderTotal.ToString("c");


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearOrder();

            //hide order details
            lblOrderNo.Visible = false;
            lblOrderNoValue.Visible = false;
            lblOrderDate.Visible = false;
            lblOrderDateValue.Visible = false;
            lblStaffName.Visible = false;
            lblStaffNameValue.Visible = false;
            lblSupplier.Visible = false;
            lblSupplierValue.Visible = false;
            lvwOrderDetails.Visible = false;
            lblOrderTotal.Visible = false;
            lblOrderTotalValue.Visible = false;
            btnClose.Visible = false;

            //display data grid view
            dgvOrderHistory.Visible = true;
        }


        private void ClearOrder()
        {
            lvwOrderDetails.Items.Clear();
            lblOrderNoValue.Text = "";
            lblOrderDateValue.Text = "";
            lblStaffNameValue.Text = "";
            lblSupplierValue.Text = "";
            lblOrderTotalValue.Text = "";
            orderTotal = 0;
        }

        private void btnOrderDelivered_Click(object sender, EventArgs e)
        {
            if (dgvOrderHistory.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvOrderHistory.SelectedRows[0];

                int orderNo = Convert.ToInt32(selectedRow.Cells["OrderNo"].Value);
                Boolean orderDelivered = Convert.ToBoolean(selectedRow.Cells["OrderDelivered"].Value);

                if (!orderDelivered)
                {
                    if (MessageBox.Show("Confirm Order No: " + orderNo + " has been delivered", "Confirm Delivery", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (DataRow row in dsRoadTripRentals.Tables["SupplierStockOrder"].Rows)
                        {
                            sqlUpdateCars = @"INSERT INTO CarDetails(CarReg, ModelID, Colour, Mileage, FuelType, NoSeats, [Year], RentalCostID)
                                        SELECT DISTINCT s.SupplierCarReg, s.ModelID, s.Colour, s.Mileage, s.FuelType, s.NoOfSeats, s.CarYear, RentalCostID = 1 
                                        FROM SupplierStock s INNER JOIN SupplierStockOrder so ON s.SupplierCarReg = so.SupplierCarReg
                                                             INNER JOIN StockOrder o ON so.OrderNo = o.OrderNo
                                                             WHERE o.OrderNo = @OrderNo
                                                             AND NOT EXISTS(SELECT 1 FROM CarDetails cd WHERE cd.CarReg = s.SupplierCarReg); ";


                            using (SqlConnection conn = new SqlConnection(connStr))
                            {
                                SqlCommand cmdCarDetails = new SqlCommand(sqlUpdateCars, conn);
                                cmdCarDetails.Parameters.AddWithValue("@OrderNo", orderNo);
                                conn.Open();
                                cmdCarDetails.ExecuteNonQuery();
                            }


                        }

                        sqlUpdateOrderDelivered = @"UPDATE StockOrder SET OrderDelivered = 1 WHERE OrderNo = @OrderNo;";
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            SqlCommand cmdOrderDelivered = new SqlCommand(sqlUpdateOrderDelivered, conn);
                            cmdOrderDelivered.Parameters.AddWithValue("@OrderNo", orderNo);
                            conn.Open();
                            cmdOrderDelivered.ExecuteNonQuery();
                        }
                        daCarDetails.Update(dsRoadTripRentals, "CarDetails");
                        MessageBox.Show("Order Delivery Confirmed");
                    }
                }
                else
                    MessageBox.Show("Order has already been delivered", "Order Delivered");
            }
            else
                MessageBox.Show("Please select an order from the list", "Order Delivered");

        }

    }
}
