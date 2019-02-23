using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dont touch me my friend");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("pls input number!");
            }
            else
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                textBox3.Text = (x * y).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
