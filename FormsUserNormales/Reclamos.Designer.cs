namespace AppConsorcio.Forms
{
    partial class Reclamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reclamos));
            panel1 = new Panel();
            rtbReclamos = new RichTextBox();
            btnPublicarReclamo = new Button();
            txtContenidoReclamo = new TextBox();
            lblEmitirReclamos = new Label();
            btnVerReclamo = new Button();
            btnHacerReclamos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(rtbReclamos);
            panel1.Controls.Add(btnPublicarReclamo);
            panel1.Controls.Add(txtContenidoReclamo);
            panel1.Controls.Add(lblEmitirReclamos);
            panel1.Controls.Add(btnVerReclamo);
            panel1.Controls.Add(btnHacerReclamos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 390);
            panel1.TabIndex = 0;
            // 
            // rtbReclamos
            // 
            rtbReclamos.Anchor = AnchorStyles.None;
            rtbReclamos.Location = new Point(215, 75);
            rtbReclamos.Name = "rtbReclamos";
            rtbReclamos.ReadOnly = true;
            rtbReclamos.Size = new Size(550, 249);
            rtbReclamos.TabIndex = 18;
            rtbReclamos.Text = "";
            rtbReclamos.Visible = false;
            // 
            // btnPublicarReclamo
            // 
            btnPublicarReclamo.Anchor = AnchorStyles.None;
            btnPublicarReclamo.BackColor = Color.FromArgb(51, 51, 76);
            btnPublicarReclamo.FlatStyle = FlatStyle.Popup;
            btnPublicarReclamo.ForeColor = Color.Gainsboro;
            btnPublicarReclamo.Location = new Point(281, 259);
            btnPublicarReclamo.Name = "btnPublicarReclamo";
            btnPublicarReclamo.Size = new Size(464, 23);
            btnPublicarReclamo.TabIndex = 17;
            btnPublicarReclamo.Text = "Publicar";
            btnPublicarReclamo.UseVisualStyleBackColor = false;
            btnPublicarReclamo.Visible = false;
            btnPublicarReclamo.Click += btnPublicarReclamo_Click;
            // 
            // txtContenidoReclamo
            // 
            txtContenidoReclamo.Anchor = AnchorStyles.None;
            txtContenidoReclamo.Location = new Point(281, 188);
            txtContenidoReclamo.Name = "txtContenidoReclamo";
            txtContenidoReclamo.Size = new Size(464, 21);
            txtContenidoReclamo.TabIndex = 16;
            txtContenidoReclamo.Visible = false;
            // 
            // lblEmitirReclamos
            // 
            lblEmitirReclamos.Anchor = AnchorStyles.None;
            lblEmitirReclamos.AutoSize = true;
            lblEmitirReclamos.BackColor = Color.Transparent;
            lblEmitirReclamos.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmitirReclamos.ForeColor = Color.White;
            lblEmitirReclamos.Location = new Point(281, 107);
            lblEmitirReclamos.Name = "lblEmitirReclamos";
            lblEmitirReclamos.Size = new Size(471, 35);
            lblEmitirReclamos.TabIndex = 15;
            lblEmitirReclamos.Text = "Emita el reclamo correspondiente aqui debajo:";
            lblEmitirReclamos.Visible = false;
            // 
            // btnVerReclamo
            // 
            btnVerReclamo.Anchor = AnchorStyles.None;
            btnVerReclamo.BackColor = Color.FromArgb(51, 51, 76);
            btnVerReclamo.FlatAppearance.BorderSize = 0;
            btnVerReclamo.FlatStyle = FlatStyle.Popup;
            btnVerReclamo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerReclamo.ForeColor = Color.Gainsboro;
            btnVerReclamo.Location = new Point(427, 213);
            btnVerReclamo.Name = "btnVerReclamo";
            btnVerReclamo.Size = new Size(223, 26);
            btnVerReclamo.TabIndex = 14;
            btnVerReclamo.Text = "Ver reclamos";
            btnVerReclamo.UseVisualStyleBackColor = false;
            btnVerReclamo.Click += btnVerReclamo_Click;
            // 
            // btnHacerReclamos
            // 
            btnHacerReclamos.Anchor = AnchorStyles.None;
            btnHacerReclamos.BackColor = Color.FromArgb(51, 51, 76);
            btnHacerReclamos.FlatAppearance.BorderSize = 0;
            btnHacerReclamos.FlatStyle = FlatStyle.Popup;
            btnHacerReclamos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHacerReclamos.ForeColor = Color.Gainsboro;
            btnHacerReclamos.Location = new Point(427, 135);
            btnHacerReclamos.Name = "btnHacerReclamos";
            btnHacerReclamos.Size = new Size(223, 26);
            btnHacerReclamos.TabIndex = 13;
            btnHacerReclamos.Text = "Hacer reclamo";
            btnHacerReclamos.UseVisualStyleBackColor = false;
            btnHacerReclamos.Click += btnHacerReclamos_Click;
            // 
            // Reclamos
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(panel1);
            Font = new Font("Mongolian Baiti", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reclamos";
            Text = "Reclamos";
            Load += Reclamos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVerReclamo;
        private Button btnHacerReclamos;
        private Button btnPublicarReclamo;
        private TextBox txtContenidoReclamo;
        private Label lblEmitirReclamos;
        private RichTextBox rtbReclamos;
    }
}