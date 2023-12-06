using AppConsorcio;
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
using ClasesApp;
using ClasesApp.Serializadoras;
using ClasesApp.Interfaces;
using ClasesApp.metodos;

namespace AppConsorcio
{
    public partial class FormCrearUsuarioAD : Form
    {
        public FormCrearUsuarioAD()
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

        public void btnCrearUsuario_Click(object sender, EventArgs e)
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



    }
}
