using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)

                     || e.KeyChar == Convert.ToInt32(Keys.Back)

                     || (e.KeyChar == '-')
                )

            { 

            }

            else

            {
                e.Handled = true; 

            }
        }
    }
}
    

