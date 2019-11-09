namespace TaxiDriverSystem
{
    partial class DriverStartEndDay
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
            this.cmbDID = new System.Windows.Forms.ComboBox();
            this.lblDID = new System.Windows.Forms.Label();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.btnEndTime = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnJourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDID
            // 
            this.cmbDID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDID.FormattingEnabled = true;
            this.cmbDID.Location = new System.Drawing.Point(205, 65);
            this.cmbDID.Name = "cmbDID";
            this.cmbDID.Size = new System.Drawing.Size(194, 32);
            this.cmbDID.TabIndex = 0;
            // 
            // lblDID
            // 
            this.lblDID.AutoSize = true;
            this.lblDID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDID.Location = new System.Drawing.Point(72, 68);
            this.lblDID.Name = "lblDID";
            this.lblDID.Size = new System.Drawing.Size(106, 24);
            this.lblDID.TabIndex = 1;
            this.lblDID.Text = "Driver ID :";
            // 
            // btnStartTime
            // 
            this.btnStartTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTime.Location = new System.Drawing.Point(76, 183);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(130, 36);
            this.btnStartTime.TabIndex = 2;
            this.btnStartTime.Text = "Start Time";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnEndTime
            // 
            this.btnEndTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTime.Location = new System.Drawing.Point(238, 183);
            this.btnEndTime.Name = "btnEndTime";
            this.btnEndTime.Size = new System.Drawing.Size(161, 36);
            this.btnEndTime.TabIndex = 3;
            this.btnEndTime.Text = "End Time";
            this.btnEndTime.UseVisualStyleBackColor = true;
            this.btnEndTime.Click += new System.EventHandler(this.btnEndTime_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(81, 249);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 4;
            // 
            // btnJourney
            // 
            this.btnJourney.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJourney.Location = new System.Drawing.Point(137, 312);
            this.btnJourney.Name = "btnJourney";
            this.btnJourney.Size = new System.Drawing.Size(191, 36);
            this.btnJourney.TabIndex = 5;
            this.btnJourney.Text = "Start journey";
            this.btnJourney.UseVisualStyleBackColor = true;
            this.btnJourney.Click += new System.EventHandler(this.btnJourney_Click);
            // 
            // DriverStartEndDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 372);
            this.Controls.Add(this.btnJourney);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnEndTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.lblDID);
            this.Controls.Add(this.cmbDID);
            this.Name = "DriverStartEndDay";
            this.Text = "DriverStartEndDay";
            this.Load += new System.EventHandler(this.DriverStartEndDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDID;
        private System.Windows.Forms.Label lblDID;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Button btnEndTime;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnJourney;
    }
}