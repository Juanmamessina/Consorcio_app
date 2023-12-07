using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsorcio
{
    public partial class MainMenuAdministrador : Form
    {
        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form formActivo;

        //constructor
        public MainMenuAdministrador()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnCloseChildFormAD.Visible = false;
            //usuario = new Usuario();
            //lblCategoria.Text = usuario.Categoria();

        }

        //para poder arrastrar el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaptureAD();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessageAD(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        //metodos

        //elijo color random

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTituloAD.BackColor = color;
                    panelLogoAD.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.colorPrimario = color;
                    ThemeColor.colorSecundario = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildFormAD.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control botonPrevio in panelMenuAD.Controls)
            {
                if (botonPrevio.GetType() == typeof(Button))
                {
                    botonPrevio.BackColor = Color.FromArgb(51, 51, 76);
                    botonPrevio.ForeColor = Color.Gainsboro;
                    botonPrevio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildFormAD(Form childForm, Object btnsender)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            ActivateButton(btnsender);
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHomeAD.Controls.Add(childForm);
            this.panelHomeAD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloAD.Text = childForm.Text;
        }

        private void panelTituloAD_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCaptureAD();
            SendMessageAD(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAD.Text = DateTime.Now.ToString("HH:mm:ss");

            // Actualiza la etiqueta de la fecha con la fecha actual formateada
            lblFechaAD.Text = DateTime.Now.ToString("dddd d 'de' MMMM 'del' yyyy");
        }
        private void btnCerrarAD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizarAD_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizarAD_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUsuariosAD_Click(object sender, EventArgs e)
        {
            OpenChildFormAD(new FormsAdministrador.FormUsuariosAD(), sender);
        }

        private void btnComunicadosAD_Click(object sender, EventArgs e)
        {
            OpenChildFormAD(new FormsAdministrador.FormsComunicadosAD(), sender);
        }

        private void btnConfiguracionAD_Click(object sender, EventArgs e)
        {
            OpenChildFormAD(new FormsAdministrador.FormConfiguracionAD(), sender);
        }

        private void btnCloseChildFormAD_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
                formActivo.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTituloAD.Text = "HOME";
            panelTituloAD.BackColor = Color.FromArgb(0, 150, 136);
            panelLogoAD.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildFormAD.Visible = false;
        }


    }

}
