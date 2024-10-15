using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System.Linq;

namespace EjemploRepositorios
{
    public partial class ABMLibro : Form
    {
        private ILibroLogic _libroLogic;
        private IAutorLogic _autorLogic;
        private IGeneroLogic _generoLogic;


        private bool allowTabChange = false;


        public ABMLibro(ILibroLogic libroLogic)
        {
            _libroLogic = libroLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoLibros();
                clbAutorAlta.DataSource = _autorLogic.ObtenerAutores();
                clbAutorAlta.DisplayMember = "Nombre";
                clbAutorAlta.ValueMember = "IdAutor";
            }
        }

        private void ABMLibro_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();

        }

        private void CargarListadoLibros()
        {
            List<dynamic> libros = _libroLogic.ObtenerLibroParaListado();
            dgvListadoLibros.DataSource = libros;

            dgvListadoLibros.Columns["btnModificarColumna"].DisplayIndex = dgvListadoLibros.Columns.Count - 1;
            dgvListadoLibros.Columns["btnEliminarColumna"].DisplayIndex = dgvListadoLibros.Columns.Count - 1;
        }

        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoLibros.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "btnModificarColumna";
            modifyButtonColumn.HeaderText = "";
            modifyButtonColumn.Text = "Modificar";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoLibros.Columns.Add(modifyButtonColumn);

            CargarListadoLibros();

            modifyButtonColumn.DisplayIndex = dgvListadoLibros.Columns.Count - 1;
            deleteButtonColumn.DisplayIndex = dgvListadoLibros.Columns.Count - 1;
        }

        private void dgvListadoLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoLibros.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string libroId = dgvListadoLibros.Rows[e.RowIndex].Cells["IdLibro"].Value.ToString();

                _libroLogic.BajaLibro(libroId);
                CargarListadoLibros();
            }

            if (e.ColumnIndex == dgvListadoLibros.Columns["btnModificarColumna"].Index && e.RowIndex >= 0)
            {
                string libroId = dgvListadoLibros.Rows[e.RowIndex].Cells["IdLibro"].Value.ToString();

                tbIdLibroModificacion.Text = libroId;
                DatosLibrosModificacion(libroId);
                allowTabChange = true;
                tabControlPrincipal.SelectedTab = tabModificar;
            }
        }

        private void DatosLibrosModificacion(string autorId)
        {
            Libro? libro = _libroLogic.ObtenerLibroPorID(tbIdLibroModificacion.Text);

            tbISBNModificar.Text = libro.ISBN;
            tbTituloModificar.Text = libro.Titulo;
            tbPrecioVentaModificar.Text = libro.PrecioVenta.ToString("F2");
            cbEditorialModificar.SelectedItem = libro.Editorial;
            tbDescripcionModificar.Text = libro.Descripcion;
            dtFechaPublicacionModificar.Value = libro.FechaPublicacion;
            foreach (Autor autor in libro.Autores)
            {
                for (int i = 0; i < clbAutorModificar.Items.Count; i++)
                {
                    Autor item = (Autor)clbAutorModificar.Items[i];
                    if (item.IdAutor == autor.IdAutor)
                    {
                        clbAutorModificar.SetItemChecked(i, true);  // Marca el autor correspondiente por Id
                    }
                }
            }
            foreach (Genero genero in libro.Generos)
            {
                for (int i = 0; i < clbGeneroModificar.Items.Count; i++)
                {
                    Genero item = (Genero)clbGeneroModificar.Items[i];
                    if (item.IdGenero == genero.IdGenero)
                    {
                        clbGeneroModificar.SetItemChecked(i, true);  // Marca el género correspondiente por Id
                    }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string ISBN = tbISBNAlta.Text;
            string titulo = tbTituloAlta.Text;
            DateTime fechaPublicacion = dtFechaPublicacionAlta.Value;
            float precioVenta = float.Parse(tbPrecioVentaAlta.Text);
            string descripcion = tbDescripcionAlta.Text;
            string editorial = cbEditorialAlta.Text;
            List<int> autor = (from int autorSeleccionado in clbAutorAlta.CheckedItems
                               select autorSeleccionado).ToList();
            List<int> genero = (from int generoSeleccionado in clbGeneroAlta.CheckedItems
                                select generoSeleccionado).ToList();
            try
            {
                _libroLogic.AltaLibro(ISBN, titulo, fechaPublicacion, precioVenta, descripcion, editorial, autor, genero);
                MessageBox.Show("El autor se ha registrado con éxito.");

                tbISBNAlta.Clear();
                tbTituloAlta.Clear();
                dtFechaPublicacionModificar.Value = DateTime.Now;
                tbTelefonoAlta.Clear();
                tbBiografiaAlta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnRecargarAlta_Click(object sender, EventArgs e)
        {
            CargarListadoLibros();
        }

        private void tabControlPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabModificar && !allowTabChange)
            {
                e.Cancel = true;
            }
            else
            {
                allowTabChange = false;
            }
        }
        private void tbPrecioVentaModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumerica(sender, e);
        }

        private void tbPrecioVentaAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumerica(sender, e);
        }

        private void TextBoxNumerica(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla es un dígito o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Rechaza la tecla si no es válida
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Rechaza si ya hay un punto decimal
            }
        }


    }
}
