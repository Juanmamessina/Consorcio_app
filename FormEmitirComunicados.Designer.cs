namespace AppConsorcio
{
    partial class FormEmitirComunicados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmitirComunicados));
            lblEmitirComunicados = new Label();
            txtContenido = new TextBox();
            btnPublicarComunicado = new Button();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            picRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            SuspendLayout();
            // 
            // lblEmitirComunicados
            // 
            lblEmitirComunicados.AutoSize = true;
            lblEmitirComunicados.BackColor = Color.Transparent;
            lblEmitirComunicados.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirComunicados.ForeColor = Color.White;
            lblEmitirComunicados.Location = new Point(147, 65);
            lblEmitirComunicados.Name = "lblEmitirComunicados";
            lblEmitirComunicados.Size = new Size(511, 35);
            lblEmitirComunicados.TabIndex = 0;
            lblEmitirComunicados.Text = "Emita el comunicado correspondiente aqui debajo:";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(173, 168);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(464, 23);
            txtContenido.TabIndex = 1;
            // 
            // btnPublicarComunicado
            // 
            btnPublicarComunicado.BackColor = Color.Crimson;
            btnPublicarComunicado.FlatStyle = FlatStyle.Popup;
            btnPublicarComunicado.Location = new Point(173, 259);
            btnPublicarComunicado.Name = "btnPublicarComunicado";
            btnPublicarComunicado.Size = new Size(464, 23);
            btnPublicarComunicado.TabIndex = 2;
            btnPublicarComunicado.Text = "Publicar";
            btnPublicarComunicado.UseVisualStyleBackColor = false;
            btnPublicarComunicado.Click += btnPublicarComunicado_Click;
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(751, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 5;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(730, 12);
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
            picRegresar.Location = new Point(42, 12);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 11;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // FormEmitirComunicados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 450);
            Controls.Add(picRegresar);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(btnPublicarComunicado);
            Controls.Add(txtContenido);
            Controls.Add(lblEmitirComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmitirComunicados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmitirComunicados";
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmitirComunicados;
        private TextBox txtContenido;
        private Button btnPublicarComunicado;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
        private PictureBox picRegresar;
    }
}