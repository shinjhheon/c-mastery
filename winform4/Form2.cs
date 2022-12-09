using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
 public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // 더하기
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int Result = Num1 + Num2;

            textBox3.Text = Result.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int Result = Num1 - Num2;

            textBox3.Text = Result.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int Result = Num1 * Num2;

            textBox3.Text = Result.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int Result = Num1 / Num2;

            textBox3.Text = Result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);

            int Result = Num1 % Num2;

            textBox3.Text = Result.ToString();
        }
    }
}
