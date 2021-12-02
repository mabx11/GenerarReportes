using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Ordenes
{
    public class ListOrdenes
    {
        public class Ejecuta : IRequest<List<TblOrdene>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblOrdene>>
        {
            private readonly netLISContext _context;
            public Manejador(netLISContext context)
            {
                _context = context;
            }
            public async Task<List<TblOrdene>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var orden = await _context.TblOrdenes.ToListAsync();
                return orden;
            }
        }
    }
}
