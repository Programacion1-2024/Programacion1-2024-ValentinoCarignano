namespace Presentacion
{
    partial class Form1
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
            tabClientes = new TabPage();
            btnCrearCliente = new Button();
            tbxApellidoCliente = new TextBox();
            tbxNombreCliente = new TextBox();
            tbxDNICliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gridClientes = new DataGridView();
            tabTarjetasCredito = new TabPage();
            dataGridView1 = new DataGridView();
            tabCuentasBancarias = new TabPage();
            btnCrearCuentaBancaria = new Button();
            cbTipoCuenta = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cbDNI = new ComboBox();
            label4 = new Label();
            tbNroCUenta = new TextBox();
            gridCuentas = new DataGridView();
            tabControlPrincipal.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            tabTarjetasCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabCuentasBancarias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCuentas).BeginInit();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabClientes);
            tabControlPrincipal.Controls.Add(tabTarjetasCredito);
            tabControlPrincipal.Controls.Add(tabCuentasBancarias);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(776, 426);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(btnCrearCliente);
            tabClientes.Controls.Add(tbxApellidoCliente);
            tabClientes.Controls.Add(tbxNombreCliente);
            tabClientes.Controls.Add(tbxDNICliente);
            tabClientes.Controls.Add(label3);
            tabClientes.Controls.Add(label2);
            tabClientes.Controls.Add(label1);
            tabClientes.Controls.Add(gridClientes);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(768, 398);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.Font = new Font("Segoe UI", 12F);
            btnCrearCliente.Location = new Point(639, 67);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(100, 29);
            btnCrearCliente.TabIndex = 4;
            btnCrearCliente.Text = "Crear";
            btnCrearCliente.UseVisualStyleBackColor = true;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // tbxApellidoCliente
            // 
            tbxApellidoCliente.Font = new Font("Segoe UI", 12F);
            tbxApellidoCliente.Location = new Point(496, 67);
            tbxApellidoCliente.Name = "tbxApellidoCliente";
            tbxApellidoCliente.Size = new Size(100, 29);
            tbxApellidoCliente.TabIndex = 2;
            // 
            // tbxNombreCliente
            // 
            tbxNombreCliente.Font = new Font("Segoe UI", 12F);
            tbxNombreCliente.Location = new Point(291, 67);
            tbxNombreCliente.Name = "tbxNombreCliente";
            tbxNombreCliente.Size = new Size(100, 29);
            tbxNombreCliente.TabIndex = 1;
            // 
            // tbxDNICliente
            // 
            tbxDNICliente.Font = new Font("Segoe UI", 12F);
            tbxDNICliente.Location = new Point(73, 67);
            tbxDNICliente.Name = "tbxDNICliente";
            tbxDNICliente.Size = new Size(100, 29);
            tbxDNICliente.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(423, 70);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(217, 70);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // gridClientes
            // 
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(6, 137);
            gridClientes.Name = "gridClientes";
            gridClientes.Size = new Size(756, 255);
            gridClientes.TabIndex = 4;
            // 
            // tabTarjetasCredito
            // 
            tabTarjetasCredito.Controls.Add(dataGridView1);
            tabTarjetasCredito.Location = new Point(4, 24);
            tabTarjetasCredito.Name = "tabTarjetasCredito";
            tabTarjetasCredito.Padding = new Padding(3);
            tabTarjetasCredito.Size = new Size(768, 398);
            tabTarjetasCredito.TabIndex = 1;
            tabTarjetasCredito.Text = "Tarjetas Credito";
            tabTarjetasCredito.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 255);
            dataGridView1.TabIndex = 5;
            // 
            // tabCuentasBancarias
            // 
            tabCuentasBancarias.Controls.Add(btnCrearCuentaBancaria);
            tabCuentasBancarias.Controls.Add(cbTipoCuenta);
            tabCuentasBancarias.Controls.Add(label6);
            tabCuentasBancarias.Controls.Add(label5);
            tabCuentasBancarias.Controls.Add(cbDNI);
            tabCuentasBancarias.Controls.Add(label4);
            tabCuentasBancarias.Controls.Add(tbNroCUenta);
            tabCuentasBancarias.Controls.Add(gridCuentas);
            tabCuentasBancarias.Location = new Point(4, 24);
            tabCuentasBancarias.Name = "tabCuentasBancarias";
            tabCuentasBancarias.Padding = new Padding(3);
            tabCuentasBancarias.Size = new Size(768, 398);
            tabCuentasBancarias.TabIndex = 2;
            tabCuentasBancarias.Text = "Cuentas Bancarias";
            tabCuentasBancarias.UseVisualStyleBackColor = true;
            // 
            // btnCrearCuentaBancaria
            // 
            btnCrearCuentaBancaria.Font = new Font("Segoe UI", 12F);
            btnCrearCuentaBancaria.Location = new Point(662, 14);
            btnCrearCuentaBancaria.Name = "btnCrearCuentaBancaria";
            btnCrearCuentaBancaria.Size = new Size(100, 29);
            btnCrearCuentaBancaria.TabIndex = 17;
            btnCrearCuentaBancaria.Text = "Crear";
            btnCrearCuentaBancaria.UseVisualStyleBackColor = true;
            btnCrearCuentaBancaria.Click += btnCrearCuentaBancaria_Click;
            // 
            // cbTipoCuenta
            // 
            cbTipoCuenta.Font = new Font("Segoe UI", 12F);
            cbTipoCuenta.FormattingEnabled = true;
            cbTipoCuenta.Items.AddRange(new object[] { "Corriente", "Ahorro" });
            cbTipoCuenta.Location = new Point(338, 14);
            cbTipoCuenta.Name = "cbTipoCuenta";
            cbTipoCuenta.Size = new Size(100, 29);
            cbTipoCuenta.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 17);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 14;
            label6.Text = "Numero Cuenta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(239, 17);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 13;
            label5.Text = "Tipo Cuenta";
            // 
            // cbDNI
            // 
            cbDNI.Font = new Font("Segoe UI", 12F);
            cbDNI.FormattingEnabled = true;
            cbDNI.Location = new Point(539, 14);
            cbDNI.Name = "cbDNI";
            cbDNI.Size = new Size(100, 29);
            cbDNI.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(444, 17);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 11;
            label4.Text = "DNI Cliente";
            // 
            // tbNroCUenta
            // 
            tbNroCUenta.Font = new Font("Segoe UI", 12F);
            tbNroCUenta.Location = new Point(133, 14);
            tbNroCUenta.Name = "tbNroCUenta";
            tbNroCUenta.Size = new Size(100, 29);
            tbNroCUenta.TabIndex = 7;
            // 
            // gridCuentas
            // 
            gridCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCuentas.Location = new Point(6, 212);
            gridCuentas.Name = "gridCuentas";
            gridCuentas.Size = new Size(756, 180);
            gridCuentas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlPrincipal);
            Name = "Form1";
            Text = "Aplicacion Bancaria";
            Load += Form1_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            tabTarjetasCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabCuentasBancarias.ResumeLayout(false);
            tabCuentasBancarias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabClientes;
        private TabPage tabTarjetasCredito;
        private TabPage tabCuentasBancarias;
        private DataGridView gridClientes;
        private TextBox tbxApellidoCliente;
        private TextBox tbxNombreCliente;
        private TextBox tbxDNICliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCrearCliente;
        private DataGridView dataGridView1;
        private DataGridView gridCuentas;
        private Label label5;
        private ComboBox cbDNI;
        private Label label4;
        private TextBox tbNroCUenta;
        private Label label6;
        private ComboBox cbTipoCuenta;
        private Button btnCrearCuentaBancaria;
    }
}
