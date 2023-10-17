using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AppConsorcio
{
    public partial class FormVerReclamos : Form
    {
        private List<Reclamo> reclamosList = new List<Reclamo>();

        public FormVerReclamos()
        {
            InitializeComponent();
            MostrarReclamos();
        }


        private void picMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();

            FormReclamosMenu formReclamosMenu = new FormReclamosMenu();
            formReclamosMenu.Show();
        }

        private void MostrarReclamos()
        {
            if (File.Exists("reclamos.json"))
            {
                string json = File.ReadAllText("reclamos.json");
                reclamosList = JsonConvert.DeserializeObject<List<Reclamo>>(json);

                rtbReclamos.Clear();

                foreach (var reclamo in reclamosList)
                {
                    // Usa el método ToString personalizado para formatear el reclamo
                    string reclamoFormateado = reclamo.ToString();
                    rtbReclamos.AppendText(reclamoFormateado + Environment.NewLine);
                }

                rtbReclamos.Visible = true;
            }
        }


    }
}

