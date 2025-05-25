namespace RoadTripRentals
{
    partial class frmOrderHistory
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
            this.pnlOrderHistory = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnOrderDelivered = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.pnlOrderHistoryDet = new System.Windows.Forms.Panel();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.lblOrderNoValue = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOrderTotalValue = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSupplierValue = new System.Windows.Forms.Label();
            this.lblStaffNameValue = new System.Windows.Forms.Label();
            this.lblOrderDateValue = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.CarReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOrderHistory.SuspendLayout();
            this.pnlOrderHistoryDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderHistory
            // 
            this.pnlOrderHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlOrderHistory.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOrderHistory.Controls.Add(this.btnDeleteOrder);
            this.pnlOrderHistory.Controls.Add(this.btnOrderDelivered);
            this.pnlOrderHistory.Controls.Add(this.btnOrderDetails);
            this.pnlOrderHistory.Controls.Add(this.pnlOrderHistoryDet);
            this.pnlOrderHistory.Location = new System.Drawing.Point(1, 2);
            this.pnlOrderHistory.Name = "pnlOrderHistory";
            this.pnlOrderHistory.Size = new System.Drawing.Size(484, 414);
            this.pnlOrderHistory.TabIndex = 13;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.AllowDrop = true;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteOrder.Location = new System.Drawing.Point(200, 358);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(108, 51);
            this.btnDeleteOrder.TabIndex = 35;
            this.btnDeleteOrder.Tag = "S1";
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnOrderDelivered
            // 
            this.btnOrderDelivered.AllowDrop = true;
            this.btnOrderDelivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnOrderDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderDelivered.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderDelivered.Location = new System.Drawing.Point(360, 358);
            this.btnOrderDelivered.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOrderDelivered.Name = "btnOrderDelivered";
            this.btnOrderDelivered.Size = new System.Drawing.Size(108, 51);
            this.btnOrderDelivered.TabIndex = 34;
            this.btnOrderDelivered.Tag = "S1";
            this.btnOrderDelivered.Text = "Order Delivered";
            this.btnOrderDelivered.UseVisualStyleBackColor = false;
            this.btnOrderDelivered.Click += new System.EventHandler(this.btnOrderDelivered_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.AllowDrop = true;
            this.btnOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderDetails.Location = new System.Drawing.Point(34, 358);
            this.btnOrderDetails.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(108, 51);
            this.btnOrderDetails.TabIndex = 33;
            this.btnOrderDetails.Tag = "S1";
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // pnlOrderHistoryDet
            // 
            this.pnlOrderHistoryDet.Controls.Add(this.dgvOrderHistory);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderNoValue);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderNo);
            this.pnlOrderHistoryDet.Controls.Add(this.btnClose);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderTotalValue);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderTotal);
            this.pnlOrderHistoryDet.Controls.Add(this.lblSupplierValue);
            this.pnlOrderHistoryDet.Controls.Add(this.lblStaffNameValue);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderDateValue);
            this.pnlOrderHistoryDet.Controls.Add(this.lblOrderDate);
            this.pnlOrderHistoryDet.Controls.Add(this.lblSupplier);
            this.pnlOrderHistoryDet.Controls.Add(this.lblStaffName);
            this.pnlOrderHistoryDet.Controls.Add(this.lvwOrderDetails);
            this.pnlOrderHistoryDet.Location = new System.Drawing.Point(3, 5);
            this.pnlOrderHistoryDet.Name = "pnlOrderHistoryDet";
            this.pnlOrderHistoryDet.Size = new System.Drawing.Size(468, 350);
            this.pnlOrderHistoryDet.TabIndex = 10;
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.ReadOnly = true;
            this.dgvOrderHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderHistory.Size = new System.Drawing.Size(462, 334);
            this.dgvOrderHistory.TabIndex = 6;
            // 
            // lblOrderNoValue
            // 
            this.lblOrderNoValue.AutoSize = true;
            this.lblOrderNoValue.Location = new System.Drawing.Point(123, 14);
            this.lblOrderNoValue.Name = "lblOrderNoValue";
            this.lblOrderNoValue.Size = new System.Drawing.Size(0, 13);
            this.lblOrderNoValue.TabIndex = 47;
            this.lblOrderNoValue.Visible = false;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.Location = new System.Drawing.Point(17, 14);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(74, 16);
            this.lblOrderNo.TabIndex = 46;
            this.lblOrderNo.Text = "Order No:";
            this.lblOrderNo.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(358, 284);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 33);
            this.btnClose.TabIndex = 45;
            this.btnClose.Tag = "S1";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrderTotalValue
            // 
            this.lblOrderTotalValue.BackColor = System.Drawing.Color.White;
            this.lblOrderTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalValue.Location = new System.Drawing.Point(337, 226);
            this.lblOrderTotalValue.Name = "lblOrderTotalValue";
            this.lblOrderTotalValue.Size = new System.Drawing.Size(88, 36);
            this.lblOrderTotalValue.TabIndex = 44;
            this.lblOrderTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderTotalValue.Visible = false;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.White;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(247, 226);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(94, 36);
            this.lblOrderTotal.TabIndex = 43;
            this.lblOrderTotal.Text = "Order Total:";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderTotal.Visible = false;
            // 
            // lblSupplierValue
            // 
            this.lblSupplierValue.AutoSize = true;
            this.lblSupplierValue.Location = new System.Drawing.Point(123, 65);
            this.lblSupplierValue.Name = "lblSupplierValue";
            this.lblSupplierValue.Size = new System.Drawing.Size(0, 13);
            this.lblSupplierValue.TabIndex = 42;
            this.lblSupplierValue.Visible = false;
            // 
            // lblStaffNameValue
            // 
            this.lblStaffNameValue.AutoSize = true;
            this.lblStaffNameValue.Location = new System.Drawing.Point(123, 41);
            this.lblStaffNameValue.Name = "lblStaffNameValue";
            this.lblStaffNameValue.Size = new System.Drawing.Size(0, 13);
            this.lblStaffNameValue.TabIndex = 41;
            this.lblStaffNameValue.Visible = false;
            // 
            // lblOrderDateValue
            // 
            this.lblOrderDateValue.AutoSize = true;
            this.lblOrderDateValue.Location = new System.Drawing.Point(311, 17);
            this.lblOrderDateValue.Name = "lblOrderDateValue";
            this.lblOrderDateValue.Size = new System.Drawing.Size(0, 13);
            this.lblOrderDateValue.TabIndex = 40;
            this.lblOrderDateValue.Visible = false;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(218, 14);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(87, 16);
            this.lblOrderDate.TabIndex = 39;
            this.lblOrderDate.Text = "Order Date:";
            this.lblOrderDate.Visible = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(17, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(93, 16);
            this.lblSupplier.TabIndex = 38;
            this.lblSupplier.Text = "Supplier No:";
            this.lblSupplier.Visible = false;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(17, 41);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(61, 16);
            this.lblStaffName.TabIndex = 37;
            this.lblStaffName.Text = "Staff ID:";
            this.lblStaffName.Visible = false;
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarReg,
            this.Make,
            this.Model,
            this.Cost});
            this.lvwOrderDetails.HideSelection = false;
            this.lvwOrderDetails.Location = new System.Drawing.Point(20, 96);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(406, 127);
            this.lvwOrderDetails.TabIndex = 36;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwOrderDetails.View = System.Windows.Forms.View.Details;
            this.lvwOrderDetails.Visible = false;
            // 
            // CarReg
            // 
            this.CarReg.Text = "Car Reg";
            this.CarReg.Width = 100;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 100;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 100;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 100;
            // 
            // frmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 437);
            this.Controls.Add(this.pnlOrderHistory);
            this.Name = "frmOrderHistory";
            this.Text = "frmOrderHistory";
            this.Load += new System.EventHandler(this.frmOrderHistory_Load);
            this.pnlOrderHistory.ResumeLayout(false);
            this.pnlOrderHistoryDet.ResumeLayout(false);
            this.pnlOrderHistoryDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderHistory;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrderDelivered;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Panel pnlOrderHistoryDet;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrderTotalValue;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblSupplierValue;
        private System.Windows.Forms.Label lblStaffNameValue;
        private System.Windows.Forms.Label lblOrderDateValue;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.ListView lvwOrderDetails;
        private System.Windows.Forms.ColumnHeader CarReg;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label lblOrderNoValue;
        private System.Windows.Forms.Label lblOrderNo;
    }
}