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
    public partial class FormEditarUsuariosMenuAD : Form
    {
        public FormEditarUsuariosMenuAD()
        {
            InitializeComponent();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            MenuAD formAdmin = new MenuAD();
            formAdmin.Show();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Close();

            FormCrearUsuarioAD formCrearUsuarioAD = new FormCrearUsuarioAD();
            formCrearUsuarioAD.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();

            FormEliminarUsuarioAD formEliminarUsuarioAD = new FormEliminarUsuarioAD();
            formEliminarUsuarioAD.Show();
        }
    }
}
