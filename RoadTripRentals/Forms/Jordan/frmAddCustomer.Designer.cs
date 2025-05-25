namespace RoadTripRentals.Forms.Jordan
{
    partial class frmAddCustomer
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
            this.lblAddCustNoValue = new System.Windows.Forms.Label();
            this.cmbAddTitle = new System.Windows.Forms.ComboBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.lblAddTelNo = new System.Windows.Forms.Label();
            this.LblAddPostcode = new System.Windows.Forms.Label();
            this.LblAddCounty = new System.Windows.Forms.Label();
            this.lblAddTown = new System.Windows.Forms.Label();
            this.lblAddForename = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddCustomerNo = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddStreet = new System.Windows.Forms.Label();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.panelSub = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.panelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCustNoValue
            // 
            this.lblAddCustNoValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddCustNoValue.AutoSize = true;
            this.lblAddCustNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustNoValue.Location = new System.Drawing.Point(197, 20);
            this.lblAddCustNoValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddCustNoValue.Name = "lblAddCustNoValue";
            this.lblAddCustNoValue.Size = new System.Drawing.Size(17, 24);
            this.lblAddCustNoValue.TabIndex = 50;
            this.lblAddCustNoValue.Text = "-";
            // 
            // cmbAddTitle
            // 
            this.cmbAddTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAddTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddTitle.FormattingEnabled = true;
            this.cmbAddTitle.ItemHeight = 13;
            this.cmbAddTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs"});
            this.cmbAddTitle.Location = new System.Drawing.Point(196, 63);
            this.cmbAddTitle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbAddTitle.Name = "cmbAddTitle";
            this.cmbAddTitle.Size = new System.Drawing.Size(54, 21);
            this.cmbAddTitle.TabIndex = 49;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddSurname.Location = new System.Drawing.Point(196, 98);
            this.txtAddSurname.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddSurname.Multiline = true;
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(364, 30);
            this.txtAddSurname.TabIndex = 48;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddForename.Location = new System.Drawing.Point(196, 141);
            this.txtAddForename.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddForename.Multiline = true;
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(364, 30);
            this.txtAddForename.TabIndex = 47;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddTown.Location = new System.Drawing.Point(196, 229);
            this.txtAddTown.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddTown.Multiline = true;
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(364, 30);
            this.txtAddTown.TabIndex = 45;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddCounty.Location = new System.Drawing.Point(196, 277);
            this.txtAddCounty.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddCounty.Multiline = true;
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(218, 30);
            this.txtAddCounty.TabIndex = 44;
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddPostcode.Location = new System.Drawing.Point(196, 322);
            this.txtAddPostcode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddPostcode.Multiline = true;
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(218, 30);
            this.txtAddPostcode.TabIndex = 43;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddTelNo.Location = new System.Drawing.Point(196, 413);
            this.txtAddTelNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddTelNo.Multiline = true;
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(218, 30);
            this.txtAddTelNo.TabIndex = 42;
            // 
            // lblAddTelNo
            // 
            this.lblAddTelNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddTelNo.AutoSize = true;
            this.lblAddTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddTelNo.Location = new System.Drawing.Point(75, 423);
            this.lblAddTelNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddTelNo.Name = "lblAddTelNo";
            this.lblAddTelNo.Size = new System.Drawing.Size(60, 20);
            this.lblAddTelNo.TabIndex = 41;
            this.lblAddTelNo.Text = "Tel No";
            // 
            // LblAddPostcode
            // 
            this.LblAddPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddPostcode.AutoSize = true;
            this.LblAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.LblAddPostcode.Location = new System.Drawing.Point(74, 332);
            this.LblAddPostcode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblAddPostcode.Name = "LblAddPostcode";
            this.LblAddPostcode.Size = new System.Drawing.Size(84, 20);
            this.LblAddPostcode.TabIndex = 40;
            this.LblAddPostcode.Text = "Postcode";
            // 
            // LblAddCounty
            // 
            this.LblAddCounty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddCounty.AutoSize = true;
            this.LblAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.LblAddCounty.Location = new System.Drawing.Point(75, 287);
            this.LblAddCounty.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblAddCounty.Name = "LblAddCounty";
            this.LblAddCounty.Size = new System.Drawing.Size(65, 20);
            this.LblAddCounty.TabIndex = 39;
            this.LblAddCounty.Text = "County";
            // 
            // lblAddTown
            // 
            this.lblAddTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddTown.AutoSize = true;
            this.lblAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddTown.Location = new System.Drawing.Point(75, 239);
            this.lblAddTown.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddTown.Name = "lblAddTown";
            this.lblAddTown.Size = new System.Drawing.Size(51, 20);
            this.lblAddTown.TabIndex = 38;
            this.lblAddTown.Text = "Town";
            // 
            // lblAddForename
            // 
            this.lblAddForename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddForename.AutoSize = true;
            this.lblAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddForename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddForename.Location = new System.Drawing.Point(74, 151);
            this.lblAddForename.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddForename.Name = "lblAddForename";
            this.lblAddForename.Size = new System.Drawing.Size(90, 20);
            this.lblAddForename.TabIndex = 36;
            this.lblAddForename.Text = "Forename";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddSurname.Location = new System.Drawing.Point(75, 108);
            this.lblAddSurname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(81, 20);
            this.lblAddSurname.TabIndex = 35;
            this.lblAddSurname.Text = "Surname";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddTitle.Location = new System.Drawing.Point(75, 64);
            this.lblAddTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(43, 20);
            this.lblAddTitle.TabIndex = 34;
            this.lblAddTitle.Text = "Title";
            // 
            // lblAddCustomerNo
            // 
            this.lblAddCustomerNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddCustomerNo.AutoSize = true;
            this.lblAddCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddCustomerNo.Location = new System.Drawing.Point(75, 23);
            this.lblAddCustomerNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(113, 20);
            this.lblAddCustomerNo.TabIndex = 33;
            this.lblAddCustomerNo.Text = "Customer No";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.AllowDrop = true;
            this.btnAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCancel.BackColor = System.Drawing.Color.Silver;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.Location = new System.Drawing.Point(382, 460);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(178, 45);
            this.btnAddCancel.TabIndex = 30;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.AllowDrop = true;
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(205)))), ((int)(((byte)(169)))));
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAdd.Location = new System.Drawing.Point(196, 460);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(178, 45);
            this.btnAddAdd.TabIndex = 29;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // lblAddStreet
            // 
            this.lblAddStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddStreet.AutoSize = true;
            this.lblAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddStreet.Location = new System.Drawing.Point(74, 197);
            this.lblAddStreet.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddStreet.Name = "lblAddStreet";
            this.lblAddStreet.Size = new System.Drawing.Size(110, 20);
            this.lblAddStreet.TabIndex = 35;
            this.lblAddStreet.Text = "Street Name";
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddStreet.Location = new System.Drawing.Point(196, 187);
            this.txtAddStreet.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddStreet.Multiline = true;
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(364, 30);
            this.txtAddStreet.TabIndex = 48;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblAddEmail.Location = new System.Drawing.Point(75, 378);
            this.lblAddEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(53, 20);
            this.lblAddEmail.TabIndex = 35;
            this.lblAddEmail.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAddEmail.Location = new System.Drawing.Point(196, 368);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAddEmail.Multiline = true;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(364, 30);
            this.txtAddEmail.TabIndex = 48;
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.lblAddCustNoValue);
            this.panelSub.Controls.Add(this.txtAddTelNo);
            this.panelSub.Controls.Add(this.cmbAddTitle);
            this.panelSub.Controls.Add(this.btnAddAdd);
            this.panelSub.Controls.Add(this.txtAddEmail);
            this.panelSub.Controls.Add(this.btnAddCancel);
            this.panelSub.Controls.Add(this.txtAddStreet);
            this.panelSub.Controls.Add(this.lblAddCustomerNo);
            this.panelSub.Controls.Add(this.txtAddSurname);
            this.panelSub.Controls.Add(this.lblAddTitle);
            this.panelSub.Controls.Add(this.txtAddForename);
            this.panelSub.Controls.Add(this.lblAddSurname);
            this.panelSub.Controls.Add(this.txtAddTown);
            this.panelSub.Controls.Add(this.lblAddForename);
            this.panelSub.Controls.Add(this.txtAddCounty);
            this.panelSub.Controls.Add(this.lblAddStreet);
            this.panelSub.Controls.Add(this.txtAddPostcode);
            this.panelSub.Controls.Add(this.lblAddEmail);
            this.panelSub.Controls.Add(this.lblAddTown);
            this.panelSub.Controls.Add(this.lblAddTelNo);
            this.panelSub.Controls.Add(this.LblAddCounty);
            this.panelSub.Controls.Add(this.LblAddPostcode);
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(0, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(698, 518);
            this.panelSub.TabIndex = 51;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 518);
            this.Controls.Add(this.panelSub);
            this.Name = "frmAddCustomer";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddCustNoValue;
        private System.Windows.Forms.ComboBox cmbAddTitle;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.Label lblAddTelNo;
        private System.Windows.Forms.Label LblAddPostcode;
        private System.Windows.Forms.Label LblAddCounty;
        private System.Windows.Forms.Label lblAddTown;
        private System.Windows.Forms.Label lblAddForename;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddCustomerNo;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddStreet;
        private System.Windows.Forms.Panel panelSub;
    }
}