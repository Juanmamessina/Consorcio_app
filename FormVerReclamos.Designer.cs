namespace AppConsorcio
{
    partial class FormVerReclamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerReclamos));
            rtbReclamos = new RichTextBox();
            picRegresar = new PictureBox();
            picMinimizar = new PictureBox();
            picCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            SuspendLayout();
            // 
            // rtbReclamos
            // 
            rtbReclamos.Location = new Point(125, 82);
            rtbReclamos.Name = "rtbReclamos";
            rtbReclamos.ReadOnly = true;
            rtbReclamos.Size = new Size(550, 287);
            rtbReclamos.TabIndex = 12;
            rtbReclamos.Text = "";
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(34, 12);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 15;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click_1;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(752, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 16;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click_1;
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(773, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 17;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // FormVerReclamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picCerrar);
            Controls.Add(picMinimizar);
            Controls.Add(picRegresar);
            Controls.Add(rtbReclamos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerReclamos";
            Text = "FormVerReclamos";
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbReclamos;
        private PictureBox picRegresar;
        private PictureBox picMinimizar;
        private PictureBox picCerrar;
    }
}