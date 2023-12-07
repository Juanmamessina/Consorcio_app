using ClasesApp.Interfaces;
using ClasesApp.Serializadoras;
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

namespace AppConsorcio.FormsAdministrador
{
    public partial class FormsComunicadosAD : Form
    {
        public FormsComunicadosAD()
        {
            InitializeComponent();
        }

        private void btnPublicarComunicado_Click(object sender, EventArgs e)
        {
            string contenido = txtContenido.Text.Trim();
            string path = "comunicados.json";

            if (string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Por favor, ingresa el contenido del comunicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Comunicado> comunicadosList;

            // Cargar la lista de comunicados existente desde el archivo JSON
            if (File.Exists(path))
            {
                ISerializable<Comunicado> serializableComunicados = new SerializadoraJSON<Comunicado>(path);
                comunicadosList = serializableComunicados.Deserializar();
            }
            else
            {
                comunicadosList = new List<Comunicado>();
            }

            // Crear un nuevo comunicado
            Comunicado nuevoComunicado = new Comunicado
            {
                Contenido = contenido,
                Fecha = DateTime.Now,
                Autor = "Administrador"
            };

            // Agregar el nuevo comunicado a la lista
            comunicadosList.Add(nuevoComunicado);

            try
            {
                // Guardar la lista completa de comunicados en el archivo JSON
                ISerializable<Comunicado> serializableComunicado = new SerializadoraJSON<Comunicado>(path);
                serializableComunicado.Serializar(comunicadosList);

                txtContenido.Clear();

                MessageBox.Show("El comunicado fue publicado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el comunicado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
