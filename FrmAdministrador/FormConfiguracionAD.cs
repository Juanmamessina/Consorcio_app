using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsorcio.FormsAdministrador
{
    public partial class FormConfiguracionAD : Form
    {
        public FormConfiguracionAD()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario del menú principal usando GENERICS
            AccionesFormulario<MainMenuAdministrador>.CerrarFormulario();

            // Mostrar el formulario de inicio de sesión
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
