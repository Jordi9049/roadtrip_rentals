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
    public partial class frmSupplierMain : Form
    {
        int noMenuItems = 0;
        Label[] menuItems;

        public delegate void OpenSubFormRequestHandler(Form subForm);
        public event OpenSubFormRequestHandler OpenSubFormRequest;

        public frmSupplierMain()
        {
            InitializeComponent();
        }

        private void frmSupplierMain_Load(object sender, EventArgs e)
        {
            frmDisplaySupplier frm1 = new frmDisplaySupplier();
            frm1.TopLevel = false;
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.WindowState = FormWindowState.Maximized;
            pnlMain.Controls.Add(frm1);
            frm1.Show();
        }
       
        private void lblDisplaySupplierDet_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            Label lbl = (Label)sender;
            
            MyGlobals.frmClosing = false;
            MyGlobals.frmEditForm = false;

            startIndex = Convert.ToInt32(lbl.Tag.ToString().Substring(1, 1));

                switch (startIndex)
                {
                    case 1:
                        frmDisplaySupplier frm1 = new frmDisplaySupplier();
                        frm1.TopLevel = false;
                        frm1.FormBorderStyle = FormBorderStyle.None;
                        frm1.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frm1);
                        frm1.Show();
                        break;
                    case 2:
                        frmAddSupplier frm2 = new frmAddSupplier();
                        frm2.TopLevel = false;
                        frm2.FormBorderStyle = FormBorderStyle.None;
                        frm2.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frm2);
                        frm2.Show();
                        break;
                    case 3:
                        //frmEditSupplier frm3 = new frmEditSupplier();
                        //frm3.TopLevel = false;
                        //frm3.FormBorderStyle = FormBorderStyle.None;
                        //frm3.WindowState = FormWindowState.Maximized;
                        //pnlMain.Controls.Add(frm3);
                        //frm3.Show();
                        break;
                    case 4:
                        frmDeleteSupplier frm4 = new frmDeleteSupplier();
                        frm4.TopLevel = false;
                        frm4.FormBorderStyle = FormBorderStyle.None;
                        frm4.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frm4);
                        frm4.Show();
                        break;
                    case 5:
                        this.Close();
                        break;
                }
            //}
         
        }

        private void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (MyGlobals.frmEditForm)
            //{
            //    frmEditSupplier frm3 = new frmEditSupplier();
            //    frm3.TopLevel = false;
            //    frm3.FormBorderStyle = FormBorderStyle.None;
            //    frm3.WindowState = FormWindowState.Maximized;
            //    pnlMain.Controls.Add(frm3);
            //    frm3.Show();
            //}
        }

        private void lblSupplierQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblSupplierEdit_Click(object sender, EventArgs e)
        {
            if (MyGlobals.selectedSupplierNo != 0)
            {
                frmEditSupplier frm3 = new frmEditSupplier();
                frm3.TopLevel = false;
                frm3.FormBorderStyle = FormBorderStyle.None;
                frm3.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frm3);
                frm3.Show();
            }
            else
                MessageBox.Show("No Supplier selected for edit!", "Select a Supplier");
        }
    }
}
