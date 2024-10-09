namespace EjemploRepositorios
{
    partial class ABMLibro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabListado = new TabPage();
            btRecargar = new Button();
            dgvListadoLibros = new DataGridView();
            tabAlta = new TabPage();
            panelAlta = new Panel();
            clbGeneroAlta = new CheckedListBox();
            clbAutorAlta = new CheckedListBox();
            btGuardar = new Button();
            lbEditorial = new Label();
            cbEditorialAlta = new ComboBox();
            lbGenero = new Label();
            lbAutor = new Label();
            tbPrecioVentaAlta = new TextBox();
            lbPrecioVenta = new Label();
            dtFechaPublicacionAlta = new DateTimePicker();
            tbDescripcionAlta = new TextBox();
            lbFechaNacimientoAlta = new Label();
            tbISBNAlta = new TextBox();
            tbFechaNacimientoAlta = new TextBox();
            lblISBN = new Label();
            tbBiografiaAlta = new TextBox();
            lbApellidoAlta = new Label();
            lbTelefonoAlta = new Label();
            tbTituloAlta = new TextBox();
            lbTitulo = new Label();
            tbTelefonoAlta = new TextBox();
            lbfechaDePublicacion = new Label();
            tbApellidoAlta = new TextBox();
            lbDescripcion = new Label();
            btnGuardar = new Button();
            tabModificar = new TabPage();
            panel1 = new Panel();
            clbGeneroModificar = new CheckedListBox();
            clbAutorModificar = new CheckedListBox();
            tbIdLibroModificacion = new TextBox();
            lbIdLibroModificacion = new Label();
            tbDescripcionModificar = new TextBox();
            btActualizar = new Button();
            label1 = new Label();
            cbEditorialModificar = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tbPrecioVentaModificar = new TextBox();
            label4 = new Label();
            dtFechaPublicacionModificar = new DateTimePicker();
            textBox4 = new TextBox();
            label5 = new Label();
            tbISBNModificar = new TextBox();
            textBox6 = new TextBox();
            lbISBN = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbTituloModificar = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            button2 = new Button();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoLibros).BeginInit();
            tabAlta.SuspendLayout();
            panelAlta.SuspendLayout();
            tabModificar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificar);
            tabControlPrincipal.Location = new Point(14, 16);
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(1086, 663);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(btRecargar);
            tabListado.Controls.Add(dgvListadoLibros);
            tabListado.Location = new Point(4, 29);
            tabListado.Margin = new Padding(3, 4, 3, 4);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3, 4, 3, 4);
            tabListado.Size = new Size(1078, 630);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // btRecargar
            // 
            btRecargar.Location = new Point(966, 585);
            btRecargar.Margin = new Padding(3, 4, 3, 4);
            btRecargar.Name = "btRecargar";
            btRecargar.Size = new Size(104, 32);
            btRecargar.TabIndex = 1;
            btRecargar.Text = "button1";
            btRecargar.UseVisualStyleBackColor = true;
            // 
            // dgvListadoLibros
            // 
            dgvListadoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoLibros.Location = new Point(7, 7);
            dgvListadoLibros.Margin = new Padding(3, 4, 3, 4);
            dgvListadoLibros.Name = "dgvListadoLibros";
            dgvListadoLibros.RowHeadersWidth = 51;
            dgvListadoLibros.Size = new Size(1063, 571);
            dgvListadoLibros.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 29);
            tabAlta.Margin = new Padding(3, 4, 3, 4);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3, 4, 3, 4);
            tabAlta.Size = new Size(1078, 630);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // panelAlta
            // 
            panelAlta.Anchor = AnchorStyles.None;
            panelAlta.Controls.Add(clbGeneroAlta);
            panelAlta.Controls.Add(clbAutorAlta);
            panelAlta.Controls.Add(btGuardar);
            panelAlta.Controls.Add(lbEditorial);
            panelAlta.Controls.Add(cbEditorialAlta);
            panelAlta.Controls.Add(lbGenero);
            panelAlta.Controls.Add(lbAutor);
            panelAlta.Controls.Add(tbPrecioVentaAlta);
            panelAlta.Controls.Add(lbPrecioVenta);
            panelAlta.Controls.Add(dtFechaPublicacionAlta);
            panelAlta.Controls.Add(tbDescripcionAlta);
            panelAlta.Controls.Add(lbFechaNacimientoAlta);
            panelAlta.Controls.Add(tbISBNAlta);
            panelAlta.Controls.Add(tbFechaNacimientoAlta);
            panelAlta.Controls.Add(lblISBN);
            panelAlta.Controls.Add(tbBiografiaAlta);
            panelAlta.Controls.Add(lbApellidoAlta);
            panelAlta.Controls.Add(lbTelefonoAlta);
            panelAlta.Controls.Add(tbTituloAlta);
            panelAlta.Controls.Add(lbTitulo);
            panelAlta.Controls.Add(tbTelefonoAlta);
            panelAlta.Controls.Add(lbfechaDePublicacion);
            panelAlta.Controls.Add(tbApellidoAlta);
            panelAlta.Controls.Add(lbDescripcion);
            panelAlta.Controls.Add(btnGuardar);
            panelAlta.Location = new Point(175, 71);
            panelAlta.Margin = new Padding(3, 4, 3, 4);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(727, 484);
            panelAlta.TabIndex = 13;
            // 
            // clbGeneroAlta
            // 
            clbGeneroAlta.FormattingEnabled = true;
            clbGeneroAlta.Location = new Point(543, 101);
            clbGeneroAlta.Name = "clbGeneroAlta";
            clbGeneroAlta.Size = new Size(150, 26);
            clbGeneroAlta.TabIndex = 42;
            // 
            // clbAutorAlta
            // 
            clbAutorAlta.FormattingEnabled = true;
            clbAutorAlta.Location = new Point(543, 45);
            clbAutorAlta.Name = "clbAutorAlta";
            clbAutorAlta.Size = new Size(150, 26);
            clbAutorAlta.TabIndex = 41;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(610, 436);
            btGuardar.Margin = new Padding(3, 4, 3, 4);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(86, 31);
            btGuardar.TabIndex = 40;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            // 
            // lbEditorial
            // 
            lbEditorial.AutoSize = true;
            lbEditorial.Location = new Point(424, 155);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(65, 20);
            lbEditorial.TabIndex = 39;
            lbEditorial.Text = "Editorial";
            // 
            // cbEditorialAlta
            // 
            cbEditorialAlta.FormattingEnabled = true;
            cbEditorialAlta.Location = new Point(543, 152);
            cbEditorialAlta.Margin = new Padding(3, 4, 3, 4);
            cbEditorialAlta.Name = "cbEditorialAlta";
            cbEditorialAlta.Size = new Size(153, 28);
            cbEditorialAlta.TabIndex = 38;
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Location = new Point(424, 101);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(57, 20);
            lbGenero.TabIndex = 33;
            lbGenero.Text = "Género";
            // 
            // lbAutor
            // 
            lbAutor.AutoSize = true;
            lbAutor.Location = new Point(424, 48);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(46, 20);
            lbAutor.TabIndex = 31;
            lbAutor.Text = "Autor";
            // 
            // tbPrecioVentaAlta
            // 
            tbPrecioVentaAlta.BorderStyle = BorderStyle.FixedSingle;
            tbPrecioVentaAlta.Location = new Point(174, 155);
            tbPrecioVentaAlta.Margin = new Padding(3, 4, 3, 4);
            tbPrecioVentaAlta.Name = "tbPrecioVentaAlta";
            tbPrecioVentaAlta.Size = new Size(153, 27);
            tbPrecioVentaAlta.TabIndex = 30;
            tbPrecioVentaAlta.KeyPress += tbPrecioVentaAlta_KeyPress;
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(32, 159);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(112, 20);
            lbPrecioVenta.TabIndex = 29;
            lbPrecioVenta.Text = "Precio de Venta";
            // 
            // dtFechaPublicacionAlta
            // 
            dtFechaPublicacionAlta.Location = new Point(174, 433);
            dtFechaPublicacionAlta.Margin = new Padding(3, 4, 3, 4);
            dtFechaPublicacionAlta.Name = "dtFechaPublicacionAlta";
            dtFechaPublicacionAlta.Size = new Size(254, 27);
            dtFechaPublicacionAlta.TabIndex = 28;
            // 
            // tbDescripcionAlta
            // 
            tbDescripcionAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescripcionAlta.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcionAlta.Location = new Point(31, 243);
            tbDescripcionAlta.Margin = new Padding(3, 4, 3, 4);
            tbDescripcionAlta.Multiline = true;
            tbDescripcionAlta.Name = "tbDescripcionAlta";
            tbDescripcionAlta.Size = new Size(665, 165);
            tbDescripcionAlta.TabIndex = 27;
            // 
            // lbFechaNacimientoAlta
            // 
            lbFechaNacimientoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbFechaNacimientoAlta.AutoSize = true;
            lbFechaNacimientoAlta.Location = new Point(864, 85);
            lbFechaNacimientoAlta.Name = "lbFechaNacimientoAlta";
            lbFechaNacimientoAlta.Size = new Size(128, 20);
            lbFechaNacimientoAlta.TabIndex = 26;
            lbFechaNacimientoAlta.Text = "Fecha Nacimiento";
            // 
            // tbISBNAlta
            // 
            tbISBNAlta.BorderStyle = BorderStyle.FixedSingle;
            tbISBNAlta.Location = new Point(174, 37);
            tbISBNAlta.Margin = new Padding(3, 4, 3, 4);
            tbISBNAlta.Name = "tbISBNAlta";
            tbISBNAlta.Size = new Size(153, 27);
            tbISBNAlta.TabIndex = 12;
            // 
            // tbFechaNacimientoAlta
            // 
            tbFechaNacimientoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbFechaNacimientoAlta.Location = new Point(989, 81);
            tbFechaNacimientoAlta.Margin = new Padding(3, 4, 3, 4);
            tbFechaNacimientoAlta.Name = "tbFechaNacimientoAlta";
            tbFechaNacimientoAlta.Size = new Size(139, 27);
            tbFechaNacimientoAlta.TabIndex = 16;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(32, 45);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 14;
            lblISBN.Text = "ISBN";
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbBiografiaAlta.Location = new Point(90, 593);
            tbBiografiaAlta.Margin = new Padding(3, 4, 3, 4);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(1099, 168);
            tbBiografiaAlta.TabIndex = 21;
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(865, 24);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(66, 20);
            lbApellidoAlta.TabIndex = 17;
            lbApellidoAlta.Text = "Apellido";
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(864, 155);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(67, 20);
            lbTelefonoAlta.TabIndex = 20;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbTituloAlta
            // 
            tbTituloAlta.BorderStyle = BorderStyle.FixedSingle;
            tbTituloAlta.Location = new Point(174, 97);
            tbTituloAlta.Margin = new Padding(3, 4, 3, 4);
            tbTituloAlta.Name = "tbTituloAlta";
            tbTituloAlta.Size = new Size(153, 27);
            tbTituloAlta.TabIndex = 15;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(32, 101);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(47, 20);
            lbTitulo.TabIndex = 23;
            lbTitulo.Text = "Título";
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTelefonoAlta.Location = new Point(990, 144);
            tbTelefonoAlta.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(138, 27);
            tbTelefonoAlta.TabIndex = 19;
            // 
            // lbfechaDePublicacion
            // 
            lbfechaDePublicacion.AutoSize = true;
            lbfechaDePublicacion.Location = new Point(31, 441);
            lbfechaDePublicacion.Name = "lbfechaDePublicacion";
            lbfechaDePublicacion.Size = new Size(148, 20);
            lbfechaDePublicacion.TabIndex = 24;
            lbfechaDePublicacion.Text = "Fecha de Publicación";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbApellidoAlta.Location = new Point(986, 20);
            tbApellidoAlta.Margin = new Padding(3, 4, 3, 4);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(141, 27);
            tbApellidoAlta.TabIndex = 13;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(31, 219);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(87, 20);
            lbDescripcion.TabIndex = 25;
            lbDescripcion.Text = "Descripción";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Location = new Point(273, 788);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(680, 31);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabModificar
            // 
            tabModificar.Controls.Add(panel1);
            tabModificar.Location = new Point(4, 29);
            tabModificar.Margin = new Padding(3, 4, 3, 4);
            tabModificar.Name = "tabModificar";
            tabModificar.Size = new Size(1078, 630);
            tabModificar.TabIndex = 2;
            tabModificar.Text = "Modificar";
            tabModificar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(clbGeneroModificar);
            panel1.Controls.Add(clbAutorModificar);
            panel1.Controls.Add(tbIdLibroModificacion);
            panel1.Controls.Add(lbIdLibroModificacion);
            panel1.Controls.Add(tbDescripcionModificar);
            panel1.Controls.Add(btActualizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbEditorialModificar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPrecioVentaModificar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtFechaPublicacionModificar);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbISBNModificar);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(lbISBN);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbTituloModificar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(175, 71);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 484);
            panel1.TabIndex = 14;
            // 
            // clbGeneroModificar
            // 
            clbGeneroModificar.FormattingEnabled = true;
            clbGeneroModificar.Location = new Point(543, 125);
            clbGeneroModificar.Name = "clbGeneroModificar";
            clbGeneroModificar.Size = new Size(150, 26);
            clbGeneroModificar.TabIndex = 48;
            // 
            // clbAutorModificar
            // 
            clbAutorModificar.FormattingEnabled = true;
            clbAutorModificar.Location = new Point(543, 83);
            clbAutorModificar.Name = "clbAutorModificar";
            clbAutorModificar.Size = new Size(150, 26);
            clbAutorModificar.TabIndex = 47;
            // 
            // tbIdLibroModificacion
            // 
            tbIdLibroModificacion.BorderStyle = BorderStyle.FixedSingle;
            tbIdLibroModificacion.Location = new Point(301, 23);
            tbIdLibroModificacion.Margin = new Padding(3, 4, 3, 4);
            tbIdLibroModificacion.Name = "tbIdLibroModificacion";
            tbIdLibroModificacion.ReadOnly = true;
            tbIdLibroModificacion.Size = new Size(180, 27);
            tbIdLibroModificacion.TabIndex = 45;
            // 
            // lbIdLibroModificacion
            // 
            lbIdLibroModificacion.AutoSize = true;
            lbIdLibroModificacion.Location = new Point(230, 25);
            lbIdLibroModificacion.Name = "lbIdLibroModificacion";
            lbIdLibroModificacion.Size = new Size(62, 20);
            lbIdLibroModificacion.TabIndex = 46;
            lbIdLibroModificacion.Text = "ID Libro";
            // 
            // tbDescripcionModificar
            // 
            tbDescripcionModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescripcionModificar.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcionModificar.Location = new Point(32, 243);
            tbDescripcionModificar.Margin = new Padding(3, 4, 3, 4);
            tbDescripcionModificar.Multiline = true;
            tbDescripcionModificar.Name = "tbDescripcionModificar";
            tbDescripcionModificar.Size = new Size(665, 165);
            tbDescripcionModificar.TabIndex = 41;
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(610, 441);
            btActualizar.Margin = new Padding(3, 4, 3, 4);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(86, 31);
            btActualizar.TabIndex = 40;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 167);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 39;
            label1.Text = "Editorial";
            // 
            // cbEditorialModificar
            // 
            cbEditorialModificar.FormattingEnabled = true;
            cbEditorialModificar.Location = new Point(543, 160);
            cbEditorialModificar.Margin = new Padding(3, 4, 3, 4);
            cbEditorialModificar.Name = "cbEditorialModificar";
            cbEditorialModificar.Size = new Size(153, 28);
            cbEditorialModificar.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 33;
            label2.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 85);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 31;
            label3.Text = "Autor";
            // 
            // tbPrecioVentaModificar
            // 
            tbPrecioVentaModificar.BorderStyle = BorderStyle.FixedSingle;
            tbPrecioVentaModificar.Location = new Point(174, 160);
            tbPrecioVentaModificar.Margin = new Padding(3, 4, 3, 4);
            tbPrecioVentaModificar.Name = "tbPrecioVentaModificar";
            tbPrecioVentaModificar.Size = new Size(153, 27);
            tbPrecioVentaModificar.TabIndex = 30;
            tbPrecioVentaModificar.KeyPress += tbPrecioVentaModificar_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 29;
            label4.Text = "Precio de Venta";
            // 
            // dtFechaPublicacionModificar
            // 
            dtFechaPublicacionModificar.Location = new Point(174, 433);
            dtFechaPublicacionModificar.Margin = new Padding(3, 4, 3, 4);
            dtFechaPublicacionModificar.Name = "dtFechaPublicacionModificar";
            dtFechaPublicacionModificar.Size = new Size(254, 27);
            dtFechaPublicacionModificar.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(31, 593);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1163, 165);
            textBox4.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1362, 85);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 26;
            label5.Text = "Fecha Nacimiento";
            // 
            // tbISBNModificar
            // 
            tbISBNModificar.BorderStyle = BorderStyle.FixedSingle;
            tbISBNModificar.Location = new Point(174, 80);
            tbISBNModificar.Margin = new Padding(3, 4, 3, 4);
            tbISBNModificar.Name = "tbISBNModificar";
            tbISBNModificar.Size = new Size(153, 27);
            tbISBNModificar.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(1487, 81);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 27);
            textBox6.TabIndex = 16;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(33, 83);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(41, 20);
            lbISBN.TabIndex = 14;
            lbISBN.Text = "ISBN";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(90, 944);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(1597, 168);
            textBox7.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1363, 24);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 17;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(1362, 155);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 20;
            label8.Text = "Telefono";
            // 
            // tbTituloModificar
            // 
            tbTituloModificar.BorderStyle = BorderStyle.FixedSingle;
            tbTituloModificar.Location = new Point(174, 121);
            tbTituloModificar.Margin = new Padding(3, 4, 3, 4);
            tbTituloModificar.Name = "tbTituloModificar";
            tbTituloModificar.Size = new Size(153, 27);
            tbTituloModificar.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 125);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 23;
            label9.Text = "Título";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox9.Location = new Point(1488, 144);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(138, 27);
            textBox9.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 441);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 24;
            label10.Text = "Fecha de Publicación";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox10.Location = new Point(1485, 20);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(141, 27);
            textBox10.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 219);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 25;
            label11.Text = "Descripción";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(273, 1139);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(1178, 31);
            button2.TabIndex = 22;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ABMLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 695);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABMLibro";
            Text = "AMBLibro";
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoLibros).EndInit();
            tabAlta.ResumeLayout(false);
            panelAlta.ResumeLayout(false);
            panelAlta.PerformLayout();
            tabModificar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabAlta;
        private TabPage tabModificar;
        private DataGridView dgvListadoLibros;
        private Button btRecargar;
        private Panel panelAlta;
        private Label lbFechaNacimientoAlta;
        private TextBox tbISBNAlta;
        private TextBox tbFechaNacimientoAlta;
        private Label lblISBN;
        private TextBox tbBiografiaAlta;
        private Label lbApellidoAlta;
        private Label lbTelefonoAlta;
        private TextBox tbTituloAlta;
        private Label lbTitulo;
        private TextBox tbTelefonoAlta;
        private Label lbfechaDePublicacion;
        private TextBox tbApellidoAlta;
        private Label lbDescripcion;
        private Button btnGuardar;
        private DateTimePicker dtFechaPublicacionAlta;
        private TextBox tbDescripcionAlta;
        private TextBox tbPrecioVentaAlta;
        private Label lbPrecioVenta;
        private Label lbAutor;
        private Label lbGenero;
        private Label lbEditorial;
        private ComboBox cbEditorialAlta;
        private Button btGuardar;
        private Panel panel1;
        private TextBox tbDescripcionModificar;
        private Button btActualizar;
        private Label label1;
        private ComboBox cbEditorialModificar;
        private Label label2;
        private Label label3;
        private TextBox tbPrecioVentaModificar;
        private Label label4;
        private DateTimePicker dtFechaPublicacionModificar;
        private TextBox textBox4;
        private Label label5;
        private TextBox tbISBNModificar;
        private TextBox textBox6;
        private Label lbISBN;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private TextBox tbTituloModificar;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private Button button2;
        private TextBox tbIdLibroModificacion;
        private Label lbIdLibroModificacion;
        private CheckedListBox clbAutorAlta;
        private CheckedListBox clbGeneroAlta;
        private CheckedListBox clbGeneroModificar;
        private CheckedListBox clbAutorModificar;
    }
}
