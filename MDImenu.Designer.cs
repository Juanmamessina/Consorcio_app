namespace AppConsorcio
{
    partial class MDImenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDImenu));
            menuStrip = new MenuStrip();
            usuarioMenu = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printSetupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            comunicadosMenu = new ToolStripMenuItem();
            verComunicadosMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            reclamosMenu = new ToolStripMenuItem();
            eventosMenu = new ToolStripMenuItem();
            agendarEventoStripMenuItem = new ToolStripMenuItem();
            consultarEventosAgendadosStripMenuItem = new ToolStripMenuItem();
            configuracionMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            lbl1 = new Label();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { usuarioMenu, comunicadosMenu, reclamosMenu, eventosMenu, configuracionMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = configuracionMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // usuarioMenu
            // 
            usuarioMenu.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, printToolStripMenuItem, printPreviewToolStripMenuItem, printSetupToolStripMenuItem, toolStripSeparator5, exitToolStripMenuItem });
            usuarioMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            usuarioMenu.Name = "usuarioMenu";
            usuarioMenu.Size = new Size(59, 20);
            usuarioMenu.Text = "Usuario";
            usuarioMenu.Click += usuarioMenu_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(206, 22);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(206, 22);
            openToolStripMenuItem.Text = "&Abrir";
            openToolStripMenuItem.Click += OpenFile;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(203, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(206, 22);
            saveToolStripMenuItem.Text = "&Guardar";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(206, 22);
            saveAsToolStripMenuItem.Text = "Guardar &como";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(203, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.ImageTransparentColor = Color.Black;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(206, 22);
            printToolStripMenuItem.Text = "&Imprimir";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(206, 22);
            printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // printSetupToolStripMenuItem
            // 
            printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            printSetupToolStripMenuItem.Size = new Size(206, 22);
            printSetupToolStripMenuItem.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(206, 22);
            exitToolStripMenuItem.Text = "&Salir";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // comunicadosMenu
            // 
            comunicadosMenu.DropDownItems.AddRange(new ToolStripItem[] { verComunicadosMenuItem, toolStripSeparator6 });
            comunicadosMenu.Name = "comunicadosMenu";
            comunicadosMenu.Size = new Size(93, 20);
            comunicadosMenu.Text = "Comunicados";
            comunicadosMenu.Click += comunicadosMenu_Click;
            // 
            // verComunicadosMenuItem
            // 
            verComunicadosMenuItem.Image = (Image)resources.GetObject("verComunicadosMenuItem.Image");
            verComunicadosMenuItem.ImageTransparentColor = Color.Black;
            verComunicadosMenuItem.Name = "verComunicadosMenuItem";
            verComunicadosMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            verComunicadosMenuItem.Size = new Size(206, 22);
            verComunicadosMenuItem.Text = "Ver comunicados";
            verComunicadosMenuItem.Click += verComunicadosMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(203, 6);
            // 
            // reclamosMenu
            // 
            reclamosMenu.Name = "reclamosMenu";
            reclamosMenu.Size = new Size(70, 20);
            reclamosMenu.Text = "Reclamos";
            reclamosMenu.Click += reclamosMenu_Click;
            // 
            // eventosMenu
            // 
            eventosMenu.DropDownItems.AddRange(new ToolStripItem[] { agendarEventoStripMenuItem, consultarEventosAgendadosStripMenuItem });
            eventosMenu.Name = "eventosMenu";
            eventosMenu.Size = new Size(60, 20);
            eventosMenu.Text = "Eventos";
            // 
            // agendarEventoStripMenuItem
            // 
            agendarEventoStripMenuItem.Name = "agendarEventoStripMenuItem";
            agendarEventoStripMenuItem.Size = new Size(169, 22);
            agendarEventoStripMenuItem.Text = "Agendar evento";
            // 
            // consultarEventosAgendadosStripMenuItem
            // 
            consultarEventosAgendadosStripMenuItem.Name = "consultarEventosAgendadosStripMenuItem";
            consultarEventosAgendadosStripMenuItem.Size = new Size(169, 22);
            consultarEventosAgendadosStripMenuItem.Text = "Consultar eventos";
            // 
            // configuracionMenu
            // 
            configuracionMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            configuracionMenu.Name = "configuracionMenu";
            configuracionMenu.Size = new Size(95, 20);
            configuracionMenu.Text = "Configuracion";
            configuracionMenu.Click += configuracionMenu_Click;
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(175, 22);
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(175, 22);
            cascadeToolStripMenuItem.Text = "&Cascada";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(175, 22);
            tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(175, 22);
            tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(175, 22);
            closeAllToolStripMenuItem.Text = "C&errar todo";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(175, 22);
            arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Transparent;
            lbl1.Location = new Point(239, 164);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(262, 55);
            lbl1.TabIndex = 5;
            lbl1.Text = "Bienvenido";
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.BackgroundImage = Properties.Resources.fondo_cuadricula_digital_abstracto_negro;
            picCerrar.Image = Properties.Resources.Close_Icon;
            picCerrar.Location = new Point(710, 38);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 7;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(689, 38);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 9;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // MDImenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.fondo_borroso_oscuro_abstracto_textura_suave_degradado_color_brillante_brillante_sitio_web_patron_banner_h;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 523);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(lbl1);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDImenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consorcio amigable";
            DoubleClick += ExitToolsStripMenuItem_Click;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem printSetupToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem usuarioMenu;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem comunicadosMenu;
        private ToolStripMenuItem verComunicadosMenuItem;
        private ToolStripMenuItem reclamosMenu;
        private ToolStripMenuItem eventosMenu;
        private ToolStripMenuItem consultarEventosAgendadosStripMenuItem;
        private ToolStripMenuItem configuracionMenu;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolTip toolTip;
        private Label lbl1;
        private ToolStripMenuItem agendarEventoStripMenuItem;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}



