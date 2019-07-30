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
    public partial class StudentManagment : Form
    {
        public StudentManagment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter some value");
                textBox1.Focus();
            }

            SMSService sMSService = new SMSService();
            var data = sMSService.GetStudents(textBox1.Text);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data.Tables[0]; // dataset
            //dataGridView1.DataMember = "Tabel"; // table name you need to show
            //dataGridView1.DataSource = data;
            //dataGridView1.DataBind();
        }
    }
}
