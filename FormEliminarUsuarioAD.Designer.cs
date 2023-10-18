namespace AppConsorcio
{
    partial class FormEliminarUsuarioAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarUsuarioAD));
            picRegresar = new PictureBox();
            picMinimizar = new PictureBox();
            lblEmitirComunicados = new Label();
            txtNombreUsuarioAEliminar = new TextBox();
            btnEliminarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(56, 24);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 17;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(720, 24);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 18;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // lblEmitirComunicados
            // 
            lblEmitirComunicados.AutoSize = true;
            lblEmitirComunicados.BackColor = Color.Transparent;
            lblEmitirComunicados.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirComunicados.ForeColor = Color.White;
            lblEmitirComunicados.Location = new Point(193, 117);
            lblEmitirComunicados.Name = "lblEmitirComunicados";
            lblEmitirComunicados.Size = new Size(407, 35);
            lblEmitirComunicados.TabIndex = 19;
            lblEmitirComunicados.Text = "Nombre del usuario que desee eliminar:";
            // 
            // txtNombreUsuarioAEliminar
            // 
            txtNombreUsuarioAEliminar.Location = new Point(160, 182);
            txtNombreUsuarioAEliminar.Name = "txtNombreUsuarioAEliminar";
            txtNombreUsuarioAEliminar.Size = new Size(464, 23);
            txtNombreUsuarioAEliminar.TabIndex = 20;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.Crimson;
            btnEliminarUsuario.FlatStyle = FlatStyle.Popup;
            btnEliminarUsuario.Location = new Point(160, 262);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(464, 23);
            btnEliminarUsuario.TabIndex = 21;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // FormEliminarUsuarioAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(txtNombreUsuarioAEliminar);
            Controls.Add(lblEmitirComunicados);
            Controls.Add(picMinimizar);
            Controls.Add(picRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEliminarUsuarioAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminarUsuarioAD";
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRegresar;
        private PictureBox picMinimizar;
        private Label lblEmitirComunicados;
        private TextBox txtNombreUsuarioAEliminar;
        private Button btnEliminarUsuario;
    }
}