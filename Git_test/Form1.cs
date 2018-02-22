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
        public double result;
        public bool b2, b3, b4, b5;
        public Form1()
        {
            InitializeComponent();

            int a = 9000;
        }
        private double resul(string text1, string text2)
        {
            res1 = Double.Parse(text1);
            res2 = Double.Parse(text2);
            if (b2) { result = res1 / res2; b2 = false; }
            else
            if (b3) { result = res1 * res2; b3 = false; }
            else
            if (b4) { result = res1 + res2; b4 = false; }
            else
            if (b5) { result = res1 - res2; b5 = false; }
            textBox2.Clear();
            textBox1.Clear();
            return result;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            b4 = true;
            if (textBox1.Text != "" && textBox2.Text != "") resul(textBox1.Text, textBox2.Text);
            else MessageBox.Show("Введите значения");
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3 = true;
            if (textBox1.Text != "" && textBox2.Text != "") resul(textBox1.Text, textBox2.Text);
            else MessageBox.Show("Введите значения");
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b5 = true;
            if (textBox1.Text != "" && textBox2.Text != "") resul(textBox1.Text, textBox2.Text);
            else MessageBox.Show("Введите значения");
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           b2 = true;
            if (textBox1.Text != "" && textBox2.Text != "") resul(textBox1.Text, textBox2.Text);
            else MessageBox.Show("Введите значения");
            textBox3.Text = result.ToString();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox3.Text != "") textBox1.Text = textBox3.Text;
            textBox3.Clear();
        }
    }
}
