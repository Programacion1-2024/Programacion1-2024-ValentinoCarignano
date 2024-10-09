﻿using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class FormaPagoRepository : Repository<FormaPago>, IFormaPagoRepository
    {
        public FormaPagoRepository(LibreriaContext context) : base(context)
        {

        }
    }
}
