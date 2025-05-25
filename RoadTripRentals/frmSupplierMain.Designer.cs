namespace RoadTripRentals
{
    partial class frmSupplierMain
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
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.pnlSideButtons = new System.Windows.Forms.Panel();
            this.lblDisplaySupplierDet = new System.Windows.Forms.Label();
            this.lblSupplierQuit = new System.Windows.Forms.Label();
            this.lblSupplierEdit = new System.Windows.Forms.Label();
            this.lblSupplierDelete = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSupplier.SuspendLayout();
            this.pnlSideButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSupplier.Controls.Add(this.pnlSideButtons);
            this.pnlSupplier.Controls.Add(this.pnlMain);
            this.pnlSupplier.Location = new System.Drawing.Point(12, 12);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(665, 497);
            this.pnlSupplier.TabIndex = 0;
            // 
            // pnlSideButtons
            // 
            this.pnlSideButtons.Controls.Add(this.lblDisplaySupplierDet);
            this.pnlSideButtons.Controls.Add(this.lblSupplierQuit);
            this.pnlSideButtons.Controls.Add(this.lblSupplierEdit);
            this.pnlSideButtons.Controls.Add(this.lblSupplierDelete);
            this.pnlSideButtons.Location = new System.Drawing.Point(13, 64);
            this.pnlSideButtons.Name = "pnlSideButtons";
            this.pnlSideButtons.Size = new System.Drawing.Size(127, 240);
            this.pnlSideButtons.TabIndex = 12;
            // 
            // lblDisplaySupplierDet
            // 
            this.lblDisplaySupplierDet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplaySupplierDet.BackColor = System.Drawing.Color.Black;
            this.lblDisplaySupplierDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySupplierDet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplaySupplierDet.Location = new System.Drawing.Point(2, 0);
            this.lblDisplaySupplierDet.Name = "lblDisplaySupplierDet";
            this.lblDisplaySupplierDet.Size = new System.Drawing.Size(120, 52);
            this.lblDisplaySupplierDet.TabIndex = 1;
            this.lblDisplaySupplierDet.Tag = "S1";
            this.lblDisplaySupplierDet.Text = "Supplier \r\nDetails ";
            this.lblDisplaySupplierDet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplaySupplierDet.Click += new System.EventHandler(this.lblDisplaySupplierDet_Click);
            // 
            // lblSupplierQuit
            // 
            this.lblSupplierQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplierQuit.BackColor = System.Drawing.Color.Black;
            this.lblSupplierQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierQuit.Location = new System.Drawing.Point(2, 181);
            this.lblSupplierQuit.Name = "lblSupplierQuit";
            this.lblSupplierQuit.Size = new System.Drawing.Size(120, 48);
            this.lblSupplierQuit.TabIndex = 5;
            this.lblSupplierQuit.Tag = "S5";
            this.lblSupplierQuit.Text = "Quit";
            this.lblSupplierQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupplierQuit.Click += new System.EventHandler(this.lblDisplaySupplierDet_Click);
            // 
            // lblSupplierEdit
            // 
            this.lblSupplierEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplierEdit.BackColor = System.Drawing.Color.Black;
            this.lblSupplierEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierEdit.Location = new System.Drawing.Point(1, 63);
            this.lblSupplierEdit.Name = "lblSupplierEdit";
            this.lblSupplierEdit.Size = new System.Drawing.Size(120, 47);
            this.lblSupplierEdit.TabIndex = 3;
            this.lblSupplierEdit.Tag = "S3";
            this.lblSupplierEdit.Text = "Edit";
            this.lblSupplierEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupplierEdit.Click += new System.EventHandler(this.lblSupplierEdit_Click);
            // 
            // lblSupplierDelete
            // 
            this.lblSupplierDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplierDelete.BackColor = System.Drawing.Color.Black;
            this.lblSupplierDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplierDelete.Location = new System.Drawing.Point(1, 124);
            this.lblSupplierDelete.Name = "lblSupplierDelete";
            this.lblSupplierDelete.Size = new System.Drawing.Size(120, 47);
            this.lblSupplierDelete.TabIndex = 4;
            this.lblSupplierDelete.Tag = "S4";
            this.lblSupplierDelete.Text = "Delete";
            this.lblSupplierDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupplierDelete.Click += new System.EventHandler(this.lblDisplaySupplierDet_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.AutoSize = true;
            this.pnlMain.Location = new System.Drawing.Point(146, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(499, 441);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlMain_ControlRemoved);
            // 
            // frmSupplierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 556);
            this.Controls.Add(this.pnlSupplier);
            this.Name = "frmSupplierMain";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSupplierMain_Load);
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.pnlSideButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSupplierQuit;
        private System.Windows.Forms.Label lblSupplierDelete;
        private System.Windows.Forms.Label lblSupplierEdit;
        private System.Windows.Forms.Label lblDisplaySupplierDet;
        private System.Windows.Forms.Panel pnlSideButtons;
    }
}




















































































































































































































































































































































































































































































































































































































































































































































































































































































