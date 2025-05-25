using RoadTripRentals.Forms.Jordan;
using RoadTripRentals.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTripRentals
{
    public partial class MainMenu : Form
    {
        Boolean vis;
        private Button currentButton;
        private Form activeForm;

        public MainMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            startSubClosed();
            btnCloseSubForm.Visible = false;
        }


        //Submenu code start
        private void startSubClosed()
        {
            panelCustomerSubmenu.Visible = false;
            panelRentalsSubmenu.Visible = false;
            panelSupplierSubmenu.Visible = false;
            panelStockSubmenu.Visible = false;
            panelCarSubmenu.Visible = false;
            panelPaymentSubmenu.Visible = false;
        }

        private void HideAllSubmenus(params Panel[] panels)
        {
            foreach (var panel in panels)
            {
                if (panel.Visible)
                {
                    panel.Visible = false;
                }
            }
        }

        private void hideSubMenu()
        {
            HideAllSubmenus(panelCustomerSubmenu, panelRentalsSubmenu, panelSupplierSubmenu, panelStockSubmenu, panelCarSubmenu, panelPaymentSubmenu);
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Submenu End


        private void mainMenu_Load(object sender, EventArgs e)
        {

            vis = false;

            tmrStop.Enabled = true;
        }

        private void ActivateButton(object btnSender) //Method for changeing the colour of the button to a color to highlight what has been selected
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(0, 180, 126); //Setting the colour variable
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); //Changing font slightly to contrast the text
                }
            }
        }

        private void DisableButton() //Changes the previous button back to stock properties
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(26, 26, 26);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void btnCloseSubForm_Click(object sender, EventArgs e) //"X" button to close current form
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset() //Back to home, removing x button
        {
            DisableButton();
            lblTitle.Text = "Main Menu";
            currentButton = null;
            btnCloseSubForm.Visible = false;
        }

        public void openSubForm(Form childForm, object btnSender) //Opens sub forms in panel
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseSubForm.Visible = true;
        }


        //Main Form buttons START
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelCustomerSubmenu);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelSupplierSubmenu);
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelRentalsSubmenu);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelCarSubmenu);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelPaymentSubmenu);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelStockSubmenu);
        }

        private void btnMainCustomer_Click(object sender, EventArgs e)
        {
            openSubForm(new RoadTripRentals.frmMainCustomer(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settingsForm = new frmSettings();
            openSubForm(settingsForm, sender);
        }

        //Main form buttons END

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.OpenSubFormRequest += OpenSubFormRequest;
            openSubForm(addCustomerForm, sender);
        }
        private void OpenSubFormRequest(Form subForm)
        {
            openSubForm(subForm, null);
        }

        private void btnMainRental_Click(object sender, EventArgs e)
        {
            frmMainRentals mainRentalsForm = new frmMainRentals();
            openSubForm(mainRentalsForm, sender);
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            frmAddRentals AddRentalsForm = new frmAddRentals();
            openSubForm(AddRentalsForm, sender);
        }

        private void btnMainCars_Click(object sender, EventArgs e)
        {
            frmMainCar mainCarForm = new frmMainCar();
            openSubForm(mainCarForm, sender);
        }


        private void btnAddCar_Click(object sender, EventArgs e)
        {
            frmAddCar addCarForm = new frmAddCar();
            openSubForm(addCarForm, sender);
        }

        private void btnMainModels_Click(object sender, EventArgs e)
        {
            frmMainModel mainModelForm = new frmMainModel();
            openSubForm(mainModelForm, sender);
        }

        private void btnMainRentalCost_Click(object sender, EventArgs e)
        {
            frmMainRentalCost mainRentalCostForm = new frmMainRentalCost();
            openSubForm(mainRentalCostForm, sender);
        }

        private void btnMainPayment_Click(object sender, EventArgs e)
        {
            frmMainPayments mainPaymentsForm = new frmMainPayments();
            openSubForm(mainPaymentsForm, sender);
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            frmAddPayments addPaymentsForm = new frmAddPayments();
            openSubForm(addPaymentsForm, sender);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmOrderStock addStockForm = new frmOrderStock();
            openSubForm(addStockForm, sender);
        }

        private void btnMainSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierMain displayForm = new frmSupplierMain();
            openSubForm(displayForm, sender);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier displayForm = new frmAddSupplier();
            openSubForm(displayForm, sender);
        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            frmOrderMain displayForm = new frmOrderMain();
            openSubForm(displayForm, sender);
        }

        private void btnEditRental_Click(object sender, EventArgs e)
        {
            frmEditRental displayForm = new frmEditRental();
            openSubForm(displayForm, sender);
        }

    }
}
