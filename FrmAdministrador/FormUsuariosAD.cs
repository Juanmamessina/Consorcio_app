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

namespace AppConsorcio.FormsAdministrador
{
    public partial class FormUsuariosAD : Form
    {
        public FormUsuariosAD()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {
            if (sender == btnCrearUsuario)
            {
                btnCrearUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                btnCrear.Visible = true;
                label1.Visible = true;
                lblEmitirComunicados.Visible = true;
                txtNombreUsuarioNuevo.Visible = true;
                txtContraseñaUsuarioNuevo.Visible = true;
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            string nombreUsuarioNuevo = txtNombreUsuarioNuevo.Text;
            string contraseñaUsuarioNuevo = txtContraseñaUsuarioNuevo.Text;

            IOperacionesAdministrador operacionesAdministrador = new MetodosAdministrador();
            bool usuarioCreado = operacionesAdministrador.CrearUsuario(nombreUsuarioNuevo, contraseñaUsuarioNuevo);

            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();

            if (usuarioCreado == true)
            {
                MessageBox.Show("Nuevo usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Limpiar los campos de entrada
            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            btnCrearUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnCrear.Visible = false;
            label1.Visible = false;
            lblEmitirComunicados.Visible = false;
            txtNombreUsuarioNuevo.Visible = false;
            txtContraseñaUsuarioNuevo.Visible = false;
            lblNombreUsuarioAEliminar.Visible = true;
            txtNombreUsuarioAEliminar.Visible = true;
            btnEliminarUsuarioAD.Visible = true;
        }

        private void btnEliminarUsuarioAD_Click(object sender, EventArgs e)
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
