using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface ITarjetaCreditoLogic
    {
        void EmitirTarjetaCredito(int numeroTarjeta, double limiteCredito, double saldoDisponible, string estado, Cliente cliente);
        void PausarTarjetaCredito(Cliente cliente, int numeroTarjeta);
        void PagarTarjetaCredito(int numeroTarjeta, double montoPago);
    }
}
