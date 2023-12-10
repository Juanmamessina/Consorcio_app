using ClasesApp;
using ClasesApp.metodos;
using ClasesApp.Interfaces;
using ClasesApp.Serializadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsorcio.Forms
{
    public partial class Reclamos : Form
    {
        private string nombreUsuarioActual;
        public Reclamos()
        {
            InitializeComponent();

            FormLogIn formLogIn = new FormLogIn();
            formLogIn.InformacionUsuarioEvent += ManejarInformacionUsuario;
        }
        private void ManejarInformacionUsuario(string usuario, string contraseña)
        {
            // Almacena la información en variables de clase
            nombreUsuarioActual = usuario;


            // Puedes realizar otras acciones aquí si es necesario
        }

        private void Reclamos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void SetButtonColors(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ThemeColor.colorPrimario;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.colorSecundario;
                }

                // Llamada recursiva para los controles anidados
                SetButtonColors(ctrl);
            }
        }
        private void LoadTheme()
        {
            SetButtonColors(this);
        }


        private void btnHacerReclamos_Click(object sender, EventArgs e)
        {
            if (sender == btnHacerReclamos)
            {
                lblEmitirReclamos.Visible = true;
                txtContenidoReclamo.Visible = true;
                btnPublicarReclamo.Visible = true;
                btnHacerReclamos.Visible = false;
                btnVerReclamo.Visible = false;
            }
        }

        private void btnPublicarReclamo_Click(object sender, EventArgs e)
        {
            string contenido = txtContenidoReclamo.Text.Trim();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;

            IOperacionesUsuario operacionesUsuario = new MetodosUsuario();
            bool reclamoPublicado = operacionesUsuario.PublicarReclamo(contenido, nombreUsuarioActual);

            if (reclamoPublicado == true)
            {
                MessageBox.Show("El reclamo fue publicado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el contenido del reclamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerReclamo_Click(object sender, EventArgs e)
        {
            if (sender == btnVerReclamo)
            {
                lblEmitirReclamos.Visible = false;
                txtContenidoReclamo.Visible = false;
                btnPublicarReclamo.Visible = false;
                btnHacerReclamos.Visible = false;
                btnVerReclamo.Visible = false;
                rtbReclamos.Visible = true;
            }

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
