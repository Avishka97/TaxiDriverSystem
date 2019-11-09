using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaxiDriverSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

     

        private void searchDriverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Driver login = new Driver();
            login.Show();
        }

        private void addQalificationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Qalification login = new Qalification();
            login.Show();
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver login = new Driver();
            login.Show();
        }

        private void assignQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverAssignQalification login = new DriverAssignQalification();
            login.Show();
        }

        private void addTrainingTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingType login = new TrainingType();
            login.Show();
        }

        private void addTrainingSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingSessions login = new TrainingSessions();
            login.Show();
        }

        private void assignTrainingSessionsToDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverAssignSession login = new DriverAssignSession();
            login.Show();
        }

        private void assignDisciplinaryAcctionsToDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplinary login = new Disciplinary();
            login.Show();
        }

        private void expiringQualificationsTrainingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpireQualificationandTraining login = new ExpireQualificationandTraining();
            login.Show();

        }

        private void predictsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel login = new Panel();
            login.Show();
        }

        private void predictWorkHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Predict login = new Predict();
            login.Show();
        }
    }
}
