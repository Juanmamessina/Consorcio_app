using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO; // Asegúrate de importar la referencia para trabajar con archivos

namespace AppConsorcio
{
    public partial class FormEmitirComunicados : Form
    {
        // Declarar una lista para almacenar los comunicados
        private List<Comunicado> comunicadosList = new List<Comunicado>();

        public FormEmitirComunicados()
        {
            InitializeComponent();
        }

        private void btnPublicarComunicado_Click(object sender, EventArgs e)
        {
            // Crear un nuevo comunicado
            Comunicado nuevoComunicado = new Comunicado
            {
                Contenido = txtContenido.Text,
                Fecha = DateTime.Now,
                Autor = "Administrador"
            };

            // Agregar el comunicado a la lista
            comunicadosList.Add(nuevoComunicado);

            // Guardar la lista en un archivo JSON
            string json = JsonConvert.SerializeObject(comunicadosList);
            File.WriteAllText("comunicados.json", json);

            // Limpiar los campos de entrada

            txtContenido.Clear();
        }
    }
}
