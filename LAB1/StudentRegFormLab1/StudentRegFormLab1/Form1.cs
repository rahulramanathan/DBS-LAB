using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegFormLab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unnned function 
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm submisson", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                verify();
            }
        }
        private void verify()
        {
            Boolean valid = true;
            RadioButton[] rb = new RadioButton[] { rbM, rbF, rbO };
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrEmpty(txtRegNo.Text) || String.IsNullOrWhiteSpace(txtRegNo.Text))
            {
                valid = false;
            }
            else if (!rb.Any(rad => rad.Checked))
            {
                valid = false;
            }
            else if (!(comboBox1.SelectedIndex > -1))
            {
                valid = false;
            }
            else if (cal.SelectionRange.Start == null)
            {
                valid = false;
            }
            String name = txtName.Text;
            String regno = Int32.Parse(txtRegNo.Text)+"";
            char[] arr = new char[100];
            arr=name.ToCharArray();
            for(int i=0;i<name.Length;i++)
            {
                
            }
            if (!valid)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("Submitted");
            }
        }
    }
}
