namespace AppConsorcio
{
    partial class FormCambiarUsuarioYContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarUsuarioYContraseña));
            lblEmitirReclamos = new Label();
            txtUsuarioNuevo = new TextBox();
            label1 = new Label();
            txtContraseñaNueva = new TextBox();
            btnCambiarUsuarioYContraseña = new Button();
            picMinimizar = new PictureBox();
            picRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            SuspendLayout();
            // 
            // lblEmitirReclamos
            // 
            lblEmitirReclamos.AutoSize = true;
            lblEmitirReclamos.BackColor = Color.Transparent;
            lblEmitirReclamos.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirReclamos.ForeColor = Color.White;
            lblEmitirReclamos.Location = new Point(317, 95);
            lblEmitirReclamos.Name = "lblEmitirReclamos";
            lblEmitirReclamos.Size = new Size(166, 70);
            lblEmitirReclamos.TabIndex = 2;
            lblEmitirReclamos.Text = "Nuevo usuario:\r\n\r\n";
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.Location = new Point(169, 131);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.Size = new Size(464, 23);
            txtUsuarioNuevo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(317, 165);
            label1.Name = "label1";
            label1.Size = new Size(198, 70);
            label1.TabIndex = 4;
            label1.Text = "Nueva contraseña:\r\n\r\n";
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.Location = new Point(169, 212);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(464, 23);
            txtContraseñaNueva.TabIndex = 5;
            // 
            // btnCambiarUsuarioYContraseña
            // 
            btnCambiarUsuarioYContraseña.BackColor = Color.MidnightBlue;
            btnCambiarUsuarioYContraseña.FlatStyle = FlatStyle.Popup;
            btnCambiarUsuarioYContraseña.ForeColor = Color.White;
            btnCambiarUsuarioYContraseña.Location = new Point(169, 283);
            btnCambiarUsuarioYContraseña.Name = "btnCambiarUsuarioYContraseña";
            btnCambiarUsuarioYContraseña.Size = new Size(464, 26);
            btnCambiarUsuarioYContraseña.TabIndex = 6;
            btnCambiarUsuarioYContraseña.Text = "Cambiar";
            btnCambiarUsuarioYContraseña.UseVisualStyleBackColor = false;
            btnCambiarUsuarioYContraseña.Click += btnCambiarUsuarioYContraseña_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(762, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 10;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(74, 12);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 13;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // FormCambiarUsuarioYContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picRegresar);
            Controls.Add(picMinimizar);
            Controls.Add(btnCambiarUsuarioYContraseña);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(label1);
            Controls.Add(txtUsuarioNuevo);
            Controls.Add(lblEmitirReclamos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCambiarUsuarioYContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCambiarUsuarioYContraseña";
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmitirReclamos;
        private TextBox txtUsuarioNuevo;
        private Label label1;
        private TextBox txtContraseñaNueva;
        private Button btnCambiarUsuarioYContraseña;
        private PictureBox picMinimizar;
        private PictureBox picRegresar;
    }
}