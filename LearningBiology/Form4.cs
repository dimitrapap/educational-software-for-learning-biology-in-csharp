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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void button2_Click(object sender, EventArgs e)
        {
            SwstoLathos3 swstoLathos3 = new SwstoLathos3();
            swstoLathos3.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumplirwshsKenwn3 sumplirwshsKenwn3 = new SumplirwshsKenwn3();
            sumplirwshsKenwn3.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PollaplhsEpiloghs3 pollaplhsEpiloghs3 = new PollaplhsEpiloghs3();
            pollaplhsEpiloghs3.Show();
            Visible = false;
        }
    }
}
