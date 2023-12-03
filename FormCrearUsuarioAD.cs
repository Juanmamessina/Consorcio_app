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
            string path = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";
            string nombreUsuarioNuevo = txtNombreUsuarioNuevo.Text;
            string contraseñaUsuarioNuevo = txtContraseñaUsuarioNuevo.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuarioNuevo) || string.IsNullOrWhiteSpace(contraseñaUsuarioNuevo))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.");
                return;
            }

            // Crear una instancia de la clase Usuario con los datos ingresados
            Usuario usuarioNuevo = new Usuario();
            
            usuarioNuevo.Nombre = nombreUsuarioNuevo;
            usuarioNuevo.Contraseña = contraseñaUsuarioNuevo;


            // Serializar el nuevo usuario
            SerializadoraXML<Usuario> serializadora = new SerializadoraXML<Usuario>(path);
            serializadora.Serializar(usuarioNuevo);
            //XDocument xmlDoc = XDocument.Load("C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml");

            //XElement usuarioElement = new XElement("usuario",
            //    new XElement("nombre", usuarioNuevo.Nombre),
            //    new XElement("contraseña", usuarioNuevo.Contraseña));

            //xmlDoc.Element("usuarios").Add(usuarioElement);
            //xmlDoc.Save("C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml");

            MessageBox.Show("Nuevo usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos de entrada
            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();
        }


    }
}
