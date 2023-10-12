namespace AppConsorcio
{
    partial class FormHacerReclamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHacerReclamo));
            lblEmitirReclamos = new Label();
            txtContenidoReclamo = new TextBox();
            btnPublicarReclamo = new Button();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // lblEmitirReclamos
            // 
            lblEmitirReclamos.AutoSize = true;
            lblEmitirReclamos.BackColor = Color.Transparent;
            lblEmitirReclamos.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirReclamos.ForeColor = Color.White;
            lblEmitirReclamos.Location = new Point(168, 107);
            lblEmitirReclamos.Name = "lblEmitirReclamos";
            lblEmitirReclamos.Size = new Size(471, 35);
            lblEmitirReclamos.TabIndex = 1;
            lblEmitirReclamos.Text = "Emita el reclamo correspondiente aqui debajo:";
            // 
            // txtContenidoReclamo
            // 
            txtContenidoReclamo.Location = new Point(168, 201);
            txtContenidoReclamo.Name = "txtContenidoReclamo";
            txtContenidoReclamo.Size = new Size(464, 23);
            txtContenidoReclamo.TabIndex = 2;
            // 
            // btnPublicarReclamo
            // 
            btnPublicarReclamo.BackColor = Color.MidnightBlue;
            btnPublicarReclamo.FlatStyle = FlatStyle.Popup;
            btnPublicarReclamo.ForeColor = Color.White;
            btnPublicarReclamo.Location = new Point(168, 283);
            btnPublicarReclamo.Name = "btnPublicarReclamo";
            btnPublicarReclamo.Size = new Size(464, 26);
            btnPublicarReclamo.TabIndex = 3;
            btnPublicarReclamo.Text = "Publicar";
            btnPublicarReclamo.UseVisualStyleBackColor = false;
            btnPublicarReclamo.Click += btnPublicarReclamo_Click;
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
            picMinimizar.Click += picMinimizar_Click;
            // 
            // FormHacerReclamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(btnPublicarReclamo);
            Controls.Add(txtContenidoReclamo);
            Controls.Add(lblEmitirReclamos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHacerReclamo";
            Text = "FormHacerReclamo";
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmitirReclamos;
        private TextBox txtContenidoReclamo;
        private Button btnPublicarReclamo;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}