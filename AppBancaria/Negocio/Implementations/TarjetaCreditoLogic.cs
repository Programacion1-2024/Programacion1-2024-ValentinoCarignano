using Datos.Repositories;
using Datos.Repositories.Contracts;
using Entidades.Entidades;
using Negocio.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementations
{
    public class TarjetaCreditoLogic : ITarjetaCreditoLogic
    {
        private ITarjetaCreditoRepository _tarjetaCreditoRepository;
        private IClienteRepository _clienteRepository;

        public TarjetaCreditoLogic(ITarjetaCreditoRepository tarjetaCreditoRepository, IClienteRepository clienteRepository)
        {
            _tarjetaCreditoRepository = tarjetaCreditoRepository;
            _clienteRepository = clienteRepository;
        }

        public void EmitirTarjetaCredito(int numeroTarjeta, double limiteCredito, double saldoDisponible, string estado, Cliente cliente)
        {
            List<string> camposErroneos = new List<string>();

            if (numeroTarjeta <= 0)
            {
                camposErroneos.Add("Numero de Tarjeta");
            }

            if (limiteCredito <= 0)
            {
                camposErroneos.Add("Limite de Credito");
            }

            if (saldoDisponible < 0)
            {
                camposErroneos.Add("Saldo Disponible");
            }

            if (!(estado == "Activa"))
            {
                camposErroneos.Add("Estado de Cuenta");
            }

            Cliente? clienteExistente = _clienteRepository.FindByCondition(c => c.ID == cliente.ID).FirstOrDefault();
            if(clienteExistente == null)
            {
                camposErroneos.Add("Cliente");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            TarjetaCredito tarjetaNueva = new TarjetaCredito()
            {
                NumeroTarjeta = numeroTarjeta,
                LimiteCredito = limiteCredito,
                SaldoDisponible = saldoDisponible,
                Estado = estado,
                Cliente = cliente
            };

            _tarjetaCreditoRepository.Create(tarjetaNueva);
            _tarjetaCreditoRepository.Save();
        }

        public void PausarTarjetaCredito(Cliente cliente, int numeroTarjeta)
        {
            List<string> camposErroneos = new List<string>();

            TarjetaCredito? tarjetaExistente = _tarjetaCreditoRepository.FindByCondition(c => c.NumeroTarjeta == numeroTarjeta).FirstOrDefault();
            if (tarjetaExistente == null || numeroTarjeta <= 0)
            {
                camposErroneos.Add("Numero de Tarjeta");
            }

            Cliente? clienteExistente = _clienteRepository.FindByCondition(c => c.ID == cliente.ID).FirstOrDefault();
            if (clienteExistente == null)
            {
                camposErroneos.Add("Cliente");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            if (tarjetaExistente != null)
            {
                tarjetaExistente.Estado = "Pausada";

                _tarjetaCreditoRepository.Update(tarjetaExistente);
                _tarjetaCreditoRepository.Save();
            }
        }

        public void PagarTarjetaCredito(int numeroTarjeta, double montoPago)
        {
            List<string> camposErroneos = new List<string>();

            TarjetaCredito? tarjetaExistente = _tarjetaCreditoRepository.FindByCondition(c => c.NumeroTarjeta == numeroTarjeta).FirstOrDefault();
            if (tarjetaExistente == null || numeroTarjeta <= 0)
            {
                camposErroneos.Add("Numero de Tarjeta");
            }

            if (montoPago <= 0)
            {
                camposErroneos.Add("Monto de Pago");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: " + string.Join(", ", camposErroneos));
            }

            if (tarjetaExistente != null)
            {
                double nuevoSaldoDisponible = tarjetaExistente.SaldoDisponible + montoPago;

                tarjetaExistente.SaldoDisponible = Math.Min(nuevoSaldoDisponible, tarjetaExistente.LimiteCredito);

                _tarjetaCreditoRepository.Update(tarjetaExistente);
                _tarjetaCreditoRepository.Save();
            }
        }
    }
}
