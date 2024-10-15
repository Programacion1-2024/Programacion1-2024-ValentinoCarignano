using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ILibroLogic
    {
        public List<Libro> ObtenerLibros();
        public Libro? ObtenerLibroPorID(string idAutor);
        List<dynamic> ObtenerLibroParaListado();
        void AltaLibro(string ISBN, string titulo, DateTime fechaPublicacion, float precioVenta, string descripcion, string editorialBuscar, List<int> listaIdGeneros, List<int> listaIdAutores);
        void BajaLibro(string isbn);
        void ActualizacionLibro(string isbn, Libro libroActualizar);
    }
}
