using Datos.Repositories.Contracts;
using Entidades.Entidades;
using Negocio.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementations
{
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _clienteRepository;

        public ClienteLogic(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AgregarCliente(string DNI, string Nombre, string Apellido)
        {
            List<string> camposErroneos = new List<string>();

            if (!ValidacionesGenerales.DocumentoValido(DNI))
            {
                camposErroneos.Add("DNI");
            }

            if (!ValidacionesGenerales.NombreValido(Nombre))
            {
                camposErroneos.Add("Nombre");
            }

            if (!ValidacionesGenerales.NombreValido(Apellido))
            {
                camposErroneos.Add("Apellido");
            }

            if(camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            Cliente clienteNuevo = new Cliente()
            {
                DNI = DNI,
                Nombre = Nombre,
                Apellido = Apellido
            };

            _clienteRepository.Create(clienteNuevo);
            _clienteRepository.Save();
        }
    }
}
