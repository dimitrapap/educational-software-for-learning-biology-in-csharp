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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumplirwshsKenwn sumplirwshsKenwn = new SumplirwshsKenwn();
            sumplirwshsKenwn.Show();
            Visible = false;
                
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

        private void button3_Click(object sender, EventArgs e)
        {
            PollaplhsEpiloghs pollaplhsEpiloghs = new PollaplhsEpiloghs();
            pollaplhsEpiloghs.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwstoLathos swstoLathos = new SwstoLathos();
            swstoLathos.Show();
            Visible = false;
        }
    }
}
