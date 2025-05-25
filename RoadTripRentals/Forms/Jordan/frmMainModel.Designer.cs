namespace RoadTripRentals.Forms.Jordan
{
    partial class frmMainModel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSub = new System.Windows.Forms.Panel();
            this.btnDelModel = new System.Windows.Forms.Button();
            this.btnEditModel = new System.Windows.Forms.Button();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.btnDelModel);
            this.panelSub.Controls.Add(this.btnEditModel);
            this.panelSub.Controls.Add(this.dgvModels);
            this.panelSub.Controls.Add(this.btnAddModel);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 35;
            // 
            // btnDelModel
            // 
            this.btnDelModel.AllowDrop = true;
            this.btnDelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDelModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelModel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelModel.Location = new System.Drawing.Point(10, 443);
            this.btnDelModel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelModel.Name = "btnDelModel";
            this.btnDelModel.Size = new System.Drawing.Size(133, 64);
            this.btnDelModel.TabIndex = 31;
            this.btnDelModel.Text = "Delete";
            this.btnDelModel.UseVisualStyleBackColor = false;
            this.btnDelModel.Click += new System.EventHandler(this.btnDelModel_Click);
            // 
            // btnEditModel
            // 
            this.btnEditModel.AllowDrop = true;
            this.btnEditModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditModel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditModel.Location = new System.Drawing.Point(10, 85);
            this.btnEditModel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditModel.Name = "btnEditModel";
            this.btnEditModel.Size = new System.Drawing.Size(133, 70);
            this.btnEditModel.TabIndex = 32;
            this.btnEditModel.Text = "Edit";
            this.btnEditModel.UseVisualStyleBackColor = false;
            this.btnEditModel.Click += new System.EventHandler(this.btnEditModel_Click);
            // 
            // dgvModels
            // 
            this.dgvModels.AllowUserToAddRows = false;
            this.dgvModels.AllowUserToDeleteRows = false;
            this.dgvModels.AllowUserToOrderColumns = true;
            this.dgvModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModels.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvModels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvModels.ColumnHeadersHeight = 25;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModels.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvModels.Location = new System.Drawing.Point(155, 11);
            this.dgvModels.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModels.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvModels.RowHeadersWidth = 82;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(126)))));
            this.dgvModels.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModels.Size = new System.Drawing.Size(520, 496);
            this.dgvModels.TabIndex = 0;
            // 
            // btnAddModel
            // 
            this.btnAddModel.AllowDrop = true;
            this.btnAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddModel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddModel.Location = new System.Drawing.Point(10, 11);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(133, 70);
            this.btnAddModel.TabIndex = 31;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // frmMainModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.Name = "frmMainModel";
            this.Text = "Models";
            this.Load += new System.EventHandler(this.frmMainModel_Load);
            this.panelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Button btnDelModel;
        private System.Windows.Forms.Button btnEditModel;
        private System.Windows.Forms.DataGridView dgvModels;
        private System.Windows.Forms.Button btnAddModel;
    }
}