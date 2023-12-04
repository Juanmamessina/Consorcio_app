using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using ClasesApp;

namespace AppConsorcio
{
    public partial class FormVerComunicados : Form
    {
        private List<Comunicado> comunicadosList = new List<Comunicado>();

        public FormVerComunicados()
        {
            InitializeComponent();
            MostrarComunicados();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();

            // Crea una instancia del formulario de menú y lo muestra
            MDImenu menu = new MDImenu();
            menu.Show();
        }


        private void MostrarComunicados()
        {
            // Ruta del archivo JSON
            string path = "comunicados.json";

            // Verificar si el archivo JSON existe
            if (File.Exists(path))
            {
                // Deserializar la lista de comunicados utilizando tu serializadora
                SerializadoraJSON<Comunicado> serializadora = new SerializadoraJSON<Comunicado>(path);
                List<Comunicado> comunicadosList = serializadora.Deserializar();

                // Limpia el RichTextBox antes de mostrar los mensajes
                rtbComunicados.Clear();

                foreach (var comunicado in comunicadosList)
                {
                    // Usa el método ToString personalizado para formatear el comunicado
                    string comunicadoFormateado = comunicado.ToString();
                    rtbComunicados.AppendText(comunicadoFormateado + Environment.NewLine);
                }

                rtbComunicados.Visible = true;
            }
        }


    }
}
