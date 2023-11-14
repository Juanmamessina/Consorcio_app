using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using AppConsorcio;


namespace AppConsorcio
{
    public partial class FormEmitirComunicadosAD : Form
    {
        private List<Comunicado> comunicadosList = new List<Comunicado>();

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

            if (string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Por favor, ingresa el contenido del comunicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar la lista de comunicados existente desde el archivo JSON
            if (File.Exists("comunicados.json"))
            {
                string json = File.ReadAllText("comunicados.json");
                comunicadosList = JsonConvert.DeserializeObject<List<Comunicado>>(json);
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
                string json = JsonConvert.SerializeObject(comunicadosList);
                File.WriteAllText("comunicados.json", json);

                // Limpiar los campos de entrada
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
