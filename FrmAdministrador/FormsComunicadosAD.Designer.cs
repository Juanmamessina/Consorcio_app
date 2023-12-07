namespace AppConsorcio.FormsAdministrador
{
    partial class FormsComunicadosAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsComunicadosAD));
            panel1 = new Panel();
            btnPublicarComunicado = new Button();
            txtContenido = new TextBox();
            lblEmitirComunicados = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnPublicarComunicado);
            panel1.Controls.Add(txtContenido);
            panel1.Controls.Add(lblEmitirComunicados);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnPublicarComunicado
            // 
            btnPublicarComunicado.Anchor = AnchorStyles.None;
            btnPublicarComunicado.BackColor = Color.White;
            btnPublicarComunicado.FlatStyle = FlatStyle.Popup;
            btnPublicarComunicado.Location = new Point(171, 311);
            btnPublicarComunicado.Name = "btnPublicarComunicado";
            btnPublicarComunicado.Size = new Size(464, 23);
            btnPublicarComunicado.TabIndex = 5;
            btnPublicarComunicado.Text = "Publicar";
            btnPublicarComunicado.UseVisualStyleBackColor = false;
            btnPublicarComunicado.Click += btnPublicarComunicado_Click;
            // 
            // txtContenido
            // 
            txtContenido.Anchor = AnchorStyles.None;
            txtContenido.Location = new Point(171, 220);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(464, 23);
            txtContenido.TabIndex = 4;
            // 
            // lblEmitirComunicados
            // 
            lblEmitirComunicados.Anchor = AnchorStyles.None;
            lblEmitirComunicados.AutoSize = true;
            lblEmitirComunicados.BackColor = Color.Transparent;
            lblEmitirComunicados.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirComunicados.ForeColor = Color.White;
            lblEmitirComunicados.Location = new Point(145, 117);
            lblEmitirComunicados.Name = "lblEmitirComunicados";
            lblEmitirComunicados.Size = new Size(511, 35);
            lblEmitirComunicados.TabIndex = 3;
            lblEmitirComunicados.Text = "Emita el comunicado correspondiente aqui debajo:";
            // 
            // FormsComunicadosAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormsComunicadosAD";
            Text = "Comunicados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPublicarComunicado;
        private TextBox txtContenido;
        private Label lblEmitirComunicados;
    }
}