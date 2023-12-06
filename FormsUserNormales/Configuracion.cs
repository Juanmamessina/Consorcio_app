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

namespace AppConsorcio.Forms
{
    public partial class Configuracion : Form
    {
        private string nombreUsuarioActual;
        public Configuracion()
        {
            InitializeComponent();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;
        }

        private void Configuracion_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void SetButtonColors(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ThemeColor.colorPrimario;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.colorSecundario;
                }

                // Llamada recursiva para los controles anidados
                SetButtonColors(ctrl);
            }
        }

        private void LoadTheme()
        {
            SetButtonColors(this);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual (Configuracion)
            this.Close();

            // Cerrar el formulario del menú principal
            MainMenu mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (mainMenu != null)
            {
                mainMenu.Close();
            }

            // Mostrar el formulario de inicio de sesión
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }

        private void btnCambiarUsuarioYContraseña_Click_1(object sender, EventArgs e)
        {
            // Mostrar los elementos solo si el evento fue desencadenado por el botón correcto
            if (sender == btnCambiarUsuarioYContraseña)
            {
                lblNuevoUsuario.Visible = true;
                txtUsuarioNuevo.Visible = true;
                lblNuevaContraseña.Visible = true;
                txtContraseñaNueva.Visible = true;
                btnConfirmarCambios.Visible = true;
                btnCerrarSesion.Visible = false;
                btnCambiarUsuarioYContraseña.Visible = false;

            }
        }
        private void btnConfirmarCambios_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario después de la pausa
            string nuevoUsuarioIngresado = txtUsuarioNuevo.Text;
            string nuevaContraseñaIngresada = txtContraseñaNueva.Text;

            IOperacionesUsuario operacionesUsuario = new MetodosUsuario();
            bool usuarioConContraseñaYNombreCambiado = operacionesUsuario.CambiarUsuarioYContraseña(nuevoUsuarioIngresado, nuevaContraseñaIngresada, nombreUsuarioActual);

            // Mostrar mensajes según el resultado
            if (usuarioConContraseñaYNombreCambiado)
            {
                // Éxito
                MessageBox.Show("Usuario y contraseña cambiados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainMenu mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
                if (mainMenu != null)
                {
                    mainMenu.Close();
                }

                // Mostrar el formulario de inicio de sesión
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
            }
            else
            {
                // Error
                MessageBox.Show("Error al cambiar el usuario y la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
