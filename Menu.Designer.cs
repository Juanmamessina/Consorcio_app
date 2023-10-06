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
            btnComunicados = new Button();
            btnReservas = new Button();
            btnReclamos = new Button();
            btnConfiguracion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnComunicados
            // 
            btnComunicados.BackColor = Color.Transparent;
            btnComunicados.BackgroundImageLayout = ImageLayout.Center;
            btnComunicados.Location = new Point(300, 150);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Size = new Size(219, 32);
            btnComunicados.TabIndex = 0;
            btnComunicados.Text = "Comunicados";
            btnComunicados.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.Transparent;
            btnReservas.BackgroundImageLayout = ImageLayout.Center;
            btnReservas.Location = new Point(300, 208);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(219, 32);
            btnReservas.TabIndex = 1;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnReclamos
            // 
            btnReclamos.BackColor = Color.Transparent;
            btnReclamos.BackgroundImageLayout = ImageLayout.Center;
            btnReclamos.Location = new Point(300, 266);
            btnReclamos.Name = "btnReclamos";
            btnReclamos.Size = new Size(219, 32);
            btnReclamos.TabIndex = 2;
            btnReclamos.Text = "Reclamos";
            btnReclamos.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.BackgroundImageLayout = ImageLayout.Center;
            btnConfiguracion.Location = new Point(300, 324);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(219, 32);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(295, 50);
            label1.Name = "label1";
            label1.Size = new Size(228, 42);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnReclamos);
            Controls.Add(btnReservas);
            Controls.Add(btnComunicados);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComunicados;
        private Button btnReservas;
        private Button btnReclamos;
        private Button btnConfiguracion;
        private Label label1;
    }
}