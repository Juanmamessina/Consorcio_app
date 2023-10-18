﻿using AppConsorcio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppConsorcio
{
    public partial class FormCrearUsuarioAD : Form
    {
        public FormCrearUsuarioAD()
        {
            InitializeComponent();
        }
        private void picRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormEditarUsuariosMenuAD formEditarUsuariosMenu = new FormEditarUsuariosMenuAD();
            formEditarUsuariosMenu.Show();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuarioNuevo = txtNombreUsuarioNuevo.Text;
            string contraseñaUsuarioNuevo = txtContraseñaUsuarioNuevo.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuarioNuevo) || string.IsNullOrWhiteSpace(contraseñaUsuarioNuevo))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.");
                return;
            }

            // Crear una instancia de la clase Usuario con los datos ingresados
            Usuario usuarioNuevo = new Usuario
            {
                nombre = nombreUsuarioNuevo,
                contraseña = contraseñaUsuarioNuevo,
            };

            XDocument xmlDoc = XDocument.Load("C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml");

            XElement usuarioElement = new XElement("usuario",
                new XElement("nombre", usuarioNuevo.nombre),
                new XElement("contraseña", usuarioNuevo.contraseña));

            xmlDoc.Element("usuarios").Add(usuarioElement);
            xmlDoc.Save("C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml");

            MessageBox.Show("Nuevo usuario creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos de entrada
            txtNombreUsuarioNuevo.Clear();
            txtContraseñaUsuarioNuevo.Clear();
        }


    }
}
