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
            this.Close();

            FormVerComunicados formComunicados = new FormVerComunicados();
            formComunicados.Show();
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            this.Close();

            FormReclamosMenu formReclamos = new FormReclamosMenu();
            formReclamos.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Close();

            FormConfiguracionMenu formConfiguracion = new FormConfiguracionMenu();
            formConfiguracion.Show();
        }
    }
}
