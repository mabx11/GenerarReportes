using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.TipoOrden
{
    public class ListTipoOrden
    {
        public class Ejecuta : IRequest<List<TblCatTipoOrden>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblCatTipoOrden>>
        {
            private readonly netLISContext _context;
            public Manejador(netLISContext context)
            {
                _context = context;
            }
            public async Task<List<TblCatTipoOrden>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tipoorden = await _context.TblCatTipoOrdens.ToListAsync();
                return tipoorden;
            }
        }
    }
}
