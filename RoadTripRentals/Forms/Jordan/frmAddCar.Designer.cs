namespace RoadTripRentals.Forms.Jordan
{
    partial class frmAddCar
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
            this.panelSub = new System.Windows.Forms.Panel();
            this.txtAddYear = new System.Windows.Forms.NumericUpDown();
            this.txtAddNoSeats = new System.Windows.Forms.NumericUpDown();
            this.txtAddMileage = new System.Windows.Forms.NumericUpDown();
            this.cmbAddRentalCostID = new System.Windows.Forms.ComboBox();
            this.cmbAddFuelType = new System.Windows.Forms.ComboBox();
            this.cmbAddColour = new System.Windows.Forms.ComboBox();
            this.cmbAddModelID = new System.Windows.Forms.ComboBox();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblAddCarReg = new System.Windows.Forms.Label();
            this.txtAddCarReg = new System.Windows.Forms.TextBox();
            this.lblAddModelID = new System.Windows.Forms.Label();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.lblAddMileage = new System.Windows.Forms.Label();
            this.lblAddFuelType = new System.Windows.Forms.Label();
            this.lblAddSeats = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNoSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.txtAddYear);
            this.panelSub.Controls.Add(this.txtAddNoSeats);
            this.panelSub.Controls.Add(this.txtAddMileage);
            this.panelSub.Controls.Add(this.cmbAddRentalCostID);
            this.panelSub.Controls.Add(this.cmbAddFuelType);
            this.panelSub.Controls.Add(this.cmbAddColour);
            this.panelSub.Controls.Add(this.cmbAddModelID);
            this.panelSub.Controls.Add(this.btnAddAdd);
            this.panelSub.Controls.Add(this.btnAddCancel);
            this.panelSub.Controls.Add(this.lblAddCarReg);
            this.panelSub.Controls.Add(this.txtAddCarReg);
            this.panelSub.Controls.Add(this.lblAddModelID);
            this.panelSub.Controls.Add(this.lblAddColour);
            this.panelSub.Controls.Add(this.lblAddMileage);
            this.panelSub.Controls.Add(this.lblAddFuelType);
            this.panelSub.Controls.Add(this.lblAddSeats);
            this.panelSub.Controls.Add(this.lblAddYear);
            this.panelSub.Controls.Add(this.lblRentalCost);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(438, 518);
            this.panelSub.TabIndex = 52;
            // 
            // txtAddYear
            // 
            this.txtAddYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddYear.Location = new System.Drawing.Point(206, 320);
            this.txtAddYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.txtAddYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.ReadOnly = true;
            this.txtAddYear.Size = new System.Drawing.Size(178, 26);
            this.txtAddYear.TabIndex = 50;
            this.txtAddYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // txtAddNoSeats
            // 
            this.txtAddNoSeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNoSeats.Location = new System.Drawing.Point(206, 276);
            this.txtAddNoSeats.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.txtAddNoSeats.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtAddNoSeats.Name = "txtAddNoSeats";
            this.txtAddNoSeats.ReadOnly = true;
            this.txtAddNoSeats.Size = new System.Drawing.Size(178, 26);
            this.txtAddNoSeats.TabIndex = 50;
            this.txtAddNoSeats.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtAddMileage
            // 
            this.txtAddMileage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMileage.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtAddMileage.Location = new System.Drawing.Point(206, 184);
            this.txtAddMileage.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtAddMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAddMileage.Name = "txtAddMileage";
            this.txtAddMileage.Size = new System.Drawing.Size(178, 26);
            this.txtAddMileage.TabIndex = 50;
            this.txtAddMileage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmbAddRentalCostID
            // 
            this.cmbAddRentalCostID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddRentalCostID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAddRentalCostID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddRentalCostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddRentalCostID.FormattingEnabled = true;
            this.cmbAddRentalCostID.ItemHeight = 20;
            this.cmbAddRentalCostID.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cmbAddRentalCostID.Location = new System.Drawing.Point(206, 363);
            this.cmbAddRentalCostID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbAddRentalCostID.Name = "cmbAddRentalCostID";
            this.cmbAddRentalCostID.Size = new System.Drawing.Size(178, 28);
            this.cmbAddRentalCostID.TabIndex = 49;
            // 
            // cmbAddFuelType
            // 
            this.cmbAddFuelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddFuelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAddFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddFuelType.FormattingEnabled = true;
            this.cmbAddFuelType.ItemHeight = 20;
            this.cmbAddFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cmbAddFuelType.Location = new System.Drawing.Point(206, 228);
            this.cmbAddFuelType.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbAddFuelType.Name = "cmbAddFuelType";
            this.cmbAddFuelType.Size = new System.Drawing.Size(178, 28);
            this.cmbAddFuelType.TabIndex = 49;
            // 
            // cmbAddColour
            // 
            this.cmbAddColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAddColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddColour.FormattingEnabled = true;
            this.cmbAddColour.ItemHeight = 20;
            this.cmbAddColour.Location = new System.Drawing.Point(206, 139);
            this.cmbAddColour.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbAddColour.Name = "cmbAddColour";
            this.cmbAddColour.Size = new System.Drawing.Size(178, 28);
            this.cmbAddColour.TabIndex = 49;
            // 
            // cmbAddModelID
            // 
            this.cmbAddModelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddModelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAddModelID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddModelID.FormattingEnabled = true;
            this.cmbAddModelID.ItemHeight = 20;
            this.cmbAddModelID.Items.AddRange(new object[] {
            "X5",
            "A4"});
            this.cmbAddModelID.Location = new System.Drawing.Point(206, 100);
            this.cmbAddModelID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbAddModelID.Name = "cmbAddModelID";
            this.cmbAddModelID.Size = new System.Drawing.Size(178, 28);
            this.cmbAddModelID.TabIndex = 49;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.AllowDrop = true;
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAdd.Location = new System.Drawing.Point(37, 410);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(178, 45);
            this.btnAddAdd.TabIndex = 29;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.AllowDrop = true;
            this.btnAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCancel.BackColor = System.Drawing.Color.Silver;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(223, 410);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(178, 45);
            this.btnAddCancel.TabIndex = 30;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblAddCarReg
            // 
            this.lblAddCarReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddCarReg.AutoSize = true;
            this.lblAddCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCarReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddCarReg.Location = new System.Drawing.Point(68, 62);
            this.lblAddCarReg.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddCarReg.Name = "lblAddCarReg";
            this.lblAddCarReg.Size = new System.Drawing.Size(75, 20);
            this.lblAddCarReg.TabIndex = 33;
            this.lblAddCarReg.Text = "Car Reg";
            // 
            // txtAddCarReg
            // 
            this.txtAddCarReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddCarReg.Location = new System.Drawing.Point(206, 59);
            this.txtAddCarReg.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddCarReg.Multiline = true;
            this.txtAddCarReg.Name = "txtAddCarReg";
            this.txtAddCarReg.Size = new System.Drawing.Size(178, 30);
            this.txtAddCarReg.TabIndex = 48;
            // 
            // lblAddModelID
            // 
            this.lblAddModelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddModelID.AutoSize = true;
            this.lblAddModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddModelID.Location = new System.Drawing.Point(68, 103);
            this.lblAddModelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddModelID.Name = "lblAddModelID";
            this.lblAddModelID.Size = new System.Drawing.Size(57, 20);
            this.lblAddModelID.TabIndex = 34;
            this.lblAddModelID.Text = "Model";
            // 
            // lblAddColour
            // 
            this.lblAddColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddColour.AutoSize = true;
            this.lblAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddColour.Location = new System.Drawing.Point(68, 147);
            this.lblAddColour.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddColour.Name = "lblAddColour";
            this.lblAddColour.Size = new System.Drawing.Size(61, 20);
            this.lblAddColour.TabIndex = 35;
            this.lblAddColour.Text = "Colour";
            // 
            // lblAddMileage
            // 
            this.lblAddMileage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddMileage.AutoSize = true;
            this.lblAddMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddMileage.Location = new System.Drawing.Point(67, 190);
            this.lblAddMileage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddMileage.Name = "lblAddMileage";
            this.lblAddMileage.Size = new System.Drawing.Size(71, 20);
            this.lblAddMileage.TabIndex = 36;
            this.lblAddMileage.Text = "Mileage";
            // 
            // lblAddFuelType
            // 
            this.lblAddFuelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddFuelType.AutoSize = true;
            this.lblAddFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddFuelType.Location = new System.Drawing.Point(67, 236);
            this.lblAddFuelType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddFuelType.Name = "lblAddFuelType";
            this.lblAddFuelType.Size = new System.Drawing.Size(87, 20);
            this.lblAddFuelType.TabIndex = 35;
            this.lblAddFuelType.Text = "Fuel Type";
            // 
            // lblAddSeats
            // 
            this.lblAddSeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddSeats.AutoSize = true;
            this.lblAddSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddSeats.Location = new System.Drawing.Point(68, 282);
            this.lblAddSeats.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddSeats.Name = "lblAddSeats";
            this.lblAddSeats.Size = new System.Drawing.Size(88, 20);
            this.lblAddSeats.TabIndex = 38;
            this.lblAddSeats.Text = "No. Seats";
            // 
            // lblAddYear
            // 
            this.lblAddYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddYear.Location = new System.Drawing.Point(68, 326);
            this.lblAddYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(47, 20);
            this.lblAddYear.TabIndex = 39;
            this.lblAddYear.Text = "Year";
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblRentalCost.Location = new System.Drawing.Point(68, 371);
            this.lblRentalCost.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(104, 20);
            this.lblRentalCost.TabIndex = 40;
            this.lblRentalCost.Text = "Rental Cost";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 518);
            this.Controls.Add(this.panelSub);
            this.Name = "frmAddCar";
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.frmAddCar_Load);
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNoSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.ComboBox cmbAddModelID;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label lblAddCarReg;
        private System.Windows.Forms.Label lblAddModelID;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.Label lblAddMileage;
        private System.Windows.Forms.Label lblAddFuelType;
        private System.Windows.Forms.Label lblAddSeats;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.TextBox txtAddCarReg;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ComboBox cmbAddFuelType;
        private System.Windows.Forms.ComboBox cmbAddColour;
        private System.Windows.Forms.NumericUpDown txtAddMileage;
        private System.Windows.Forms.NumericUpDown txtAddNoSeats;
        private System.Windows.Forms.NumericUpDown txtAddYear;
        private System.Windows.Forms.ComboBox cmbAddRentalCostID;
    }
}