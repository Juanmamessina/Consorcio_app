﻿namespace AppConsorcio.Forms
{
    partial class Comunicados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comunicados));
            panel1 = new Panel();
            rtbComunicados = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(rtbComunicados);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 390);
            panel1.TabIndex = 0;
            // 
            // rtbComunicados
            // 
            rtbComunicados.Anchor = AnchorStyles.None;
            rtbComunicados.Location = new Point(238, 111);
            rtbComunicados.Name = "rtbComunicados";
            rtbComunicados.ReadOnly = true;
            rtbComunicados.Size = new Size(550, 249);
            rtbComunicados.TabIndex = 12;
            rtbComunicados.Text = "";
            // 
            // Comunicados
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel1);
            Font = new Font("Mongolian Baiti", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Comunicados";
            Text = "Comunicados";
            Load += Comunicados_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbComunicados;
    }
}