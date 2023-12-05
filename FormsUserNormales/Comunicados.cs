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

namespace AppConsorcio.Forms
{
    public partial class Comunicados : Form
    {
        private List<Comunicado> comunicadosList = new List<Comunicado>();
        public Comunicados()
        {
            InitializeComponent();
            MostrarComunicados();
        }

        private void Comunicados_Load(object sender, EventArgs e)
        {

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
