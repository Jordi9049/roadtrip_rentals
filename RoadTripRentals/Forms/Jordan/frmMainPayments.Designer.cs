namespace RoadTripRentals.Forms.Jordan
{
    partial class frmMainPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSub = new System.Windows.Forms.Panel();
            this.btnDelPayments = new System.Windows.Forms.Button();
            this.btnEditPayments = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnAddPayments = new System.Windows.Forms.Button();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelPayments);
            this.panelSub.Controls.Add(this.btnAddPayments);
            this.panelSub.Controls.Add(this.btnEditPayments);
            this.panelSub.Controls.Add(this.dgvPayments);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 36;
            // 
            // btnDelPayments
            // 
            this.btnDelPayments.AllowDrop = true;
            this.btnDelPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelPayments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelPayments.Location = new System.Drawing.Point(10, 443);
            this.btnDelPayments.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelPayments.Name = "btnDelPayments";
            this.btnDelPayments.Size = new System.Drawing.Size(133, 64);
            this.btnDelPayments.TabIndex = 31;
            this.btnDelPayments.Text = "Delete";
            this.btnDelPayments.UseVisualStyleBackColor = false;
            this.btnDelPayments.Click += new System.EventHandler(this.btnDelPayments_Click);
            // 
            // btnEditPayments
            // 
            this.btnEditPayments.AllowDrop = true;
            this.btnEditPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditPayments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditPayments.Location = new System.Drawing.Point(10, 91);
            this.btnEditPayments.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditPayments.Name = "btnEditPayments";
            this.btnEditPayments.Size = new System.Drawing.Size(133, 70);
            this.btnEditPayments.TabIndex = 32;
            this.btnEditPayments.Text = "Edit";
            this.btnEditPayments.UseVisualStyleBackColor = false;
            this.btnEditPayments.Click += new System.EventHandler(this.btnEditPayments_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToOrderColumns = true;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayments.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayments.Location = new System.Drawing.Point(155, 11);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPayments.RowHeadersWidth = 82;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(520, 496);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnAddPayments
            // 
            this.btnAddPayments.AllowDrop = true;
            this.btnAddPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPayments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPayments.Location = new System.Drawing.Point(10, 17);
            this.btnAddPayments.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddPayments.Name = "btnAddPayments";
            this.btnAddPayments.Size = new System.Drawing.Size(133, 70);
            this.btnAddPayments.TabIndex = 32;
            this.btnAddPayments.Text = "Add";
            this.btnAddPayments.UseVisualStyleBackColor = false;
            this.btnAddPayments.Click += new System.EventHandler(this.btnAddPayments_Click);
            // 
            // frmMainPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.Name = "frmMainPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmMainPayments_Load);
            this.panelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Button btnDelPayments;
        private System.Windows.Forms.Button btnEditPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnAddPayments;
    }
}