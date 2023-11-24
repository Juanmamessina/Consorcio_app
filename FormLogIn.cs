using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using AppConsorcio;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Clases;

namespace AppConsorcio
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        public static string NombreUsuarioActual { get; private set; }

        //para poder arrastrar el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //hasta aca

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void IngresarClick(object sender, EventArgs e)
        {
            // Obtengo el user y la contraseña ingresados por el usuario
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;


            IOperacionesUsuario operacionesUsuario = new Usuario();
            bool usuarioValidado = operacionesUsuario.ValidarUsuario(usuarioIngresado, contraseñaIngresada);


            try
            {
                if (usuarioValidado == false)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return; // volver a preguntar
                }
                else if (usuarioValidado == true && usuarioIngresado != "admin")
                {
                    NombreUsuarioActual = usuarioIngresado;
                    MessageBox.Show("El ingreso fue exitoso");
                    this.Close();
                    MDImenu menu = new MDImenu();
                    menu.Show();
                }

                // Verificar si el usuario es "admin" y la contraseña es "a"
                if (usuarioIngresado == "admin" && contraseñaIngresada == "a")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    // Si el usuario es "admin" y la contraseña es "a", abrir el formulario especifico del admin
                    MenuAD formAdmin = new MenuAD();
                    formAdmin.ShowDialog();
                    return;
                }
            }
            catch (FileNotFoundException)
            {
                // Manejar el caso en el que el archivo XML no se encuentra
                MessageBox.Show("Error: archivo XML no encontrado.");
                return;
            }
            catch (XmlException ex)
            {
                // Manejar errores de análisis XML
                MessageBox.Show($"Error al analizar XML: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones inesperadas
                MessageBox.Show($"Error inesperado: {ex.Message}");
                return;
            }


        }
    }
}
