namespace RoadTripRentals
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrStop = new System.Windows.Forms.Timer(this.components);
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseSubForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCustomerSubmenu = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnMainCustomer = new System.Windows.Forms.Button();
            this.panelRentalsSubmenu = new System.Windows.Forms.Panel();
            this.btnEditRental = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnMainRental = new System.Windows.Forms.Button();
            this.panelCarSubmenu = new System.Windows.Forms.Panel();
            this.btnMainRentalCost = new System.Windows.Forms.Button();
            this.btnMainModels = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnMainCar = new System.Windows.Forms.Button();
            this.panelSupplierSubmenu = new System.Windows.Forms.Panel();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnMainSupplier = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelStockSubmenu = new System.Windows.Forms.Panel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnMainStock = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panelPaymentSubmenu = new System.Windows.Forms.Panel();
            this.btnMainPayment = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustomerSubmenu.SuspendLayout();
            this.panelRentalsSubmenu.SuspendLayout();
            this.panelCarSubmenu.SuspendLayout();
            this.panelSupplierSubmenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelStockSubmenu.SuspendLayout();
            this.panelPaymentSubmenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.panelTitle.Controls.Add(this.btnCloseSubForm);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(775, 104);
            this.panelTitle.TabIndex = 8;
            // 
            // btnCloseSubForm
            // 
            this.btnCloseSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.btnCloseSubForm.FlatAppearance.BorderSize = 0;
            this.btnCloseSubForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSubForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.btnCloseSubForm.Location = new System.Drawing.Point(704, 19);
            this.btnCloseSubForm.Name = "btnCloseSubForm";
            this.btnCloseSubForm.Size = new System.Drawing.Size(59, 60);
            this.btnCloseSubForm.TabIndex = 2;
            this.btnCloseSubForm.Text = "X";
            this.btnCloseSubForm.UseVisualStyleBackColor = false;
            this.btnCloseSubForm.Click += new System.EventHandler(this.btnCloseSubForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(281, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 104);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(775, 595);
            this.panelForm.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RoadTripRentals.Properties.Resources.roadtripRentalsIcon;
            this.pictureBox1.Location = new System.Drawing.Point(121, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCustomerSubmenu
            // 
            this.panelCustomerSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelCustomerSubmenu.Controls.Add(this.btnAddCustomer);
            this.panelCustomerSubmenu.Controls.Add(this.btnMainCustomer);
            this.panelCustomerSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerSubmenu.Location = new System.Drawing.Point(0, 164);
            this.panelCustomerSubmenu.Name = "panelCustomerSubmenu";
            this.panelCustomerSubmenu.Size = new System.Drawing.Size(183, 88);
            this.panelCustomerSubmenu.TabIndex = 9;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 42);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(183, 42);
            this.btnAddCustomer.TabIndex = 14;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnMainCustomer
            // 
            this.btnMainCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainCustomer.ForeColor = System.Drawing.Color.White;
            this.btnMainCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnMainCustomer.Name = "btnMainCustomer";
            this.btnMainCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainCustomer.Size = new System.Drawing.Size(183, 42);
            this.btnMainCustomer.TabIndex = 13;
            this.btnMainCustomer.Text = "Details";
            this.btnMainCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCustomer.UseVisualStyleBackColor = false;
            this.btnMainCustomer.Click += new System.EventHandler(this.btnMainCustomer_Click);
            // 
            // panelRentalsSubmenu
            // 
            this.panelRentalsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelRentalsSubmenu.Controls.Add(this.btnEditRental);
            this.panelRentalsSubmenu.Controls.Add(this.btnAddRental);
            this.panelRentalsSubmenu.Controls.Add(this.btnMainRental);
            this.panelRentalsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRentalsSubmenu.Location = new System.Drawing.Point(0, 312);
            this.panelRentalsSubmenu.Name = "panelRentalsSubmenu";
            this.panelRentalsSubmenu.Size = new System.Drawing.Size(183, 133);
            this.panelRentalsSubmenu.TabIndex = 11;
            // 
            // btnEditRental
            // 
            this.btnEditRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditRental.ForeColor = System.Drawing.Color.White;
            this.btnEditRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRental.Location = new System.Drawing.Point(0, 84);
            this.btnEditRental.Name = "btnEditRental";
            this.btnEditRental.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditRental.Size = new System.Drawing.Size(183, 42);
            this.btnEditRental.TabIndex = 15;
            this.btnEditRental.Text = "Edit";
            this.btnEditRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditRental.UseVisualStyleBackColor = false;
            this.btnEditRental.Click += new System.EventHandler(this.btnEditRental_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddRental.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRental.Location = new System.Drawing.Point(0, 42);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddRental.Size = new System.Drawing.Size(183, 42);
            this.btnAddRental.TabIndex = 14;
            this.btnAddRental.Text = "Add";
            this.btnAddRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRental.UseVisualStyleBackColor = false;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnMainRental
            // 
            this.btnMainRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainRental.ForeColor = System.Drawing.Color.White;
            this.btnMainRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainRental.Location = new System.Drawing.Point(0, 0);
            this.btnMainRental.Name = "btnMainRental";
            this.btnMainRental.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainRental.Size = new System.Drawing.Size(183, 42);
            this.btnMainRental.TabIndex = 13;
            this.btnMainRental.Text = "Details";
            this.btnMainRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainRental.UseVisualStyleBackColor = false;
            this.btnMainRental.Click += new System.EventHandler(this.btnMainRental_Click);
            // 
            // panelCarSubmenu
            // 
            this.panelCarSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelCarSubmenu.Controls.Add(this.btnMainRentalCost);
            this.panelCarSubmenu.Controls.Add(this.btnMainModels);
            this.panelCarSubmenu.Controls.Add(this.btnAddCar);
            this.panelCarSubmenu.Controls.Add(this.btnMainCar);
            this.panelCarSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarSubmenu.Location = new System.Drawing.Point(0, 505);
            this.panelCarSubmenu.Name = "panelCarSubmenu";
            this.panelCarSubmenu.Size = new System.Drawing.Size(183, 174);
            this.panelCarSubmenu.TabIndex = 13;
            // 
            // btnMainRentalCost
            // 
            this.btnMainRentalCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainRentalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainRentalCost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainRentalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainRentalCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainRentalCost.ForeColor = System.Drawing.Color.White;
            this.btnMainRentalCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainRentalCost.Location = new System.Drawing.Point(0, 126);
            this.btnMainRentalCost.Name = "btnMainRentalCost";
            this.btnMainRentalCost.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainRentalCost.Size = new System.Drawing.Size(183, 42);
            this.btnMainRentalCost.TabIndex = 16;
            this.btnMainRentalCost.Text = "Rental Cost";
            this.btnMainRentalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainRentalCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainRentalCost.UseVisualStyleBackColor = false;
            this.btnMainRentalCost.Click += new System.EventHandler(this.btnMainRentalCost_Click);
            // 
            // btnMainModels
            // 
            this.btnMainModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainModels.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainModels.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainModels.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainModels.ForeColor = System.Drawing.Color.White;
            this.btnMainModels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainModels.Location = new System.Drawing.Point(0, 84);
            this.btnMainModels.Name = "btnMainModels";
            this.btnMainModels.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainModels.Size = new System.Drawing.Size(183, 42);
            this.btnMainModels.TabIndex = 15;
            this.btnMainModels.Text = "Models";
            this.btnMainModels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainModels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainModels.UseVisualStyleBackColor = false;
            this.btnMainModels.Click += new System.EventHandler(this.btnMainModels_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.Location = new System.Drawing.Point(0, 42);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddCar.Size = new System.Drawing.Size(183, 42);
            this.btnAddCar.TabIndex = 14;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnMainCar
            // 
            this.btnMainCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainCar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainCar.ForeColor = System.Drawing.Color.White;
            this.btnMainCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCar.Location = new System.Drawing.Point(0, 0);
            this.btnMainCar.Name = "btnMainCar";
            this.btnMainCar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainCar.Size = new System.Drawing.Size(183, 42);
            this.btnMainCar.TabIndex = 13;
            this.btnMainCar.Text = "Details";
            this.btnMainCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainCar.UseVisualStyleBackColor = false;
            this.btnMainCar.Click += new System.EventHandler(this.btnMainCars_Click);
            // 
            // panelSupplierSubmenu
            // 
            this.panelSupplierSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelSupplierSubmenu.Controls.Add(this.btnAddSupplier);
            this.panelSupplierSubmenu.Controls.Add(this.btnMainSupplier);
            this.panelSupplierSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupplierSubmenu.Location = new System.Drawing.Point(0, 739);
            this.panelSupplierSubmenu.Name = "panelSupplierSubmenu";
            this.panelSupplierSubmenu.Size = new System.Drawing.Size(183, 88);
            this.panelSupplierSubmenu.TabIndex = 15;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(0, 42);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddSupplier.Size = new System.Drawing.Size(183, 42);
            this.btnAddSupplier.TabIndex = 14;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnMainSupplier
            // 
            this.btnMainSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainSupplier.ForeColor = System.Drawing.Color.White;
            this.btnMainSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainSupplier.Location = new System.Drawing.Point(0, 0);
            this.btnMainSupplier.Name = "btnMainSupplier";
            this.btnMainSupplier.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainSupplier.Size = new System.Drawing.Size(183, 42);
            this.btnMainSupplier.TabIndex = 13;
            this.btnMainSupplier.Text = "Details";
            this.btnMainSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainSupplier.UseVisualStyleBackColor = false;
            this.btnMainSupplier.Click += new System.EventHandler(this.btnMainSupplier_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.panelStockSubmenu);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.panelPaymentSubmenu);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.panelSupplierSubmenu);
            this.panelMenu.Controls.Add(this.btnSupplier);
            this.panelMenu.Controls.Add(this.panelCarSubmenu);
            this.panelMenu.Controls.Add(this.btnCar);
            this.panelMenu.Controls.Add(this.panelRentalsSubmenu);
            this.panelMenu.Controls.Add(this.btnRentals);
            this.panelMenu.Controls.Add(this.panelCustomerSubmenu);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 699);
            this.panelMenu.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 1082);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(183, 60);
            this.btnSettings.TabIndex = 20;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 1142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(183, 60);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelStockSubmenu
            // 
            this.panelStockSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelStockSubmenu.Controls.Add(this.btnAddStock);
            this.panelStockSubmenu.Controls.Add(this.btnMainStock);
            this.panelStockSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockSubmenu.Location = new System.Drawing.Point(0, 994);
            this.panelStockSubmenu.Name = "panelStockSubmenu";
            this.panelStockSubmenu.Size = new System.Drawing.Size(183, 88);
            this.panelStockSubmenu.TabIndex = 19;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.Location = new System.Drawing.Point(0, 42);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddStock.Size = new System.Drawing.Size(183, 42);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnMainStock
            // 
            this.btnMainStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainStock.ForeColor = System.Drawing.Color.White;
            this.btnMainStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainStock.Location = new System.Drawing.Point(0, 0);
            this.btnMainStock.Name = "btnMainStock";
            this.btnMainStock.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainStock.Size = new System.Drawing.Size(183, 42);
            this.btnMainStock.TabIndex = 13;
            this.btnMainStock.Text = "Details";
            this.btnMainStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainStock.UseVisualStyleBackColor = false;
            this.btnMainStock.Click += new System.EventHandler(this.btnStockDetails_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::RoadTripRentals.Properties.Resources.supplierIcon;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 934);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(183, 60);
            this.btnStock.TabIndex = 18;
            this.btnStock.Text = "Stock order";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panelPaymentSubmenu
            // 
            this.panelPaymentSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.panelPaymentSubmenu.Controls.Add(this.btnMainPayment);
            this.panelPaymentSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymentSubmenu.Location = new System.Drawing.Point(0, 887);
            this.panelPaymentSubmenu.Name = "panelPaymentSubmenu";
            this.panelPaymentSubmenu.Size = new System.Drawing.Size(183, 47);
            this.panelPaymentSubmenu.TabIndex = 17;
            // 
            // btnMainPayment
            // 
            this.btnMainPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMainPayment.ForeColor = System.Drawing.Color.White;
            this.btnMainPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPayment.Location = new System.Drawing.Point(0, 0);
            this.btnMainPayment.Name = "btnMainPayment";
            this.btnMainPayment.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainPayment.Size = new System.Drawing.Size(183, 42);
            this.btnMainPayment.TabIndex = 13;
            this.btnMainPayment.Text = "Details";
            this.btnMainPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainPayment.UseVisualStyleBackColor = false;
            this.btnMainPayment.Click += new System.EventHandler(this.btnMainPayment_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Image = global::RoadTripRentals.Properties.Resources.paymentIcon;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 827);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(183, 60);
            this.btnPayments.TabIndex = 16;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::RoadTripRentals.Properties.Resources.supplierIcon;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 679);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(183, 60);
            this.btnSupplier.TabIndex = 14;
            this.btnSupplier.Text = "Suppliers";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.Color.White;
            this.btnCar.Image = global::RoadTripRentals.Properties.Resources.carIcon;
            this.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.Location = new System.Drawing.Point(0, 445);
            this.btnCar.Name = "btnCar";
            this.btnCar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCar.Size = new System.Drawing.Size(183, 60);
            this.btnCar.TabIndex = 12;
            this.btnCar.Text = "Car details";
            this.btnCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentals.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentals.FlatAppearance.BorderSize = 0;
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentals.ForeColor = System.Drawing.Color.White;
            this.btnRentals.Image = global::RoadTripRentals.Properties.Resources.rentalIcon;
            this.btnRentals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentals.Location = new System.Drawing.Point(0, 252);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRentals.Size = new System.Drawing.Size(183, 60);
            this.btnRentals.TabIndex = 10;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentals.UseVisualStyleBackColor = false;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::RoadTripRentals.Properties.Resources.customerIcon;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 104);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(183, 60);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 104);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::RoadTripRentals.Properties.Resources.roadtripRentalsIcon_1;
            this.pictureBox2.Location = new System.Drawing.Point(1, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnCloseSubForm_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(975, 699);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(991, 738);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roadtrip Rentals";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustomerSubmenu.ResumeLayout(false);
            this.panelRentalsSubmenu.ResumeLayout(false);
            this.panelCarSubmenu.ResumeLayout(false);
            this.panelSupplierSubmenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelStockSubmenu.ResumeLayout(false);
            this.panelPaymentSubmenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrStop;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelCustomerSubmenu;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnMainCustomer;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Panel panelRentalsSubmenu;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnMainRental;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Panel panelCarSubmenu;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnMainCar;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel panelSupplierSubmenu;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnMainSupplier;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelStockSubmenu;
        private System.Windows.Forms.Button btnAddStock;

        private System.Windows.Forms.Button btnMainStock;
        private System.Windows.Forms.Button btnStock;

        private System.Windows.Forms.Panel panelPaymentSubmenu;
        private System.Windows.Forms.Button btnMainPayment;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCloseSubForm;
        private System.Windows.Forms.Button btnMainRentalCost;
        private System.Windows.Forms.Button btnMainModels;
        private System.Windows.Forms.Button btnEditRental;
    }
}