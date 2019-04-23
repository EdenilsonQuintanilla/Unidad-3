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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, pass;
            usuario = textBox1.Text.TrimEnd();
            pass = textBox1.Text.TrimEnd();
            if ((usuario == "UTEC") && (pass == "Programacion1"))
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else {
                MessageBox.Show("Verique usuario y contrasena");
            }
        }
    }
}
