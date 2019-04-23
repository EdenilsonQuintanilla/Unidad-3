using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (radioButton1.Checked == true)
            {
                total = total + 50;
            }
            if (radioButton2.Checked == true)
            {
                total = total + 100;
            }
            if (radioButton3.Checked == true)
            {
                total = total + 150;
            }
            if (this.checkBox1.Checked == true)
            {
                total = total + 5;
            }
            if (this.checkBox2.Checked == true)
            {
                total = total + 15;
            }
            if (this.checkBox3.Checked == true)
            {
                total = total + 20;
            }
            MessageBox.Show(" El total de gastos de eenvio es: " + total.ToString("c2"));
        }
    }
}
