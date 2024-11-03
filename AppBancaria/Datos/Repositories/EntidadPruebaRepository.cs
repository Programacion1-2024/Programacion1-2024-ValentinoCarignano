using Datos.Contexts;
using Datos.Repositories.Contracts;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class EntidadPruebaRepository : RepositoryPrueba<Cliente>, IEntidadPruebaRepository
    {
        public EntidadPruebaRepository(AppDbContext context) : base(context)
        {

        }
    }
}
