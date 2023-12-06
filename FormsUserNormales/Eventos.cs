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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
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


    }
}
