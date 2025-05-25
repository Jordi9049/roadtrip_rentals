namespace RoadTripRentals.Forms.Jordan
{
    partial class frmEditCar
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
            this.txtEditYear = new System.Windows.Forms.NumericUpDown();
            this.txtEditNoSeats = new System.Windows.Forms.NumericUpDown();
            this.txtEditMileage = new System.Windows.Forms.NumericUpDown();
            this.cmbEditRentalCostID = new System.Windows.Forms.ComboBox();
            this.cmbEditFuelType = new System.Windows.Forms.ComboBox();
            this.cmbEditColour = new System.Windows.Forms.ComboBox();
            this.cmbEditModelID = new System.Windows.Forms.ComboBox();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.lblEditCarReg = new System.Windows.Forms.Label();
            this.lblAddCarReg = new System.Windows.Forms.Label();
            this.lblAddModelID = new System.Windows.Forms.Label();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.lblAddMileage = new System.Windows.Forms.Label();
            this.lblAddFuelType = new System.Windows.Forms.Label();
            this.lblAddSeats = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNoSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.txtEditYear);
            this.panelSub.Controls.Add(this.txtEditNoSeats);
            this.panelSub.Controls.Add(this.txtEditMileage);
            this.panelSub.Controls.Add(this.cmbEditRentalCostID);
            this.panelSub.Controls.Add(this.cmbEditFuelType);
            this.panelSub.Controls.Add(this.cmbEditColour);
            this.panelSub.Controls.Add(this.cmbEditModelID);
            this.panelSub.Controls.Add(this.btnEditUpdate);
            this.panelSub.Controls.Add(this.btnEditCancel);
            this.panelSub.Controls.Add(this.lblEditCarReg);
            this.panelSub.Controls.Add(this.lblAddCarReg);
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
            this.panelSub.Size = new System.Drawing.Size(422, 479);
            this.panelSub.TabIndex = 53;
            // 
            // txtEditYear
            // 
            this.txtEditYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditYear.Location = new System.Drawing.Point(192, 303);
            this.txtEditYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.txtEditYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.txtEditYear.Name = "txtEditYear";
            this.txtEditYear.ReadOnly = true;
            this.txtEditYear.Size = new System.Drawing.Size(178, 26);
            this.txtEditYear.TabIndex = 50;
            this.txtEditYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // txtEditNoSeats
            // 
            this.txtEditNoSeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditNoSeats.Location = new System.Drawing.Point(192, 259);
            this.txtEditNoSeats.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.txtEditNoSeats.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtEditNoSeats.Name = "txtEditNoSeats";
            this.txtEditNoSeats.ReadOnly = true;
            this.txtEditNoSeats.Size = new System.Drawing.Size(178, 26);
            this.txtEditNoSeats.TabIndex = 50;
            this.txtEditNoSeats.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtEditMileage
            // 
            this.txtEditMileage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMileage.Location = new System.Drawing.Point(192, 167);
            this.txtEditMileage.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtEditMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtEditMileage.Name = "txtEditMileage";
            this.txtEditMileage.Size = new System.Drawing.Size(178, 26);
            this.txtEditMileage.TabIndex = 50;
            this.txtEditMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbEditRentalCostID
            // 
            this.cmbEditRentalCostID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditRentalCostID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEditRentalCostID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditRentalCostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditRentalCostID.FormattingEnabled = true;
            this.cmbEditRentalCostID.ItemHeight = 20;
            this.cmbEditRentalCostID.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cmbEditRentalCostID.Location = new System.Drawing.Point(192, 346);
            this.cmbEditRentalCostID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbEditRentalCostID.Name = "cmbEditRentalCostID";
            this.cmbEditRentalCostID.Size = new System.Drawing.Size(178, 28);
            this.cmbEditRentalCostID.TabIndex = 49;
            // 
            // cmbEditFuelType
            // 
            this.cmbEditFuelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditFuelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEditFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditFuelType.FormattingEnabled = true;
            this.cmbEditFuelType.ItemHeight = 20;
            this.cmbEditFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cmbEditFuelType.Location = new System.Drawing.Point(192, 211);
            this.cmbEditFuelType.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbEditFuelType.Name = "cmbEditFuelType";
            this.cmbEditFuelType.Size = new System.Drawing.Size(178, 28);
            this.cmbEditFuelType.TabIndex = 49;
            // 
            // cmbEditColour
            // 
            this.cmbEditColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEditColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditColour.FormattingEnabled = true;
            this.cmbEditColour.ItemHeight = 20;
            this.cmbEditColour.Location = new System.Drawing.Point(192, 122);
            this.cmbEditColour.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbEditColour.Name = "cmbEditColour";
            this.cmbEditColour.Size = new System.Drawing.Size(178, 28);
            this.cmbEditColour.TabIndex = 49;
            // 
            // cmbEditModelID
            // 
            this.cmbEditModelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditModelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEditModelID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditModelID.FormattingEnabled = true;
            this.cmbEditModelID.ItemHeight = 20;
            this.cmbEditModelID.Items.AddRange(new object[] {
            "X5",
            "A4"});
            this.cmbEditModelID.Location = new System.Drawing.Point(192, 83);
            this.cmbEditModelID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbEditModelID.Name = "cmbEditModelID";
            this.cmbEditModelID.Size = new System.Drawing.Size(178, 28);
            this.cmbEditModelID.TabIndex = 49;
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AllowDrop = true;
            this.btnEditUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnEditUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditUpdate.Location = new System.Drawing.Point(23, 393);
            this.btnEditUpdate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(178, 45);
            this.btnEditUpdate.TabIndex = 29;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.AllowDrop = true;
            this.btnEditCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCancel.BackColor = System.Drawing.Color.Silver;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCancel.Location = new System.Drawing.Point(209, 393);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(178, 45);
            this.btnEditCancel.TabIndex = 30;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // lblEditCarReg
            // 
            this.lblEditCarReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditCarReg.AutoSize = true;
            this.lblEditCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCarReg.ForeColor = System.Drawing.Color.Black;
            this.lblEditCarReg.Location = new System.Drawing.Point(188, 45);
            this.lblEditCarReg.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditCarReg.Name = "lblEditCarReg";
            this.lblEditCarReg.Size = new System.Drawing.Size(15, 20);
            this.lblEditCarReg.TabIndex = 33;
            this.lblEditCarReg.Text = "-";
            // 
            // lblAddCarReg
            // 
            this.lblAddCarReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddCarReg.AutoSize = true;
            this.lblAddCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCarReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddCarReg.Location = new System.Drawing.Point(54, 45);
            this.lblAddCarReg.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddCarReg.Name = "lblAddCarReg";
            this.lblAddCarReg.Size = new System.Drawing.Size(75, 20);
            this.lblAddCarReg.TabIndex = 33;
            this.lblAddCarReg.Text = "Car Reg";
            // 
            // lblAddModelID
            // 
            this.lblAddModelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddModelID.AutoSize = true;
            this.lblAddModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddModelID.Location = new System.Drawing.Point(54, 86);
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
            this.lblAddColour.Location = new System.Drawing.Point(54, 130);
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
            this.lblAddMileage.Location = new System.Drawing.Point(53, 173);
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
            this.lblAddFuelType.Location = new System.Drawing.Point(53, 219);
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
            this.lblAddSeats.Location = new System.Drawing.Point(54, 265);
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
            this.lblAddYear.Location = new System.Drawing.Point(54, 309);
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
            this.lblRentalCost.Location = new System.Drawing.Point(54, 354);
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
            // frmEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 479);
            this.Controls.Add(this.panelSub);
            this.Name = "frmEditCar";
            this.Text = "frmEditCar";
            this.Load += new System.EventHandler(this.frmEditCar_Load);
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNoSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.NumericUpDown txtEditYear;
        private System.Windows.Forms.NumericUpDown txtEditNoSeats;
        private System.Windows.Forms.NumericUpDown txtEditMileage;
        private System.Windows.Forms.ComboBox cmbEditRentalCostID;
        private System.Windows.Forms.ComboBox cmbEditFuelType;
        private System.Windows.Forms.ComboBox cmbEditColour;
        private System.Windows.Forms.ComboBox cmbEditModelID;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Label lblAddCarReg;
        private System.Windows.Forms.Label lblAddModelID;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.Label lblAddMileage;
        private System.Windows.Forms.Label lblAddFuelType;
        private System.Windows.Forms.Label lblAddSeats;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lblEditCarReg;
    }
}