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

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            if (File.Exists("comunicados.json"))
            {
                string json = File.ReadAllText("comunicados.json");
                comunicadosList = JsonConvert.DeserializeObject<List<Comunicado>>(json);

                LitBComunicados.Items.Clear();

                foreach (var comunicado in comunicadosList)
                {
                    // Usa el método ToString personalizado para formatear el comunicado
                    string comunicadoFormateado = comunicado.ToString();
                    LitBComunicados.Items.Add(comunicadoFormateado);
                }

                LitBComunicados.Visible = true;
            }
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario FormComunicados
            FormComunicadosMenu formComunicados = new FormComunicadosMenu();

            // Muestra el formulario como una ventana modal
            formComunicados.ShowDialog();
        }

    }
}

