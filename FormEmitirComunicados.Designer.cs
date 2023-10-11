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
            lblEmitirComunicados = new Label();
            txtContenido = new TextBox();
            btnPublicarComunicado = new Button();
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
            // FormEmitirComunicados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 450);
            Controls.Add(btnPublicarComunicado);
            Controls.Add(txtContenido);
            Controls.Add(lblEmitirComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmitirComunicados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmitirComunicados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmitirComunicados;
        private TextBox txtContenido;
        private Button btnPublicarComunicado;
    }
}