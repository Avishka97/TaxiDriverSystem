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
            this.txtRTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSessionID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbDriverID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRTID,
            this.cmbSessionID,
            this.cmbDriverID,
            this.txtRemark});
            this.dataGridView1.Location = new System.Drawing.Point(34, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 494);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // txtRTID
            // 
            this.txtRTID.DataPropertyName = "RT_ID";
            this.txtRTID.HeaderText = "No";
            this.txtRTID.Name = "txtRTID";
            this.txtRTID.ReadOnly = true;
            // 
            // cmbSessionID
            // 
            this.cmbSessionID.DataPropertyName = "TS_ID";
            this.cmbSessionID.HeaderText = "Session ID";
            this.cmbSessionID.Name = "cmbSessionID";
            // 
            // cmbDriverID
            // 
            this.cmbDriverID.DataPropertyName = "D_ID";
            this.cmbDriverID.HeaderText = "Driver ID";
            this.cmbDriverID.Name = "cmbDriverID";
            // 
            // txtRemark
            // 
            this.txtRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtRemark.DataPropertyName = "Remark";
            this.txtRemark.HeaderText = "Remark";
            this.txtRemark.Name = "txtRemark";
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
            this.Load += new System.EventHandler(this.DriverAssignSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddDriver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRTID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbSessionID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRemark;
    }
}