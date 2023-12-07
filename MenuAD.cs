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
    public partial class MenuAD : Form
    {
        public MenuAD()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEmitirComunicados_Click(object sender, EventArgs e)
        {
            this.Close();

            FormEmitirComunicadosAD formEmitirComunicados = new FormEmitirComunicadosAD();
            formEmitirComunicados.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            //FormEditarUsuariosMenuAD formEditarUsuariosMenu = new FormEditarUsuariosMenuAD();
            //formEditarUsuariosMenu.Show();
        }
    }
}
