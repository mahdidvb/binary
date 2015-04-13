using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DecToBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DecimalToBinary(Convert.ToInt32(textBox1.Text)).ToString();
        }

        public object DecimalToBinary(int num)
        {
            int dec = num;
            string ss = Convert.ToString(dec, 2);
            return ss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToInt64(textBox2.Text , 2).ToString() ;

        }
    }
}
