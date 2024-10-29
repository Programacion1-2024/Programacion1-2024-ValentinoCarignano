using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface ICuentaBancariaLogic
    {
        void CrearCuentaBancaria(int numeroCuenta, double saldo, string tipoCuenta, Cliente cliente);
        void RealizarDeposito(int numeroCuentaBancaria, double saldo);
        void RealizarTransferencia(int numeroCuentaBancariaTransfiere, int numeroCuentaBancariaRecibe, double saldo);
    }
}
