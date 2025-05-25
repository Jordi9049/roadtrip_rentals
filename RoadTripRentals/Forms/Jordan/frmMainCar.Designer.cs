namespace RoadTripRentals.Forms.Jordan
{
    partial class frmMainCar
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
            this.btnDelCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelCar);
            this.panelSub.Controls.Add(this.btnEditCar);
            this.panelSub.Controls.Add(this.dgvCars);
            this.panelSub.Controls.Add(this.btnAddCar);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 34;
            // 
            // btnDelCar
            // 
            this.btnDelCar.AllowDrop = true;
            this.btnDelCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelCar.Location = new System.Drawing.Point(10, 443);
            this.btnDelCar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelCar.Name = "btnDelCar";
            this.btnDelCar.Size = new System.Drawing.Size(133, 64);
            this.btnDelCar.TabIndex = 31;
            this.btnDelCar.Text = "Delete";
            this.btnDelCar.UseVisualStyleBackColor = false;
            this.btnDelCar.Click += new System.EventHandler(this.btnDelCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.AllowDrop = true;
            this.btnEditCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCar.Location = new System.Drawing.Point(10, 85);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(133, 70);
            this.btnEditCar.TabIndex = 32;
            this.btnEditCar.Text = "Edit";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AllowUserToOrderColumns = true;
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCars.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCars.Location = new System.Drawing.Point(155, 11);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCars.RowHeadersWidth = 82;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvCars.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(520, 496);
            this.dgvCars.TabIndex = 0;
            // 
            // btnAddCar
            // 
            this.btnAddCar.AllowDrop = true;
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCar.Location = new System.Drawing.Point(10, 11);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(133, 70);
            this.btnAddCar.TabIndex = 31;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // frmMainCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.MinimumSize = new System.Drawing.Size(714, 557);
            this.Name = "frmMainCar";
            this.Text = "Car details";
            this.Load += new System.EventHandler(this.frmMainCar_Load);
            this.panelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Button btnDelCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Button btnAddCar;
    }
}