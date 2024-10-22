using CLogica.Contracts;
using CLogica.Implementations;
using EjemploRepositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class Inicio : Form
    {
        IAutorLogic _autorLogic;
        IClienteLogic _clienteLogic;
        IEmpleadoLogic _empleadoLogic;
        ILibroLogic _libroLogic;
        IGeneroLogic _generoLogic;

        public Inicio(IAutorLogic autorLogic, IClienteLogic clienteLogic, IEmpleadoLogic empleadoLogic, ILibroLogic libroLogic, IGeneroLogic generoLogic)
        {
            InitializeComponent();

            _autorLogic = autorLogic;
            _clienteLogic = clienteLogic;
            _empleadoLogic = empleadoLogic;
            _libroLogic = libroLogic;
            _generoLogic = generoLogic;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMAutor abmAutor = new ABMAutor(_autorLogic);
            abmAutor.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCliente abmCliente = new ABMCliente(_clienteLogic);
            abmCliente.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleado abmEmpleado = new ABMEmpleado(_empleadoLogic);
            abmEmpleado.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMLibro abmLibro = new ABMLibro(_libroLogic);
            abmLibro.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMGenero abmGenero = new ABMGenero(_generoLogic);
            abmGenero.Show();
        }
    }
}
