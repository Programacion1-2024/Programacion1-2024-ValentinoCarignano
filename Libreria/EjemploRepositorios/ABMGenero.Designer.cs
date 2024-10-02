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
            tabModificacion.Location = new Point(4, 29);
            tabModificacion.Margin = new Padding(3, 4, 3, 4);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3, 4, 3, 4);
            tabModificacion.Size = new Size(983, 243);
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
            panelModificacion.Location = new Point(180, 77);
            panelModificacion.Margin = new Padding(3, 4, 3, 4);
            panelModificacion.Name = "panelModificacion";
            panelModificacion.Size = new Size(658, 93);
            panelModificacion.TabIndex = 28;
            // 
            // tbIdGeneroModificacion
            // 
            tbIdGeneroModificacion.Location = new Point(85, 28);
            tbIdGeneroModificacion.Margin = new Padding(3, 4, 3, 4);
            tbIdGeneroModificacion.Name = "tbIdGeneroModificacion";
            tbIdGeneroModificacion.ReadOnly = true;
            tbIdGeneroModificacion.Size = new Size(180, 27);
            tbIdGeneroModificacion.TabIndex = 28;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(279, 31);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(87, 20);
            bvNombreModificacion.TabIndex = 37;
            bvNombreModificacion.Text = "Descripcion";
            // 
            // tbDescripcionModificacion
            // 
            tbDescripcionModificacion.Location = new Point(372, 28);
            tbDescripcionModificacion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcionModificacion.Name = "tbDescripcionModificacion";
            tbDescripcionModificacion.Size = new Size(180, 27);
            tbDescripcionModificacion.TabIndex = 29;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(569, 26);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lbIdGeneroModificacion
            // 
            lbIdGeneroModificacion.AutoSize = true;
            lbIdGeneroModificacion.Location = new Point(3, 31);
            lbIdGeneroModificacion.Name = "lbIdGeneroModificacion";
            lbIdGeneroModificacion.Size = new Size(76, 20);
            lbIdGeneroModificacion.TabIndex = 44;
            lbIdGeneroModificacion.Text = "ID Genero";
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 29);
            tabAlta.Margin = new Padding(3, 4, 3, 4);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3, 4, 3, 4);
            tabAlta.Size = new Size(983, 243);
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
            panelAlta.Location = new Point(270, 95);
            panelAlta.Margin = new Padding(3, 4, 3, 4);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(469, 71);
            panelAlta.TabIndex = 12;
            // 
            // tbDescripcionAlta
            // 
            tbDescripcionAlta.Location = new Point(114, 20);
            tbDescripcionAlta.Margin = new Padding(3, 4, 3, 4);
            tbDescripcionAlta.Name = "tbDescripcionAlta";
            tbDescripcionAlta.Size = new Size(180, 27);
            tbDescripcionAlta.TabIndex = 12;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(21, 23);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(87, 20);
            lblNombreAlta.TabIndex = 14;
            lblNombreAlta.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(320, 18);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoGeneros);
            tabListado.Location = new Point(4, 29);
            tabListado.Margin = new Padding(3, 4, 3, 4);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3, 4, 3, 4);
            tabListado.Size = new Size(983, 243);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargarAlta.Location = new Point(881, 205);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(94, 32);
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
            dgvListadoGeneros.Location = new Point(3, 4);
            dgvListadoGeneros.Margin = new Padding(3, 4, 3, 4);
            dgvListadoGeneros.Name = "dgvListadoGeneros";
            dgvListadoGeneros.RowHeadersWidth = 51;
            dgvListadoGeneros.Size = new Size(971, 195);
            dgvListadoGeneros.TabIndex = 0;
            dgvListadoGeneros.CellContentClick += dgvListadoAutores_CellClick;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(14, 16);
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(991, 276);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            tabControlPrincipal.Selecting += tabControlPrincipal_Selecting;
            // 
            // ABMGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 308);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
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