namespace AppConsorcio
{
    partial class FormComunicadosMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComunicadosMenu));
            btnPublicarComunicado = new Button();
            button1 = new Button();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // btnPublicarComunicado
            // 
            btnPublicarComunicado.BackColor = Color.MidnightBlue;
            btnPublicarComunicado.FlatAppearance.BorderSize = 0;
            btnPublicarComunicado.FlatStyle = FlatStyle.Popup;
            btnPublicarComunicado.ForeColor = Color.White;
            btnPublicarComunicado.Location = new Point(178, 165);
            btnPublicarComunicado.Name = "btnHacerComunicado";
            btnPublicarComunicado.Size = new Size(464, 23);
            btnPublicarComunicado.TabIndex = 3;
            btnPublicarComunicado.Text = "Hacer reclamo";
            btnPublicarComunicado.UseVisualStyleBackColor = false;
            btnPublicarComunicado.Click += btnHacerReclamo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(178, 249);
            button1.Name = "button1";
            button1.Size = new Size(464, 23);
            button1.TabIndex = 4;
            button1.Text = "Ver reclamos";
            button1.UseVisualStyleBackColor = false;
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(773, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 7;
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
            picMinimizar.TabIndex = 9;
            picMinimizar.TabStop = false;
            // 
            // FormComunicadosMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(button1);
            Controls.Add(btnPublicarComunicado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormComunicadosMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReclamosMenu";
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPublicarComunicado;
        private Button button1;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}