using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsorcio
{
    public partial class MDImenu : Form
    {
        private int childFormNumber = 0;

        public MDImenu()
        {
            InitializeComponent();
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





        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuarioPantalla_Click(object sender, EventArgs e)
        {

        }

        private void usuarioMenu_Click(object sender, EventArgs e)
        {

        }

        private void comunicadosMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            FormVerComunicados formComunicados = new FormVerComunicados();
            formComunicados.Show();
        }

        private void reclamosMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            FormReclamosMenu formReclamos = new FormReclamosMenu();
            formReclamos.Show();
        }

        private void configuracionMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            FormConfiguracionMenu formConfiguracion = new FormConfiguracionMenu();
            formConfiguracion.Show();
        }


        private void verComunicadosMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            FormVerComunicados formComunicados = new FormVerComunicados();
            formComunicados.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
