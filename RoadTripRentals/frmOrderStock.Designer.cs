namespace RoadTripRentals
{
    partial class frmOrderStock
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
            this.pnlOrderStock = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderD = new System.Windows.Forms.Label();
            this.lblOrderTotalValue = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblRemoveFromOrder = new System.Windows.Forms.Label();
            this.lblCompleteOrder = new System.Windows.Forms.Label();
            this.lblCancelOrder = new System.Windows.Forms.Label();
            this.lblAddToOrder = new System.Windows.Forms.Label();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.CarReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvSupplierStock = new System.Windows.Forms.DataGridView();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.pnlOrderStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderStock
            // 
            this.pnlOrderStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlOrderStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.pnlOrderStock.Controls.Add(this.lblSupplier);
            this.pnlOrderStock.Controls.Add(this.lblStaffID);
            this.pnlOrderStock.Controls.Add(this.cmbStaff);
            this.pnlOrderStock.Controls.Add(this.lblOrderDate);
            this.pnlOrderStock.Controls.Add(this.lblOrderD);
            this.pnlOrderStock.Controls.Add(this.lblOrderTotalValue);
            this.pnlOrderStock.Controls.Add(this.lblOrderTotal);
            this.pnlOrderStock.Controls.Add(this.lblRemoveFromOrder);
            this.pnlOrderStock.Controls.Add(this.lblCompleteOrder);
            this.pnlOrderStock.Controls.Add(this.lblCancelOrder);
            this.pnlOrderStock.Controls.Add(this.lblAddToOrder);
            this.pnlOrderStock.Controls.Add(this.lvwOrderDetails);
            this.pnlOrderStock.Controls.Add(this.dgvSupplierStock);
            this.pnlOrderStock.Controls.Add(this.cmbSupplier);
            this.pnlOrderStock.Location = new System.Drawing.Point(29, 20);
            this.pnlOrderStock.Name = "pnlOrderStock";
            this.pnlOrderStock.Size = new System.Drawing.Size(622, 474);
            this.pnlOrderStock.TabIndex = 14;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(198, 13);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(113, 16);
            this.lblSupplier.TabIndex = 20;
            this.lblSupplier.Text = "Select Supplier";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(10, 13);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(105, 16);
            this.lblStaffID.TabIndex = 19;
            this.lblStaffID.Text = "Select Staff ID";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(13, 37);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(142, 21);
            this.cmbStaff.TabIndex = 18;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(473, 15);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 13);
            this.lblOrderDate.TabIndex = 17;
            // 
            // lblOrderD
            // 
            this.lblOrderD.AutoSize = true;
            this.lblOrderD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderD.Location = new System.Drawing.Point(380, 13);
            this.lblOrderD.Name = "lblOrderD";
            this.lblOrderD.Size = new System.Drawing.Size(87, 16);
            this.lblOrderD.TabIndex = 16;
            this.lblOrderD.Text = "Order Date:";
            // 
            // lblOrderTotalValue
            // 
            this.lblOrderTotalValue.BackColor = System.Drawing.Color.White;
            this.lblOrderTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalValue.Location = new System.Drawing.Point(256, 387);
            this.lblOrderTotalValue.Name = "lblOrderTotalValue";
            this.lblOrderTotalValue.Size = new System.Drawing.Size(88, 36);
            this.lblOrderTotalValue.TabIndex = 15;
            this.lblOrderTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.White;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(166, 387);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(94, 36);
            this.lblOrderTotal.TabIndex = 14;
            this.lblOrderTotal.Text = "Order Total";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemoveFromOrder
            // 
            this.lblRemoveFromOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.lblRemoveFromOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemoveFromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveFromOrder.Location = new System.Drawing.Point(361, 376);
            this.lblRemoveFromOrder.Name = "lblRemoveFromOrder";
            this.lblRemoveFromOrder.Size = new System.Drawing.Size(91, 47);
            this.lblRemoveFromOrder.TabIndex = 13;
            this.lblRemoveFromOrder.Tag = "S1";
            this.lblRemoveFromOrder.Text = "Remove From Order";
            this.lblRemoveFromOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemoveFromOrder.Click += new System.EventHandler(this.lblRemoveFromOrder_Click);
            // 
            // lblCompleteOrder
            // 
            this.lblCompleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.lblCompleteOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteOrder.Location = new System.Drawing.Point(458, 376);
            this.lblCompleteOrder.Name = "lblCompleteOrder";
            this.lblCompleteOrder.Size = new System.Drawing.Size(91, 47);
            this.lblCompleteOrder.TabIndex = 12;
            this.lblCompleteOrder.Tag = "S1";
            this.lblCompleteOrder.Text = "Complete Order";
            this.lblCompleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCompleteOrder.Click += new System.EventHandler(this.lblCompleteOrder_Click);
            // 
            // lblCancelOrder
            // 
            this.lblCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.lblCancelOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrder.Location = new System.Drawing.Point(458, 326);
            this.lblCancelOrder.Name = "lblCancelOrder";
            this.lblCancelOrder.Size = new System.Drawing.Size(91, 39);
            this.lblCancelOrder.TabIndex = 11;
            this.lblCancelOrder.Tag = "S1";
            this.lblCancelOrder.Text = "Cancel Order";
            this.lblCancelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancelOrder.Click += new System.EventHandler(this.lblCancelOrder_Click);
            // 
            // lblAddToOrder
            // 
            this.lblAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.lblAddToOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddToOrder.Enabled = false;
            this.lblAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToOrder.Location = new System.Drawing.Point(458, 276);
            this.lblAddToOrder.Name = "lblAddToOrder";
            this.lblAddToOrder.Size = new System.Drawing.Size(91, 43);
            this.lblAddToOrder.TabIndex = 10;
            this.lblAddToOrder.Tag = "S1";
            this.lblAddToOrder.Text = "Add To Order";
            this.lblAddToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddToOrder.Click += new System.EventHandler(this.lblAddToOrder_Click);
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarReg,
            this.Make,
            this.Model,
            this.Cost});
            this.lvwOrderDetails.HideSelection = false;
            this.lvwOrderDetails.Location = new System.Drawing.Point(13, 257);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(331, 127);
            this.lvwOrderDetails.TabIndex = 8;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // CarReg
            // 
            this.CarReg.Text = "Car Reg";
            this.CarReg.Width = 80;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 90;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 90;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 90;
            // 
            // dgvSupplierStock
            // 
            this.dgvSupplierStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSupplierStock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSupplierStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierStock.Enabled = false;
            this.dgvSupplierStock.Location = new System.Drawing.Point(13, 64);
            this.dgvSupplierStock.Name = "dgvSupplierStock";
            this.dgvSupplierStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierStock.Size = new System.Drawing.Size(536, 187);
            this.dgvSupplierStock.TabIndex = 7;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Enabled = false;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(201, 37);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(142, 21);
            this.cmbSupplier.TabIndex = 0;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // frmOrderStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 557);
            this.Controls.Add(this.pnlOrderStock);
            this.Name = "frmOrderStock";
            this.Text = "Order Stock";
            this.Load += new System.EventHandler(this.frmOrderStock_Load);
            this.pnlOrderStock.ResumeLayout(false);
            this.pnlOrderStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderStock;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ListView lvwOrderDetails;
        private System.Windows.Forms.DataGridView dgvSupplierStock;
        private System.Windows.Forms.Label lblAddToOrder;
        private System.Windows.Forms.Label lblRemoveFromOrder;
        private System.Windows.Forms.Label lblCompleteOrder;
        private System.Windows.Forms.Label lblCancelOrder;
        private System.Windows.Forms.ColumnHeader CarReg;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label lblOrderTotalValue;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderD;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStaffID;
    }
}