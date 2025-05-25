namespace RoadTripRentals.Forms.Jordan
{
    partial class frmAddRentalCost
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
            this.txtRentalCost = new System.Windows.Forms.NumericUpDown();
            this.txtRentalCostID = new System.Windows.Forms.Label();
            this.lblRentalCostID = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.txtRentalCost);
            this.panelSub.Controls.Add(this.txtRentalCostID);
            this.panelSub.Controls.Add(this.lblRentalCostID);
            this.panelSub.Controls.Add(this.btnAddCancel);
            this.panelSub.Controls.Add(this.lblRentalCost);
            this.panelSub.Controls.Add(this.btnAddAdd);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(446, 257);
            this.panelSub.TabIndex = 67;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRentalCost.DecimalPlaces = 2;
            this.txtRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRentalCost.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.txtRentalCost.Location = new System.Drawing.Point(226, 108);
            this.txtRentalCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtRentalCost.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.ReadOnly = true;
            this.txtRentalCost.Size = new System.Drawing.Size(178, 26);
            this.txtRentalCost.TabIndex = 56;
            this.txtRentalCost.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtRentalCostID
            // 
            this.txtRentalCostID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRentalCostID.AutoSize = true;
            this.txtRentalCostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalCostID.ForeColor = System.Drawing.Color.Black;
            this.txtRentalCostID.Location = new System.Drawing.Point(222, 60);
            this.txtRentalCostID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtRentalCostID.Name = "txtRentalCostID";
            this.txtRentalCostID.Size = new System.Drawing.Size(15, 20);
            this.txtRentalCostID.TabIndex = 54;
            this.txtRentalCostID.Text = "-";
            // 
            // lblRentalCostID
            // 
            this.lblRentalCostID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRentalCostID.AutoSize = true;
            this.lblRentalCostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCostID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblRentalCostID.Location = new System.Drawing.Point(36, 60);
            this.lblRentalCostID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRentalCostID.Name = "lblRentalCostID";
            this.lblRentalCostID.Size = new System.Drawing.Size(128, 20);
            this.lblRentalCostID.TabIndex = 54;
            this.lblRentalCostID.Text = "Rental Cost ID";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.AllowDrop = true;
            this.btnAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCancel.BackColor = System.Drawing.Color.Silver;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(226, 161);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(178, 45);
            this.btnAddCancel.TabIndex = 52;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblRentalCost.Location = new System.Drawing.Point(36, 114);
            this.lblRentalCost.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(131, 20);
            this.lblRentalCost.TabIndex = 54;
            this.lblRentalCost.Text = "Rental Cost (£)";
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.AllowDrop = true;
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAdd.Location = new System.Drawing.Point(40, 161);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(178, 45);
            this.btnAddAdd.TabIndex = 51;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmAddRentalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 257);
            this.Controls.Add(this.panelSub);
            this.Name = "frmAddRentalCost";
            this.Text = "New Rental Cost";
            this.Load += new System.EventHandler(this.frmAddRentalCost_Load);
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Label lblRentalCostID;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label txtRentalCostID;
        private System.Windows.Forms.NumericUpDown txtRentalCost;
    }
}