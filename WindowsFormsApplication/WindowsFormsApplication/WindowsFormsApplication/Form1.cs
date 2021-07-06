using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;
            if (!Regex.IsMatch(input1, @"\d+$") || !Regex.IsMatch(input2, @"\d+$"))
            {
                MessageBox.Show("Please write the valid input");
            }

            if (Add.Checked)
            {
                MessageBox.Show((Convert.ToInt32(input1) + Convert.ToInt32(input2)).ToString());
            }
            else if (Subtract.Checked)
            {
                MessageBox.Show((Convert.ToInt32(input1) - Convert.ToInt32(input2)).ToString());
            }
            else if (Multiply.Checked)
            {
                MessageBox.Show((Convert.ToInt32(input1) * Convert.ToInt32(input2)).ToString());
            }
            else if (Divide.Checked)
            {
                MessageBox.Show((Convert.ToInt32(input1) / Convert.ToInt32(input2)).ToString());
            }
            else
            {
                MessageBox.Show("Please provide the valid Option");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
