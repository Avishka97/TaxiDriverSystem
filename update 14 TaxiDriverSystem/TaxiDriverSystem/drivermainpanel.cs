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
    public partial class drivermainpanel : Form
    {
        SQLWebServiceReference5.WebService1SoapClient client = null;
        public drivermainpanel()
        {
            InitializeComponent();
            client = new SQLWebServiceReference5.WebService1SoapClient();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DriverStartEndDay login = new DriverStartEndDay();
            login.Show();
            client = new SQLWebServiceReference5.WebService1SoapClient();
        }

        private void drivermainpanel_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        void PopulateGrid()
        {
            int DID = Login.DriverID;
            dataGridView1.DataSource = client.HoursWord(DID);

        }
    }
}
