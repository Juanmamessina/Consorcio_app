namespace AppConsorcio
{
    partial class FormVerComunicados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerComunicados));
            rtbComunicados = new RichTextBox();
            picMinimizar = new PictureBox();
            picRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            SuspendLayout();
            // 
            // rtbComunicados
            // 
            rtbComunicados.Location = new Point(125, 67);
            rtbComunicados.Name = "rtbComunicados";
            rtbComunicados.ReadOnly = true;
            rtbComunicados.Size = new Size(550, 287);
            rtbComunicados.TabIndex = 11;
            rtbComunicados.Text = "";
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(752, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 13;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(45, 12);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 14;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // FormVerComunicados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picRegresar);
            Controls.Add(picMinimizar);
            Controls.Add(rtbComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerComunicados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerComunicados";
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbComunicados;
        private PictureBox picMinimizar;
        private PictureBox picRegresar;
    }
}