using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Operation
{
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 3;
            
            if(progressBar1.Value >= 99)
            {
                Main m = new Main();
                this.Hide();
                m.Show();

                timer1.Enabled = false;
                progressBar1.Value -= 1;
            }
        }
    }
}
