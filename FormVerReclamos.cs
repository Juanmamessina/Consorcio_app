using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AppConsorcio
{
    public partial class FormVerReclamos : Form
    {
        

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

                // Deserializar en un Dictionary
                Dictionary<string, List<Reclamo>> reclamosDict = JsonConvert.DeserializeObject<Dictionary<string, List<Reclamo>>>(json);

                rtbReclamos.Clear();

                // Puedes iterar sobre el diccionario y trabajar con cada autor y sus reclamos
                foreach (var kvp in reclamosDict)
                {
                    string autor = kvp.Key;
                    List<Reclamo> reclamos = kvp.Value;

                    rtbReclamos.AppendText($"Autor: {autor}" + Environment.NewLine);

                    // Itera sobre los reclamos del autor
                    foreach (var reclamo in reclamos)
                    {
                        // Usa el método ToString personalizado para formatear el reclamo
                        string reclamoFormateado = reclamo.ToString();
                        rtbReclamos.AppendText($"  {reclamoFormateado}" + Environment.NewLine);
                    }
                }

                rtbReclamos.Visible = true;
            }
            else
            {
                rtbReclamos.AppendText("No hay reclamos disponibles." + Environment.NewLine);
                rtbReclamos.Visible = true;
            }
        }



    }
}

