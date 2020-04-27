using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan27Apr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double first_num = Double.Parse(textBox1.Text);
            double second_num = Double.Parse(textBox2.Text);
            double result_num = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                result_num = first_num + second_num;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                result_num = first_num - second_num;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                result_num = first_num / second_num;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                result_num = first_num * second_num;
            }
            else
            {
                MessageBox.Show("Operator salah");
            }

            textBox3.Text = result_num.ToString();
        }
    }
}
