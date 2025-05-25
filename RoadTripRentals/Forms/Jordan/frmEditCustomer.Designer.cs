namespace RoadTripRentals.Forms.Jordan
{
    partial class frmEditCustomer
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
            this.lblEditCustNoValue = new System.Windows.Forms.Label();
            this.cmbEditTitle = new System.Windows.Forms.ComboBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditForename = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.txtEditTelNo = new System.Windows.Forms.TextBox();
            this.lblEditTelNo = new System.Windows.Forms.Label();
            this.LblEditPostcode = new System.Windows.Forms.Label();
            this.LblEditCounty = new System.Windows.Forms.Label();
            this.lblEditTown = new System.Windows.Forms.Label();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.lblEditStreet = new System.Windows.Forms.Label();
            this.lblEditForename = new System.Windows.Forms.Label();
            this.lblEditSurname = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditCustomerNo = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSub = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.panelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditCustNoValue
            // 
            this.lblEditCustNoValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditCustNoValue.AutoSize = true;
            this.lblEditCustNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustNoValue.Location = new System.Drawing.Point(196, 20);
            this.lblEditCustNoValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditCustNoValue.Name = "lblEditCustNoValue";
            this.lblEditCustNoValue.Size = new System.Drawing.Size(17, 24);
            this.lblEditCustNoValue.TabIndex = 72;
            this.lblEditCustNoValue.Text = "-";
            // 
            // cmbEditTitle
            // 
            this.cmbEditTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEditTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditTitle.FormattingEnabled = true;
            this.cmbEditTitle.ItemHeight = 13;
            this.cmbEditTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs"});
            this.cmbEditTitle.Location = new System.Drawing.Point(195, 63);
            this.cmbEditTitle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbEditTitle.Name = "cmbEditTitle";
            this.cmbEditTitle.Size = new System.Drawing.Size(54, 21);
            this.cmbEditTitle.TabIndex = 71;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditEmail.Location = new System.Drawing.Point(195, 368);
            this.txtEditEmail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditEmail.Multiline = true;
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(364, 30);
            this.txtEditEmail.TabIndex = 70;
            // 
            // txtEditStreet
            // 
            this.txtEditStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditStreet.Location = new System.Drawing.Point(195, 187);
            this.txtEditStreet.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditStreet.Multiline = true;
            this.txtEditStreet.Name = "txtEditStreet";
            this.txtEditStreet.Size = new System.Drawing.Size(364, 30);
            this.txtEditStreet.TabIndex = 69;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditSurname.Location = new System.Drawing.Point(195, 98);
            this.txtEditSurname.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditSurname.Multiline = true;
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(364, 30);
            this.txtEditSurname.TabIndex = 68;
            // 
            // txtEditForename
            // 
            this.txtEditForename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditForename.Location = new System.Drawing.Point(195, 141);
            this.txtEditForename.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditForename.Multiline = true;
            this.txtEditForename.Name = "txtEditForename";
            this.txtEditForename.Size = new System.Drawing.Size(364, 30);
            this.txtEditForename.TabIndex = 67;
            // 
            // txtEditTown
            // 
            this.txtEditTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditTown.Location = new System.Drawing.Point(195, 229);
            this.txtEditTown.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditTown.Multiline = true;
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(364, 30);
            this.txtEditTown.TabIndex = 66;
            // 
            // txtEditCounty
            // 
            this.txtEditCounty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditCounty.Location = new System.Drawing.Point(195, 277);
            this.txtEditCounty.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditCounty.Multiline = true;
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(218, 30);
            this.txtEditCounty.TabIndex = 65;
            // 
            // txtEditPostcode
            // 
            this.txtEditPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditPostcode.Location = new System.Drawing.Point(195, 322);
            this.txtEditPostcode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditPostcode.Multiline = true;
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(218, 30);
            this.txtEditPostcode.TabIndex = 64;
            // 
            // txtEditTelNo
            // 
            this.txtEditTelNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEditTelNo.Location = new System.Drawing.Point(195, 413);
            this.txtEditTelNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtEditTelNo.Multiline = true;
            this.txtEditTelNo.Name = "txtEditTelNo";
            this.txtEditTelNo.Size = new System.Drawing.Size(218, 30);
            this.txtEditTelNo.TabIndex = 63;
            // 
            // lblEditTelNo
            // 
            this.lblEditTelNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditTelNo.AutoSize = true;
            this.lblEditTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditTelNo.Location = new System.Drawing.Point(74, 423);
            this.lblEditTelNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditTelNo.Name = "lblEditTelNo";
            this.lblEditTelNo.Size = new System.Drawing.Size(60, 20);
            this.lblEditTelNo.TabIndex = 62;
            this.lblEditTelNo.Text = "Tel No";
            // 
            // LblEditPostcode
            // 
            this.LblEditPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEditPostcode.AutoSize = true;
            this.LblEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.LblEditPostcode.Location = new System.Drawing.Point(73, 332);
            this.LblEditPostcode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblEditPostcode.Name = "LblEditPostcode";
            this.LblEditPostcode.Size = new System.Drawing.Size(84, 20);
            this.LblEditPostcode.TabIndex = 61;
            this.LblEditPostcode.Text = "Postcode";
            // 
            // LblEditCounty
            // 
            this.LblEditCounty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEditCounty.AutoSize = true;
            this.LblEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.LblEditCounty.Location = new System.Drawing.Point(74, 287);
            this.LblEditCounty.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblEditCounty.Name = "LblEditCounty";
            this.LblEditCounty.Size = new System.Drawing.Size(65, 20);
            this.LblEditCounty.TabIndex = 60;
            this.LblEditCounty.Text = "County";
            // 
            // lblEditTown
            // 
            this.lblEditTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditTown.AutoSize = true;
            this.lblEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditTown.Location = new System.Drawing.Point(74, 239);
            this.lblEditTown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditTown.Name = "lblEditTown";
            this.lblEditTown.Size = new System.Drawing.Size(51, 20);
            this.lblEditTown.TabIndex = 59;
            this.lblEditTown.Text = "Town";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditEmail.Location = new System.Drawing.Point(74, 378);
            this.lblEditEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEditEmail.TabIndex = 57;
            this.lblEditEmail.Text = "Email";
            // 
            // lblEditStreet
            // 
            this.lblEditStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditStreet.AutoSize = true;
            this.lblEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditStreet.Location = new System.Drawing.Point(73, 197);
            this.lblEditStreet.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditStreet.Name = "lblEditStreet";
            this.lblEditStreet.Size = new System.Drawing.Size(110, 20);
            this.lblEditStreet.TabIndex = 56;
            this.lblEditStreet.Text = "Street Name";
            // 
            // lblEditForename
            // 
            this.lblEditForename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditForename.AutoSize = true;
            this.lblEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditForename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditForename.Location = new System.Drawing.Point(73, 151);
            this.lblEditForename.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditForename.Name = "lblEditForename";
            this.lblEditForename.Size = new System.Drawing.Size(90, 20);
            this.lblEditForename.TabIndex = 58;
            this.lblEditForename.Text = "Forename";
            // 
            // lblEditSurname
            // 
            this.lblEditSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditSurname.AutoSize = true;
            this.lblEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditSurname.Location = new System.Drawing.Point(74, 108);
            this.lblEditSurname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditSurname.Name = "lblEditSurname";
            this.lblEditSurname.Size = new System.Drawing.Size(81, 20);
            this.lblEditSurname.TabIndex = 55;
            this.lblEditSurname.Text = "Surname";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditTitle.Location = new System.Drawing.Point(74, 64);
            this.lblEditTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(43, 20);
            this.lblEditTitle.TabIndex = 54;
            this.lblEditTitle.Text = "Title";
            // 
            // lblEditCustomerNo
            // 
            this.lblEditCustomerNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditCustomerNo.AutoSize = true;
            this.lblEditCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomerNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblEditCustomerNo.Location = new System.Drawing.Point(74, 23);
            this.lblEditCustomerNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditCustomerNo.Name = "lblEditCustomerNo";
            this.lblEditCustomerNo.Size = new System.Drawing.Size(113, 20);
            this.lblEditCustomerNo.TabIndex = 53;
            this.lblEditCustomerNo.Text = "Customer No";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.AllowDrop = true;
            this.btnEditCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCancel.BackColor = System.Drawing.Color.Silver;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCancel.Location = new System.Drawing.Point(381, 460);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(178, 45);
            this.btnEditCancel.TabIndex = 52;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.AllowDrop = true;
            this.btnEditAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnEditAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditAdd.Location = new System.Drawing.Point(195, 460);
            this.btnEditAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(178, 45);
            this.btnEditAdd.TabIndex = 51;
            this.btnEditAdd.Text = "Save";
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.lblEditCustNoValue);
            this.panelSub.Controls.Add(this.lblEditCustomerNo);
            this.panelSub.Controls.Add(this.cmbEditTitle);
            this.panelSub.Controls.Add(this.btnEditAdd);
            this.panelSub.Controls.Add(this.txtEditEmail);
            this.panelSub.Controls.Add(this.btnEditCancel);
            this.panelSub.Controls.Add(this.txtEditStreet);
            this.panelSub.Controls.Add(this.lblEditTitle);
            this.panelSub.Controls.Add(this.txtEditSurname);
            this.panelSub.Controls.Add(this.lblEditSurname);
            this.panelSub.Controls.Add(this.txtEditForename);
            this.panelSub.Controls.Add(this.lblEditForename);
            this.panelSub.Controls.Add(this.txtEditTown);
            this.panelSub.Controls.Add(this.lblEditStreet);
            this.panelSub.Controls.Add(this.txtEditCounty);
            this.panelSub.Controls.Add(this.lblEditEmail);
            this.panelSub.Controls.Add(this.txtEditPostcode);
            this.panelSub.Controls.Add(this.lblEditTown);
            this.panelSub.Controls.Add(this.txtEditTelNo);
            this.panelSub.Controls.Add(this.LblEditCounty);
            this.panelSub.Controls.Add(this.lblEditTelNo);
            this.panelSub.Controls.Add(this.LblEditPostcode);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 73;
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.MaximumSize = new System.Drawing.Size(714, 557);
            this.Name = "frmEditCustomer";
            this.Text = "frmEditCustomer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEditCustNoValue;
        private System.Windows.Forms.ComboBox cmbEditTitle;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditForename;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.TextBox txtEditTelNo;
        private System.Windows.Forms.Label lblEditTelNo;
        private System.Windows.Forms.Label LblEditPostcode;
        private System.Windows.Forms.Label LblEditCounty;
        private System.Windows.Forms.Label lblEditTown;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditStreet;
        private System.Windows.Forms.Label lblEditForename;
        private System.Windows.Forms.Label lblEditSurname;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditCustomerNo;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel panelSub;
    }
}