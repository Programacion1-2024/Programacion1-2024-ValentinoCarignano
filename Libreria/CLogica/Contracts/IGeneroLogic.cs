using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IGeneroLogic
    {
        void AltaGenero(string descripcion);
        void BajaGenero(string id);
        void ActualizacionGenero(string id, string descripcion);
        List<Genero> ObtenerGeneros();
        List<dynamic> ObtenerGenerosParaListado();
        Genero? ObtenerGeneroPorID(string idGenero);
    }
}
