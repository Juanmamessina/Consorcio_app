namespace AppConsorcio
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            btnConfiguracion = new Button();
            btnEventos = new Button();
            btnReclamos = new Button();
            btnComunicados = new Button();
            btnUsuario = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitulo = new Panel();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            lblTitulo = new Label();
            panelHome = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            timerHoraFecha = new System.Windows.Forms.Timer(components);
            btnCloseChildForm = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnConfiguracion);
            panelMenu.Controls.Add(btnEventos);
            panelMenu.Controls.Add(btnReclamos);
            panelMenu.Controls.Add(btnComunicados);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 523);
            panelMenu.TabIndex = 4;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.Gainsboro;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 320);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(12, 0, 0, 0);
            btnConfiguracion.Size = new Size(220, 60);
            btnConfiguracion.TabIndex = 4;
            btnConfiguracion.Text = "   Configuracion";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnEventos
            // 
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEventos.ForeColor = Color.Gainsboro;
            btnEventos.Image = (Image)resources.GetObject("btnEventos.Image");
            btnEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventos.Location = new Point(0, 260);
            btnEventos.Name = "btnEventos";
            btnEventos.Padding = new Padding(12, 0, 0, 0);
            btnEventos.Size = new Size(220, 60);
            btnEventos.TabIndex = 3;
            btnEventos.Text = "   Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnReclamos
            // 
            btnReclamos.Dock = DockStyle.Top;
            btnReclamos.FlatAppearance.BorderSize = 0;
            btnReclamos.FlatStyle = FlatStyle.Flat;
            btnReclamos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReclamos.ForeColor = Color.Gainsboro;
            btnReclamos.Image = (Image)resources.GetObject("btnReclamos.Image");
            btnReclamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnReclamos.Location = new Point(0, 200);
            btnReclamos.Name = "btnReclamos";
            btnReclamos.Padding = new Padding(12, 0, 0, 0);
            btnReclamos.Size = new Size(220, 60);
            btnReclamos.TabIndex = 2;
            btnReclamos.Text = "   Reclamos";
            btnReclamos.TextAlign = ContentAlignment.MiddleLeft;
            btnReclamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReclamos.UseVisualStyleBackColor = true;
            btnReclamos.Click += btnReclamos_Click;
            // 
            // btnComunicados
            // 
            btnComunicados.Dock = DockStyle.Top;
            btnComunicados.FlatAppearance.BorderSize = 0;
            btnComunicados.FlatStyle = FlatStyle.Flat;
            btnComunicados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnComunicados.ForeColor = Color.Gainsboro;
            btnComunicados.Image = (Image)resources.GetObject("btnComunicados.Image");
            btnComunicados.ImageAlign = ContentAlignment.MiddleLeft;
            btnComunicados.Location = new Point(0, 140);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Padding = new Padding(12, 0, 0, 0);
            btnComunicados.Size = new Size(220, 60);
            btnComunicados.TabIndex = 1;
            btnComunicados.Text = "   Comunicados";
            btnComunicados.TextAlign = ContentAlignment.MiddleLeft;
            btnComunicados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComunicados.UseVisualStyleBackColor = true;
            btnComunicados.Click += btnComunicados_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.Gainsboro;
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(0, 80);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(12, 0, 0, 0);
            btnUsuario.Size = new Size(220, 60);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "   Usuario";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(12, 0, 0, 0);
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Consorcio App";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelTitulo.Controls.Add(btnCloseChildForm);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(220, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(690, 80);
            panelTitulo.TabIndex = 6;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(588, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 46);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "O";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Location = new Point(624, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 46);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.Text = "O";
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(660, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 46);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "O";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Mongolian Baiti", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(297, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "HOME";
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(39, 39, 58);
            panelHome.Controls.Add(lblFecha);
            panelHome.Controls.Add(lblHora);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(0, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(910, 523);
            panelHome.TabIndex = 11;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(39, 39, 58);
            lblFecha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.Gainsboro;
            lblFecha.Location = new Point(402, 281);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(78, 32);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label3";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(433, 185);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(208, 86);
            lblHora.TabIndex = 0;
            lblHora.Text = "label2";
            // 
            // timerHoraFecha
            // 
            timerHoraFecha.Enabled = true;
            timerHoraFecha.Tick += timerHoraFecha_Tick;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackgroundImage = (Image)resources.GetObject("btnCloseChildForm.BackgroundImage");
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Location = new Point(25, 23);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(31, 31);
            btnCloseChildForm.TabIndex = 4;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(910, 523);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Controls.Add(panelHome);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenu";
            Text = "MDIParent1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnUsuario;
        private Panel panelLogo;
        private Button btnConfiguracion;
        private Button btnEventos;
        private Button btnReclamos;
        private Button btnComunicados;
        private Panel panelTitulo;
        private Label lblTitulo;
        private Label label1;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Panel panelHome;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHoraFecha;
        private Button btnCloseChildForm;
    }
}



