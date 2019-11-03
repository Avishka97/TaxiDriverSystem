namespace TaxiDriverSystem
{
    partial class DriverAssignQalification
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
            this.txtRQ_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbD_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbQID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddDriver
            // 
            this.lblAddDriver.AutoSize = true;
            this.lblAddDriver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDriver.Location = new System.Drawing.Point(179, 33);
            this.lblAddDriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddDriver.Name = "lblAddDriver";
            this.lblAddDriver.Size = new System.Drawing.Size(468, 37);
            this.lblAddDriver.TabIndex = 19;
            this.lblAddDriver.Text = "Assign Qalifications to Driver";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRQ_ID,
            this.cmbD_ID,
            this.cmbQID});
            this.dataGridView1.Location = new System.Drawing.Point(28, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 443);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // txtRQ_ID
            // 
            this.txtRQ_ID.DataPropertyName = "RQ_ID";
            this.txtRQ_ID.HeaderText = "No";
            this.txtRQ_ID.Name = "txtRQ_ID";
            this.txtRQ_ID.ReadOnly = true;
            // 
            // cmbD_ID
            // 
            this.cmbD_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbD_ID.DataPropertyName = "D_ID";
            this.cmbD_ID.HeaderText = "Driver";
            this.cmbD_ID.Name = "cmbD_ID";
            // 
            // cmbQID
            // 
            this.cmbQID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbQID.DataPropertyName = "Q_ID";
            this.cmbQID.HeaderText = "Qualification";
            this.cmbQID.Name = "cmbQID";
            // 
            // DriverAssignQalification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAddDriver);
            this.Name = "DriverAssignQalification";
            this.Text = "DriverAssignQalification";
            this.Load += new System.EventHandler(this.DriverAssignQalification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddDriver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRQ_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbD_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbQID;
    }
}