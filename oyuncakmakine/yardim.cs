using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace oyuncakmakine
{
    public partial class yardim : Form
    {
        public yardim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
          StreamReader sr = new StreamReader(Application.StartupPath+ "/dokuman/program.txt");

            textBox1.Text = sr.ReadToEnd();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/get.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/print.txt");

            textBox1.Text = sr.ReadToEnd();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/load.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/store.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/add.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/mod.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/sub.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/mul.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/div.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/goto.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ifpos.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ifzero.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ifneg.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ifcift.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/iftek.txt");

            textBox1.Text = sr.ReadToEnd();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ebob.txt");

            textBox1.Text = sr.ReadToEnd();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/ekok.txt");

            textBox1.Text = sr.ReadToEnd();

        }

        private void yardim_Load(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Clear();

            StreamReader sr = new StreamReader(Application.StartupPath + "/dokuman/program.txt");

            textBox1.Text = sr.ReadToEnd();
        }
    }
}
