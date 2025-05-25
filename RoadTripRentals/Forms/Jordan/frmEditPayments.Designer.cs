namespace RoadTripRentals.Forms.Jordan
{
    partial class frmEditPayments
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
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.txtPaymentID = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.cmbPaymentType);
            this.panelSub.Controls.Add(this.txtPaymentID);
            this.panelSub.Controls.Add(this.lblPaymentID);
            this.panelSub.Controls.Add(this.btnAddCancel);
            this.panelSub.Controls.Add(this.lblPaymentType);
            this.panelSub.Controls.Add(this.btnAddAdd);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(444, 243);
            this.panelSub.TabIndex = 69;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Cheque",
            "Paypal"});
            this.cmbPaymentType.Location = new System.Drawing.Point(225, 105);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(178, 28);
            this.cmbPaymentType.TabIndex = 55;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPaymentID.AutoSize = true;
            this.txtPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentID.Location = new System.Drawing.Point(221, 59);
            this.txtPaymentID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(15, 20);
            this.txtPaymentID.TabIndex = 54;
            this.txtPaymentID.Text = "-";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblPaymentID.Location = new System.Drawing.Point(35, 59);
            this.lblPaymentID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(102, 20);
            this.lblPaymentID.TabIndex = 54;
            this.lblPaymentID.Text = "Payment ID";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.AllowDrop = true;
            this.btnAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCancel.BackColor = System.Drawing.Color.Silver;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(225, 174);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(178, 45);
            this.btnAddCancel.TabIndex = 52;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblPaymentType.Location = new System.Drawing.Point(35, 113);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(121, 20);
            this.lblPaymentType.TabIndex = 54;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.AllowDrop = true;
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAdd.Location = new System.Drawing.Point(39, 174);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(178, 45);
            this.btnAddAdd.TabIndex = 51;
            this.btnAddAdd.Text = "Update";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmEditPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 243);
            this.Controls.Add(this.panelSub);
            this.Name = "frmEditPayments";
            this.Text = "Update Payment";
            this.Load += new System.EventHandler(this.frmEditPayments_Load);
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label txtPaymentID;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.ErrorProvider errP;
    }
}