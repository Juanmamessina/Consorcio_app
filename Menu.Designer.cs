namespace AppConsorcio
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnComunicados = new Button();
            btnReclamos = new Button();
            btnConfiguracion = new Button();
            lbl1 = new Label();
            comunicadoBindingSource = new BindingSource(components);
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)comunicadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // btnComunicados
            // 
            btnComunicados.BackColor = Color.Transparent;
            btnComunicados.BackgroundImageLayout = ImageLayout.Center;
            btnComunicados.Location = new Point(300, 166);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Size = new Size(219, 32);
            btnComunicados.TabIndex = 0;
            btnComunicados.Text = "Comunicados";
            btnComunicados.UseVisualStyleBackColor = false;
            btnComunicados.Click += btnComunicados_Click;
            // 
            // btnReclamos
            // 
            btnReclamos.BackColor = Color.Transparent;
            btnReclamos.BackgroundImageLayout = ImageLayout.Center;
            btnReclamos.Location = new Point(300, 231);
            btnReclamos.Name = "btnReclamos";
            btnReclamos.Size = new Size(219, 32);
            btnReclamos.TabIndex = 2;
            btnReclamos.Text = "Reclamos";
            btnReclamos.UseVisualStyleBackColor = false;
            btnReclamos.Click += btnReclamos_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.BackgroundImageLayout = ImageLayout.Center;
            btnConfiguracion.Location = new Point(300, 297);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(219, 32);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(273, 74);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(262, 55);
            lbl1.TabIndex = 4;
            lbl1.Text = "Bienvenido";
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(773, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 6;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(752, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 8;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(lbl1);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnReclamos);
            Controls.Add(btnComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)comunicadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComunicados;
        private Button btnReclamos;
        private Button btnConfiguracion;
        private Label lbl1;
        private BindingSource comunicadoBindingSource;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}