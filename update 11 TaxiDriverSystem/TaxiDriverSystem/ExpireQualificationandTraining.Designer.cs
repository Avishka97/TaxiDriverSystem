namespace TaxiDriverSystem
{
    partial class ExpireQualificationandTraining
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Qualifications = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Qualifications.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddDriver
            // 
            this.lblAddDriver.AutoSize = true;
            this.lblAddDriver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDriver.Location = new System.Drawing.Point(194, 32);
            this.lblAddDriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddDriver.Name = "lblAddDriver";
            this.lblAddDriver.Size = new System.Drawing.Size(579, 37);
            this.lblAddDriver.TabIndex = 20;
            this.lblAddDriver.Text = "Expiring Qualifications and trainings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 245);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(919, 255);
            this.dataGridView2.TabIndex = 22;
            // 
            // Qualifications
            // 
            this.Qualifications.Controls.Add(this.dataGridView1);
            this.Qualifications.Location = new System.Drawing.Point(9, 85);
            this.Qualifications.Name = "Qualifications";
            this.Qualifications.Size = new System.Drawing.Size(939, 273);
            this.Qualifications.TabIndex = 23;
            this.Qualifications.TabStop = false;
            this.Qualifications.Text = "Qualifications";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(9, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 285);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainings";
            // 
            // ExpireQualificationandTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Qualifications);
            this.Controls.Add(this.lblAddDriver);
            this.Name = "ExpireQualificationandTraining";
            this.Text = "ExpireQualificationandTraining";
            this.Load += new System.EventHandler(this.ExpireQualificationandTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Qualifications.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddDriver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox Qualifications;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}