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
    public class CuentaBancariaLogic : ICuentaBancariaLogic
    {
        private ICuentaBancariaRepository _cuentaBancariaRepository;
        private IClienteRepository _clienteRepository;

        public CuentaBancariaLogic(ICuentaBancariaRepository cuentaBancariaRepository, IClienteRepository clienteRepository)
        {
            _cuentaBancariaRepository = cuentaBancariaRepository;
            _clienteRepository = clienteRepository;
        }

        public void CrearCuentaBancaria(string numeroCuenta, string tipoCuenta, string cliente)
        {
            List<string> camposErroneos = new List<string>();

            int numeroCuentaParse;
            if (!Int32.TryParse(numeroCuenta, out numeroCuentaParse) || numeroCuentaParse <= 0)
            {
                camposErroneos.Add("Numero de Cuenta");
            }

            if (!(tipoCuenta == "Corriente" || tipoCuenta == "Ahorro"))
            {
                camposErroneos.Add("Tipo de Cuenta");
            }

            Cliente? clienteExistente = _clienteRepository.FindByCondition(c => c.DNI == cliente).FirstOrDefault();
            if (clienteExistente == null)
            {
                camposErroneos.Add("Cliente");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            CuentaBancaria cuentaNueva = new CuentaBancaria()
            {
                NumeroCuenta = numeroCuentaParse,
                Saldo = 0,
                TipoCuenta = tipoCuenta,
                Cliente = clienteExistente
            };

            _cuentaBancariaRepository.Create(cuentaNueva);
            _cuentaBancariaRepository.Save();
        }

        public void RealizarDeposito(int numeroCuentaBancaria, double saldo)
        {
            List<string> camposErroneos = new List<string>();

            CuentaBancaria? cuentaExistente = _cuentaBancariaRepository.FindByCondition(c => c.NumeroCuenta == numeroCuentaBancaria).FirstOrDefault();
            if (cuentaExistente == null)
            {
                camposErroneos.Add("Cuenta Bancaria");
            }

            if (saldo <= 0)
            {
                camposErroneos.Add("Saldo");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            if (cuentaExistente != null)
            {
                cuentaExistente.Saldo += saldo;

                _cuentaBancariaRepository.Update(cuentaExistente);
                _cuentaBancariaRepository.Save();
            }
        }

        public void RealizarTransferencia(int numeroCuentaBancariaTransfiere, int numeroCuentaBancariaRecibe, double saldo)
        {
            List<string> camposErroneos = new List<string>();

            CuentaBancaria? cuentaExistenteTransfiere = _cuentaBancariaRepository.FindByCondition(c => c.NumeroCuenta == numeroCuentaBancariaTransfiere).FirstOrDefault();
            if (cuentaExistenteTransfiere == null)
            {
                camposErroneos.Add("Cuenta Bancaria (Transfiere)");
            }

            CuentaBancaria? cuentaExistenteRecibe = _cuentaBancariaRepository.FindByCondition(c => c.NumeroCuenta == numeroCuentaBancariaRecibe).FirstOrDefault();
            if (cuentaExistenteRecibe == null)
            {
                camposErroneos.Add("Cuenta Bancaria (Recibe)");
            }

            if (saldo <= 0 || saldo > cuentaExistenteTransfiere.Saldo)
            {
                camposErroneos.Add("Saldo");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            if (cuentaExistenteRecibe != null && cuentaExistenteTransfiere != null)
            {
                cuentaExistenteRecibe.Saldo += saldo;
                cuentaExistenteTransfiere.Saldo -= saldo;

                _cuentaBancariaRepository.Update(cuentaExistenteRecibe);
                _cuentaBancariaRepository.Update(cuentaExistenteTransfiere);
                _cuentaBancariaRepository.Save();
            }
        }

        public List<dynamic> ObtenerCuentas()
        {
            return _cuentaBancariaRepository.FindAll().Select(a => new {a.NumeroCuenta, CLiente = a.Cliente.Nombre + " " + a.Cliente.Apellido, a.TipoCuenta, a.Saldo}).ToList<dynamic>();
        }
    }
}
