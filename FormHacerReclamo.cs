using Clases;
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
        private string nombreUsuarioActual;

        public FormHacerReclamo()
        {
            InitializeComponent();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormReclamosMenu formReclamosMenu = new FormReclamosMenu();
            formReclamosMenu.Show();
        }

        private void btnPublicarReclamo_Click(object sender, EventArgs e)
        {
            string contenido = txtContenidoReclamo.Text.Trim();

            IOperacionesUsuario operacionesUsuario = new Usuario();
            bool reclamoPublicado = operacionesUsuario.PublicarReclamo(contenido, nombreUsuarioActual);

            if(reclamoPublicado == true)
            {
                MessageBox.Show("El reclamo fue publicado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormReclamosMenu formReclamosMenu = new FormReclamosMenu();
                formReclamosMenu.Show();
            } 
            else
            {
                MessageBox.Show("Por favor, ingresa el contenido del reclamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
