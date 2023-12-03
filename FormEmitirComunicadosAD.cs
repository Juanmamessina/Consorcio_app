using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using AppConsorcio;
using ClasesApp;

namespace AppConsorcio
{
    public partial class FormEmitirComunicadosAD : Form 
    {
        

        public FormEmitirComunicadosAD()
        {
            InitializeComponent();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            MenuAD formAdmin = new MenuAD();
            formAdmin.Show();
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
