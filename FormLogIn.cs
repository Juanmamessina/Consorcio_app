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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "Contrase�a")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "Contrase�a";
                txtContrase�a.ForeColor = Color.Silver;
                txtContrase�a.UseSystemPasswordChar = false;
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
            // Obtengo el user y la contrase�a ingresados por el usuario
            string usuarioIngresado = txtUsuario.Text;
            string contrase�aIngresada = txtContrase�a.Text;

            // Valido que las entradas no est�n vac�as
            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contrase�aIngresada))
            {
                MessageBox.Show("Por favor, ingrese usuario y contrase�a.");
                return; // volver a preguntar
            }

            // Verificar si el usuario es "admin" y la contrase�a es "a"
            if (usuarioIngresado == "admin" && contrase�aIngresada == "a")
            {
                // Si el usuario es "admin" y la contrase�a es "a", abrir el formulario especifico del admin
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
                    string contrase�a = usuarioElement.Element("contrase�a").Value;

                    usuarios.Add(new Usuario { usuario = nombre, contrase�a = contrase�a });
                }

                // Verificar si el usuario y la contrase�a coinciden con los registros en el XML
                bool usuarioValido = false;

                foreach (var usuario in usuarios)
                {
                    if (usuario.usuario == usuarioIngresado && usuario.contrase�a == contrase�aIngresada)
                    {
                        usuarioValido = true;
                        break;
                    }
                }

                if (usuarioValido)
                {
                    // Usuario y contrase�a correctos, permitir el acceso
                    MessageBox.Show("El ingreso fue correcto");

                    // Cerrar el formulario actual (FormLogIn) y abrir el nuevo formulario (Menu)
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Usuario o contrase�a incorrectos, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contrase�a incorrecta.");
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
            public string contrase�a { get; set; }
        }
    }
}
