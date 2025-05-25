namespace RoadTripRentals.Forms.Jordan
{
    partial class frmMainRentalCost
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
            this.btnDelRentalCost = new System.Windows.Forms.Button();
            this.btnEditRentalCost = new System.Windows.Forms.Button();
            this.dgvRentalCosts = new System.Windows.Forms.DataGridView();
            this.btnAddRentalCost = new System.Windows.Forms.Button();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelRentalCost);
            this.panelSub.Controls.Add(this.btnEditRentalCost);
            this.panelSub.Controls.Add(this.dgvRentalCosts);
            this.panelSub.Controls.Add(this.btnAddRentalCost);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 36;
            // 
            // btnDelRentalCost
            // 
            this.btnDelRentalCost.AllowDrop = true;
            this.btnDelRentalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelRentalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelRentalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelRentalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelRentalCost.Location = new System.Drawing.Point(10, 443);
            this.btnDelRentalCost.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelRentalCost.Name = "btnDelRentalCost";
            this.btnDelRentalCost.Size = new System.Drawing.Size(133, 64);
            this.btnDelRentalCost.TabIndex = 31;
            this.btnDelRentalCost.Text = "Delete";
            this.btnDelRentalCost.UseVisualStyleBackColor = false;
            this.btnDelRentalCost.Click += new System.EventHandler(this.btnDelRentalCost_Click);
            // 
            // btnEditRentalCost
            // 
            this.btnEditRentalCost.AllowDrop = true;
            this.btnEditRentalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditRentalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditRentalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditRentalCost.Location = new System.Drawing.Point(10, 85);
            this.btnEditRentalCost.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditRentalCost.Name = "btnEditRentalCost";
            this.btnEditRentalCost.Size = new System.Drawing.Size(133, 70);
            this.btnEditRentalCost.TabIndex = 32;
            this.btnEditRentalCost.Text = "Edit";
            this.btnEditRentalCost.UseVisualStyleBackColor = false;
            this.btnEditRentalCost.Click += new System.EventHandler(this.btnEditRentalCost_Click);
            // 
            // dgvRentalCosts
            // 
            this.dgvRentalCosts.AllowUserToAddRows = false;
            this.dgvRentalCosts.AllowUserToDeleteRows = false;
            this.dgvRentalCosts.AllowUserToOrderColumns = true;
            this.dgvRentalCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentalCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentalCosts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvRentalCosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalCosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentalCosts.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalCosts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRentalCosts.Location = new System.Drawing.Point(155, 11);
            this.dgvRentalCosts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRentalCosts.Name = "dgvRentalCosts";
            this.dgvRentalCosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalCosts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRentalCosts.RowHeadersWidth = 82;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvRentalCosts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRentalCosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalCosts.Size = new System.Drawing.Size(520, 496);
            this.dgvRentalCosts.TabIndex = 0;
            // 
            // btnAddRentalCost
            // 
            this.btnAddRentalCost.AllowDrop = true;
            this.btnAddRentalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddRentalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRentalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRentalCost.Location = new System.Drawing.Point(10, 11);
            this.btnAddRentalCost.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddRentalCost.Name = "btnAddRentalCost";
            this.btnAddRentalCost.Size = new System.Drawing.Size(133, 70);
            this.btnAddRentalCost.TabIndex = 31;
            this.btnAddRentalCost.Text = "Add";
            this.btnAddRentalCost.UseVisualStyleBackColor = false;
            this.btnAddRentalCost.Click += new System.EventHandler(this.btnAddRentalCost_Click);
            // 
            // frmMainRentalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.MinimumSize = new System.Drawing.Size(714, 557);
            this.Name = "frmMainRentalCost";
            this.Text = "Rental Cost";
            this.Load += new System.EventHandler(this.frmMainRentalCost_Load);
            this.panelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalCosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Button btnDelRentalCost;
        private System.Windows.Forms.Button btnEditRentalCost;
        private System.Windows.Forms.DataGridView dgvRentalCosts;
        private System.Windows.Forms.Button btnAddRentalCost;
    }
}