namespace RoadTripRentals
{
    partial class frmMainCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDelCustomer = new System.Windows.Forms.Button();
            this.panelSub = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Location = new System.Drawing.Point(155, 11);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.RowHeadersWidth = 82;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(520, 496);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.AllowDrop = true;
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCustomer.Location = new System.Drawing.Point(10, 85);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(133, 70);
            this.btnEditCustomer.TabIndex = 32;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AllowDrop = true;
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCustomer.Location = new System.Drawing.Point(10, 11);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(133, 70);
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.AllowDrop = true;
            this.btnDelCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelCustomer.Location = new System.Drawing.Point(10, 443);
            this.btnDelCustomer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(133, 64);
            this.btnDelCustomer.TabIndex = 31;
            this.btnDelCustomer.Text = "Delete";
            this.btnDelCustomer.UseVisualStyleBackColor = false;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelCustomer);
            this.panelSub.Controls.Add(this.btnEditCustomer);
            this.panelSub.Controls.Add(this.dgvCustomers);
            this.panelSub.Controls.Add(this.btnAddCustomer);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 33;
            // 
            // frmMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(714, 557);
            this.Name = "frmMainCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmMainCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panelSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDelCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panelSub;
    }
}