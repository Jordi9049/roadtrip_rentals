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
    public partial class frmOrderMain : Form
    {
        SqlDataAdapter daStockOrder, daStockOrderDetails, daStaff, daSuppliers, daSupplierStock, daModel, daCarDetails;
        DataSet dsRoadTripRentals = new DataSet();
        SqlConnection conn;
        SqlCommand cmdSuppliers, cmdSupplierStock, cmdCarDetails;
        SqlCommandBuilder cmdBStockOrder, cmdBStockOrderDetails, cmdBStaff, cmdBSuppliers, cmdBSupplierStock, cmdBModel;
              
        DataRow drSupplierStock;

        String sqlStockOrder, sqlStockOrderDetails, sqlStaff, sqlSuppliers, sqlSupplierStock, sqlModel, sqlCarDetails;

        String connStr;

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        public frmOrderMain()
        {
            InitializeComponent();
        }

        private void frmOrderMain_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\sqlExpress; Initial Catalog = RoadTripRentals; Integrated Security = true";
            //connStr = @"Data Source = DESKTOP-ASEMACC\INTHEDOGHOUSE; Initial Catalog = RoadTripRentals; Integrated Security = true";
            frmOrderHistory frm1 = new frmOrderHistory();
            frm1.TopLevel = false;
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.WindowState = FormWindowState.Maximized;
            pnlMain.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            Button btn = (Button)sender;

            MyGlobals.frmClosing = false;
            MyGlobals.frmEditForm = false;

            startIndex = Convert.ToInt32(btn.Tag.ToString().Substring(1, 1));

            switch (startIndex)
            {
                case 1:
                    frmOrderHistory frm1 = new frmOrderHistory();
                        frm1.TopLevel = false;
                        frm1.FormBorderStyle = FormBorderStyle.None;
                        frm1.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frm1);
                        frm1.Show();
                        break;    
            }
            

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
