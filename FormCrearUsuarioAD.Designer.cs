namespace AppConsorcio
{
    partial class FormCrearUsuarioAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearUsuarioAD));
            lblEmitirComunicados = new Label();
            txtNombreUsuarioNuevo = new TextBox();
            label1 = new Label();
            txtContraseñaUsuarioNuevo = new TextBox();
            btnCrearUsuario = new Button();
            picRegresar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // lblEmitirComunicados
            // 
            lblEmitirComunicados.AutoSize = true;
            lblEmitirComunicados.BackColor = Color.Transparent;
            lblEmitirComunicados.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirComunicados.ForeColor = Color.White;
            lblEmitirComunicados.Location = new Point(207, 106);
            lblEmitirComunicados.Name = "lblEmitirComunicados";
            lblEmitirComunicados.Size = new Size(375, 35);
            lblEmitirComunicados.TabIndex = 1;
            lblEmitirComunicados.Text = "Nombre del usuario que desee crear:";
            // 
            // txtNombreUsuarioNuevo
            // 
            txtNombreUsuarioNuevo.Location = new Point(151, 164);
            txtNombreUsuarioNuevo.Name = "txtNombreUsuarioNuevo";
            txtNombreUsuarioNuevo.Size = new Size(464, 23);
            txtNombreUsuarioNuevo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 210);
            label1.Name = "label1";
            label1.Size = new Size(299, 35);
            label1.TabIndex = 3;
            label1.Text = "Contraseña que quiera darle:";
            // 
            // txtContraseñaUsuarioNuevo
            // 
            txtContraseñaUsuarioNuevo.Location = new Point(151, 260);
            txtContraseñaUsuarioNuevo.Name = "txtContraseñaUsuarioNuevo";
            txtContraseñaUsuarioNuevo.Size = new Size(464, 23);
            txtContraseñaUsuarioNuevo.TabIndex = 4;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.Crimson;
            btnCrearUsuario.FlatStyle = FlatStyle.Popup;
            btnCrearUsuario.Location = new Point(151, 339);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(464, 23);
            btnCrearUsuario.TabIndex = 15;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(50, 24);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 16;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(752, 24);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 17;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // FormCrearUsuarioAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picRegresar);
            Controls.Add(btnCrearUsuario);
            Controls.Add(txtContraseñaUsuarioNuevo);
            Controls.Add(label1);
            Controls.Add(txtNombreUsuarioNuevo);
            Controls.Add(lblEmitirComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrearUsuarioAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrearUsuarioAD";
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmitirComunicados;
        private TextBox txtNombreUsuarioNuevo;
        private Label label1;
        private TextBox txtContraseñaUsuarioNuevo;
        private Button btnCrearUsuario;
        private PictureBox picRegresar;
        private PictureBox picMinimizar;
    }
}