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
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(950, 497);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(btRecargar);
            tabListado.Controls.Add(dgvListadoLibros);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3, 3, 3, 3);
            tabListado.Size = new Size(942, 469);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // btRecargar
            // 
            btRecargar.Location = new Point(845, 439);
            btRecargar.Name = "btRecargar";
            btRecargar.Size = new Size(91, 24);
            btRecargar.TabIndex = 1;
            btRecargar.Text = "button1";
            btRecargar.UseVisualStyleBackColor = true;
            // 
            // dgvListadoLibros
            // 
            dgvListadoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoLibros.Location = new Point(6, 5);
            dgvListadoLibros.Name = "dgvListadoLibros";
            dgvListadoLibros.RowHeadersWidth = 51;
            dgvListadoLibros.Size = new Size(930, 428);
            dgvListadoLibros.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3, 3, 3, 3);
            tabAlta.Size = new Size(942, 469);
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
            panelAlta.Location = new Point(153, 53);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(636, 363);
            panelAlta.TabIndex = 13;
            // 
            // clbGeneroAlta
            // 
            clbGeneroAlta.FormattingEnabled = true;
            clbGeneroAlta.Location = new Point(475, 73);
            clbGeneroAlta.Margin = new Padding(3, 2, 3, 2);
            clbGeneroAlta.Name = "clbGeneroAlta";
            clbGeneroAlta.Size = new Size(134, 22);
            clbGeneroAlta.TabIndex = 42;
            // 
            // clbAutorAlta
            // 
            clbAutorAlta.FormattingEnabled = true;
            clbAutorAlta.Location = new Point(475, 29);
            clbAutorAlta.Margin = new Padding(3, 2, 3, 2);
            clbAutorAlta.Name = "clbAutorAlta";
            clbAutorAlta.Size = new Size(134, 22);
            clbAutorAlta.TabIndex = 41;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(534, 327);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 40;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            // 
            // lbEditorial
            // 
            lbEditorial.AutoSize = true;
            lbEditorial.Location = new Point(371, 116);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(50, 15);
            lbEditorial.TabIndex = 39;
            lbEditorial.Text = "Editorial";
            // 
            // cbEditorialAlta
            // 
            cbEditorialAlta.FormattingEnabled = true;
            cbEditorialAlta.Location = new Point(475, 115);
            cbEditorialAlta.Name = "cbEditorialAlta";
            cbEditorialAlta.Size = new Size(134, 23);
            cbEditorialAlta.TabIndex = 38;
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Location = new Point(371, 76);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(45, 15);
            lbGenero.TabIndex = 33;
            lbGenero.Text = "Género";
            // 
            // lbAutor
            // 
            lbAutor.AutoSize = true;
            lbAutor.Location = new Point(371, 36);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(37, 15);
            lbAutor.TabIndex = 31;
            lbAutor.Text = "Autor";
            // 
            // tbPrecioVentaAlta
            // 
            tbPrecioVentaAlta.BorderStyle = BorderStyle.FixedSingle;
            tbPrecioVentaAlta.Location = new Point(152, 116);
            tbPrecioVentaAlta.Name = "tbPrecioVentaAlta";
            tbPrecioVentaAlta.Size = new Size(134, 23);
            tbPrecioVentaAlta.TabIndex = 30;
            tbPrecioVentaAlta.KeyPress += tbPrecioVentaAlta_KeyPress;
            // 
            // lbPrecioVenta
            // 
            lbPrecioVenta.AutoSize = true;
            lbPrecioVenta.Location = new Point(28, 119);
            lbPrecioVenta.Name = "lbPrecioVenta";
            lbPrecioVenta.Size = new Size(88, 15);
            lbPrecioVenta.TabIndex = 29;
            lbPrecioVenta.Text = "Precio de Venta";
            // 
            // dtFechaPublicacionAlta
            // 
            dtFechaPublicacionAlta.Location = new Point(152, 325);
            dtFechaPublicacionAlta.Name = "dtFechaPublicacionAlta";
            dtFechaPublicacionAlta.Size = new Size(223, 23);
            dtFechaPublicacionAlta.TabIndex = 28;
            // 
            // tbDescripcionAlta
            // 
            tbDescripcionAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescripcionAlta.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcionAlta.Location = new Point(27, 182);
            tbDescripcionAlta.Multiline = true;
            tbDescripcionAlta.Name = "tbDescripcionAlta";
            tbDescripcionAlta.Size = new Size(582, 124);
            tbDescripcionAlta.TabIndex = 27;
            // 
            // lbFechaNacimientoAlta
            // 
            lbFechaNacimientoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbFechaNacimientoAlta.AutoSize = true;
            lbFechaNacimientoAlta.Location = new Point(756, 64);
            lbFechaNacimientoAlta.Name = "lbFechaNacimientoAlta";
            lbFechaNacimientoAlta.Size = new Size(103, 15);
            lbFechaNacimientoAlta.TabIndex = 26;
            lbFechaNacimientoAlta.Text = "Fecha Nacimiento";
            // 
            // tbISBNAlta
            // 
            tbISBNAlta.BorderStyle = BorderStyle.FixedSingle;
            tbISBNAlta.Location = new Point(152, 28);
            tbISBNAlta.Name = "tbISBNAlta";
            tbISBNAlta.Size = new Size(134, 23);
            tbISBNAlta.TabIndex = 12;
            // 
            // tbFechaNacimientoAlta
            // 
            tbFechaNacimientoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbFechaNacimientoAlta.Location = new Point(865, 61);
            tbFechaNacimientoAlta.Name = "tbFechaNacimientoAlta";
            tbFechaNacimientoAlta.Size = new Size(122, 23);
            tbFechaNacimientoAlta.TabIndex = 16;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(28, 34);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 14;
            lblISBN.Text = "ISBN";
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbBiografiaAlta.Location = new Point(79, 445);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(962, 127);
            tbBiografiaAlta.TabIndex = 21;
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(757, 18);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(51, 15);
            lbApellidoAlta.TabIndex = 17;
            lbApellidoAlta.Text = "Apellido";
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(756, 116);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(52, 15);
            lbTelefonoAlta.TabIndex = 20;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbTituloAlta
            // 
            tbTituloAlta.BorderStyle = BorderStyle.FixedSingle;
            tbTituloAlta.Location = new Point(152, 73);
            tbTituloAlta.Name = "tbTituloAlta";
            tbTituloAlta.Size = new Size(134, 23);
            tbTituloAlta.TabIndex = 15;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(28, 76);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(37, 15);
            lbTitulo.TabIndex = 23;
            lbTitulo.Text = "Título";
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTelefonoAlta.Location = new Point(866, 108);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(121, 23);
            tbTelefonoAlta.TabIndex = 19;
            // 
            // lbfechaDePublicacion
            // 
            lbfechaDePublicacion.AutoSize = true;
            lbfechaDePublicacion.Location = new Point(27, 331);
            lbfechaDePublicacion.Name = "lbfechaDePublicacion";
            lbfechaDePublicacion.Size = new Size(119, 15);
            lbfechaDePublicacion.TabIndex = 24;
            lbfechaDePublicacion.Text = "Fecha de Publicación";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbApellidoAlta.Location = new Point(863, 15);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(124, 23);
            tbApellidoAlta.TabIndex = 13;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(27, 164);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(69, 15);
            lbDescripcion.TabIndex = 25;
            lbDescripcion.Text = "Descripción";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Location = new Point(239, 591);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(595, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabModificar
            // 
            tabModificar.Controls.Add(panel1);
            tabModificar.Location = new Point(4, 24);
            tabModificar.Name = "tabModificar";
            tabModificar.Size = new Size(942, 469);
            tabModificar.TabIndex = 2;
            tabModificar.Text = "Modificar";
            tabModificar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
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
            panel1.Location = new Point(153, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 363);
            panel1.TabIndex = 14;
            // 
            // clbGeneroModificar
            // 
            clbGeneroModificar.FormattingEnabled = true;
            clbGeneroModificar.Location = new Point(475, 94);
            clbGeneroModificar.Margin = new Padding(3, 2, 3, 2);
            clbGeneroModificar.Name = "clbGeneroModificar";
            clbGeneroModificar.Size = new Size(134, 22);
            clbGeneroModificar.TabIndex = 48;
            // 
            // clbAutorModificar
            // 
            clbAutorModificar.FormattingEnabled = true;
            clbAutorModificar.Location = new Point(475, 62);
            clbAutorModificar.Margin = new Padding(3, 2, 3, 2);
            clbAutorModificar.Name = "clbAutorModificar";
            clbAutorModificar.Size = new Size(134, 22);
            clbAutorModificar.TabIndex = 47;
            // 
            // tbIdLibroModificacion
            // 
            tbIdLibroModificacion.BorderStyle = BorderStyle.FixedSingle;
            tbIdLibroModificacion.Location = new Point(263, 17);
            tbIdLibroModificacion.Name = "tbIdLibroModificacion";
            tbIdLibroModificacion.ReadOnly = true;
            tbIdLibroModificacion.Size = new Size(158, 23);
            tbIdLibroModificacion.TabIndex = 45;
            // 
            // lbIdLibroModificacion
            // 
            lbIdLibroModificacion.AutoSize = true;
            lbIdLibroModificacion.Location = new Point(201, 19);
            lbIdLibroModificacion.Name = "lbIdLibroModificacion";
            lbIdLibroModificacion.Size = new Size(48, 15);
            lbIdLibroModificacion.TabIndex = 46;
            lbIdLibroModificacion.Text = "ID Libro";
            // 
            // tbDescripcionModificar
            // 
            tbDescripcionModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescripcionModificar.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcionModificar.Location = new Point(28, 182);
            tbDescripcionModificar.Multiline = true;
            tbDescripcionModificar.Name = "tbDescripcionModificar";
            tbDescripcionModificar.Size = new Size(582, 124);
            tbDescripcionModificar.TabIndex = 41;
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(534, 331);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(75, 23);
            btActualizar.TabIndex = 40;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 125);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 39;
            label1.Text = "Editorial";
            // 
            // cbEditorialModificar
            // 
            cbEditorialModificar.FormattingEnabled = true;
            cbEditorialModificar.Location = new Point(475, 120);
            cbEditorialModificar.Name = "cbEditorialModificar";
            cbEditorialModificar.Size = new Size(134, 23);
            cbEditorialModificar.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 94);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 33;
            label2.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 31;
            label3.Text = "Autor";
            // 
            // tbPrecioVentaModificar
            // 
            tbPrecioVentaModificar.BorderStyle = BorderStyle.FixedSingle;
            tbPrecioVentaModificar.Location = new Point(152, 120);
            tbPrecioVentaModificar.Name = "tbPrecioVentaModificar";
            tbPrecioVentaModificar.Size = new Size(134, 23);
            tbPrecioVentaModificar.TabIndex = 30;
            tbPrecioVentaModificar.KeyPress += tbPrecioVentaModificar_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 123);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 29;
            label4.Text = "Precio de Venta";
            // 
            // dtFechaPublicacionModificar
            // 
            dtFechaPublicacionModificar.Location = new Point(152, 325);
            dtFechaPublicacionModificar.Name = "dtFechaPublicacionModificar";
            dtFechaPublicacionModificar.Size = new Size(223, 23);
            dtFechaPublicacionModificar.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1192, 64);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 26;
            label5.Text = "Fecha Nacimiento";
            // 
            // tbISBNModificar
            // 
            tbISBNModificar.BorderStyle = BorderStyle.FixedSingle;
            tbISBNModificar.Location = new Point(152, 60);
            tbISBNModificar.Name = "tbISBNModificar";
            tbISBNModificar.Size = new Size(134, 23);
            tbISBNModificar.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(1301, 61);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 23);
            textBox6.TabIndex = 16;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(29, 62);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(32, 15);
            lbISBN.TabIndex = 14;
            lbISBN.Text = "ISBN";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(79, 708);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(1398, 127);
            textBox7.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1193, 18);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 17;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(1192, 116);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 20;
            label8.Text = "Telefono";
            // 
            // tbTituloModificar
            // 
            tbTituloModificar.BorderStyle = BorderStyle.FixedSingle;
            tbTituloModificar.Location = new Point(152, 91);
            tbTituloModificar.Name = "tbTituloModificar";
            tbTituloModificar.Size = new Size(134, 23);
            tbTituloModificar.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 94);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 23;
            label9.Text = "Título";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox9.Location = new Point(1302, 108);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(121, 23);
            textBox9.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 331);
            label10.Name = "label10";
            label10.Size = new Size(119, 15);
            label10.TabIndex = 24;
            label10.Text = "Fecha de Publicación";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox10.Location = new Point(1299, 15);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(124, 23);
            textBox10.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 164);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 25;
            label11.Text = "Descripción";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(239, 854);
            button2.Name = "button2";
            button2.Size = new Size(1031, 23);
            button2.TabIndex = 22;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ABMLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 521);
            Controls.Add(tabControlPrincipal);
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
