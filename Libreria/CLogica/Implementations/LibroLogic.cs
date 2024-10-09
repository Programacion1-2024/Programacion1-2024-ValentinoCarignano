using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Implementations
{
    public class LibroLogic : ILibroLogic
    {
        private ILibroRepository _libroRepository;
        private IAutorRepository _autorRepository;
        private IGeneroRepository _generoRepository;
        private IEditorialRepository _editorialRepository;


        public LibroLogic(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        public List<Libro> ObtenerLibros()
        {
            return _libroRepository.FindAll().ToList();
        }

        public Libro? ObtenerLibroPorID(string idAutor)
        {
            return _libroRepository.FindByCondition(a => a.IdLibro == Int32.Parse(idAutor)).FirstOrDefault();
        }

        public List<dynamic> ObtenerLibroParaListado()
        {
            return _libroRepository.ObtenerLibros().Select(a => new { IdLibro = a.IdLibro, Titulo = a.Titulo, FechaPublicacion = a.FechaPublicacion, Descripcion = a.Descripcion, PrecioVenta = a.PrecioVenta, Autor = a.Autores, Genero = a.Generos, Editorial = a.Editorial, Copias = a.Copias, Ventas = a.Ventas }).ToList<dynamic>();
        }

        public void AltaLibro(string ISBN, string titulo, DateTime fechaPublicacion, float precioVenta, string descripcion, string editorialBuscar, List<int> listaIdGeneros, List<int> listaIdAutores)
        {
            try
            {
                List<Autor> listaAutores = new List<Autor>();
                foreach (int autor in listaIdAutores)
                {
                    Autor autorBuscar = _autorRepository.FindByCondition(a => a.IdAutor == autor).FirstOrDefault();
                    listaAutores.Add(autorBuscar);
                }

                List<Genero> listaGeneros = new List<Genero>();
                foreach (int genero in listaIdGeneros)
                {
                    Genero generoBuscar = _generoRepository.FindByCondition(g => g.Nombre == genero).FirstOrDefault();
                    listaGeneros.Add(generoBuscar);
                }

                Editorial editorial = _editorialRepository.FindByCondition(g => g.Nombre == editorialBuscar).FirstOrDefault();

                Libro libroNuevo = new Libro()
                {
                    ISBN = ISBN,
                    Titulo = titulo,
                    FechaPublicacion = fechaPublicacion,
                    PrecioVenta = precioVenta,
                    Descripcion = descripcion,
                    Generos = listaGeneros,
                    Editorial = editorial,
                    Autores = listaAutores
                };

                List<string> camposErroneos = new List<string>();

                if (libroNuevo == null)
                {
                    throw new ArgumentNullException("No se ha ingresado ningun libro.");
                }

                if (!ISBNEsValido(libroNuevo.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroNuevo.ISBN).Count() != 0)
                {
                    camposErroneos.Add("ISBN");
                }

                if (libroNuevo.Titulo == null)
                {
                    throw new ArgumentNullException("titulo");
                }

                if (libroNuevo.Descripcion == null)
                {
                    throw new ArgumentNullException("descripcion");
                }

                if (libroNuevo.Autores == null)
                {
                    throw new ArgumentNullException("autor");
                }

                if (libroNuevo.Generos == null)
                {
                    throw new ArgumentNullException("genero");
                }

                if (libroNuevo.Editorial == null)
                {
                    throw new ArgumentNullException("editorial");
                }

                if (libroNuevo.PrecioVenta <= 0)
                {
                    throw new ArgumentNullException("precio");
                }

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
                }

                _libroRepository.Create(libroNuevo);
                _libroRepository.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BajaLibro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn) || !ISBNEsValido(isbn))
            {
                throw new ArgumentException("El ISBN ingresado no es valido.");
            }

            Libro? libroEliminar = _libroRepository.FindByCondition(p => p.ISBN == isbn).FirstOrDefault();

            if (libroEliminar == null)
            {
                throw new InvalidOperationException("El libro que se desea eliminar no existe.");
            }

            _libroRepository.Delete(libroEliminar);
            _libroRepository.Save();
        }

        public void ActualizacionLibro(string isbn, Libro libroActualizar)
        {

            if (libroActualizar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ningun libro.");
            }

            Libro? libroExistente = _libroRepository.FindByCondition(p => p.ISBN == isbn).FirstOrDefault();

            if (libroExistente == null)
            {
                throw new InvalidOperationException("El libro que se desea actualizar no existe.");
            }

            List<string> camposErroneos = new List<string>();

            if (libroActualizar.Titulo == null)
            {
                throw new ArgumentNullException("titulo");
            }

            if (libroActualizar.Descripcion == null)
            {
                throw new ArgumentNullException("descripcion");
            }

            if (libroActualizar.Autores == null)
            {
                throw new ArgumentNullException("autor");
            }

            if (libroActualizar.Generos == null)
            {
                throw new ArgumentNullException("genero");
            }

            if (libroActualizar.Editorial == null)
            {
                throw new ArgumentNullException("editorial");
            }

            if (libroActualizar.PrecioVenta <= 0)
            {
                throw new ArgumentNullException("precio");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            libroExistente.Descripcion = libroActualizar.Descripcion;
            libroExistente.PrecioVenta = libroActualizar.PrecioVenta;

            _libroRepository.Create(libroExistente);
            _libroRepository.Save();
        }

        #region validaciones
        private bool ISBNEsValido(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return true;
            }

            var regex = new Regex(@"^(?:\d{1,5}-\d{1,7}-\d{1,7}-[\dX]|\d{3}-\d{1,5}-\d{1,7}-\d{1,7}-\d)$");
            return regex.IsMatch(isbn);
        }
        #endregion
    }
}