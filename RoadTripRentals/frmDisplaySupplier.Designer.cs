namespace RoadTripRentals
{
    partial class frmDisplaySupplier
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
            this.pnlDisplaySupplier = new System.Windows.Forms.Panel();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.pnlDisplaySupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDisplaySupplier
            // 
            this.pnlDisplaySupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlDisplaySupplier.Controls.Add(this.dgvSupplier);
            this.pnlDisplaySupplier.Location = new System.Drawing.Point(1, 3);
            this.pnlDisplaySupplier.Name = "pnlDisplaySupplier";
            this.pnlDisplaySupplier.Size = new System.Drawing.Size(438, 364);
            this.pnlDisplaySupplier.TabIndex = 13;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(3, 0);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(432, 361);
            this.dgvSupplier.TabIndex = 6;
            this.dgvSupplier.Click += new System.EventHandler(this.dgvSupplier_Click);
            // 
            // frmDisplaySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 404);
            this.Controls.Add(this.pnlDisplaySupplier);
            this.Name = "frmDisplaySupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisplaySupplier_FormClosing);
            this.Load += new System.EventHandler(this.frmDisplaySupplier_Load);
            this.pnlDisplaySupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplaySupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
    }
}