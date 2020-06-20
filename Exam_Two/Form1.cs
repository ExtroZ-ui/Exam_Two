using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToDouble(numericUpDown1.Value);
                double b = Convert.ToDouble(numericUpDown2.Value);
                double c = Convert.ToDouble(numericUpDown3.Value);
                double P = (a + b + c) / 2;
                double S = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
                textBox4.Text = Convert.ToString(S);
            }
            if (radioButton2.Checked)
            {
                double a = Convert.ToDouble(numericUpDown1.Value);
                double b = Convert.ToDouble(numericUpDown2.Value);
                double c = Convert.ToDouble(numericUpDown3.Value);
                double P = (a + b + c) / 2;
                textBox4.Text = Convert.ToString(P);
            }
        }
    }
}
