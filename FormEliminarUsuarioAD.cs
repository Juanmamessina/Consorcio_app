using ClasesApp;
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

            // Ruta del archivo XML
            string path = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

            // Deserializar la lista actual de usuarios
            SerializadoraXML<Usuario> serializadora = new SerializadoraXML<Usuario>(path);
            List<Usuario> usuarios = serializadora.Deserializar();

            // Buscar el usuario en la lista
            Usuario usuarioAEliminar = usuarios.FirstOrDefault(u => u.Nombre == nombreUsuarioAEliminar);

            if (usuarioAEliminar != null)
            {
                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el usuario de la lista
                    usuarios.Remove(usuarioAEliminar);

                    // Serializar la lista actualizada de usuarios al archivo XML
                    serializadora.Serializar(usuarios);

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
                MessageBox.Show("El usuario especificado no fue encontrado en la lista de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
