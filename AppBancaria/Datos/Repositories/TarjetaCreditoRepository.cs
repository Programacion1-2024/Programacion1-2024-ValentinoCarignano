using CDatos.Repositories;
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
    public class TarjetaCreditoRepository : Repository<TarjetaCredito>, ITarjetaCreditoRepository
    {
        public TarjetaCreditoRepository(AppDbContext context) : base(context) { }
    }
}
