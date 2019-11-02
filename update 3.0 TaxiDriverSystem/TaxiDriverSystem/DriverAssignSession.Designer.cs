namespace TaxiDriverSystem
{
    partial class DriverAssignSession
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
            this.lblAddDriver = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddDriver
            // 
            this.lblAddDriver.AutoSize = true;
            this.lblAddDriver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDriver.Location = new System.Drawing.Point(239, 28);
            this.lblAddDriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddDriver.Name = "lblAddDriver";
            this.lblAddDriver.Size = new System.Drawing.Size(573, 37);
            this.lblAddDriver.TabIndex = 18;
            this.lblAddDriver.Text = "Assign Driver\'s to Training Sessions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 494);
            this.dataGridView1.TabIndex = 19;
            // 
            // DriverAssignSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAddDriver);
            this.Name = "DriverAssignSession";
            this.Text = "DriverAssignSession";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddDriver;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}