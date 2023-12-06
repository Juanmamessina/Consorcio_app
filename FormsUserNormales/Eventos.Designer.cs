namespace AppConsorcio.Forms
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            monthCalendar1 = new MonthCalendar();
            panel1 = new Panel();
            btnAgendar = new Button();
            btnConsultarEventos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.None;
            monthCalendar1.BackColor = Color.Gainsboro;
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(203, 108);
            monthCalendar1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = SystemColors.ActiveBorder;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(btnAgendar);
            panel1.Controls.Add(btnConsultarEventos);
            panel1.Controls.Add(monthCalendar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // btnAgendar
            // 
            btnAgendar.Anchor = AnchorStyles.None;
            btnAgendar.BackColor = Color.FromArgb(51, 51, 76);
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Popup;
            btnAgendar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendar.ForeColor = Color.Gainsboro;
            btnAgendar.Location = new Point(725, 293);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(107, 26);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // btnConsultarEventos
            // 
            btnConsultarEventos.Anchor = AnchorStyles.None;
            btnConsultarEventos.BackColor = Color.FromArgb(51, 51, 76);
            btnConsultarEventos.FlatAppearance.BorderSize = 0;
            btnConsultarEventos.FlatStyle = FlatStyle.Popup;
            btnConsultarEventos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarEventos.ForeColor = Color.Gainsboro;
            btnConsultarEventos.Location = new Point(725, 350);
            btnConsultarEventos.Name = "btnConsultarEventos";
            btnConsultarEventos.Size = new Size(107, 26);
            btnConsultarEventos.TabIndex = 4;
            btnConsultarEventos.Text = "Consultar ";
            btnConsultarEventos.UseVisualStyleBackColor = false;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Eventos";
            Text = "FormEventos";
            Load += Eventos_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Panel panel1;
        private Button btnConsultarEventos;
        private Button btnAgendar;
    }
}