namespace RoadTripRentals
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox checkBoxOption;

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
            this.colorSchemeComboBox = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkBoxOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // colorSchemeComboBox
            // 
            this.colorSchemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSchemeComboBox.FormattingEnabled = true;
            this.colorSchemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "SubPanel"});
            this.colorSchemeComboBox.Location = new System.Drawing.Point(90, 12);
            this.colorSchemeComboBox.Name = "colorSchemeComboBox";
            this.colorSchemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorSchemeComboBox.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 93);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(199, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBoxOption
            // 
            this.checkBoxOption.AutoSize = true;
            this.checkBoxOption.Location = new System.Drawing.Point(15, 48);
            this.checkBoxOption.Name = "checkBoxOption";
            this.checkBoxOption.Size = new System.Drawing.Size(94, 17);
            this.checkBoxOption.TabIndex = 3;
            this.checkBoxOption.Text = "Enable Option";
            this.checkBoxOption.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 128);
            this.Controls.Add(this.checkBoxOption);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.colorSchemeComboBox);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox colorSchemeComboBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
    }
}