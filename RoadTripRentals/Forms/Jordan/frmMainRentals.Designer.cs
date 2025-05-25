namespace RoadTripRentals.Forms.Jordan
{
    partial class frmMainRentals
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
            this.btnDelRental = new System.Windows.Forms.Button();
            this.btnEditRental = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelRental);
            this.panelSub.Controls.Add(this.btnEditRental);
            this.panelSub.Controls.Add(this.dgvRentals);
            this.panelSub.Controls.Add(this.btnAddRental);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(755, 577);
            this.panelSub.TabIndex = 35;
            // 
            // btnDelRental
            // 
            this.btnDelRental.AllowDrop = true;
            this.btnDelRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelRental.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelRental.Location = new System.Drawing.Point(10, 502);
            this.btnDelRental.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelRental.Name = "btnDelRental";
            this.btnDelRental.Size = new System.Drawing.Size(133, 64);
            this.btnDelRental.TabIndex = 31;
            this.btnDelRental.Text = "Delete";
            this.btnDelRental.UseVisualStyleBackColor = false;
            this.btnDelRental.Click += new System.EventHandler(this.btnDelRental_Click);
            // 
            // btnEditRental
            // 
            this.btnEditRental.AllowDrop = true;
            this.btnEditRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditRental.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditRental.Location = new System.Drawing.Point(10, 85);
            this.btnEditRental.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditRental.Name = "btnEditRental";
            this.btnEditRental.Size = new System.Drawing.Size(133, 70);
            this.btnEditRental.TabIndex = 32;
            this.btnEditRental.Text = "Edit";
            this.btnEditRental.UseVisualStyleBackColor = false;
            this.btnEditRental.Click += new System.EventHandler(this.btnEditRental_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.AllowUserToOrderColumns = true;
            this.dgvRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentals.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentals.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRentals.Location = new System.Drawing.Point(155, 11);
            this.dgvRentals.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRentals.RowHeadersWidth = 82;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvRentals.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(577, 555);
            this.dgvRentals.TabIndex = 0;
            // 
            // btnAddRental
            // 
            this.btnAddRental.AllowDrop = true;
            this.btnAddRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRental.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRental.Location = new System.Drawing.Point(10, 11);
            this.btnAddRental.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(133, 70);
            this.btnAddRental.TabIndex = 31;
            this.btnAddRental.Text = "Add";
            this.btnAddRental.UseVisualStyleBackColor = false;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // frmMainRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 577);
            this.Controls.Add(this.panelSub);
            this.Name = "frmMainRentals";
            this.Text = "Rentals ";
            this.Load += new System.EventHandler(this.frmMainRentals_Load);
            this.panelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Button btnDelRental;
        private System.Windows.Forms.Button btnEditRental;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnAddRental;
    }
}