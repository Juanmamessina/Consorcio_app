using ClasesApp.Interfaces;
using ClasesApp.metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesApp;

namespace AppConsorcio.FormsAdministrador
{
    public partial class FormUsuariosAD : Form
    {
        private List<Usuario> ListadeUsuariosparaDataGrid;
        public FormUsuariosAD()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {
            if (sender == btnCrearUsuario)
            {
                btnCrearUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                btnCrear.Visible = true;
                label1.Visible = true;
                lblEmitirComunicados.Visible = true;
                txtNombreUsuarioNuevo.Visible = true;
                txtContraseñaUsuarioNuevo.Visible = true;
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            string nombreUsuarioNuevo = txtNombreUsuarioNuevo.Text;
            string contraseñaUsuarioNuevo = txtContraseñaUsuarioNuevo.Text;

            IOperacionesAdministrador operacionesAdministrador = new MetodosAdministrador();
            bool usuarioCreado = operacionesAdministrador.CrearUsuario(nombreUsuarioNuevo, contraseñaUsuarioNuevo);

            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();

            if (usuarioCreado == true)
            {
                MessageBox.Show("Nuevo usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Limpiar los campos de entrada
            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            btnCrearUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnCrear.Visible = false;
            label1.Visible = false;
            lblEmitirComunicados.Visible = false;
            txtNombreUsuarioNuevo.Visible = false;
            txtContraseñaUsuarioNuevo.Visible = false;
            lblNombreUsuarioAEliminar.Visible = true;
            txtNombreUsuarioAEliminar.Visible = true;
            btnEliminarUsuarioAD.Visible = true;
        }

        private void btnEliminarUsuarioAD_Click(object sender, EventArgs e)
        {
            string nombreUsuarioAEliminar = txtNombreUsuarioAEliminar.Text.Trim();

            DB.Delete(nombreUsuarioAEliminar);

            IOperacionesAdministrador operacionesAdministrador = new MetodosAdministrador();
            bool usuarioEliminado = operacionesAdministrador.EliminarUsuario(nombreUsuarioAEliminar);

            if (usuarioEliminado == true)
            {
                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido elimianr el usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnVerUsuariosRegistrados_Click(object sender, EventArgs e)
        {

            btnCrearUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnCrear.Visible = false;
            label1.Visible = false;
            lblEmitirComunicados.Visible = false;
            txtNombreUsuarioNuevo.Visible = false;
            txtContraseñaUsuarioNuevo.Visible = false;
            lblNombreUsuarioAEliminar.Visible = false;
            txtNombreUsuarioAEliminar.Visible = false;
            btnEliminarUsuarioAD.Visible = false;

            btnVerUsuariosRegistrados.Visible = false;

            cargando_gif.Image = System.Drawing.Image.FromFile(@"C:\Users\Juanma\Desktop\CONSORCIOFINAL\Consorcio_app\Resources\gifLoading.gif");
            cargando_gif.BackColor = Color.DarkGray;

            cargando_gif.Visible = !cargando_gif.Visible;//si esta invisible lo vuelve visible
            await Task.Delay(5500);
            cargando_gif.Visible = false;

            dataGridView1.Visible = true;

            dataGridView1.AutoGenerateColumns = true;
            ListadeUsuariosparaDataGrid = await DB.SelectAsync();
            dataGridView1.DataSource = ListadeUsuariosparaDataGrid;
            dataGridView1.Columns["Nombre"].Width = 200;
            dataGridView1.Columns["Contraseña"].Width = 225;
        }
    }
}
