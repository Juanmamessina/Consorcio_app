using ClasesApp.Interfaces;
using ClasesApp.metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppConsorcio
{
    public partial class FormEliminarUsuarioAD : Form
    {
        public FormEliminarUsuarioAD()
        {
            InitializeComponent();
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormEditarUsuariosMenuAD formEditarUsuariosMenu = new FormEditarUsuariosMenuAD();
            formEditarUsuariosMenu.Show();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuarioAEliminar = txtNombreUsuarioAEliminar.Text.Trim();

            IOperacionesAdministrador operacionesAdministrador = new MetodosAdministrador();
            bool usuarioEliminado = operacionesAdministrador.EliminarUsuario(nombreUsuarioAEliminar);

            if (usuarioEliminado == true)
            {
                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido elimianr el usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
