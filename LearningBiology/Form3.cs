using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningBiology
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumplirwshsKenwn2 sumplirwshsKenwn2 = new SumplirwshsKenwn2();
            sumplirwshsKenwn2.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PollaplhsEpiloghs2 pollaplhsEpiloghs2 = new PollaplhsEpiloghs2();
            pollaplhsEpiloghs2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwstoLathos2 swstoLathos2 = new SwstoLathos2();
            swstoLathos2.Show();
            Visible = false;
        }
    }
}
