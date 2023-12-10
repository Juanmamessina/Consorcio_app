using AppConsorcio.Forms;
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
    public partial class MainMenu : Form
    {

        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form formActivo;
        Usuario usuario;


        //constructor
        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnCloseChildForm.Visible = false;
            //usuario = new Usuario();
            //lblCategoria.Text = usuario.Categoria();

        }

        //para poder arrastrar el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



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
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.colorPrimario = color;
                    ThemeColor.colorSecundario = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control botonPrevio in panelMenu.Controls)
            {
                if (botonPrevio.GetType() == typeof(Button))
                {
                    botonPrevio.BackColor = Color.FromArgb(51, 51, 76);
                    botonPrevio.ForeColor = Color.Gainsboro;
                    botonPrevio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, Object btnsender)
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
            this.panelHome.Controls.Add(childForm);
            this.panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            // Actualiza la etiqueta de la fecha con la fecha actual formateada
            lblFecha.Text = DateTime.Now.ToString("dddd d 'de' MMMM 'del' yyyy");
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Usuario(), sender);
        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Comunicados(), sender);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reclamos(), sender);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Eventos(), sender);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Configuracion(), sender);
        }



        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
                formActivo.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitulo.Text = "HOME";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}