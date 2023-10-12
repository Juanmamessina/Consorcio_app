﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsorcio
{
    public partial class FormComunicadosMenu : Form
    {
        public FormComunicadosMenu()
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
            // Crea una instancia del formulario FormComunicados
            FormHacerReclamo formHacerReclamos = new FormHacerReclamo();

            // Muestra el formulario como una ventana modal
            formHacerReclamos.ShowDialog();
        }
    }
}