namespace AppConsorcio.FormsAdministrador
{
    partial class FormUsuariosAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuariosAD));
            btnEliminarUsuario = new Button();
            btnCrearUsuario = new Button();
            panel1 = new Panel();
            btnEliminarUsuarioAD = new Button();
            txtNombreUsuarioAEliminar = new TextBox();
            lblNombreUsuarioAEliminar = new Label();
            btnCrear = new Button();
            txtContraseñaUsuarioNuevo = new TextBox();
            label1 = new Label();
            txtNombreUsuarioNuevo = new TextBox();
            lblEmitirComunicados = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Anchor = AnchorStyles.None;
            btnEliminarUsuario.BackColor = Color.White;
            btnEliminarUsuario.FlatStyle = FlatStyle.Popup;
            btnEliminarUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarUsuario.Location = new Point(257, 239);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(296, 23);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Anchor = AnchorStyles.None;
            btnCrearUsuario.BackColor = Color.White;
            btnCrearUsuario.FlatStyle = FlatStyle.Popup;
            btnCrearUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearUsuario.Location = new Point(257, 184);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(296, 23);
            btnCrearUsuario.TabIndex = 15;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnEliminarUsuarioAD);
            panel1.Controls.Add(txtNombreUsuarioAEliminar);
            panel1.Controls.Add(lblNombreUsuarioAEliminar);
            panel1.Controls.Add(btnCrearUsuario);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(txtContraseñaUsuarioNuevo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombreUsuarioNuevo);
            panel1.Controls.Add(lblEmitirComunicados);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 17;
            // 
            // btnEliminarUsuarioAD
            // 
            btnEliminarUsuarioAD.Anchor = AnchorStyles.None;
            btnEliminarUsuarioAD.BackColor = Color.White;
            btnEliminarUsuarioAD.FlatStyle = FlatStyle.Popup;
            btnEliminarUsuarioAD.Location = new Point(168, 286);
            btnEliminarUsuarioAD.Name = "btnEliminarUsuarioAD";
            btnEliminarUsuarioAD.Size = new Size(464, 23);
            btnEliminarUsuarioAD.TabIndex = 24;
            btnEliminarUsuarioAD.Text = "Eliminar";
            btnEliminarUsuarioAD.UseVisualStyleBackColor = false;
            btnEliminarUsuarioAD.Visible = false;
            btnEliminarUsuarioAD.Click += btnEliminarUsuarioAD_Click;
            // 
            // txtNombreUsuarioAEliminar
            // 
            txtNombreUsuarioAEliminar.Anchor = AnchorStyles.None;
            txtNombreUsuarioAEliminar.Location = new Point(168, 206);
            txtNombreUsuarioAEliminar.Name = "txtNombreUsuarioAEliminar";
            txtNombreUsuarioAEliminar.Size = new Size(464, 23);
            txtNombreUsuarioAEliminar.TabIndex = 23;
            txtNombreUsuarioAEliminar.Visible = false;
            // 
            // lblNombreUsuarioAEliminar
            // 
            lblNombreUsuarioAEliminar.Anchor = AnchorStyles.None;
            lblNombreUsuarioAEliminar.AutoSize = true;
            lblNombreUsuarioAEliminar.BackColor = Color.Transparent;
            lblNombreUsuarioAEliminar.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuarioAEliminar.ForeColor = Color.White;
            lblNombreUsuarioAEliminar.Location = new Point(201, 141);
            lblNombreUsuarioAEliminar.Name = "lblNombreUsuarioAEliminar";
            lblNombreUsuarioAEliminar.Size = new Size(407, 35);
            lblNombreUsuarioAEliminar.TabIndex = 22;
            lblNombreUsuarioAEliminar.Text = "Nombre del usuario que desee eliminar:";
            lblNombreUsuarioAEliminar.Visible = false;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.None;
            btnCrear.BackColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Location = new Point(168, 330);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(464, 23);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Visible = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // txtContraseñaUsuarioNuevo
            // 
            txtContraseñaUsuarioNuevo.Anchor = AnchorStyles.None;
            txtContraseñaUsuarioNuevo.Location = new Point(168, 251);
            txtContraseñaUsuarioNuevo.Name = "txtContraseñaUsuarioNuevo";
            txtContraseñaUsuarioNuevo.Size = new Size(464, 23);
            txtContraseñaUsuarioNuevo.TabIndex = 19;
            txtContraseñaUsuarioNuevo.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(257, 201);
            label1.Name = "label1";
            label1.Size = new Size(299, 35);
            label1.TabIndex = 18;
            label1.Text = "Contraseña que quiera darle:";
            label1.Visible = false;
            // 
            // txtNombreUsuarioNuevo
            // 
            txtNombreUsuarioNuevo.Anchor = AnchorStyles.None;
            txtNombreUsuarioNuevo.Location = new Point(168, 155);
            txtNombreUsuarioNuevo.Name = "txtNombreUsuarioNuevo";
            txtNombreUsuarioNuevo.Size = new Size(464, 23);
            txtNombreUsuarioNuevo.TabIndex = 17;
            txtNombreUsuarioNuevo.Visible = false;
            // 
            // lblEmitirComunicados
            // 
            lblEmitirComunicados.Anchor = AnchorStyles.None;
            lblEmitirComunicados.AutoSize = true;
            lblEmitirComunicados.BackColor = Color.Transparent;
            lblEmitirComunicados.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirComunicados.ForeColor = Color.White;
            lblEmitirComunicados.Location = new Point(224, 97);
            lblEmitirComunicados.Name = "lblEmitirComunicados";
            lblEmitirComunicados.Size = new Size(375, 35);
            lblEmitirComunicados.TabIndex = 16;
            lblEmitirComunicados.Text = "Nombre del usuario que desee crear:";
            lblEmitirComunicados.Visible = false;
            // 
            // FormUsuariosAD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuariosAD";
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminarUsuario;
        private Button btnCrearUsuario;
        private Panel panel1;
        private Button btnCrear;
        private TextBox txtContraseñaUsuarioNuevo;
        private Label label1;
        private TextBox txtNombreUsuarioNuevo;
        private Label lblEmitirComunicados;
        private Button btnEliminarUsuarioAD;
        private TextBox txtNombreUsuarioAEliminar;
        private Label lblNombreUsuarioAEliminar;
    }
}