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
            // Crea una instancia del formulario FormHacerReclamo
            FormHacerReclamo formHacerReclamos = new FormHacerReclamo();

            // Muestra el formulario como una ventana modal
            formHacerReclamos.ShowDialog();
        }

        private void btnVerReclamos_Click(object sender, EventArgs e)
        {
            FormVerReclamos formVerReclamos = new FormVerReclamos();
            formVerReclamos.ShowDialog();
        }
        private void picRegresar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();

            // Muestra el formulario principal (Menu)
            Menu menuForm = new Menu();
            menuForm.Show();
        }
    }
}
