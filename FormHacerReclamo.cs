using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AppConsorcio
{
    public partial class FormHacerReclamo : Form
    {
        private List<Reclamo> reclamosList = new List<Reclamo>();

        public FormHacerReclamo()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPublicarReclamo_Click(object sender, EventArgs e)
        {
            string contenido = txtContenidoReclamo.Text.Trim();

            if (string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Por favor, ingresa el contenido del reclamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar la lista de reclamos existente desde el archivo JSON
            if (File.Exists("reclamos.json"))
            {
                string json = File.ReadAllText("reclamos.json");
                reclamosList = JsonConvert.DeserializeObject<List<Reclamo>>(json);
            }

            // Crear un nuevo reclamo
            Reclamo nuevoReclamo = new Reclamo
            {
                Contenido = contenido,
                Fecha = DateTime.Now,
                Autor = "Administrador"
            };

            // Agregar el nuevo reclamo a la lista
            reclamosList.Add(nuevoReclamo);

            try
            {
                // Guardar la lista completa de reclamos en el archivo JSON
                string json = JsonConvert.SerializeObject(reclamosList);
                File.WriteAllText("reclamos.json", json);

                // Limpiar los campos de entrada
                txtContenidoReclamo.Clear();

                MessageBox.Show("El reclamo fue publicado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el reclamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
