using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
using ClasesApp;

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

            string path = "reclamos.json";

            if (File.Exists(path))
            {
                

                // Deserializar en una lista de Reclamo
                ISerializable<Reclamo> serializableReclamos = new SerializadoraJSON<Reclamo>(path);
                List<Reclamo> listaReclamos = serializableReclamos.Deserializar();

                if (listaReclamos != null && listaReclamos.Any())
                {
                    foreach (var reclamo in listaReclamos)
                    {
                        string reclamoFormateado = reclamo.ToString();
                        rtbReclamos.AppendText($"{reclamoFormateado}" + Environment.NewLine);
                    }
                }
                else
                {
                    rtbReclamos.AppendText("No hay reclamos disponibles." + Environment.NewLine);
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

