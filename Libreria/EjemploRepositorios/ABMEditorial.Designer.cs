namespace CPresentacion
{
    partial class ABMEditorial
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
            tabControl1 = new TabControl();
            tabAlta = new TabPage();
            tabModificar = new TabPage();
            tabInterfaz = new TabPage();
            dgv_editoriales = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtContacto = new TextBox();
            txtDireccion = new TextBox();
            btModificar = new Button();
            panel2 = new Panel();
            bt_agregar = new Button();
            label3 = new Label();
            Direccion = new Label();
            label1 = new Label();
            txt_contacto = new TextBox();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            bnRecargar = new Button();
            tabControl1.SuspendLayout();
            tabAlta.SuspendLayout();
            tabModificar.SuspendLayout();
            tabInterfaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_editoriales).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInterfaz);
            tabControl1.Controls.Add(tabAlta);
            tabControl1.Controls.Add(tabModificar);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 231);
            tabControl1.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panel2);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(660, 203);
            tabAlta.TabIndex = 0;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // tabModificar
            // 
            tabModificar.Controls.Add(panel1);
            tabModificar.Location = new Point(4, 24);
            tabModificar.Name = "tabModificar";
            tabModificar.Padding = new Padding(3);
            tabModificar.Size = new Size(660, 203);
            tabModificar.TabIndex = 1;
            tabModificar.Text = "Modificacion";
            tabModificar.UseVisualStyleBackColor = true;
            // 
            // tabInterfaz
            // 
            tabInterfaz.Controls.Add(bnRecargar);
            tabInterfaz.Controls.Add(dgv_editoriales);
            tabInterfaz.Location = new Point(4, 24);
            tabInterfaz.Name = "tabInterfaz";
            tabInterfaz.Padding = new Padding(3);
            tabInterfaz.Size = new Size(660, 203);
            tabInterfaz.TabIndex = 2;
            tabInterfaz.Text = "Listado";
            tabInterfaz.UseVisualStyleBackColor = true;
            // 
            // dgv_editoriales
            // 
            dgv_editoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_editoriales.Location = new Point(6, 6);
            dgv_editoriales.Name = "dgv_editoriales";
            dgv_editoriales.Size = new Size(648, 163);
            dgv_editoriales.TabIndex = 0;
            dgv_editoriales.SelectionChanged += ABMEditorial_Load;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btModificar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtContacto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 172);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 18);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 17;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(292, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 81);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Contacto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(498, 78);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(292, 78);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 10;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(306, 121);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 9;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_agregar);
            panel2.Controls.Add(txt_direccion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(Direccion);
            panel2.Controls.Add(txt_contacto);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 145);
            panel2.TabIndex = 7;
            // 
            // bt_agregar
            // 
            bt_agregar.Location = new Point(314, 95);
            bt_agregar.Name = "bt_agregar";
            bt_agregar.Size = new Size(75, 23);
            bt_agregar.TabIndex = 13;
            bt_agregar.Text = "Agregar";
            bt_agregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 34);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Contacto";
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(242, 34);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(57, 15);
            Direccion.TabIndex = 11;
            Direccion.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // txt_contacto
            // 
            txt_contacto.Location = new Point(512, 31);
            txt_contacto.Name = "txt_contacto";
            txt_contacto.Size = new Size(100, 23);
            txt_contacto.TabIndex = 9;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(299, 31);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 8;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(76, 31);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 7;
            // 
            // bnRecargar
            // 
            bnRecargar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargar.Location = new Point(572, 174);
            bnRecargar.Margin = new Padding(3, 2, 3, 2);
            bnRecargar.Name = "bnRecargar";
            bnRecargar.Size = new Size(82, 24);
            bnRecargar.TabIndex = 2;
            bnRecargar.Text = "Recargar";
            bnRecargar.UseVisualStyleBackColor = true;
            bnRecargar.Click += bnRecargar_Click;
            // 
            // ABMEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 257);
            Controls.Add(tabControl1);
            Name = "ABMEditorial";
            Text = "ABMEditorial";
            tabControl1.ResumeLayout(false);
            tabAlta.ResumeLayout(false);
            tabModificar.ResumeLayout(false);
            tabInterfaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_editoriales).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAlta;
        private TabPage tabModificar;
        private TabPage tabInterfaz;
        private DataGridView dgv_editoriales;
        private Panel panel2;
        private Button bt_agregar;
        private TextBox txt_direccion;
        private Label label3;
        private TextBox txt_nombre;
        private Label Direccion;
        private TextBox txt_contacto;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private TextBox txtId;
        private Button btModificar;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtContacto;
        private Label label2;
        private TextBox txtNombre;
        private Button bnRecargar;
    }
}