using AppConsorcio.Clases;
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
            nombreUsuarioActual = FormLogIn.nombreUsuarioActual;
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

            // Valido que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(nuevoUsuarioIngresado) || string.IsNullOrWhiteSpace(nuevaContraseñaIngresada))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña nuevas.");
                return; // volver a preguntar
            }
            
            // Cargar y analizar el archivo XML
            string xmlFilePath = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            // Obtener la lista de usuarios del XML
            List<Usuario> usuarios = new List<Usuario>();

            foreach (var usuarioElement in xmlDoc.Root.Elements("usuario"))
            {
                string nombre = usuarioElement.Element("nombre").Value;
                string contraseña = usuarioElement.Element("contraseña").Value;

                usuarios.Add(new Usuario { nombre = nombre, contraseña = contraseña });
            }

            // Encuentra y modifica al usuario actual
            Usuario usuarioActual = usuarios.Find(u => u.nombre == nombreUsuarioActual);

            if (usuarioActual != null)
            {
                // Modifica el nombre y la contraseña del usuario
                usuarioActual.nombre = nuevoUsuarioIngresado;
                usuarioActual.contraseña = nuevaContraseñaIngresada;

                // Guarda la información actualizada en el archivo XML
                xmlDoc.Root.Elements("usuario")
                    .First(u => u.Element("nombre").Value == nombreUsuarioActual)
                    .SetElementValue("nombre", nuevoUsuarioIngresado);

                xmlDoc.Root.Elements("usuario")
                    .First(u => u.Element("nombre").Value == nuevoUsuarioIngresado)
                    .SetElementValue("contraseña", nuevaContraseñaIngresada);

                xmlDoc.Save(xmlFilePath);

                MessageBox.Show("Usuario y contraseña cambiados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // el usuario no fue encontrado
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
