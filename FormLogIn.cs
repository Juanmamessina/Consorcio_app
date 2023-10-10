using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppConsorcio
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

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

            // Valido que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return; // volver a preguntar
            }

            // Verificar si el usuario es "admin" y la contraseña es "a"
            if (usuarioIngresado == "admin" && contraseñaIngresada == "a")
            {
                // Si el usuario es "admin" y la contraseña es "a", abrir el formulario especifico del admin
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
                return;
            }

            try
            {
                // Cargar y analizar el archivo XML
                string xmlFilePath = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                // Obtener la lista de usuarios del XML
                List<Usuario> usuarios = new List<Usuario>();

                foreach (var usuarioElement in xmlDoc.Root.Elements("usuario"))
                {
                    string nombre = usuarioElement.Element("nombre").Value;
                    string contraseña = usuarioElement.Element("contraseña").Value;

                    usuarios.Add(new Usuario { usuario = nombre, contraseña = contraseña });
                }

                // Verificar si el usuario y la contraseña coinciden con los registros en el XML
                bool usuarioValido = false;

                foreach (var usuario in usuarios)
                {
                    if (usuario.usuario == usuarioIngresado && usuario.contraseña == contraseñaIngresada)
                    {
                        usuarioValido = true;
                        break;
                    }
                }

                if (usuarioValido)
                {
                    // Usuario y contraseña correctos, permitir el acceso
                    MessageBox.Show("El ingreso fue correcto");

                    // Cerrar el formulario actual (FormLogIn) y abrir el nuevo formulario (Menu)
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Usuario o contraseña incorrectos, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                }
            }
            catch (FileNotFoundException)
            {
                // Manejar el caso en el que el archivo XML no se encuentra
                MessageBox.Show("Archivo XML no encontrado.");
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Define una clase para representar la estructura del usuario en el XML
        private class Usuario
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
        }
    }
}
