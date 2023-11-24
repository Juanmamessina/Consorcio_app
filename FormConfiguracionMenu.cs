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
    public partial class FormConfiguracionMenu : Form
    {
        public FormConfiguracionMenu()
        {
            InitializeComponent();
        }

        private void btbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }

        private void btnCambiarUsuarioYcontraseña_Click(object sender, EventArgs e)
        {
            this.Close();

            FormCambiarUsuarioYContraseña formCambiar = new FormCambiarUsuarioYContraseña();
            formCambiar.Show();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            MDImenu menu = new MDImenu();
            menu.Show();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
