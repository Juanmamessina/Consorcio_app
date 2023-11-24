using AppConsorcio;
using Clases;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AppConsorcio
{
    public partial class FormCambiarUsuarioYContraseña : Form
    {
        private string nombreUsuarioActual;

        public FormCambiarUsuarioYContraseña()
        {
            InitializeComponent();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormConfiguracionMenu formConfiguracion = new FormConfiguracionMenu();
            formConfiguracion.Show();
        }

        private void btnCambiarUsuarioYContraseña_Click(object sender, EventArgs e)
        {
            // Obtengo el usuario y la contraseña nuevas ingresados por el usuario
            string nuevoUsuarioIngresado = txtUsuarioNuevo.Text;
            string nuevaContraseñaIngresada = txtContraseñaNueva.Text;

            IOperacionesUsuario operacionesUsuario = new Usuario();
            bool usuarioConContraseñaYnombreCambiado = operacionesUsuario.CambiarUsuarioYContraseña(nuevoUsuarioIngresado, nuevaContraseñaIngresada, nombreUsuarioActual);

            if (usuarioConContraseñaYnombreCambiado == true)
            {
                // Éxito
                MessageBox.Show("Usuario y contraseña cambiados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormLogIn login = new FormLogIn();
                login.Show();
            }
            else
            {
                // Error
                MessageBox.Show("Error al cambiar el usuario y la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
