﻿namespace AppConsorcio
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            button1 = new Button();
            lblContraseñaOlvidada = new LinkLabel();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Blue;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(237, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(263, 16);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Blue;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(237, 135);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(263, 16);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(237, 178);
            button1.Name = "button1";
            button1.Size = new Size(263, 34);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += IngresarClick;
            // 
            // lblContraseñaOlvidada
            // 
            lblContraseñaOlvidada.AutoSize = true;
            lblContraseñaOlvidada.LinkColor = Color.Blue;
            lblContraseñaOlvidada.Location = new Point(299, 239);
            lblContraseñaOlvidada.Name = "lblContraseñaOlvidada";
            lblContraseñaOlvidada.Size = new Size(157, 15);
            lblContraseñaOlvidada.TabIndex = 3;
            lblContraseñaOlvidada.TabStop = true;
            lblContraseñaOlvidada.Text = "¿Ha olvidado su contraseña?";
            // 
            // picCerrar
            // 
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(673, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 4;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(652, 3);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 5;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 284);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(lblContraseñaOlvidada);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            MouseDown += FormLogIn_MouseDown;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button button1;
        private LinkLabel lblContraseñaOlvidada;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}
#endregion