using Negocio.Contracts;
using Negocio.Implementations;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        IClienteLogic _clienteLogic;
        ITarjetaCreditoLogic _tarjetaCreditoLogic;
        ICuentaBancariaLogic _cuentaBancariaLogic;

        public Form1(IClienteLogic clienteLogic, ITarjetaCreditoLogic tarjetaCreditoLogic, ICuentaBancariaLogic cuentaBancariaLogic)
        {
            InitializeComponent();

            _clienteLogic = clienteLogic;
            _tarjetaCreditoLogic = tarjetaCreditoLogic;
            _cuentaBancariaLogic = cuentaBancariaLogic;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarCuentas();
            cbDNI.Items.AddRange( _clienteLogic.ObtenerClientesDNI().ToArray());
        }

        public void CargarClientes()
        {
            gridClientes.DataSource = _clienteLogic.ObtenerClientes();
        }

        public void CargarCuentas()
        {
            gridCuentas.DataSource = _cuentaBancariaLogic.ObtenerCuentas();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                _clienteLogic.AgregarCliente(tbxDNICliente.Text, tbxNombreCliente.Text, tbxApellidoCliente.Text);
                CargarClientes();

                tbxDNICliente.Clear();
                tbxNombreCliente.Clear();
                tbxApellidoCliente.Clear();

                MessageBox.Show("Cliente creado con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearCuentaBancaria_Click(object sender, EventArgs e)
        {
            try
            {
                _cuentaBancariaLogic.CrearCuentaBancaria(tbNroCUenta.Text, cbTipoCuenta.Text, cbDNI.Text);
                CargarCuentas();

                tbNroCUenta.Clear();
                cbTipoCuenta.Text = null;
                cbDNI.Text = null;

                MessageBox.Show("Cuenta Bancaria creado con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
