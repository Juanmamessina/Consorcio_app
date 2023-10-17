using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO; // Añade esta línea para usar System.IO
using System.Windows.Forms;

namespace AppConsorcio
{
    public partial class FormReclamosMenu : Form
    {
        private List<Reclamo> reclamosList = new List<Reclamo>(); // Agrega la definición de la lista de reclamos

        public FormReclamosMenu()
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

        private void btnHacerReclamo_Click(object sender, EventArgs e)
        {
            this.Close();
            
            FormHacerReclamo formHacerReclamos = new FormHacerReclamo();
            formHacerReclamos.Show();
        }

        private void btnVerReclamos_Click(object sender, EventArgs e)
        {
            this.Close();

            FormVerReclamos formVerReclamos = new FormVerReclamos();
            formVerReclamos.Show();
        }
        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            Menu formMenu = new Menu();
            formMenu.Show();
        }
    }
}
