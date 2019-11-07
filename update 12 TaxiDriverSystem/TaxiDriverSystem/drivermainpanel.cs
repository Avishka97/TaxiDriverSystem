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
        public drivermainpanel()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DriverStartEndDay login = new DriverStartEndDay();
            login.Show();
        }

        private void drivermainpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
