using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class GeneroLogic : IGeneroLogic
    {
        private IGeneroRepository _generoRepository;

        public GeneroLogic(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public void AltaGenero(string descripcion)
        {
            try
            {
                Genero generoNuevo = new()
                {
                    Descripcion = descripcion
                };

                if (!ValidacionesLogic.TextoEsValido(generoNuevo.Descripcion))
                {
                    throw new Exception("El nombre ingresado no es valido.");
                }

                _generoRepository.Create(generoNuevo);
                _generoRepository.Save();
            }
            catch
            {
                throw;
            }           
        }

        public void BajaGenero(string id)
        {
            try
            {
                Genero? generoExistente = _generoRepository.FindByCondition(g => g.IdGenero == Int32.Parse(id)).FirstOrDefault();

                if (generoExistente == null)
                {
                    throw new Exception("El genero que se quiere eliminar no existe.");
                }

                _generoRepository.Delete(generoExistente);
                _generoRepository.Save();
            }
            catch
            {
                throw;
            }
        }

        public void ActualizacionGenero(string id, string descripcion)
        {
            try
            {
                Genero? generoActualizar = _generoRepository.FindByCondition(g => g.IdGenero == Int32.Parse(id)).FirstOrDefault();

                if (generoActualizar == null)
                {
                    throw new Exception("El genero que se quiere actualizar no existe.");
                }

                if (!ValidacionesLogic.TextoEsValido(descripcion))
                {
                    throw new Exception("El nombre ingresado no es valido.");
                }

                generoActualizar.Descripcion = descripcion;

                _generoRepository.Create(generoActualizar);
                _generoRepository.Save();
            }
            catch
            {
                throw;
            }
        }

        public List<Genero> ObtenerGeneros()
        {
            return _generoRepository.ObtenerGeneros();
        }

        public List<dynamic> ObtenerGenerosParaListado()
        {
            return _generoRepository.ObtenerGeneros().Select(a => new { IdGenero = a.IdGenero, Descripcion = a.Descripcion }).ToList<dynamic>();
        }

        public Genero? ObtenerGeneroPorID(string idGenero)
        {
            return _generoRepository.FindByCondition(a => a.IdGenero == Int32.Parse(idGenero)).FirstOrDefault();
        }
    }
}
