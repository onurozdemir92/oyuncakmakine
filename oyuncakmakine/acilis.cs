using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncakmakine
{
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            timer1.Stop();
            timer1.Stop();










            this.Hide();
        }

        private void acilis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
