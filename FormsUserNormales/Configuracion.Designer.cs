namespace AppConsorcio.Forms
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrarSesion = new Button();
            panel1 = new Panel();
            txtUsuarioNuevo = new TextBox();
            txtContraseñaNueva = new TextBox();
            btnConfirmarCambios = new Button();
            btnCambiarUsuarioYContraseña = new Button();
            lblNuevaContraseña = new Label();
            lblNuevoUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.None;
            btnCerrarSesion.BackColor = Color.FromArgb(51, 51, 76);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(410, 311);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(223, 30);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(txtUsuarioNuevo);
            panel1.Controls.Add(txtContraseñaNueva);
            panel1.Controls.Add(btnConfirmarCambios);
            panel1.Controls.Add(btnCambiarUsuarioYContraseña);
            panel1.Controls.Add(lblNuevaContraseña);
            panel1.Controls.Add(lblNuevoUsuario);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.Anchor = AnchorStyles.None;
            txtUsuarioNuevo.Location = new Point(294, 167);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.Size = new Size(464, 23);
            txtUsuarioNuevo.TabIndex = 8;
            txtUsuarioNuevo.Visible = false;
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.Anchor = AnchorStyles.None;
            txtContraseñaNueva.Location = new Point(294, 231);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(464, 23);
            txtContraseñaNueva.TabIndex = 10;
            txtContraseñaNueva.Visible = false;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Anchor = AnchorStyles.None;
            btnConfirmarCambios.BackColor = Color.FromArgb(51, 51, 76);
            btnConfirmarCambios.FlatAppearance.BorderSize = 0;
            btnConfirmarCambios.FlatStyle = FlatStyle.Popup;
            btnConfirmarCambios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarCambios.ForeColor = Color.Gainsboro;
            btnConfirmarCambios.Location = new Point(410, 275);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(223, 30);
            btnConfirmarCambios.TabIndex = 12;
            btnConfirmarCambios.Text = "Confirmar cambios";
            btnConfirmarCambios.UseVisualStyleBackColor = false;
            btnConfirmarCambios.Visible = false;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click_1;
            // 
            // btnCambiarUsuarioYContraseña
            // 
            btnCambiarUsuarioYContraseña.Anchor = AnchorStyles.None;
            btnCambiarUsuarioYContraseña.BackColor = Color.FromArgb(51, 51, 76);
            btnCambiarUsuarioYContraseña.FlatAppearance.BorderSize = 0;
            btnCambiarUsuarioYContraseña.FlatStyle = FlatStyle.Popup;
            btnCambiarUsuarioYContraseña.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarUsuarioYContraseña.ForeColor = Color.Gainsboro;
            btnCambiarUsuarioYContraseña.Location = new Point(410, 224);
            btnCambiarUsuarioYContraseña.Name = "btnCambiarUsuarioYContraseña";
            btnCambiarUsuarioYContraseña.Size = new Size(223, 30);
            btnCambiarUsuarioYContraseña.TabIndex = 11;
            btnCambiarUsuarioYContraseña.Text = "Cambiar usuario y contraseña";
            btnCambiarUsuarioYContraseña.UseVisualStyleBackColor = false;
            btnCambiarUsuarioYContraseña.Click += btnCambiarUsuarioYContraseña_Click_1;
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.Anchor = AnchorStyles.None;
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.BackColor = Color.Transparent;
            lblNuevaContraseña.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaContraseña.ForeColor = Color.White;
            lblNuevaContraseña.Location = new Point(435, 193);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(198, 70);
            lblNuevaContraseña.TabIndex = 9;
            lblNuevaContraseña.Text = "Nueva contraseña:\r\n\r\n";
            lblNuevaContraseña.Visible = false;
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.Anchor = AnchorStyles.None;
            lblNuevoUsuario.AutoSize = true;
            lblNuevoUsuario.BackColor = Color.Transparent;
            lblNuevoUsuario.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevoUsuario.ForeColor = Color.White;
            lblNuevoUsuario.Location = new Point(435, 120);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(166, 70);
            lblNuevoUsuario.TabIndex = 7;
            lblNuevoUsuario.Text = "Nuevo usuario:\r\n\r\n";
            lblNuevoUsuario.Visible = false;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Configuracion";
            Text = "Configuracion";
            Load += Configuracion_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCerrarSesion;
        private Panel panel1;
        private TextBox txtContraseñaNueva;
        private Label lblNuevaContraseña;
        private TextBox txtUsuarioNuevo;
        private Label lblNuevoUsuario;
        private Button btnConfirmarCambios;
        private Button btnCambiarUsuarioYContraseña;
    }
}