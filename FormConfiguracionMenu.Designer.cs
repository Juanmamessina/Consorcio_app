namespace AppConsorcio
{
    partial class FormConfiguracionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracionMenu));
            btnCambiarUsuarioYcontraseña = new Button();
            btbCerrarSesion = new Button();
            picRegresar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // btnCambiarUsuarioYcontraseña
            // 
            btnCambiarUsuarioYcontraseña.BackColor = Color.Transparent;
            btnCambiarUsuarioYcontraseña.BackgroundImageLayout = ImageLayout.Center;
            btnCambiarUsuarioYcontraseña.Location = new Point(294, 155);
            btnCambiarUsuarioYcontraseña.Name = "btnCambiarUsuarioYcontraseña";
            btnCambiarUsuarioYcontraseña.Size = new Size(219, 32);
            btnCambiarUsuarioYcontraseña.TabIndex = 1;
            btnCambiarUsuarioYcontraseña.Text = "Cambiar usuario y contraseña";
            btnCambiarUsuarioYcontraseña.UseVisualStyleBackColor = false;
            btnCambiarUsuarioYcontraseña.Click += btnCambiarUsuarioYcontraseña_Click;
            // 
            // btbCerrarSesion
            // 
            btbCerrarSesion.BackColor = Color.Transparent;
            btbCerrarSesion.BackgroundImageLayout = ImageLayout.Center;
            btbCerrarSesion.Location = new Point(294, 231);
            btbCerrarSesion.Name = "btbCerrarSesion";
            btbCerrarSesion.Size = new Size(219, 32);
            btbCerrarSesion.TabIndex = 2;
            btbCerrarSesion.Text = "Cerrar sesion";
            btbCerrarSesion.UseVisualStyleBackColor = false;
            btbCerrarSesion.Click += btbCerrarSesion_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(65, 26);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 14;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(756, 26);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 15;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // FormConfiguracionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picRegresar);
            Controls.Add(btbCerrarSesion);
            Controls.Add(btnCambiarUsuarioYcontraseña);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfiguracionMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfiguracionMenu";
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCambiarUsuarioYcontraseña;
        private Button btbCerrarSesion;
        private PictureBox picRegresar;
        private PictureBox picMinimizar;
    }
}