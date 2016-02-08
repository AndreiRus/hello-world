using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex.init(listBox1);
            (new Complex(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)) + new Complex(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text))).show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Complex test;
            Complex element = test[Int32.Parse(numericUpDown1.Value)];
        }
    }
}
