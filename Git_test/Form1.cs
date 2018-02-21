using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_test
{
    public partial class Form1 : Form
    {
        public double res1 = 0;
        public double res2 = 0;
        public double result = 0;
        public Form1()
        {
            InitializeComponent();

            int a = 6000;
        }
private double resul (string text1, string text2){
}
private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") res1 = Double.Parse(textBox1.Text);
            if (textBox2.Text != "") res2 = Double.Parse(textBox2.Text);
            result = res1 + res2;
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (textBox1.Text!="") res1 = Double.Parse(textBox1.Text);
           if (textBox2.Text != "") res2 = Double.Parse(textBox2.Text);
            result = res1 * res2;
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") res1 = Double.Parse(textBox1.Text);
            if (textBox2.Text != "") res2 = Double.Parse(textBox2.Text);
            result = res1 - res2;
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") res1 = Double.Parse(textBox1.Text);
            if (textBox2.Text != "") res2 = Double.Parse(textBox2.Text);
            result = res1 / res2;
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox3.Text != "") textBox1.Text = textBox3.Text;
            textBox3.Clear();
        }
    }
}
