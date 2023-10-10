namespace AppConsorcio
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            lbl1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(238, 65);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(373, 68);
            lbl1.TabIndex = 0;
            lbl1.Text = "Bienvenido, administrador\r\n\r\n";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(303, 157);
            button1.Name = "button1";
            button1.Size = new Size(229, 23);
            button1.TabIndex = 1;
            button1.Text = "Emitir comunicado";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(303, 213);
            button2.Name = "button2";
            button2.Size = new Size(229, 23);
            button2.TabIndex = 2;
            button2.Text = "Publicar expensas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(303, 276);
            button3.Name = "button3";
            button3.Size = new Size(229, 23);
            button3.TabIndex = 3;
            button3.Text = "Editar usuarios";
            button3.UseVisualStyleBackColor = false;
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Crimson;
            picCerrar.BackgroundImage = Properties.Resources.Close_Icon;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(773, 12);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(15, 15);
            picCerrar.TabIndex = 5;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Crimson;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(752, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 15);
            picMinimizar.TabIndex = 6;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.render_3d_fondo_tecnologia_diseno_estructura_comunicaciones_red;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}