namespace CPresentacion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menuInicio = new MenuStrip();
            personasToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            copiasToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            generosToolStripMenuItem = new ToolStripMenuItem();
            libroToolStripMenuItem = new ToolStripMenuItem();
            transaccionesToolStripMenuItem = new ToolStripMenuItem();
            formasDePagoToolStripMenuItem = new ToolStripMenuItem();
            préstamosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuInicio.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuInicio
            // 
            menuInicio.BackColor = SystemColors.ControlDark;
            menuInicio.Dock = DockStyle.Fill;
            menuInicio.Items.AddRange(new ToolStripItem[] { personasToolStripMenuItem, librosToolStripMenuItem, transaccionesToolStripMenuItem });
            menuInicio.Location = new Point(0, 0);
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new Size(891, 57);
            menuInicio.TabIndex = 0;
            menuInicio.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autorToolStripMenuItem, clienteToolStripMenuItem, empleadoToolStripMenuItem });
            personasToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Padding = new Padding(10, 0, 10, 0);
            personasToolStripMenuItem.Size = new Size(96, 53);
            personasToolStripMenuItem.Text = "Personas";
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(156, 26);
            autorToolStripMenuItem.Text = "Autores";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(156, 26);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(156, 26);
            empleadoToolStripMenuItem.Text = "Empleados";
            empleadoToolStripMenuItem.Click += empleadoToolStripMenuItem_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiasToolStripMenuItem, editorialesToolStripMenuItem, generosToolStripMenuItem, libroToolStripMenuItem });
            librosToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Padding = new Padding(10, 0, 10, 0);
            librosToolStripMenuItem.Size = new Size(77, 53);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // copiasToolStripMenuItem
            // 
            copiasToolStripMenuItem.Name = "copiasToolStripMenuItem";
            copiasToolStripMenuItem.Size = new Size(180, 26);
            copiasToolStripMenuItem.Text = "Copias";
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(180, 26);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // generosToolStripMenuItem
            // 
            generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            generosToolStripMenuItem.Size = new Size(180, 26);
            generosToolStripMenuItem.Text = "Géneros";
            generosToolStripMenuItem.Click += generosToolStripMenuItem_Click;
            // 
            // libroToolStripMenuItem
            // 
            libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            libroToolStripMenuItem.Size = new Size(180, 26);
            libroToolStripMenuItem.Text = "Libros";
            libroToolStripMenuItem.Click += libroToolStripMenuItem_Click;
            // 
            // transaccionesToolStripMenuItem
            // 
            transaccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formasDePagoToolStripMenuItem, préstamosToolStripMenuItem, ventasToolStripMenuItem });
            transaccionesToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            transaccionesToolStripMenuItem.Padding = new Padding(10, 0, 10, 0);
            transaccionesToolStripMenuItem.Size = new Size(130, 53);
            transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // formasDePagoToolStripMenuItem
            // 
            formasDePagoToolStripMenuItem.Name = "formasDePagoToolStripMenuItem";
            formasDePagoToolStripMenuItem.Size = new Size(191, 26);
            formasDePagoToolStripMenuItem.Text = "Formas de Pago";
            // 
            // préstamosToolStripMenuItem
            // 
            préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            préstamosToolStripMenuItem.Size = new Size(191, 26);
            préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(191, 26);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(menuInicio);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 57);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 438);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 435);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("AR BLANCA", 50.2499924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 100);
            label1.Name = "label1";
            label1.Size = new Size(395, 240);
            label1.TabIndex = 4;
            label1.Text = "SISTEMA\r\nDE GESTIÓN\r\nDE LIBRERÍA";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MainMenuStrip = menuInicio;
            Name = "Inicio";
            Text = "Sistema de Gestión de Librería";
            menuInicio.ResumeLayout(false);
            menuInicio.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuInicio;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem copiasToolStripMenuItem;
        private ToolStripMenuItem libroToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem generosToolStripMenuItem;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
        private ToolStripMenuItem formasDePagoToolStripMenuItem;
        private ToolStripMenuItem préstamosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}