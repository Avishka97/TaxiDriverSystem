namespace TaxiDriverSystem
{
    partial class Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQalificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainingTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainingSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTrainingSessionsToDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaryActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiringQualificationsTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiringQualificationsTrainingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predictsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predictWorkHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome Taxi Driver System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin Panel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverToolStripMenuItem,
            this.qualificationToolStripMenuItem,
            this.trainingToolStripMenuItem,
            this.disciplinaryActionToolStripMenuItem,
            this.expiringQualificationsTrainingToolStripMenuItem,
            this.predictsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDriverToolStripMenuItem,
            this.searchDriverToolStripMenuItem,
            this.driverLoginToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // addDriverToolStripMenuItem
            // 
            this.addDriverToolStripMenuItem.Name = "addDriverToolStripMenuItem";
            this.addDriverToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addDriverToolStripMenuItem.Text = "Add Driver";
            this.addDriverToolStripMenuItem.Click += new System.EventHandler(this.addDriverToolStripMenuItem_Click);
            // 
            // searchDriverToolStripMenuItem
            // 
            this.searchDriverToolStripMenuItem.Name = "searchDriverToolStripMenuItem";
            this.searchDriverToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.searchDriverToolStripMenuItem.Text = "Search Driver";
            this.searchDriverToolStripMenuItem.Click += new System.EventHandler(this.searchDriverToolStripMenuItem_Click_1);
            // 
            // driverLoginToolStripMenuItem
            // 
            this.driverLoginToolStripMenuItem.Name = "driverLoginToolStripMenuItem";
            this.driverLoginToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.driverLoginToolStripMenuItem.Text = "Driver Login";
            // 
            // qualificationToolStripMenuItem
            // 
            this.qualificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQalificationToolStripMenuItem,
            this.assignQualificationToolStripMenuItem});
            this.qualificationToolStripMenuItem.Name = "qualificationToolStripMenuItem";
            this.qualificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.qualificationToolStripMenuItem.Text = "Qualification";
            // 
            // addQalificationToolStripMenuItem
            // 
            this.addQalificationToolStripMenuItem.Name = "addQalificationToolStripMenuItem";
            this.addQalificationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addQalificationToolStripMenuItem.Text = "Add Qalification";
            this.addQalificationToolStripMenuItem.Click += new System.EventHandler(this.addQalificationToolStripMenuItem_Click_1);
            // 
            // assignQualificationToolStripMenuItem
            // 
            this.assignQualificationToolStripMenuItem.Name = "assignQualificationToolStripMenuItem";
            this.assignQualificationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.assignQualificationToolStripMenuItem.Text = "Assign Qualification to Driver";
            this.assignQualificationToolStripMenuItem.Click += new System.EventHandler(this.assignQualificationToolStripMenuItem_Click);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainingTypeToolStripMenuItem,
            this.addTrainingSessionToolStripMenuItem,
            this.assignTrainingSessionsToDriverToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // addTrainingTypeToolStripMenuItem
            // 
            this.addTrainingTypeToolStripMenuItem.Name = "addTrainingTypeToolStripMenuItem";
            this.addTrainingTypeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.addTrainingTypeToolStripMenuItem.Text = "Add Training Type";
            this.addTrainingTypeToolStripMenuItem.Click += new System.EventHandler(this.addTrainingTypeToolStripMenuItem_Click);
            // 
            // addTrainingSessionToolStripMenuItem
            // 
            this.addTrainingSessionToolStripMenuItem.Name = "addTrainingSessionToolStripMenuItem";
            this.addTrainingSessionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.addTrainingSessionToolStripMenuItem.Text = "Add Training Session";
            this.addTrainingSessionToolStripMenuItem.Click += new System.EventHandler(this.addTrainingSessionToolStripMenuItem_Click);
            // 
            // assignTrainingSessionsToDriverToolStripMenuItem
            // 
            this.assignTrainingSessionsToDriverToolStripMenuItem.Name = "assignTrainingSessionsToDriverToolStripMenuItem";
            this.assignTrainingSessionsToDriverToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.assignTrainingSessionsToDriverToolStripMenuItem.Text = "Assign Training Sessions to Driver";
            this.assignTrainingSessionsToDriverToolStripMenuItem.Click += new System.EventHandler(this.assignTrainingSessionsToDriverToolStripMenuItem_Click);
            // 
            // disciplinaryActionToolStripMenuItem
            // 
            this.disciplinaryActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem});
            this.disciplinaryActionToolStripMenuItem.Name = "disciplinaryActionToolStripMenuItem";
            this.disciplinaryActionToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.disciplinaryActionToolStripMenuItem.Text = "Disciplinary Action";
            // 
            // assignDisciplinaryAcctionsToDriverToolStripMenuItem
            // 
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem.Name = "assignDisciplinaryAcctionsToDriverToolStripMenuItem";
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem.Text = "Assign Disciplinary Acctions to Driver";
            this.assignDisciplinaryAcctionsToDriverToolStripMenuItem.Click += new System.EventHandler(this.assignDisciplinaryAcctionsToDriverToolStripMenuItem_Click);
            // 
            // expiringQualificationsTrainingToolStripMenuItem
            // 
            this.expiringQualificationsTrainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expiringQualificationsTrainingToolStripMenuItem1});
            this.expiringQualificationsTrainingToolStripMenuItem.Name = "expiringQualificationsTrainingToolStripMenuItem";
            this.expiringQualificationsTrainingToolStripMenuItem.Size = new System.Drawing.Size(206, 20);
            this.expiringQualificationsTrainingToolStripMenuItem.Text = "Expiring Qualifications and Training";
            // 
            // expiringQualificationsTrainingToolStripMenuItem1
            // 
            this.expiringQualificationsTrainingToolStripMenuItem1.Name = "expiringQualificationsTrainingToolStripMenuItem1";
            this.expiringQualificationsTrainingToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.expiringQualificationsTrainingToolStripMenuItem1.Text = "Expiring Qualifications and Training";
            this.expiringQualificationsTrainingToolStripMenuItem1.Click += new System.EventHandler(this.expiringQualificationsTrainingToolStripMenuItem1_Click);
            // 
            // predictsToolStripMenuItem
            // 
            this.predictsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predictsToolStripMenuItem1,
            this.predictWorkHoursToolStripMenuItem});
            this.predictsToolStripMenuItem.Name = "predictsToolStripMenuItem";
            this.predictsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.predictsToolStripMenuItem.Text = "Predicts";
            // 
            // predictsToolStripMenuItem1
            // 
            this.predictsToolStripMenuItem1.Name = "predictsToolStripMenuItem1";
            this.predictsToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.predictsToolStripMenuItem1.Text = "Predicts Accident";
            this.predictsToolStripMenuItem1.Click += new System.EventHandler(this.predictsToolStripMenuItem1_Click);
            // 
            // predictWorkHoursToolStripMenuItem
            // 
            this.predictWorkHoursToolStripMenuItem.Name = "predictWorkHoursToolStripMenuItem";
            this.predictWorkHoursToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.predictWorkHoursToolStripMenuItem.Text = "Predict Work Hours";
            this.predictWorkHoursToolStripMenuItem.Click += new System.EventHandler(this.predictWorkHoursToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaxiDriverSystem.Properties.Resources.Taxis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 416);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQalificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainingTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainingSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTrainingSessionsToDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaryActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDisciplinaryAcctionsToDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiringQualificationsTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiringQualificationsTrainingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predictsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predictWorkHoursToolStripMenuItem;
    }
}