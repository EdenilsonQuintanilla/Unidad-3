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
    public partial class Ejercicios : Form
    {
        private int childFormNumber = 0;

        public Ejercicios()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Ejercicios_Load(object sender, EventArgs e)
        {

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hijo1 = new Form1();
            hijo1.MdiParent = this;
            hijo1.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 hijo2 = new Form2();
            hijo2.MdiParent = this;
            hijo2.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijo3 = new Form3();
            hijo3.MdiParent = this;
            hijo3.Show();

        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 hijo4 = new Form4();
            hijo4.MdiParent = this;
            hijo4.Show();
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
