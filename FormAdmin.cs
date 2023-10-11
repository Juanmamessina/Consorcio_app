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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
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

        private void btnEmitirComunicados_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormEmitirComunicados
            FormEmitirComunicados formEmitirComunicados = new FormEmitirComunicados();

            // Mostrar el nuevo formulario
            formEmitirComunicados.Show();
        }

    }
}