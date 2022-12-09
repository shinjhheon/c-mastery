using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void check()
        {
            if(radioButton1.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("버튼");
      
                listBox1.Items.Add("체크 상자");
            
                listBox1.Items.Add("라디오 버튼");
            }
            if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
           
                listBox1.Items.Add("리스트 상자");
             
                listBox1.Items.Add("콤보 상자");
               
                listBox1.Items.Add("체크 리스트 상자");
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            check();

        }
    }
}
