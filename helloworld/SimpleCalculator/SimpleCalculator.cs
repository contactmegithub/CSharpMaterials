using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            CalculatorService.Operator = "A";
            textBox1.Text = "";
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            CalculatorService.Operator = "S";
            textBox1.Text = "";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            CalculatorService.Operator = "M";
            textBox1.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            CalculatorService.Operator = "D";
            textBox1.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            CalculatorService.FirstNumber = textBox1.Tag == null ? "" : textBox1.Tag.ToString();
            CalculatorService.SecondNumber = textBox1.Text;
            textBox1.Text = CalculatorService.Calculate().ToString();

            if (!string.IsNullOrEmpty(CalculatorService.ErrorMessage))
                MessageBox.Show(CalculatorService.ErrorMessage);
            CalculatorService.ErrorMessage = string.Empty;
        }
    }
}
