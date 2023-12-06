namespace AppConsorcio.Forms
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            panel1 = new Panel();
            txtContraseñaUsuario = new TextBox();
            btnVerContraseña = new Button();
            lblNombreDelUsuario = new Label();
            lblInformacionDelUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(txtContraseñaUsuario);
            panel1.Controls.Add(btnVerContraseña);
            panel1.Controls.Add(lblNombreDelUsuario);
            panel1.Controls.Add(lblInformacionDelUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 390);
            panel1.TabIndex = 0;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Anchor = AnchorStyles.None;
            txtContraseñaUsuario.BackColor = Color.FromArgb(39, 39, 58);
            txtContraseñaUsuario.BorderStyle = BorderStyle.None;
            txtContraseñaUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseñaUsuario.ForeColor = Color.Gainsboro;
            txtContraseñaUsuario.Location = new Point(430, 198);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.PasswordChar = '*';
            txtContraseñaUsuario.Size = new Size(197, 22);
            txtContraseñaUsuario.TabIndex = 4;
            // 
            // btnVerContraseña
            // 
            btnVerContraseña.Anchor = AnchorStyles.None;
            btnVerContraseña.BackColor = Color.FromArgb(51, 51, 76);
            btnVerContraseña.FlatAppearance.BorderSize = 0;
            btnVerContraseña.FlatStyle = FlatStyle.Popup;
            btnVerContraseña.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerContraseña.ForeColor = Color.Gainsboro;
            btnVerContraseña.Location = new Point(421, 238);
            btnVerContraseña.Name = "btnVerContraseña";
            btnVerContraseña.Size = new Size(210, 26);
            btnVerContraseña.TabIndex = 3;
            btnVerContraseña.Text = "Ver contraseña";
            btnVerContraseña.UseVisualStyleBackColor = false;
            btnVerContraseña.Click += btnVerContraseña_Click;
            // 
            // lblNombreDelUsuario
            // 
            lblNombreDelUsuario.Anchor = AnchorStyles.None;
            lblNombreDelUsuario.AutoSize = true;
            lblNombreDelUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreDelUsuario.ForeColor = Color.Gainsboro;
            lblNombreDelUsuario.Location = new Point(421, 152);
            lblNombreDelUsuario.Name = "lblNombreDelUsuario";
            lblNombreDelUsuario.Size = new Size(210, 24);
            lblNombreDelUsuario.TabIndex = 1;
            lblNombreDelUsuario.Text = "                                        ";
            // 
            // lblInformacionDelUsuario
            // 
            lblInformacionDelUsuario.Anchor = AnchorStyles.None;
            lblInformacionDelUsuario.AutoSize = true;
            lblInformacionDelUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacionDelUsuario.ForeColor = Color.Gainsboro;
            lblInformacionDelUsuario.Location = new Point(421, 109);
            lblInformacionDelUsuario.Name = "lblInformacionDelUsuario";
            lblInformacionDelUsuario.Size = new Size(206, 24);
            lblInformacionDelUsuario.TabIndex = 0;
            lblInformacionDelUsuario.Text = "Informacion del usuario";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel1);
            Font = new Font("Mongolian Baiti", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNombreDelUsuario;
        private Label lblInformacionDelUsuario;
        private Button btnVerContraseña;
        private TextBox txtContraseñaUsuario;
    }
}