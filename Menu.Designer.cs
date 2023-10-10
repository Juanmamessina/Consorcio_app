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
            btnReclamos = new Button();
            btnConfiguracion = new Button();
            lbl1 = new Label();
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
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(280, 51);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(262, 55);
            lbl1.TabIndex = 4;
            lbl1.Text = "Bienvenido";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnReclamos);
            Controls.Add(btnComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComunicados;
        private Button btnReclamos;
        private Button btnConfiguracion;
        private Label lbl1;
    }
}