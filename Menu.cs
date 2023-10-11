using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppConsorcio
{
    public partial class Menu : Form
    {
        private List<Comunicado> comunicadosList = new List<Comunicado>(); // Declarar la lista en el ámbito de la clase

        public Menu()
        {
            InitializeComponent();
        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            // Cargar los comunicados desde el archivo JSON
            if (File.Exists("comunicados.json"))
            {
                string json = File.ReadAllText("comunicados.json");
                comunicadosList = JsonConvert.DeserializeObject<List<Comunicado>>(json);

                // Desvincular la colección de datos del ComboBox
                cboComunicados.DataSource = null;

                // Cargar los comunicados en el ComboBox
                cboComunicados.Items.Clear(); // Limpia los elementos si es necesario
                foreach (var comunicado in comunicadosList)
                {
                    cboComunicados.Items.Add(comunicado.Contenido);
                }

                // Vuelve a vincular la colección de datos al ComboBox
                cboComunicados.DataSource = comunicadosList;
                cboComunicados.DisplayMember = "Contenido"; // Define la propiedad que se mostrará en el ComboBox
                cboComunicados.Visible = true;
            }
        }


        private void cboComunicados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice seleccionado
            int selectedIndex = cboComunicados.SelectedIndex;

            if (selectedIndex >= 0)
            {
                // Obtener el comunicado seleccionado de la lista de comunicados
                Comunicado seleccionado = comunicadosList[selectedIndex];

                // Mostrar el contenido del comunicado en un control (por ejemplo, un TextBox)
                cboComunicados.Text = seleccionado.Contenido;
            }
        }
    }
}

