using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciFiCalc
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            TB.AppendText("9");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            TB.AppendText("8");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            TB.AppendText("7");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            TB.AppendText("6");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            TB.AppendText("5");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            TB.AppendText("4");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            TB.AppendText("3");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            TB.AppendText("2");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            TB.AppendText("1");
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (TB.Text.Equals("0") || TB.Text.Equals(""))
                TB.AppendText("");
            else
                TB.AppendText("0");

        }

        private void b_dec_Click(object sender, EventArgs e)
        {
            if (!TB.Text.Contains("."))
                TB.AppendText(".");                
        }

        private void b_clr_Click(object sender, EventArgs e)
        {
            TB.Clear();
            num1 = num2 = 0;
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            TB.Text = TB.Text.Remove(TB.Text.Length - 1);
        }

        private void b_log_Click(object sender, EventArgs e)
        {
            TB.Text = Math.Log10(Double.Parse(TB.Text))+"";
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(TB.Text);
            if (num2==0)
            {
                num2 = num1;
                TB.Clear();
            }
            else
            {
                num2 += num1;
                TB.Text = num2 + "";
            }
        }

        private void b_sub_Click(object sender, EventArgs e)
        {

        }

        private void b_mul_Click(object sender, EventArgs e)
        {

        }

        private void b_div_Click(object sender, EventArgs e)
        {

        }

        private void b_sqrt_Click(object sender, EventArgs e)
        {
            TB.Text = Math.Sqrt(Double.Parse(TB.Text))+"";
        }

        private void b_sqr_Click(object sender, EventArgs e)
        {
            TB.Text = Math.Pow((Double.Parse(TB.Text)),2)+ "";
        }

        private void b_eq_Click(object sender, EventArgs e)
        {
            TB.Text = num2 + "";
        }
    }
}
