using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.OrdenDet
{
    public class ListOrdenDet
    {
        public class Ejecuta : IRequest<List<TblOrdenesDetalle>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblOrdenesDetalle>>
        {
            private readonly netLISContext _context;
            public Manejador(netLISContext context)
            {
                _context = context;
            }
            public async Task<List<TblOrdenesDetalle>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ordendet = await _context.TblOrdenesDetalles.ToListAsync();
                return ordendet;
            }
        }
    }
}
