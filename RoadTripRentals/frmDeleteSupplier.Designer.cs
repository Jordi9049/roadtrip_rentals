namespace RoadTripRentals
{
    partial class frmDeleteSupplier
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
            this.pnlDeleteSupplier = new System.Windows.Forms.Panel();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.pnlDeleteSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeleteSupplier
            // 
            this.pnlDeleteSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlDeleteSupplier.Controls.Add(this.btnDeleteSupplier);
            this.pnlDeleteSupplier.Controls.Add(this.dgvSupplier);
            this.pnlDeleteSupplier.Location = new System.Drawing.Point(3, 3);
            this.pnlDeleteSupplier.Name = "pnlDeleteSupplier";
            this.pnlDeleteSupplier.Size = new System.Drawing.Size(469, 389);
            this.pnlDeleteSupplier.TabIndex = 13;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.AllowDrop = true;
            this.btnDeleteSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSupplier.Location = new System.Drawing.Point(144, 328);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(178, 45);
            this.btnDeleteSupplier.TabIndex = 52;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(3, 3);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(463, 311);
            this.dgvSupplier.TabIndex = 6;
            // 
            // frmDeleteSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 404);
            this.Controls.Add(this.pnlDeleteSupplier);
            this.Name = "frmDeleteSupplier";
            this.Text = "Delete Supplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeleteSupplier_FormClosing);
            this.Load += new System.EventHandler(this.frmDeleteSupplier_Load);
            this.pnlDeleteSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
    }
}