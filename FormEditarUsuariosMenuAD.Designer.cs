namespace AppConsorcio
{
    partial class FormEditarUsuariosMenuAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarUsuariosMenuAD));
            btnCrearUsuario = new Button();
            picRegresar = new PictureBox();
            picMinimizar = new PictureBox();
            btnEliminarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)picRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.Crimson;
            btnCrearUsuario.FlatStyle = FlatStyle.Popup;
            btnCrearUsuario.Location = new Point(176, 166);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(464, 23);
            btnCrearUsuario.TabIndex = 3;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // picRegresar
            // 
            picRegresar.BackColor = Color.Transparent;
            picRegresar.Image = (Image)resources.GetObject("picRegresar.Image");
            picRegresar.Location = new Point(60, 23);
            picRegresar.Name = "picRegresar";
            picRegresar.Size = new Size(21, 26);
            picRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegresar.TabIndex = 12;
            picRegresar.TabStop = false;
            picRegresar.Click += picRegresar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(736, 23);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(16, 17);
            picMinimizar.TabIndex = 13;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.Crimson;
            btnEliminarUsuario.FlatStyle = FlatStyle.Popup;
            btnEliminarUsuario.Location = new Point(176, 227);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(464, 23);
            btnEliminarUsuario.TabIndex = 14;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // FormEditarUsuariosMenuAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(picMinimizar);
            Controls.Add(picRegresar);
            Controls.Add(btnCrearUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditarUsuariosMenuAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarUsuariosMenu";
            ((System.ComponentModel.ISupportInitialize)picRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearUsuario;
        private PictureBox picRegresar;
        private PictureBox picMinimizar;
        private Button btnEliminarUsuario;
    }
}