namespace TaxiDriverSystem
{
    partial class DriverStartEndJourney
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnEndTime = new System.Windows.Forms.Button();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.lblDID = new System.Windows.Forms.Label();
            this.cmbDID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(40, 293);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 9;
            // 
            // btnEndTime
            // 
            this.btnEndTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTime.Location = new System.Drawing.Point(205, 206);
            this.btnEndTime.Name = "btnEndTime";
            this.btnEndTime.Size = new System.Drawing.Size(161, 36);
            this.btnEndTime.TabIndex = 8;
            this.btnEndTime.Text = "End Time";
            this.btnEndTime.UseVisualStyleBackColor = true;
            this.btnEndTime.Click += new System.EventHandler(this.btnEndTime_Click);
            // 
            // btnStartTime
            // 
            this.btnStartTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTime.Location = new System.Drawing.Point(43, 206);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(130, 36);
            this.btnStartTime.TabIndex = 7;
            this.btnStartTime.Text = "Start Time";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // lblDID
            // 
            this.lblDID.AutoSize = true;
            this.lblDID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDID.Location = new System.Drawing.Point(39, 91);
            this.lblDID.Name = "lblDID";
            this.lblDID.Size = new System.Drawing.Size(106, 24);
            this.lblDID.TabIndex = 6;
            this.lblDID.Text = "Driver ID :";
            // 
            // cmbDID
            // 
            this.cmbDID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDID.FormattingEnabled = true;
            this.cmbDID.Location = new System.Drawing.Point(172, 88);
            this.cmbDID.Name = "cmbDID";
            this.cmbDID.Size = new System.Drawing.Size(194, 32);
            this.cmbDID.TabIndex = 5;
            // 
            // DriverStartEndJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 389);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnEndTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.lblDID);
            this.Controls.Add(this.cmbDID);
            this.Name = "DriverStartEndJourney";
            this.Text = "DriverStartEndJourney";
            this.Load += new System.EventHandler(this.DriverStartEndJourney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnEndTime;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Label lblDID;
        private System.Windows.Forms.ComboBox cmbDID;
    }
}