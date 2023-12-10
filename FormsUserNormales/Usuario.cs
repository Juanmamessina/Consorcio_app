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
    public partial class Usuario : Form
    {
        private string nombreUsuarioActual;
        private string contraseñaUsuarioActual;
        public Usuario()
        {
            InitializeComponent();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;
            contraseñaUsuarioActual = FormLogIn.ContraseñaUsuarioActual;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            LoadTheme();
            lblNombreDelUsuario.Text = nombreUsuarioActual;
            txtContraseñaUsuario.Text = contraseñaUsuarioActual;
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

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            txtContraseñaUsuario.PasswordChar = '\0';
        }


    }
}