namespace RoadTripRentals.Forms.Jordan
{
    partial class frmEditModel
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
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModelID = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModelDesc = new System.Windows.Forms.Label();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.txtMake);
            this.panelSub.Controls.Add(this.txtDesc);
            this.panelSub.Controls.Add(this.txtModel);
            this.panelSub.Controls.Add(this.lblModelID);
            this.panelSub.Controls.Add(this.btnAddCancel);
            this.panelSub.Controls.Add(this.lblMake);
            this.panelSub.Controls.Add(this.lblModelDesc);
            this.panelSub.Controls.Add(this.btnEditAdd);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(476, 302);
            this.panelSub.TabIndex = 67;
            // 
            // txtMake
            // 
            this.txtMake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMake.Location = new System.Drawing.Point(241, 160);
            this.txtMake.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtMake.Multiline = true;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(178, 30);
            this.txtMake.TabIndex = 55;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDesc.Location = new System.Drawing.Point(241, 104);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(178, 30);
            this.txtDesc.TabIndex = 55;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtModel.Location = new System.Drawing.Point(241, 50);
            this.txtModel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(178, 30);
            this.txtModel.TabIndex = 55;
            // 
            // lblModelID
            // 
            this.lblModelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModelID.AutoSize = true;
            this.lblModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblModelID.Location = new System.Drawing.Point(51, 60);
            this.lblModelID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblModelID.Name = "lblModelID";
            this.lblModelID.Size = new System.Drawing.Size(57, 20);
            this.lblModelID.TabIndex = 54;
            this.lblModelID.Text = "Model";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.AllowDrop = true;
            this.btnAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCancel.BackColor = System.Drawing.Color.Silver;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(241, 228);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(178, 45);
            this.btnAddCancel.TabIndex = 52;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblMake
            // 
            this.lblMake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblMake.Location = new System.Drawing.Point(51, 170);
            this.lblMake.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(52, 20);
            this.lblMake.TabIndex = 54;
            this.lblMake.Text = "Make";
            // 
            // lblModelDesc
            // 
            this.lblModelDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModelDesc.AutoSize = true;
            this.lblModelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblModelDesc.Location = new System.Drawing.Point(51, 114);
            this.lblModelDesc.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblModelDesc.Name = "lblModelDesc";
            this.lblModelDesc.Size = new System.Drawing.Size(100, 20);
            this.lblModelDesc.TabIndex = 54;
            this.lblModelDesc.Text = "Description";
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.AllowDrop = true;
            this.btnEditAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnEditAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditAdd.Location = new System.Drawing.Point(55, 228);
            this.btnEditAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(178, 45);
            this.btnEditAdd.TabIndex = 51;
            this.btnEditAdd.Text = "Update";
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmEditModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 302);
            this.Controls.Add(this.panelSub);
            this.Name = "frmEditModel";
            this.Text = "frmEditModel";
            this.Load += new System.EventHandler(this.frmEditModel_Load);
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModelID;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModelDesc;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.ErrorProvider errP;
    }
}