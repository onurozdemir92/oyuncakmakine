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
    public partial class get : Form
    {
        public get()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.aku = float.Parse(textBox1.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Sayisal bir deger giriniz!");
            }
            
        }
    }
}
