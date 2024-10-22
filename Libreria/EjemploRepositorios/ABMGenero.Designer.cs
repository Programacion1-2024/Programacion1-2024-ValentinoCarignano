namespace CPresentacion
{
    partial class ABMGenero
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
            openFileDialog1 = new OpenFileDialog();
            tabModificacion = new TabPage();
            panelModificacion = new Panel();
            tbIdGeneroModificacion = new TextBox();
            bvNombreModificacion = new Label();
            tbDescripcionModificacion = new TextBox();
            btnActualizar = new Button();
            lbIdGeneroModificacion = new Label();
            tabAlta = new TabPage();
            panelAlta = new Panel();
            tbDescripcionAlta = new TextBox();
            lblNombreAlta = new Label();
            btnGuardar = new Button();
            tabListado = new TabPage();
            bnRecargarAlta = new Button();
            dgvListadoGeneros = new DataGridView();
            tabControlPrincipal = new TabControl();
            tabModificacion.SuspendLayout();
            panelModificacion.SuspendLayout();
            tabAlta.SuspendLayout();
            panelAlta.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoGeneros).BeginInit();
            tabControlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(panelModificacion);
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(625, 179);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // panelModificacion
            // 
            panelModificacion.Anchor = AnchorStyles.None;
            panelModificacion.Controls.Add(tbIdGeneroModificacion);
            panelModificacion.Controls.Add(bvNombreModificacion);
            panelModificacion.Controls.Add(tbDescripcionModificacion);
            panelModificacion.Controls.Add(btnActualizar);
            panelModificacion.Controls.Add(lbIdGeneroModificacion);
            panelModificacion.Location = new Point(24, 56);
            panelModificacion.Name = "panelModificacion";
            panelModificacion.Size = new Size(576, 70);
            panelModificacion.TabIndex = 28;
            // 
            // tbIdGeneroModificacion
            // 
            tbIdGeneroModificacion.Location = new Point(74, 21);
            tbIdGeneroModificacion.Name = "tbIdGeneroModificacion";
            tbIdGeneroModificacion.ReadOnly = true;
            tbIdGeneroModificacion.Size = new Size(158, 23);
            tbIdGeneroModificacion.TabIndex = 28;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(244, 23);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(69, 15);
            bvNombreModificacion.TabIndex = 37;
            bvNombreModificacion.Text = "Descripcion";
            // 
            // tbDescripcionModificacion
            // 
            tbDescripcionModificacion.Location = new Point(326, 21);
            tbDescripcionModificacion.Name = "tbDescripcionModificacion";
            tbDescripcionModificacion.Size = new Size(158, 23);
            tbDescripcionModificacion.TabIndex = 29;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(498, 20);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lbIdGeneroModificacion
            // 
            lbIdGeneroModificacion.AutoSize = true;
            lbIdGeneroModificacion.Location = new Point(3, 23);
            lbIdGeneroModificacion.Name = "lbIdGeneroModificacion";
            lbIdGeneroModificacion.Size = new Size(59, 15);
            lbIdGeneroModificacion.TabIndex = 44;
            lbIdGeneroModificacion.Text = "ID Genero";
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(625, 179);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // panelAlta
            // 
            panelAlta.Anchor = AnchorStyles.None;
            panelAlta.Controls.Add(tbDescripcionAlta);
            panelAlta.Controls.Add(lblNombreAlta);
            panelAlta.Controls.Add(btnGuardar);
            panelAlta.Location = new Point(115, 63);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(410, 53);
            panelAlta.TabIndex = 12;
            // 
            // tbDescripcionAlta
            // 
            tbDescripcionAlta.Location = new Point(100, 15);
            tbDescripcionAlta.Name = "tbDescripcionAlta";
            tbDescripcionAlta.Size = new Size(158, 23);
            tbDescripcionAlta.TabIndex = 12;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(18, 17);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(69, 15);
            lblNombreAlta.TabIndex = 14;
            lblNombreAlta.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(280, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoGeneros);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(625, 179);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargarAlta.Location = new Point(537, 154);
            bnRecargarAlta.Margin = new Padding(3, 2, 3, 2);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(82, 24);
            bnRecargarAlta.TabIndex = 1;
            bnRecargarAlta.Text = "Recargar";
            bnRecargarAlta.UseVisualStyleBackColor = true;
            bnRecargarAlta.Click += bnRecargarAlta_Click;
            // 
            // dgvListadoGeneros
            // 
            dgvListadoGeneros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoGeneros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoGeneros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoGeneros.Location = new Point(3, 3);
            dgvListadoGeneros.Name = "dgvListadoGeneros";
            dgvListadoGeneros.RowHeadersWidth = 51;
            dgvListadoGeneros.Size = new Size(616, 146);
            dgvListadoGeneros.TabIndex = 0;
            dgvListadoGeneros.CellContentClick += dgvListadoAutores_CellClick;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(633, 207);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            tabControlPrincipal.Selecting += tabControlPrincipal_Selecting;
            // 
            // ABMGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 231);
            Controls.Add(tabControlPrincipal);
            Name = "ABMGenero";
            Text = "Sistema de Gestion de Libreria";
            Load += ABMAutor_Load;
            tabModificacion.ResumeLayout(false);
            panelModificacion.ResumeLayout(false);
            panelModificacion.PerformLayout();
            tabAlta.ResumeLayout(false);
            panelAlta.ResumeLayout(false);
            panelAlta.PerformLayout();
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoGeneros).EndInit();
            tabControlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabModificacion;
        private TabPage tabAlta;
        private TabPage tabListado;
        private DataGridView dgvListadoGeneros;
        private TabControl tabControlPrincipal;
        private Button bnRecargarAlta;
        private Panel panelModificacion;
        private TextBox tbIdGeneroModificacion;
        private Label bvNombreModificacion;
        private TextBox tbDescripcionModificacion;
        private Button btnActualizar;
        private Label lbIdGeneroModificacion;
        private Panel panelAlta;
        private TextBox tbDescripcionAlta;
        private Label lblNombreAlta;
        private Button btnGuardar;
    }
}