using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TaxiDriverSystem
{
    public partial class Drivertel : System.Windows.Forms.TextBox
    {
        public Drivertel()
        {
            InitializeComponent();
        }

        public Drivertel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 11)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (textBox1.Text.Length > 11)
            {
                textBox1.ForeColor = Color.Red;
            }
            
        }

    }
}
