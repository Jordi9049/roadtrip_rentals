namespace RoadTripRentals
{
    partial class frmOrderMain
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOrder.Controls.Add(this.btnQuit);
            this.pnlOrder.Controls.Add(this.btnOrderHistory);
            this.pnlOrder.Controls.Add(this.pnlMain);
            this.pnlOrder.Location = new System.Drawing.Point(9, 12);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(677, 500);
            this.pnlOrder.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.AllowDrop = true;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuit.Location = new System.Drawing.Point(23, 392);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 53);
            this.btnQuit.TabIndex = 35;
            this.btnQuit.Tag = "S4";
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.AllowDrop = true;
            this.btnOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderHistory.Location = new System.Drawing.Point(9, 17);
            this.btnOrderHistory.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(133, 70);
            this.btnOrderHistory.TabIndex = 32;
            this.btnOrderHistory.Tag = "S1";
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.AutoSize = true;
            this.pnlMain.Location = new System.Drawing.Point(146, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(518, 476);
            this.pnlMain.TabIndex = 6;
            // 
            // frmOrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 524);
            this.Controls.Add(this.pnlOrder);
            this.Name = "frmOrderMain";
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.frmOrderMain_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnOrderHistory;
    }
}