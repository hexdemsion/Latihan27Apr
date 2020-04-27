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
            double highest_number;
            double first_num = Double.Parse(textBox1.Text);
            double second_num = Double.Parse(textBox2.Text);

            if (first_num > second_num)
            {
                highest_number = first_num;
            }
            else
            {
                highest_number = second_num;
            }

            textBox3.Text = "Angka terbesar adalah: " + highest_number;
        }
    }
}
