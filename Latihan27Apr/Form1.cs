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

        private void button1_Click(object sender, EventArgs e)
        {
            double standar = 85;
            double first_num = Double.Parse(textBox1.Text);
            double second_num = Double.Parse(textBox2.Text);
            double third_num = Double.Parse(textBox3.Text);
            double average_num = (first_num + second_num + third_num) / 3;

            textBox4.Text = average_num.ToString();
            if (average_num > standar)
            {
                label5.Text = "Hore, kamu lulus";
            }
            else
            {
                label5.Text = "Maaf coba tahun depan";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
