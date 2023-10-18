namespace AppConsorcio
{
    partial class FormReclamosMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReclamosMenu));
            btnPublicarComunicado = new Button();
            btnVerReclamos = new Button();
            picMinimizar = new PictureBox();
            picRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            SuspendLayout();
            // 
            // btnPublicarComunicado
            // 
            btnPublicarComunicado.BackColor = Color.MidnightBlue;
            btnPublicarComunicado.FlatAppearance.BorderSize = 0;
            btnPublicarComunicado.FlatStyle = FlatStyle.Popup;
            btnPublicarComunicado.ForeColor = Color.White;
            btnPublicarComunicado.Location = new Point(178, 165);
            btnPublicarComunicado.Name = "btnPublicarComunicado";
            btnPublicarComunicado.Size = new Size(464, 23);
            btnPublicarComunicado.TabIndex = 3;
            btnPublicarComunicado.Text = "Hacer reclamo";
            btnPublicarComunicado.UseVisualStyleBackColor = false;
            btnPublicarComunicado.Click += btnHacerReclamo_Click;
            // 
            // btnVerReclamos
            // 
            btnVerReclamos.BackColor = Color.MidnightBlue;
            btnVerReclamos.FlatAppearance.BorderSize = 0;
            btnVerReclamos.FlatStyle = FlatStyle.Popup;
            btnVerReclamos.ForeColor = Color.White;
            btnVerReclamos.Location = new Point(178, 249);
            btnVerReclamos.Name = "btnVerReclamos";
            btnVerReclamos.Size = new Size(464, 23);
            btnVerReclamos.TabIndex = 4;
            btnVerReclamos.Text = "Ver reclamos";
            btnVerReclamos.UseVisualStyleBackColor = false;
            btnVerReclamos.Click += btnVerReclamos_Click;
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
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(53, 12);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 12;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // FormReclamosMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picRegresar);
            Controls.Add(picMinimizar);
            Controls.Add(btnVerReclamos);
            Controls.Add(btnPublicarComunicado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReclamosMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReclamosMenu";
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPublicarComunicado;
        private Button btnVerReclamos;
        private PictureBox picMinimizar;
        private PictureBox picRegresar;
    }
}