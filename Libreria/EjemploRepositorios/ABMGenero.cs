using CEntidades.Entidades;
using CLogica.Contracts;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMGenero : Form
    {

        private IGeneroLogic _generoLogic;
        private bool allowTabChange = false;

        public ABMGenero(IGeneroLogic generoLogic)
        {
            _generoLogic = generoLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoGeneros();
            }
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
        }

        private void CargarListadoGeneros()
        {
            List<dynamic> generos = _generoLogic.ObtenerGenerosParaListado();
            dgvListadoGeneros.DataSource = generos;

            dgvListadoGeneros.Columns["btnModificarColumna"].DisplayIndex = dgvListadoGeneros.Columns.Count - 1;
            dgvListadoGeneros.Columns["btnEliminarColumna"].DisplayIndex = dgvListadoGeneros.Columns.Count - 1;
        }

        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoGeneros.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "btnModificarColumna";
            modifyButtonColumn.HeaderText = "";
            modifyButtonColumn.Text = "Modificar";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoGeneros.Columns.Add(modifyButtonColumn);

            CargarListadoGeneros();

            modifyButtonColumn.DisplayIndex = dgvListadoGeneros.Columns.Count - 1;
            deleteButtonColumn.DisplayIndex = dgvListadoGeneros.Columns.Count - 1;
        }

        private void dgvListadoAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoGeneros.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string generoId = dgvListadoGeneros.Rows[e.RowIndex].Cells["IdGenero"].Value.ToString();

                _generoLogic.BajaGenero(generoId);
                CargarListadoGeneros();
            }

            if (e.ColumnIndex == dgvListadoGeneros.Columns["btnModificarColumna"].Index && e.RowIndex >= 0)
            {
                string generoId = dgvListadoGeneros.Rows[e.RowIndex].Cells["IdGenero"].Value.ToString();

                tbIdGeneroModificacion.Text = generoId;
                DatosUsuarioModificacion(generoId);
                allowTabChange = true;
                tabControlPrincipal.SelectedTab = tabModificacion;
            }
        }

        private void DatosUsuarioModificacion(string autorId)
        {
            Genero? genero = _generoLogic.ObtenerGeneroPorID(tbIdGeneroModificacion.Text);

            tbDescripcionModificacion.Text = genero.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = tbDescripcionAlta.Text;

            try
            {
                _generoLogic.AltaGenero(descripcion);
                MessageBox.Show("El genero se ha registrado con éxito.");

                tbDescripcionAlta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idGenero = tbIdGeneroModificacion.Text;
            string descripcion = tbDescripcionModificacion.Text;

            try
            {
                _generoLogic.ActualizacionGenero(idGenero, descripcion);
                MessageBox.Show("El genero se ha actualizado con éxito.");

                tbIdGeneroModificacion.Clear();
                tbDescripcionModificacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnRecargarAlta_Click(object sender, EventArgs e)
        {
            CargarListadoGeneros();
        }

        private void tabControlPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabModificacion && !allowTabChange)
            {
                e.Cancel = true;
            }
            else
            {
                allowTabChange = false;
            }
        }
    }
}
