using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface IClienteLogic
    {
        void AgregarCliente(string DNI, string Nombre, string Apellido);
    }
}
