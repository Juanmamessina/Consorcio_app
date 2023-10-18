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

            if (string.IsNullOrWhiteSpace(nombreUsuarioAEliminar))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario a eliminar.");
                return;
            }

            // Cargar y analizar el archivo XML
            string xmlFilePath = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";
            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            // Buscar el usuario en el archivo XML
            XElement usuarioAEliminar = xmlDoc.Root.Elements("usuario")
                .FirstOrDefault(u => u.Element("nombre").Value == nombreUsuarioAEliminar);

            if (usuarioAEliminar != null)
            {
                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el usuario del archivo XML
                    usuarioAEliminar.Remove();
                    xmlDoc.Save(xmlFilePath);

                    MessageBox.Show("El usuario ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el cuadro de texto después de la eliminación
                    txtNombreUsuarioAEliminar.Clear();
                }
                else
                {
                    MessageBox.Show("La eliminación ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El usuario especificado no fue encontrado en el archivo XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
